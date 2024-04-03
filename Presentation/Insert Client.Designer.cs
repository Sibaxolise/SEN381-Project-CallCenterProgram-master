
namespace CallCenterProgram.Presentation
{
    partial class Insert_Client
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
            this.btnInsertClient = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.nudID = new System.Windows.Forms.NumericUpDown();
            this.lstCountries = new System.Windows.Forms.ListBox();
            this.nudStreetNumber = new System.Windows.Forms.NumericUpDown();
            this.lstCurrentClient = new System.Windows.Forms.ListBox();
            this.rtbStatus = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStreetNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertClient
            // 
            this.btnInsertClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnInsertClient.Location = new System.Drawing.Point(92, 456);
            this.btnInsertClient.Name = "btnInsertClient";
            this.btnInsertClient.Size = new System.Drawing.Size(224, 27);
            this.btnInsertClient.TabIndex = 0;
            this.btnInsertClient.Text = "Insert Client";
            this.btnInsertClient.UseVisualStyleBackColor = true;
            this.btnInsertClient.Click += new System.EventHandler(this.btnInsertClient_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(200, 75);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(116, 23);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(200, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(200, 135);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(116, 23);
            this.txtCellphone.TabIndex = 4;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(200, 195);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(116, 23);
            this.txtStreetName.TabIndex = 5;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(200, 225);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(116, 23);
            this.txtCity.TabIndex = 6;
            // 
            // nudID
            // 
            this.nudID.Location = new System.Drawing.Point(200, 15);
            this.nudID.Name = "nudID";
            this.nudID.Size = new System.Drawing.Size(117, 23);
            this.nudID.TabIndex = 8;
            this.nudID.ValueChanged += new System.EventHandler(this.nudID_ValueChanged);
            // 
            // lstCountries
            // 
            this.lstCountries.AllowDrop = true;
            this.lstCountries.FormattingEnabled = true;
            this.lstCountries.ItemHeight = 15;
            this.lstCountries.Items.AddRange(new object[] {
            "South Africa",
            "America",
            "Canada",
            "Congo",
            "England",
            "Australia",
            "Kenya",
            "Other"});
            this.lstCountries.Location = new System.Drawing.Point(200, 255);
            this.lstCountries.Name = "lstCountries";
            this.lstCountries.Size = new System.Drawing.Size(116, 49);
            this.lstCountries.TabIndex = 9;
            // 
            // nudStreetNumber
            // 
            this.nudStreetNumber.Location = new System.Drawing.Point(200, 165);
            this.nudStreetNumber.Maximum = new decimal(new int[] {
            986039,
            0,
            0,
            0});
            this.nudStreetNumber.Name = "nudStreetNumber";
            this.nudStreetNumber.Size = new System.Drawing.Size(117, 23);
            this.nudStreetNumber.TabIndex = 10;
            // 
            // lstCurrentClient
            // 
            this.lstCurrentClient.AllowDrop = true;
            this.lstCurrentClient.FormattingEnabled = true;
            this.lstCurrentClient.ItemHeight = 15;
            this.lstCurrentClient.Items.AddRange(new object[] {
            "True",
            "False"});
            this.lstCurrentClient.Location = new System.Drawing.Point(200, 391);
            this.lstCurrentClient.Name = "lstCurrentClient";
            this.lstCurrentClient.Size = new System.Drawing.Size(116, 34);
            this.lstCurrentClient.TabIndex = 11;
            // 
            // rtbStatus
            // 
            this.rtbStatus.Location = new System.Drawing.Point(200, 315);
            this.rtbStatus.Name = "rtbStatus";
            this.rtbStatus.Size = new System.Drawing.Size(116, 65);
            this.rtbStatus.TabIndex = 12;
            this.rtbStatus.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Surname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Cellphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Street";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Street No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(89, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Country";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(89, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(89, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Current Client";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.nudID);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnInsertClient);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCellphone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtStreetName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lstCountries);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudStreetNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lstCurrentClient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rtbStatus);
            this.panel1.Location = new System.Drawing.Point(22, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 550);
            this.panel1.TabIndex = 24;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnBack.Location = new System.Drawing.Point(92, 505);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(224, 27);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.txtBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnMax);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 48);
            this.panel2.TabIndex = 25;
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterminimize;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(289, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(54, 48);
            this.btnMin.TabIndex = 18;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcentermaximize;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(343, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(56, 48);
            this.btnMax.TabIndex = 17;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterexit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(399, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 48);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Insert_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(455, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.Name = "Insert_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert_Client";
            this.Load += new System.EventHandler(this.Insert_Client_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Insert_Client_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.nudID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStreetNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertClient;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.NumericUpDown nudID;
        private System.Windows.Forms.ListBox lstCountries;
        private System.Windows.Forms.NumericUpDown nudStreetNumber;
        private System.Windows.Forms.ListBox lstCurrentClient;
        private System.Windows.Forms.RichTextBox rtbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
    }
}