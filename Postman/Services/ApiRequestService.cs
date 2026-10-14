using Postman.Models;
using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace Postman.Services
{
    public class ApiRequestService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<ApiResponseModel> SendAsync(
            string method,
            string url,
            string body,
            string bodyType,
            Dictionary<string, string> headers)
        {
            var request = new HttpRequestMessage(new HttpMethod(method), url);

            foreach (var header in headers)
            {
                request.Headers.TryAddWithoutValidation(header.Key, header.Value);
            }

            if (method != "GET" && method != "DELETE" && !string.IsNullOrWhiteSpace(body))
            {
                if (bodyType == "x-www-form-urlencoded")
                {
                    request.Content = CreateFormUrlEncodedContent(body);
                }
                else
                {
                    string contentType = GetContentType(bodyType);
                    request.Content = new StringContent(body, Encoding.UTF8, contentType);
                }
            }

            var stopwatch = Stopwatch.StartNew();

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            stopwatch.Stop();

            string responseContent = await response.Content.ReadAsStringAsync();
            responseContent = TryFormatJson(responseContent);

            return new ApiResponseModel
            {
                StatusCode = (int)response.StatusCode,
                ReasonPhrase = response.ReasonPhrase ?? "",
                Content = responseContent,
                Length = Encoding.UTF8.GetByteCount(responseContent),
                ElapsedMilliseconds = stopwatch.ElapsedMilliseconds
            };
        }

        private string GetContentType(string bodyType)
        {
            switch (bodyType)
            {
                case "json":
                    return "application/json";

                case "xml":
                    return "application/xml";

                case "text":
                    return "text/plain";

                case "x-www-form-urlencoded":
                    return "application/x-www-form-urlencoded";

                default:
                    return "text/plain";
            }
        }
        private string TryFormatJson(string content)
        {
            try
            {
                using (JsonDocument document = JsonDocument.Parse(content))
                {
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };

                    return JsonSerializer.Serialize(document.RootElement, options);
                }
            }
            catch
            {
                return content;
            }
        }
        private FormUrlEncodedContent CreateFormUrlEncodedContent(string body)
        {
            List<KeyValuePair<string, string>> formValues = new List<KeyValuePair<string, string>>();

            string[] pairs = body.Split('&');

            foreach (string pair in pairs)
            {
                string[] keyAndValue = pair.Split('=');

                if (keyAndValue.Length == 2)
                {
                    string key = keyAndValue[0];
                    string value = keyAndValue[1];

                    formValues.Add(new KeyValuePair<string, string>(key, value));
                }
            }

            return new FormUrlEncodedContent(formValues);
        }
    }
}
