namespace CallCenterProgram.Presentation
{
    partial class frmIncident
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbReportInfo = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateIssued = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxPriority = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCallerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.Incidents = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximizeToggle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report Info:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rtbReportInfo
            // 
            this.rtbReportInfo.Location = new System.Drawing.Point(149, 82);
            this.rtbReportInfo.Name = "rtbReportInfo";
            this.rtbReportInfo.Size = new System.Drawing.Size(611, 159);
            this.rtbReportInfo.TabIndex = 2;
            this.rtbReportInfo.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(16, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Issued:";
            // 
            // dtpDateIssued
            // 
            this.dtpDateIssued.Location = new System.Drawing.Point(149, 257);
            this.dtpDateIssued.Name = "dtpDateIssued";
            this.dtpDateIssued.Size = new System.Drawing.Size(200, 20);
            this.dtpDateIssued.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label3.Location = new System.Drawing.Point(16, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(149, 296);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(200, 20);
            this.txtCost.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label4.Location = new System.Drawing.Point(16, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Priority:";
            // 
            // cbxPriority
            // 
            this.cbxPriority.FormattingEnabled = true;
            this.cbxPriority.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbxPriority.Location = new System.Drawing.Point(149, 322);
            this.cbxPriority.Name = "cbxPriority";
            this.cbxPriority.Size = new System.Drawing.Size(200, 21);
            this.cbxPriority.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.groupBox1.Location = new System.Drawing.Point(149, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 119);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skills";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Technical";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Hardware";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Software";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mechanical";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label5.Location = new System.Drawing.Point(16, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ability Req:";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(149, 503);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(200, 20);
            this.txtClientID.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label6.Location = new System.Drawing.Point(16, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Client ID:";
            // 
            // txtCallerID
            // 
            this.txtCallerID.Location = new System.Drawing.Point(149, 529);
            this.txtCallerID.Name = "txtCallerID";
            this.txtCallerID.Size = new System.Drawing.Size(200, 20);
            this.txtCallerID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label7.Location = new System.Drawing.Point(16, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Caller ID:";
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCreateIncident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateIncident.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnCreateIncident.Location = new System.Drawing.Point(149, 557);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(200, 27);
            this.btnCreateIncident.TabIndex = 15;
            this.btnCreateIncident.Text = "Create Incident";
            this.btnCreateIncident.UseVisualStyleBackColor = false;
            this.btnCreateIncident.Click += new System.EventHandler(this.btnCreateIncident_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlTitleBar.Controls.Add(this.btnHome);
            this.pnlTitleBar.Controls.Add(this.Incidents);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximizeToggle);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(800, 56);
            this.pnlTitleBar.TabIndex = 16;
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnHome.Location = new System.Drawing.Point(498, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 42);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // Incidents
            // 
            this.Incidents.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Incidents.AutoSize = true;
            this.Incidents.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incidents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.Incidents.Location = new System.Drawing.Point(275, 0);
            this.Incidents.Name = "Incidents";
            this.Incidents.Size = new System.Drawing.Size(217, 58);
            this.Incidents.TabIndex = 5;
            this.Incidents.Text = "Incidents";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnMinimize.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterminimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(579, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 56);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximizeToggle
            // 
            this.btnMaximizeToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnMaximizeToggle.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcentermaximize;
            this.btnMaximizeToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximizeToggle.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximizeToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeToggle.Location = new System.Drawing.Point(654, 0);
            this.btnMaximizeToggle.Name = "btnMaximizeToggle";
            this.btnMaximizeToggle.Size = new System.Drawing.Size(75, 56);
            this.btnMaximizeToggle.TabIndex = 4;
            this.btnMaximizeToggle.UseVisualStyleBackColor = false;
            this.btnMaximizeToggle.Click += new System.EventHandler(this.btnMaximizeToggle_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterexit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(729, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.btnCreateIncident);
            this.Controls.Add(this.txtCallerID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateIssued);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbReportInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmIncident";
            this.Text = "Incident";
            this.Load += new System.EventHandler(this.frmIncident_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbReportInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateIssued;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxPriority;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCallerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label Incidents;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximizeToggle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHome;
    }
}