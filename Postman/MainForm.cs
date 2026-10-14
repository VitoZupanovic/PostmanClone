using Postman.Models;
using Postman.Services;

namespace Postman
{
    public partial class MainForm : Form
    {
        private readonly ApiRequestService _apiRequestService = new ApiRequestService();
        private readonly HistoryService _historyService = new HistoryService();
        public MainForm()
        {
            InitializeComponent();
            cmbMethod.SelectedIndex = 0;
            cmbBodyType.SelectedIndex = 0;
            LoadHistory();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string method = cmbMethod.SelectedItem?.ToString() ?? "GET";
                string url = txtUrl.Text.Trim();
                url = ReplacePathParams(url);
                url = BuildUrlWithQueryParams(url);
                string body = txtRequestBody.Text;
                string bodyType = cmbBodyType.SelectedItem?.ToString() ?? "none";
                Dictionary<string, string> headers = GetHeadersFromGrid();

                if (string.IsNullOrWhiteSpace(url))
                {
                    lblStatus.Text = "Status: Missing URL";
                    lblTime.Text = "Time: -";
                    lblSize.Text = "Size: -";
                    txtResponseBody.Text = "Please enter a URL.";
                    return;
                }

                if (!IsValidUrl(url))
                {
                    lblStatus.Text = "Status: Invalid URL";
                    lblTime.Text = "Time: -";
                    lblSize.Text = "Size: -";
                    txtResponseBody.Text = "The entered URL is not valid.";
                    return;
                }

                lblStatus.Text = "Status: sending...";
                lblTime.Text = "Time: -";
                lblSize.Text = "Size: -";
                txtResponseBody.Text = "";

                var response = await _apiRequestService.SendAsync(method, url, body, bodyType, headers);

                lblStatus.Text = $"Status: {response.StatusCode} {response.ReasonPhrase}";
                lblTime.Text = $"Time: {response.ElapsedMilliseconds} ms";
                lblSize.Text = $"Size: {response.Length} bytes";
                txtResponseBody.Text = response.Content;
                RequestHistoryItem historyItem = CreateHistoryItem(method, txtUrl.Text.Trim(), response);

                _historyService.SaveRequest(historyItem);

                lstHistory.Items.Insert(0, historyItem);
            }
            catch (HttpRequestException ex)
            {
                lblStatus.Text = "Status: Request failed";
                lblTime.Text = "Time: -";
                lblSize.Text = "Size: -";
                txtResponseBody.Text = "Request failed. Check if the server is running and if the URL is correct.\r\n\r\n" + ex.Message;
            }
            catch (TaskCanceledException ex)
            {
                lblStatus.Text = "Status: Timeout";
                lblTime.Text = "Time: -";
                lblSize.Text = "Size: -";
                txtResponseBody.Text = "The request took too long and timed out.\r\n\r\n" + ex.Message;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Status: Error";
                lblTime.Text = "Time: -";
                lblSize.Text = "Size: -";
                txtResponseBody.Text = ex.Message;
            }
        }
        private string BuildUrlWithQueryParams(string url)
        {
            List<string> queryParams = new List<string>();

            foreach (DataGridViewRow row in dgvQueryParams.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                bool isEnabled = Convert.ToBoolean(row.Cells["colQueryEnabled"].Value ?? false);
                string key = row.Cells["colQueryKey"].Value?.ToString()?.Trim() ?? "";
                string value = row.Cells["colQueryValue"].Value?.ToString()?.Trim() ?? "";

                if (!isEnabled || string.IsNullOrWhiteSpace(key))
                {
                    continue;
                }

                string encodedKey = Uri.EscapeDataString(key);
                string encodedValue = Uri.EscapeDataString(value);

                queryParams.Add($"{encodedKey}={encodedValue}");
            }

            if (queryParams.Count == 0)
            {
                return url;
            }

            string separator = url.Contains("?") ? "&" : "?";

            return url + separator + string.Join("&", queryParams);
        }
        private string ReplacePathParams(string url)
        {
            foreach (DataGridViewRow row in dgvPathParams.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                bool isEnabled = Convert.ToBoolean(row.Cells["colPathEnabled"].Value ?? false);
                string key = row.Cells["colPathKey"].Value?.ToString()?.Trim() ?? "";
                string value = row.Cells["colPathValue"].Value?.ToString()?.Trim() ?? "";

                if (!isEnabled || string.IsNullOrWhiteSpace(key))
                {
                    continue;
                }

                url = url.Replace("{" + key + "}", Uri.EscapeDataString(value));
            }

            return url;
        }
        private Dictionary<string, string> GetHeadersFromGrid()
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();

            foreach (DataGridViewRow row in dgvHeaders.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                bool isEnabled = Convert.ToBoolean(row.Cells["colHeaderEnabled"].Value ?? false);
                string key = row.Cells["colHeaderKey"].Value?.ToString()?.Trim() ?? "";
                string value = row.Cells["colHeaderValue"].Value?.ToString()?.Trim() ?? "";

                if (!isEnabled || string.IsNullOrWhiteSpace(key))
                {
                    continue;
                }

                headers[key] = value;
            }

            return headers;
        }
        private void LoadHistory()
        {
            lstHistory.Items.Clear();

            List<RequestHistoryItem> historyItems = _historyService.LoadHistory();

            foreach (RequestHistoryItem item in historyItems)
            {
                lstHistory.Items.Add(item);
            }
        }
        private bool IsValidUrl(string url)
        {
            Uri? result;

            return Uri.TryCreate(url, UriKind.Absolute, out result);
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            _historyService.ClearHistory();
            lstHistory.Items.Clear();
        }

        private void lstHistory_DoubleClick(object sender, EventArgs e)
        {
            if (lstHistory.SelectedItem == null)
            {
                return;
            }

            RequestHistoryItem? selectedHistoryItem = lstHistory.SelectedItem as RequestHistoryItem;

            if (selectedHistoryItem == null)
            {
                return;
            }

            cmbMethod.SelectedItem = selectedHistoryItem.Method;
            txtUrl.Text = selectedHistoryItem.Url;

            ClearRequestInputs();

            LoadParametersToGrid(
                dgvQueryParams,
                selectedHistoryItem.QueryParams,
                "colQueryEnabled",
                "colQueryKey",
                "colQueryValue");

            LoadParametersToGrid(
                dgvPathParams,
                selectedHistoryItem.PathParams,
                "colPathEnabled",
                "colPathKey",
                "colPathValue");

            LoadParametersToGrid(
                dgvHeaders,
                selectedHistoryItem.Headers,
                "colHeaderEnabled",
                "colHeaderKey",
                "colHeaderValue");

            cmbBodyType.SelectedItem = selectedHistoryItem.BodyType;
            txtRequestBody.Text = selectedHistoryItem.Body;


            lblStatus.Text = "Status: " + selectedHistoryItem.StatusCode + " " + selectedHistoryItem.ReasonPhrase;
            lblTime.Text = "Time: " + selectedHistoryItem.ElapsedMilliseconds + " ms";
            lblSize.Text = "Size: " + selectedHistoryItem.ResponseLength + " bytes";
            txtResponseBody.Text = selectedHistoryItem.ResponseContent;
        }

        private void btnCopyResponse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResponseBody.Text))
            {
                MessageBox.Show("There is no response to copy.");
                return;
            }

            Clipboard.SetText(txtResponseBody.Text);
            MessageBox.Show("Response copied to clipboard.");
        }

        private void ClearRequestInputs()
        {
            dgvQueryParams.Rows.Clear();
            dgvPathParams.Rows.Clear();
            dgvHeaders.Rows.Clear();

            cmbBodyType.SelectedIndex = 0;
            txtRequestBody.Text = "";
        }

        private void cmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            string method = cmbMethod.SelectedItem?.ToString() ?? "";

            if (method == "POST" || method == "PUT")
            {
                tabRequest.SelectedTab = tabBody;
            }
        }
        private RequestHistoryItem CreateHistoryItem(string method, string originalUrl, ApiResponseModel response)
        {
            RequestHistoryItem item = new RequestHistoryItem();

            item.SentAt = DateTime.Now;
            item.Method = method;
            item.Url = originalUrl;

            item.QueryParams = GetHistoryParametersFromGrid(dgvQueryParams, "colQueryEnabled", "colQueryKey", "colQueryValue");
            item.PathParams = GetHistoryParametersFromGrid(dgvPathParams, "colPathEnabled", "colPathKey", "colPathValue");
            item.Headers = GetHistoryParametersFromGrid(dgvHeaders, "colHeaderEnabled", "colHeaderKey", "colHeaderValue");

            item.BodyType = cmbBodyType.SelectedItem?.ToString() ?? "none";
            item.Body = txtRequestBody.Text;

            item.StatusCode = response.StatusCode;
            item.ReasonPhrase = response.ReasonPhrase;
            item.ResponseLength = response.Length;
            item.ElapsedMilliseconds = response.ElapsedMilliseconds;
            item.ResponseContent = response.Content;

            return item;
        }
        private List<HistoryParameterModel> GetHistoryParametersFromGrid(
            DataGridView grid,
            string enabledColumnName,
            string keyColumnName,
            string valueColumnName)
        {
            List<HistoryParameterModel> parameters = new List<HistoryParameterModel>();

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                HistoryParameterModel parameter = new HistoryParameterModel();

                parameter.Enabled = Convert.ToBoolean(row.Cells[enabledColumnName].Value ?? false);
                parameter.Key = row.Cells[keyColumnName].Value?.ToString()?.Trim() ?? "";
                parameter.Value = row.Cells[valueColumnName].Value?.ToString()?.Trim() ?? "";

                parameters.Add(parameter);
            }

            return parameters;
        }
        private void LoadParametersToGrid(
            DataGridView grid,
            List<HistoryParameterModel> parameters,
            string enabledColumnName,
            string keyColumnName,
            string valueColumnName)
        {
            foreach (HistoryParameterModel parameter in parameters)
            {
                int rowIndex = grid.Rows.Add();

                grid.Rows[rowIndex].Cells[enabledColumnName].Value = parameter.Enabled;
                grid.Rows[rowIndex].Cells[keyColumnName].Value = parameter.Key;
                grid.Rows[rowIndex].Cells[valueColumnName].Value = parameter.Value;
            }
        }
    }
}
