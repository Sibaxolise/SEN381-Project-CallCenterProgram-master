
namespace CallCenterProgram.Presentation
{
    partial class Business_Client_Info
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
            this.dgvBusinessClients = new System.Windows.Forms.DataGridView();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnViewIndividualClients = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnUpdateClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.nudStreetNumber = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstCountries = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cellphone = new System.Windows.Forms.Label();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnUpdateConfirm = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinessClients)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStreetNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Business Clients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvBusinessClients
            // 
            this.dgvBusinessClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusinessClients.Location = new System.Drawing.Point(19, 46);
            this.dgvBusinessClients.MultiSelect = false;
            this.dgvBusinessClients.Name = "dgvBusinessClients";
            this.dgvBusinessClients.Size = new System.Drawing.Size(561, 200);
            this.dgvBusinessClients.TabIndex = 1;
            this.dgvBusinessClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBusinessClients_CellClick);
            this.dgvBusinessClients.SelectionChanged += new System.EventHandler(this.dgvBusinessClients_SelectionChanged);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(505, 17);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(253, 17);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnViewIndividualClients
            // 
            this.btnViewIndividualClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIndividualClients.Location = new System.Drawing.Point(348, 17);
            this.btnViewIndividualClients.Name = "btnViewIndividualClients";
            this.btnViewIndividualClients.Size = new System.Drawing.Size(136, 23);
            this.btnViewIndividualClients.TabIndex = 4;
            this.btnViewIndividualClients.Text = "View Individual Clients";
            this.btnViewIndividualClients.UseVisualStyleBackColor = true;
            this.btnViewIndividualClients.Click += new System.EventHandler(this.btnViewIndividualClients_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Location = new System.Drawing.Point(19, 252);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(167, 23);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClient.Location = new System.Drawing.Point(221, 252);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(166, 23);
            this.btnUpdateClient.TabIndex = 6;
            this.btnUpdateClient.Text = "Show Update Panel";
            this.btnUpdateClient.UseVisualStyleBackColor = true;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClient.Location = new System.Drawing.Point(420, 252);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(160, 23);
            this.btnDeleteClient.TabIndex = 7;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDeleteClient);
            this.panel1.Controls.Add(this.dgvBusinessClients);
            this.panel1.Controls.Add(this.btnUpdateClient);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnAddClient);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnViewIndividualClients);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 295);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnMax);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 62);
            this.panel2.TabIndex = 8;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterminimize;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(399, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 62);
            this.btnMin.TabIndex = 15;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcentermaximize;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(474, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 62);
            this.btnMax.TabIndex = 14;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterexit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(549, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 62);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtCity);
            this.panel3.Controls.Add(this.nudStreetNumber);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtStreetName);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lstCountries);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.Cellphone);
            this.panel3.Controls.Add(this.rtbStatus);
            this.panel3.Controls.Add(this.txtCellphone);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.btnUpdateConfirm);
            this.panel3.Controls.Add(this.txtRole);
            this.panel3.Controls.Add(this.txtSurname);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Location = new System.Drawing.Point(76, 369);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(484, 222);
            this.panel3.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(348, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(60, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(29, 21);
            this.txtID.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(95, 169);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 21);
            this.txtCity.TabIndex = 20;
            // 
            // nudStreetNumber
            // 
            this.nudStreetNumber.Location = new System.Drawing.Point(95, 115);
            this.nudStreetNumber.Maximum = new decimal(new int[] {
            986039,
            0,
            0,
            0});
            this.nudStreetNumber.Name = "nudStreetNumber";
            this.nudStreetNumber.Size = new System.Drawing.Size(118, 21);
            this.nudStreetNumber.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "StreetNo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "StreetName";
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(95, 142);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(100, 21);
            this.txtStreetName.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Country";
            // 
            // lstCountries
            // 
            this.lstCountries.AllowDrop = true;
            this.lstCountries.FormattingEnabled = true;
            this.lstCountries.Items.AddRange(new object[] {
            "South Africa",
            "America",
            "Canada",
            "Congo",
            "England",
            "Australia",
            "Kenya",
            "Other"});
            this.lstCountries.Location = new System.Drawing.Point(348, 105);
            this.lstCountries.Name = "lstCountries";
            this.lstCountries.Size = new System.Drawing.Size(100, 43);
            this.lstCountries.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(345, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Role";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Status";
            // 
            // Cellphone
            // 
            this.Cellphone.AutoSize = true;
            this.Cellphone.Location = new System.Drawing.Point(29, 61);
            this.Cellphone.Name = "Cellphone";
            this.Cellphone.Size = new System.Drawing.Size(56, 13);
            this.Cellphone.TabIndex = 8;
            this.Cellphone.Text = "Cellphone";
            // 
            // rtbStatus
            // 
            this.rtbStatus.Location = new System.Drawing.Point(348, 51);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(100, 48);
            this.rtbStatus.TabIndex = 7;
            this.rtbStatus.Text = "";
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(95, 61);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(100, 21);
            this.txtCellphone.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(95, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 21);
            this.txtEmail.TabIndex = 5;
            // 
            // btnUpdateConfirm
            // 
            this.btnUpdateConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateConfirm.Location = new System.Drawing.Point(157, 196);
            this.btnUpdateConfirm.Name = "btnUpdateConfirm";
            this.btnUpdateConfirm.Size = new System.Drawing.Size(166, 23);
            this.btnUpdateConfirm.TabIndex = 4;
            this.btnUpdateConfirm.Text = "Update";
            this.btnUpdateConfirm.UseVisualStyleBackColor = true;
            this.btnUpdateConfirm.Click += new System.EventHandler(this.btnUpdateConfirm_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(348, 24);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 21);
            this.txtRole.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(201, 24);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 21);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 0;
            // 
            // Business_Client_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(624, 595);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.Name = "Business_Client_Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business_Client_Info";
            this.Load += new System.EventHandler(this.Business_Client_Info_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Business_Client_Info_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusinessClients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStreetNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBusinessClients;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnViewIndividualClients;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnUpdateClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdateConfirm;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cellphone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lstCountries;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudStreetNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnCancel;
    }
}