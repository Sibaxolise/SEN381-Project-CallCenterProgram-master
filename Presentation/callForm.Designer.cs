
namespace CallCenterProgram.Presentation
{
    partial class callForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.rtxtFaultReport = new System.Windows.Forms.RichTextBox();
            this.lblFaultReport = new System.Windows.Forms.Label();
            this.lblCallReport = new System.Windows.Forms.Label();
            this.lblProblemInfo = new System.Windows.Forms.Label();
            this.lblWorkRequest = new System.Windows.Forms.Label();
            this.rtxtCallReport = new System.Windows.Forms.RichTextBox();
            this.rtxtProblemInfo = new System.Windows.Forms.RichTextBox();
            this.rtxtWorkRequest = new System.Windows.Forms.RichTextBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximizeToggle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlReports = new System.Windows.Forms.Panel();
            this.numStationNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSetStationNumber = new System.Windows.Forms.Button();
            this.lblStationNumber = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.pnlClientInfo = new System.Windows.Forms.Panel();
            this.numClientID = new System.Windows.Forms.NumericUpDown();
            this.lblClientNumber = new System.Windows.Forms.Label();
            this.btnFindClientInfo = new System.Windows.Forms.Button();
            this.lblAgreements = new System.Windows.Forms.Label();
            this.dgvCallHistory = new System.Windows.Forms.DataGridView();
            this.lblClientCallHistory = new System.Windows.Forms.Label();
            this.dgvAgreements = new System.Windows.Forms.DataGridView();
            this.lblClientInfo = new System.Windows.Forms.Label();
            this.pnlRightSide = new System.Windows.Forms.Panel();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.pnlRightBottom = new System.Windows.Forms.Panel();
            this.btnInsertIntoDB = new System.Windows.Forms.Button();
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.btnTakeCall = new System.Windows.Forms.Button();
            this.pnlTitleBar.SuspendLayout();
            this.pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStationNumber)).BeginInit();
            this.pnlClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClientID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgreements)).BeginInit();
            this.pnlRightSide.SuspendLayout();
            this.pnlRightBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(82)))), ((int)(((byte)(203)))));
            this.lblTitle.Location = new System.Drawing.Point(503, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(230, 58);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Call Form";
            // 
            // rtxtFaultReport
            // 
            this.rtxtFaultReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.rtxtFaultReport.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.rtxtFaultReport.Location = new System.Drawing.Point(19, 134);
            this.rtxtFaultReport.Name = "rtxtFaultReport";
            this.rtxtFaultReport.Size = new System.Drawing.Size(192, 155);
            this.rtxtFaultReport.TabIndex = 6;
            this.rtxtFaultReport.Text = "";
            // 
            // lblFaultReport
            // 
            this.lblFaultReport.AutoSize = true;
            this.lblFaultReport.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaultReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.lblFaultReport.Location = new System.Drawing.Point(22, 83);
            this.lblFaultReport.Name = "lblFaultReport";
            this.lblFaultReport.Size = new System.Drawing.Size(189, 38);
            this.lblFaultReport.TabIndex = 7;
            this.lblFaultReport.Text = "Fault Report";
            // 
            // lblCallReport
            // 
            this.lblCallReport.AutoSize = true;
            this.lblCallReport.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCallReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.lblCallReport.Location = new System.Drawing.Point(260, 83);
            this.lblCallReport.Name = "lblCallReport";
            this.lblCallReport.Size = new System.Drawing.Size(172, 38);
            this.lblCallReport.TabIndex = 8;
            this.lblCallReport.Text = "Call Report";
            // 
            // lblProblemInfo
            // 
            this.lblProblemInfo.AutoSize = true;
            this.lblProblemInfo.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.lblProblemInfo.Location = new System.Drawing.Point(473, 83);
            this.lblProblemInfo.Name = "lblProblemInfo";
            this.lblProblemInfo.Size = new System.Drawing.Size(200, 38);
            this.lblProblemInfo.TabIndex = 9;
            this.lblProblemInfo.Text = "Problem Info";
            // 
            // lblWorkRequest
            // 
            this.lblWorkRequest.AutoSize = true;
            this.lblWorkRequest.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.lblWorkRequest.Location = new System.Drawing.Point(696, 83);
            this.lblWorkRequest.Name = "lblWorkRequest";
            this.lblWorkRequest.Size = new System.Drawing.Size(215, 38);
            this.lblWorkRequest.TabIndex = 10;
            this.lblWorkRequest.Text = "Work Request";
            // 
            // rtxtCallReport
            // 
            this.rtxtCallReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.rtxtCallReport.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.rtxtCallReport.Location = new System.Drawing.Point(251, 134);
            this.rtxtCallReport.Name = "rtxtCallReport";
            this.rtxtCallReport.Size = new System.Drawing.Size(192, 155);
            this.rtxtCallReport.TabIndex = 11;
            this.rtxtCallReport.Text = "";
            // 
            // rtxtProblemInfo
            // 
            this.rtxtProblemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.rtxtProblemInfo.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.rtxtProblemInfo.Location = new System.Drawing.Point(480, 134);
            this.rtxtProblemInfo.Name = "rtxtProblemInfo";
            this.rtxtProblemInfo.Size = new System.Drawing.Size(192, 155);
            this.rtxtProblemInfo.TabIndex = 12;
            this.rtxtProblemInfo.Text = "";
            // 
            // rtxtWorkRequest
            // 
            this.rtxtWorkRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.rtxtWorkRequest.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.rtxtWorkRequest.Location = new System.Drawing.Point(703, 134);
            this.rtxtWorkRequest.Name = "rtxtWorkRequest";
            this.rtxtWorkRequest.Size = new System.Drawing.Size(192, 155);
            this.rtxtWorkRequest.TabIndex = 13;
            this.rtxtWorkRequest.Text = "";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximizeToggle);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.btnHome);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1394, 72);
            this.pnlTitleBar.TabIndex = 15;
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnMinimize.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterminimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1173, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 72);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximizeToggle
            // 
            this.btnMaximizeToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnMaximizeToggle.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcentermaximize;
            this.btnMaximizeToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizeToggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizeToggle.FlatAppearance.BorderSize = 0;
            this.btnMaximizeToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeToggle.Location = new System.Drawing.Point(1248, 0);
            this.btnMaximizeToggle.Name = "btnMaximizeToggle";
            this.btnMaximizeToggle.Size = new System.Drawing.Size(75, 72);
            this.btnMaximizeToggle.TabIndex = 8;
            this.btnMaximizeToggle.UseVisualStyleBackColor = false;
            this.btnMaximizeToggle.Click += new System.EventHandler(this.btnMaximizeToggle_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterexit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1323, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 72);
            this.btnExit.TabIndex = 6;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnHome.Location = new System.Drawing.Point(1080, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 42);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlReports
            // 
            this.pnlReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlReports.Controls.Add(this.numStationNumber);
            this.pnlReports.Controls.Add(this.btnSetStationNumber);
            this.pnlReports.Controls.Add(this.lblStationNumber);
            this.pnlReports.Controls.Add(this.lblReports);
            this.pnlReports.Controls.Add(this.rtxtWorkRequest);
            this.pnlReports.Controls.Add(this.rtxtFaultReport);
            this.pnlReports.Controls.Add(this.lblFaultReport);
            this.pnlReports.Controls.Add(this.lblCallReport);
            this.pnlReports.Controls.Add(this.rtxtProblemInfo);
            this.pnlReports.Controls.Add(this.lblProblemInfo);
            this.pnlReports.Controls.Add(this.rtxtCallReport);
            this.pnlReports.Controls.Add(this.lblWorkRequest);
            this.pnlReports.Location = new System.Drawing.Point(150, 90);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(925, 318);
            this.pnlReports.TabIndex = 16;
            // 
            // numStationNumber
            // 
            this.numStationNumber.Location = new System.Drawing.Point(661, 27);
            this.numStationNumber.Name = "numStationNumber";
            this.numStationNumber.Size = new System.Drawing.Size(120, 20);
            this.numStationNumber.TabIndex = 27;
            // 
            // btnSetStationNumber
            // 
            this.btnSetStationNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetStationNumber.Font = new System.Drawing.Font("Roboto Thin", 27.75F);
            this.btnSetStationNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnSetStationNumber.Location = new System.Drawing.Point(787, 10);
            this.btnSetStationNumber.Name = "btnSetStationNumber";
            this.btnSetStationNumber.Size = new System.Drawing.Size(116, 52);
            this.btnSetStationNumber.TabIndex = 26;
            this.btnSetStationNumber.Text = "Set";
            this.btnSetStationNumber.UseVisualStyleBackColor = true;
            this.btnSetStationNumber.Click += new System.EventHandler(this.btnSetStationNumber_Click);
            // 
            // lblStationNumber
            // 
            this.lblStationNumber.AutoSize = true;
            this.lblStationNumber.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStationNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.lblStationNumber.Location = new System.Drawing.Point(416, 10);
            this.lblStationNumber.Name = "lblStationNumber";
            this.lblStationNumber.Size = new System.Drawing.Size(239, 38);
            this.lblStationNumber.TabIndex = 26;
            this.lblStationNumber.Text = "Station Number";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Roboto Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.lblReports.Location = new System.Drawing.Point(13, 23);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(151, 46);
            this.lblReports.TabIndex = 20;
            this.lblReports.Text = "Reports";
            // 
            // pnlClientInfo
            // 
            this.pnlClientInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlClientInfo.Controls.Add(this.numClientID);
            this.pnlClientInfo.Controls.Add(this.lblClientNumber);
            this.pnlClientInfo.Controls.Add(this.btnFindClientInfo);
            this.pnlClientInfo.Controls.Add(this.lblAgreements);
            this.pnlClientInfo.Controls.Add(this.dgvCallHistory);
            this.pnlClientInfo.Controls.Add(this.lblClientCallHistory);
            this.pnlClientInfo.Controls.Add(this.dgvAgreements);
            this.pnlClientInfo.Controls.Add(this.lblClientInfo);
            this.pnlClientInfo.Location = new System.Drawing.Point(150, 435);
            this.pnlClientInfo.Name = "pnlClientInfo";
            this.pnlClientInfo.Size = new System.Drawing.Size(925, 363);
            this.pnlClientInfo.TabIndex = 17;
            // 
            // numClientID
            // 
            this.numClientID.Location = new System.Drawing.Point(503, 40);
            this.numClientID.Name = "numClientID";
            this.numClientID.Size = new System.Drawing.Size(120, 20);
            this.numClientID.TabIndex = 26;
            // 
            // lblClientNumber
            // 
            this.lblClientNumber.AutoSize = true;
            this.lblClientNumber.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.lblClientNumber.Location = new System.Drawing.Point(362, 30);
            this.lblClientNumber.Name = "lblClientNumber";
            this.lblClientNumber.Size = new System.Drawing.Size(135, 38);
            this.lblClientNumber.TabIndex = 25;
            this.lblClientNumber.Text = "Client ID";
            // 
            // btnFindClientInfo
            // 
            this.btnFindClientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindClientInfo.Font = new System.Drawing.Font("Roboto Thin", 27.75F);
            this.btnFindClientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnFindClientInfo.Location = new System.Drawing.Point(629, 14);
            this.btnFindClientInfo.Name = "btnFindClientInfo";
            this.btnFindClientInfo.Size = new System.Drawing.Size(282, 66);
            this.btnFindClientInfo.TabIndex = 24;
            this.btnFindClientInfo.Text = "Find Client Info";
            this.btnFindClientInfo.UseVisualStyleBackColor = true;
            this.btnFindClientInfo.Click += new System.EventHandler(this.btnFindClientInfo_Click);
            // 
            // lblAgreements
            // 
            this.lblAgreements.AutoSize = true;
            this.lblAgreements.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgreements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.lblAgreements.Location = new System.Drawing.Point(64, 107);
            this.lblAgreements.Name = "lblAgreements";
            this.lblAgreements.Size = new System.Drawing.Size(189, 38);
            this.lblAgreements.TabIndex = 19;
            this.lblAgreements.Text = "Agreements";
            // 
            // dgvCallHistory
            // 
            this.dgvCallHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCallHistory.Location = new System.Drawing.Point(289, 148);
            this.dgvCallHistory.Name = "dgvCallHistory";
            this.dgvCallHistory.Size = new System.Drawing.Size(598, 187);
            this.dgvCallHistory.TabIndex = 18;
            // 
            // lblClientCallHistory
            // 
            this.lblClientCallHistory.AutoSize = true;
            this.lblClientCallHistory.Font = new System.Drawing.Font("Roboto Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientCallHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.lblClientCallHistory.Location = new System.Drawing.Point(496, 107);
            this.lblClientCallHistory.Name = "lblClientCallHistory";
            this.lblClientCallHistory.Size = new System.Drawing.Size(177, 38);
            this.lblClientCallHistory.TabIndex = 17;
            this.lblClientCallHistory.Text = "Call History";
            // 
            // dgvAgreements
            // 
            this.dgvAgreements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgreements.Location = new System.Drawing.Point(29, 148);
            this.dgvAgreements.Name = "dgvAgreements";
            this.dgvAgreements.Size = new System.Drawing.Size(254, 187);
            this.dgvAgreements.TabIndex = 16;
            // 
            // lblClientInfo
            // 
            this.lblClientInfo.AutoSize = true;
            this.lblClientInfo.Font = new System.Drawing.Font("Roboto Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.lblClientInfo.Location = new System.Drawing.Point(12, 18);
            this.lblClientInfo.Name = "lblClientInfo";
            this.lblClientInfo.Size = new System.Drawing.Size(189, 46);
            this.lblClientInfo.TabIndex = 14;
            this.lblClientInfo.Text = "Client info";
            // 
            // pnlRightSide
            // 
            this.pnlRightSide.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnlRightSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlRightSide.Controls.Add(this.btnEndCall);
            this.pnlRightSide.Controls.Add(this.pnlRightBottom);
            this.pnlRightSide.Controls.Add(this.btnMakeCall);
            this.pnlRightSide.Controls.Add(this.btnTakeCall);
            this.pnlRightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightSide.Location = new System.Drawing.Point(1207, 72);
            this.pnlRightSide.Name = "pnlRightSide";
            this.pnlRightSide.Size = new System.Drawing.Size(187, 745);
            this.pnlRightSide.TabIndex = 18;
            // 
            // btnEndCall
            // 
            this.btnEndCall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEndCall.FlatAppearance.BorderSize = 0;
            this.btnEndCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndCall.Font = new System.Drawing.Font("Roboto Thin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndCall.ForeColor = System.Drawing.Color.Red;
            this.btnEndCall.Location = new System.Drawing.Point(0, 180);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Size = new System.Drawing.Size(187, 90);
            this.btnEndCall.TabIndex = 1;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndCall.UseVisualStyleBackColor = true;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // pnlRightBottom
            // 
            this.pnlRightBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightBottom.BackColor = System.Drawing.Color.Gray;
            this.pnlRightBottom.Controls.Add(this.btnInsertIntoDB);
            this.pnlRightBottom.Location = new System.Drawing.Point(17, 597);
            this.pnlRightBottom.Name = "pnlRightBottom";
            this.pnlRightBottom.Size = new System.Drawing.Size(158, 136);
            this.pnlRightBottom.TabIndex = 5;
            // 
            // btnInsertIntoDB
            // 
            this.btnInsertIntoDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnInsertIntoDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertIntoDB.FlatAppearance.BorderSize = 0;
            this.btnInsertIntoDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertIntoDB.Font = new System.Drawing.Font("Roboto Thin", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertIntoDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnInsertIntoDB.Location = new System.Drawing.Point(0, 0);
            this.btnInsertIntoDB.Name = "btnInsertIntoDB";
            this.btnInsertIntoDB.Size = new System.Drawing.Size(158, 136);
            this.btnInsertIntoDB.TabIndex = 4;
            this.btnInsertIntoDB.Text = "Insert call into database";
            this.btnInsertIntoDB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsertIntoDB.UseVisualStyleBackColor = false;
            this.btnInsertIntoDB.Click += new System.EventHandler(this.btnInsertIntoDB_Click);
            // 
            // btnMakeCall
            // 
            this.btnMakeCall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMakeCall.FlatAppearance.BorderSize = 0;
            this.btnMakeCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeCall.Font = new System.Drawing.Font("Roboto Thin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeCall.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnMakeCall.Location = new System.Drawing.Point(0, 90);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(187, 90);
            this.btnMakeCall.TabIndex = 2;
            this.btnMakeCall.Text = "Make Call";
            this.btnMakeCall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMakeCall.UseVisualStyleBackColor = true;
            this.btnMakeCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // btnTakeCall
            // 
            this.btnTakeCall.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTakeCall.FlatAppearance.BorderSize = 0;
            this.btnTakeCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeCall.Font = new System.Drawing.Font("Roboto Thin", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeCall.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnTakeCall.Location = new System.Drawing.Point(0, 0);
            this.btnTakeCall.Name = "btnTakeCall";
            this.btnTakeCall.Size = new System.Drawing.Size(187, 90);
            this.btnTakeCall.TabIndex = 0;
            this.btnTakeCall.Text = "Take Call";
            this.btnTakeCall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTakeCall.UseVisualStyleBackColor = true;
            this.btnTakeCall.Click += new System.EventHandler(this.btnTakeCall_Click);
            // 
            // callForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1394, 817);
            this.Controls.Add(this.pnlRightSide);
            this.Controls.Add(this.pnlClientInfo);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.pnlTitleBar);
            this.Name = "callForm";
            this.Text = "call";
            this.Load += new System.EventHandler(this.call_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlReports.ResumeLayout(false);
            this.pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStationNumber)).EndInit();
            this.pnlClientInfo.ResumeLayout(false);
            this.pnlClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numClientID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCallHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgreements)).EndInit();
            this.pnlRightSide.ResumeLayout(false);
            this.pnlRightBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox rtxtFaultReport;
        private System.Windows.Forms.Label lblFaultReport;
        private System.Windows.Forms.Label lblCallReport;
        private System.Windows.Forms.Label lblProblemInfo;
        private System.Windows.Forms.Label lblWorkRequest;
        private System.Windows.Forms.RichTextBox rtxtCallReport;
        private System.Windows.Forms.RichTextBox rtxtProblemInfo;
        private System.Windows.Forms.RichTextBox rtxtWorkRequest;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Panel pnlClientInfo;
        private System.Windows.Forms.Label lblClientInfo;
        private System.Windows.Forms.Label lblClientCallHistory;
        private System.Windows.Forms.DataGridView dgvCallHistory;
        private System.Windows.Forms.DataGridView dgvAgreements;
        private System.Windows.Forms.Label lblAgreements;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblClientNumber;
        private System.Windows.Forms.Button btnFindClientInfo;
        private System.Windows.Forms.Panel pnlRightSide;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.Panel pnlRightBottom;
        private System.Windows.Forms.Button btnInsertIntoDB;
        private System.Windows.Forms.Button btnMakeCall;
        private System.Windows.Forms.Button btnTakeCall;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximizeToggle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSetStationNumber;
        private System.Windows.Forms.Label lblStationNumber;
        private System.Windows.Forms.NumericUpDown numClientID;
        private System.Windows.Forms.NumericUpDown numStationNumber;
    }
}