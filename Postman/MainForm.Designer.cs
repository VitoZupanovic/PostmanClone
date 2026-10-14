namespace Postman
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            cmbMethod = new ComboBox();
            txtUrl = new TextBox();
            btnSend = new Button();
            pnlSidebar = new Panel();
            btnClearHistory = new Button();
            lstHistory = new ListBox();
            lblHistoryTitle = new Label();
            tabRequest = new TabControl();
            tabQueryParams = new TabPage();
            dgvQueryParams = new DataGridView();
            colQueryEnabled = new DataGridViewCheckBoxColumn();
            colQueryKey = new DataGridViewTextBoxColumn();
            colQueryValue = new DataGridViewTextBoxColumn();
            tabHeaders = new TabPage();
            dgvHeaders = new DataGridView();
            colHeaderEnabled = new DataGridViewCheckBoxColumn();
            colHeaderKey = new DataGridViewTextBoxColumn();
            colHeaderValue = new DataGridViewTextBoxColumn();
            tabPathParams = new TabPage();
            dgvPathParams = new DataGridView();
            colPathEnabled = new DataGridViewCheckBoxColumn();
            colPathKey = new DataGridViewTextBoxColumn();
            colPathValue = new DataGridViewTextBoxColumn();
            tabBody = new TabPage();
            txtRequestBody = new TextBox();
            cmbBodyType = new ComboBox();
            lblStatus = new Label();
            lblTime = new Label();
            lblSize = new Label();
            txtResponseBody = new TextBox();
            lblRequest = new Label();
            lblResponse = new Label();
            btnCopyResponse = new Button();
            pnlSidebar.SuspendLayout();
            tabRequest.SuspendLayout();
            tabQueryParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQueryParams).BeginInit();
            tabHeaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).BeginInit();
            tabPathParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPathParams).BeginInit();
            tabBody.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMethod
            // 
            cmbMethod.BackColor = Color.FromArgb(45, 45, 45);
            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMethod.FlatStyle = FlatStyle.Flat;
            cmbMethod.ForeColor = Color.White;
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Items.AddRange(new object[] { "GET", "POST", "PUT", "DELETE" });
            cmbMethod.Location = new Point(383, 55);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(103, 28);
            cmbMethod.TabIndex = 0;
            cmbMethod.SelectedIndexChanged += cmbMethod_SelectedIndexChanged;
            // 
            // txtUrl
            // 
            txtUrl.BackColor = Color.FromArgb(45, 45, 45);
            txtUrl.BorderStyle = BorderStyle.FixedSingle;
            txtUrl.ForeColor = Color.White;
            txtUrl.Location = new Point(489, 56);
            txtUrl.Name = "txtUrl";
            txtUrl.PlaceholderText = "Enter request URL, e.g. https://postman-echo.com/get";
            txtUrl.Size = new Size(650, 27);
            txtUrl.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Blue;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(1145, 56);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(143, 28);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSidebar.BackColor = Color.FromArgb(37, 37, 38);
            pnlSidebar.Controls.Add(btnClearHistory);
            pnlSidebar.Controls.Add(lstHistory);
            pnlSidebar.Controls.Add(lblHistoryTitle);
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(377, 700);
            pnlSidebar.TabIndex = 3;
            // 
            // btnClearHistory
            // 
            btnClearHistory.BackColor = Color.FromArgb(45, 45, 45);
            btnClearHistory.FlatAppearance.BorderSize = 0;
            btnClearHistory.FlatStyle = FlatStyle.Flat;
            btnClearHistory.ForeColor = Color.White;
            btnClearHistory.Location = new Point(110, 635);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(150, 40);
            btnClearHistory.TabIndex = 2;
            btnClearHistory.Text = "Clear History";
            btnClearHistory.UseVisualStyleBackColor = false;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // lstHistory
            // 
            lstHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lstHistory.BackColor = Color.FromArgb(30, 30, 30);
            lstHistory.BorderStyle = BorderStyle.FixedSingle;
            lstHistory.ForeColor = Color.White;
            lstHistory.FormattingEnabled = true;
            lstHistory.HorizontalScrollbar = true;
            lstHistory.IntegralHeight = false;
            lstHistory.Location = new Point(15, 55);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(343, 562);
            lstHistory.TabIndex = 1;
            lstHistory.DoubleClick += lstHistory_DoubleClick;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.BackColor = Color.Transparent;
            lblHistoryTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHistoryTitle.ForeColor = Color.White;
            lblHistoryTitle.Location = new Point(15, 14);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(81, 23);
            lblHistoryTitle.TabIndex = 0;
            lblHistoryTitle.Text = "HISTORY";
            // 
            // tabRequest
            // 
            tabRequest.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabRequest.Controls.Add(tabQueryParams);
            tabRequest.Controls.Add(tabHeaders);
            tabRequest.Controls.Add(tabPathParams);
            tabRequest.Controls.Add(tabBody);
            tabRequest.Location = new Point(383, 102);
            tabRequest.Name = "tabRequest";
            tabRequest.SelectedIndex = 0;
            tabRequest.Size = new Size(905, 260);
            tabRequest.TabIndex = 4;
            // 
            // tabQueryParams
            // 
            tabQueryParams.BackColor = Color.FromArgb(30, 30, 30);
            tabQueryParams.Controls.Add(dgvQueryParams);
            tabQueryParams.ForeColor = Color.White;
            tabQueryParams.Location = new Point(4, 29);
            tabQueryParams.Name = "tabQueryParams";
            tabQueryParams.Padding = new Padding(3);
            tabQueryParams.Size = new Size(897, 227);
            tabQueryParams.TabIndex = 0;
            tabQueryParams.Text = "Query Params";
            // 
            // dgvQueryParams
            // 
            dgvQueryParams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvQueryParams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQueryParams.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvQueryParams.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvQueryParams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvQueryParams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQueryParams.Columns.AddRange(new DataGridViewColumn[] { colQueryEnabled, colQueryKey, colQueryValue });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(55, 55, 55);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvQueryParams.DefaultCellStyle = dataGridViewCellStyle2;
            dgvQueryParams.EnableHeadersVisualStyles = false;
            dgvQueryParams.GridColor = Color.FromArgb(60, 60, 60);
            dgvQueryParams.Location = new Point(10, 10);
            dgvQueryParams.Name = "dgvQueryParams";
            dgvQueryParams.RowHeadersVisible = false;
            dgvQueryParams.RowHeadersWidth = 51;
            dgvQueryParams.Size = new Size(875, 210);
            dgvQueryParams.TabIndex = 0;
            // 
            // colQueryEnabled
            // 
            colQueryEnabled.HeaderText = "Enabled";
            colQueryEnabled.MinimumWidth = 6;
            colQueryEnabled.Name = "colQueryEnabled";
            // 
            // colQueryKey
            // 
            colQueryKey.HeaderText = "Key";
            colQueryKey.MinimumWidth = 6;
            colQueryKey.Name = "colQueryKey";
            // 
            // colQueryValue
            // 
            colQueryValue.HeaderText = "Value";
            colQueryValue.MinimumWidth = 6;
            colQueryValue.Name = "colQueryValue";
            // 
            // tabHeaders
            // 
            tabHeaders.BackColor = Color.FromArgb(30, 30, 30);
            tabHeaders.Controls.Add(dgvHeaders);
            tabHeaders.ForeColor = Color.White;
            tabHeaders.Location = new Point(4, 29);
            tabHeaders.Name = "tabHeaders";
            tabHeaders.Padding = new Padding(3);
            tabHeaders.Size = new Size(897, 227);
            tabHeaders.TabIndex = 1;
            tabHeaders.Text = "Headers";
            // 
            // dgvHeaders
            // 
            dgvHeaders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHeaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHeaders.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvHeaders.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHeaders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHeaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHeaders.Columns.AddRange(new DataGridViewColumn[] { colHeaderEnabled, colHeaderKey, colHeaderValue });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(55, 55, 55);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvHeaders.DefaultCellStyle = dataGridViewCellStyle4;
            dgvHeaders.EnableHeadersVisualStyles = false;
            dgvHeaders.GridColor = Color.FromArgb(60, 60, 60);
            dgvHeaders.Location = new Point(10, 10);
            dgvHeaders.Name = "dgvHeaders";
            dgvHeaders.RowHeadersVisible = false;
            dgvHeaders.RowHeadersWidth = 51;
            dgvHeaders.Size = new Size(875, 210);
            dgvHeaders.TabIndex = 0;
            // 
            // colHeaderEnabled
            // 
            colHeaderEnabled.HeaderText = "Enabled";
            colHeaderEnabled.MinimumWidth = 6;
            colHeaderEnabled.Name = "colHeaderEnabled";
            // 
            // colHeaderKey
            // 
            colHeaderKey.HeaderText = "Key";
            colHeaderKey.MinimumWidth = 6;
            colHeaderKey.Name = "colHeaderKey";
            // 
            // colHeaderValue
            // 
            colHeaderValue.HeaderText = "Value";
            colHeaderValue.MinimumWidth = 6;
            colHeaderValue.Name = "colHeaderValue";
            // 
            // tabPathParams
            // 
            tabPathParams.BackColor = Color.FromArgb(30, 30, 30);
            tabPathParams.Controls.Add(dgvPathParams);
            tabPathParams.ForeColor = Color.White;
            tabPathParams.Location = new Point(4, 29);
            tabPathParams.Name = "tabPathParams";
            tabPathParams.Size = new Size(897, 227);
            tabPathParams.TabIndex = 2;
            tabPathParams.Text = "Path Params";
            // 
            // dgvPathParams
            // 
            dgvPathParams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPathParams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPathParams.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvPathParams.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(45, 45, 45);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvPathParams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvPathParams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPathParams.Columns.AddRange(new DataGridViewColumn[] { colPathEnabled, colPathKey, colPathValue });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(37, 37, 38);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(55, 55, 55);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvPathParams.DefaultCellStyle = dataGridViewCellStyle6;
            dgvPathParams.EnableHeadersVisualStyles = false;
            dgvPathParams.GridColor = Color.FromArgb(60, 60, 60);
            dgvPathParams.Location = new Point(10, 10);
            dgvPathParams.Name = "dgvPathParams";
            dgvPathParams.RowHeadersVisible = false;
            dgvPathParams.RowHeadersWidth = 51;
            dgvPathParams.Size = new Size(875, 210);
            dgvPathParams.TabIndex = 1;
            // 
            // colPathEnabled
            // 
            colPathEnabled.HeaderText = "Enabled";
            colPathEnabled.MinimumWidth = 6;
            colPathEnabled.Name = "colPathEnabled";
            // 
            // colPathKey
            // 
            colPathKey.HeaderText = "Key";
            colPathKey.MinimumWidth = 6;
            colPathKey.Name = "colPathKey";
            // 
            // colPathValue
            // 
            colPathValue.HeaderText = "Value";
            colPathValue.MinimumWidth = 6;
            colPathValue.Name = "colPathValue";
            // 
            // tabBody
            // 
            tabBody.BackColor = Color.FromArgb(30, 30, 30);
            tabBody.Controls.Add(txtRequestBody);
            tabBody.Controls.Add(cmbBodyType);
            tabBody.ForeColor = Color.White;
            tabBody.Location = new Point(4, 29);
            tabBody.Name = "tabBody";
            tabBody.Size = new Size(897, 227);
            tabBody.TabIndex = 3;
            tabBody.Text = "Body";
            // 
            // txtRequestBody
            // 
            txtRequestBody.AcceptsReturn = true;
            txtRequestBody.AcceptsTab = true;
            txtRequestBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtRequestBody.BackColor = Color.FromArgb(37, 37, 38);
            txtRequestBody.BorderStyle = BorderStyle.FixedSingle;
            txtRequestBody.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRequestBody.ForeColor = Color.White;
            txtRequestBody.Location = new Point(10, 50);
            txtRequestBody.Multiline = true;
            txtRequestBody.Name = "txtRequestBody";
            txtRequestBody.PlaceholderText = "Enter request body here";
            txtRequestBody.ScrollBars = ScrollBars.Both;
            txtRequestBody.Size = new Size(875, 170);
            txtRequestBody.TabIndex = 1;
            txtRequestBody.WordWrap = false;
            // 
            // cmbBodyType
            // 
            cmbBodyType.BackColor = Color.FromArgb(45, 45, 45);
            cmbBodyType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBodyType.FlatStyle = FlatStyle.Flat;
            cmbBodyType.ForeColor = Color.White;
            cmbBodyType.FormattingEnabled = true;
            cmbBodyType.Items.AddRange(new object[] { "none", "text", "json", "xml", "x-www-form-urlencoded" });
            cmbBodyType.Location = new Point(10, 10);
            cmbBodyType.Name = "cmbBodyType";
            cmbBodyType.Size = new Size(220, 28);
            cmbBodyType.TabIndex = 0;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(515, 377);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(67, 20);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status: -";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.White;
            lblTime.Location = new Point(700, 377);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(58, 20);
            lblTime.TabIndex = 6;
            lblTime.Text = "Time: -";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.ForeColor = Color.White;
            lblSize.Location = new Point(876, 377);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(50, 20);
            lblSize.TabIndex = 7;
            lblSize.Text = "Size: -";
            // 
            // txtResponseBody
            // 
            txtResponseBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtResponseBody.BackColor = Color.FromArgb(20, 20, 20);
            txtResponseBody.BorderStyle = BorderStyle.FixedSingle;
            txtResponseBody.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResponseBody.ForeColor = Color.White;
            txtResponseBody.Location = new Point(383, 411);
            txtResponseBody.Multiline = true;
            txtResponseBody.Name = "txtResponseBody";
            txtResponseBody.ReadOnly = true;
            txtResponseBody.ScrollBars = ScrollBars.Both;
            txtResponseBody.Size = new Size(905, 280);
            txtResponseBody.TabIndex = 8;
            txtResponseBody.WordWrap = false;
            // 
            // lblRequest
            // 
            lblRequest.AutoSize = true;
            lblRequest.BackColor = Color.Transparent;
            lblRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequest.ForeColor = Color.White;
            lblRequest.Location = new Point(383, 14);
            lblRequest.Name = "lblRequest";
            lblRequest.Size = new Size(84, 23);
            lblRequest.TabIndex = 9;
            lblRequest.Text = "REQUEST";
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.BackColor = Color.Transparent;
            lblResponse.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponse.ForeColor = Color.White;
            lblResponse.Location = new Point(383, 375);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(95, 23);
            lblResponse.TabIndex = 10;
            lblResponse.Text = "RESPONSE";
            // 
            // btnCopyResponse
            // 
            btnCopyResponse.BackColor = Color.FromArgb(45, 45, 45);
            btnCopyResponse.FlatAppearance.BorderSize = 0;
            btnCopyResponse.FlatStyle = FlatStyle.Flat;
            btnCopyResponse.ForeColor = Color.White;
            btnCopyResponse.Location = new Point(1168, 372);
            btnCopyResponse.Name = "btnCopyResponse";
            btnCopyResponse.Size = new Size(120, 30);
            btnCopyResponse.TabIndex = 11;
            btnCopyResponse.Text = "Copy Response";
            btnCopyResponse.UseVisualStyleBackColor = false;
            btnCopyResponse.Click += btnCopyResponse_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1332, 703);
            Controls.Add(btnCopyResponse);
            Controls.Add(lblResponse);
            Controls.Add(lblRequest);
            Controls.Add(txtResponseBody);
            Controls.Add(lblSize);
            Controls.Add(lblTime);
            Controls.Add(lblStatus);
            Controls.Add(tabRequest);
            Controls.Add(pnlSidebar);
            Controls.Add(btnSend);
            Controls.Add(txtUrl);
            Controls.Add(cmbMethod);
            MinimumSize = new Size(1100, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Postman Clone";
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            tabRequest.ResumeLayout(false);
            tabQueryParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQueryParams).EndInit();
            tabHeaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHeaders).EndInit();
            tabPathParams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPathParams).EndInit();
            tabBody.ResumeLayout(false);
            tabBody.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMethod;
        private TextBox txtUrl;
        private Button btnSend;
        private Panel pnlSidebar;
        private Label lblHistoryTitle;
        private ListBox lstHistory;
        private TabControl tabRequest;
        private TabPage tabQueryParams;
        private TabPage tabHeaders;
        private TabPage tabPathParams;
        private TabPage tabBody;
        private DataGridView dgvQueryParams;
        private DataGridViewCheckBoxColumn colQueryEnabled;
        private DataGridViewTextBoxColumn colQueryKey;
        private DataGridViewTextBoxColumn colQueryValue;
        private DataGridView dgvHeaders;
        private DataGridViewCheckBoxColumn colHeaderEnabled;
        private DataGridViewTextBoxColumn colHeaderKey;
        private DataGridViewTextBoxColumn colHeaderValue;
        private DataGridView dgvPathParams;
        private DataGridViewCheckBoxColumn colPathEnabled;
        private DataGridViewTextBoxColumn colPathKey;
        private DataGridViewTextBoxColumn colPathValue;
        private TextBox txtRequestBody;
        private ComboBox cmbBodyType;
        private Label lblStatus;
        private Label lblTime;
        private Label lblSize;
        private TextBox txtResponseBody;
        private Label lblRequest;
        private Label lblResponse;
        private Button btnClearHistory;
        private Button btnCopyResponse;
    }
}
