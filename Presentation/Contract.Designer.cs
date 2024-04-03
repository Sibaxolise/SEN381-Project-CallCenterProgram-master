
namespace CallCenterProgram.Presentation
{
    partial class Contract
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
            this.dgvPackages = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvClientContract = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchContract = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtPackageID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAdd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdateContract = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximizeToggle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientContract)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPackages
            // 
            this.dgvPackages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackages.Location = new System.Drawing.Point(23, 119);
            this.dgvPackages.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPackages.Name = "dgvPackages";
            this.dgvPackages.RowHeadersWidth = 51;
            this.dgvPackages.RowTemplate.Height = 24;
            this.dgvPackages.Size = new System.Drawing.Size(586, 191);
            this.dgvPackages.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label11.Location = new System.Drawing.Point(20, 80);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 20);
            this.label11.TabIndex = 60;
            this.label11.Text = "Existing Pakcages:";
            // 
            // dgvClientContract
            // 
            this.dgvClientContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientContract.Location = new System.Drawing.Point(639, 184);
            this.dgvClientContract.Margin = new System.Windows.Forms.Padding(2);
            this.dgvClientContract.Name = "dgvClientContract";
            this.dgvClientContract.RowHeadersWidth = 51;
            this.dgvClientContract.RowTemplate.Height = 24;
            this.dgvClientContract.Size = new System.Drawing.Size(586, 127);
            this.dgvClientContract.TabIndex = 62;
            this.dgvClientContract.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientContract_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnSearch.Location = new System.Drawing.Point(1114, 129);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 39);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "SEARCH CLIENT";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchContract
            // 
            this.txtSearchContract.Location = new System.Drawing.Point(786, 140);
            this.txtSearchContract.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchContract.Name = "txtSearchContract";
            this.txtSearchContract.Size = new System.Drawing.Size(244, 20);
            this.txtSearchContract.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label5.Location = new System.Drawing.Point(636, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "Enter Client ID:";
            // 
            // btnAddContract
            // 
            this.btnAddContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnAddContract.Location = new System.Drawing.Point(489, 512);
            this.btnAddContract.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(110, 39);
            this.btnAddContract.TabIndex = 73;
            this.btnAddContract.Text = "ADD CONTRACT";
            this.btnAddContract.UseVisualStyleBackColor = true;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(269, 431);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(2);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(332, 20);
            this.txtClientID.TabIndex = 71;
            // 
            // txtPackageID
            // 
            this.txtPackageID.Location = new System.Drawing.Point(269, 382);
            this.txtPackageID.Margin = new System.Windows.Forms.Padding(2);
            this.txtPackageID.Name = "txtPackageID";
            this.txtPackageID.Size = new System.Drawing.Size(332, 20);
            this.txtPackageID.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label4.Location = new System.Drawing.Point(28, 430);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Enter Client ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label3.Location = new System.Drawing.Point(28, 383);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 32);
            this.label3.TabIndex = 67;
            this.label3.Text = "Enter Package ID:\r\n(ContractTypeID)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label2.Location = new System.Drawing.Point(20, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "ADD CONTRACT SECTION: (ALL FIELDS TO BE FILLED IN!)";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnMainMenu.Location = new System.Drawing.Point(489, 593);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(356, 39);
            this.btnMainMenu.TabIndex = 74;
            this.btnMainMenu.Text = "MAIN MENU";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(635, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Client Contracts";
            // 
            // cmbAdd
            // 
            this.cmbAdd.FormattingEnabled = true;
            this.cmbAdd.Items.AddRange(new object[] {
            "Active",
            "Not-Active"});
            this.cmbAdd.Location = new System.Drawing.Point(269, 462);
            this.cmbAdd.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAdd.Name = "cmbAdd";
            this.cmbAdd.Size = new System.Drawing.Size(152, 21);
            this.cmbAdd.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label6.Location = new System.Drawing.Point(28, 465);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 78;
            this.label6.Text = "Select Contract State:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label7.Location = new System.Drawing.Point(644, 431);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 16);
            this.label7.TabIndex = 85;
            this.label7.Text = "Select Contract State:";
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Items.AddRange(new object[] {
            "Active",
            "Not-Active"});
            this.cmbUpdate.Location = new System.Drawing.Point(885, 429);
            this.cmbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(152, 21);
            this.cmbUpdate.TabIndex = 84;
            // 
            // txtContractID
            // 
            this.txtContractID.Location = new System.Drawing.Point(885, 382);
            this.txtContractID.Margin = new System.Windows.Forms.Padding(2);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.Size = new System.Drawing.Size(332, 20);
            this.txtContractID.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label9.Location = new System.Drawing.Point(644, 383);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 80;
            this.label9.Text = "Contract ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label10.Location = new System.Drawing.Point(635, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(632, 20);
            this.label10.TabIndex = 79;
            this.label10.Text = "UPDATE CONTRACT SECTION: (ALL FIELDS TO BE FILLED IN!)";
            // 
            // btnUpdateContract
            // 
            this.btnUpdateContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnUpdateContract.Location = new System.Drawing.Point(1105, 512);
            this.btnUpdateContract.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateContract.Name = "btnUpdateContract";
            this.btnUpdateContract.Size = new System.Drawing.Size(110, 39);
            this.btnUpdateContract.TabIndex = 86;
            this.btnUpdateContract.Text = "UPDATE CONTRACT";
            this.btnUpdateContract.UseVisualStyleBackColor = true;
            this.btnUpdateContract.Click += new System.EventHandler(this.btnUpdateContract_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximizeToggle);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1251, 64);
            this.pnlTitleBar.TabIndex = 87;
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnMinimize.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterminimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.CausesValidation = false;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1030, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(75, 64);
            this.btnMinimize.TabIndex = 6;
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
            this.btnMaximizeToggle.Location = new System.Drawing.Point(1105, 0);
            this.btnMaximizeToggle.Name = "btnMaximizeToggle";
            this.btnMaximizeToggle.Size = new System.Drawing.Size(75, 64);
            this.btnMaximizeToggle.TabIndex = 7;
            this.btnMaximizeToggle.UseVisualStyleBackColor = false;
            this.btnMaximizeToggle.Click += new System.EventHandler(this.btnMaximizeToggle_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SlateGray;
            this.btnExit.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterexit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1180, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 64);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1251, 650);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.btnUpdateContract);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbUpdate);
            this.Controls.Add(this.txtContractID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnAddContract);
            this.Controls.Add(this.txtClientID);
            this.Controls.Add(this.txtPackageID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchContract);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvClientContract);
            this.Controls.Add(this.dgvPackages);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Contract";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.Contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientContract)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPackages;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvClientContract;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchContract;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtPackageID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdateContract;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximizeToggle;
        private System.Windows.Forms.Button btnExit;
    }
}