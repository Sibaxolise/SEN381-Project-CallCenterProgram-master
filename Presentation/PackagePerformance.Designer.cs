
namespace CallCenterProgram.Presentation
{
    partial class PackagePerformance
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBestPackageOfTheMonth = new System.Windows.Forms.DataGridView();
            this.btnSearchPackage = new System.Windows.Forms.Button();
            this.txtSearchPackage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbActive = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBestNumbersSold = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalPackages = new System.Windows.Forms.Label();
            this.lblActivePackagesMonthly = new System.Windows.Forms.Label();
            this.dgvPackageByCity = new System.Windows.Forms.DataGridView();
            this.PackageSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.lblResolutionTime = new System.Windows.Forms.Label();
            this.lblBusinessClients = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pbPercentBusinessClients = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnFilterDataByDate = new System.Windows.Forms.Button();
            this.btnBackToPackage = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximizeToggle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestPackageOfTheMonth)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageByCity)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Number Of Packages\r\n                Bought";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Number Of Active Packages";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Best Perfoming Package of the Month";
            // 
            // dgvBestPackageOfTheMonth
            // 
            this.dgvBestPackageOfTheMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBestPackageOfTheMonth.Location = new System.Drawing.Point(641, 75);
            this.dgvBestPackageOfTheMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBestPackageOfTheMonth.Name = "dgvBestPackageOfTheMonth";
            this.dgvBestPackageOfTheMonth.RowHeadersWidth = 51;
            this.dgvBestPackageOfTheMonth.RowTemplate.Height = 24;
            this.dgvBestPackageOfTheMonth.Size = new System.Drawing.Size(494, 164);
            this.dgvBestPackageOfTheMonth.TabIndex = 5;
            // 
            // btnSearchPackage
            // 
            this.btnSearchPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnSearchPackage.Location = new System.Drawing.Point(666, 372);
            this.btnSearchPackage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchPackage.Name = "btnSearchPackage";
            this.btnSearchPackage.Size = new System.Drawing.Size(110, 39);
            this.btnSearchPackage.TabIndex = 68;
            this.btnSearchPackage.Text = "SEARCH PACKAGE";
            this.btnSearchPackage.UseVisualStyleBackColor = true;
            this.btnSearchPackage.Click += new System.EventHandler(this.btnSearchPackage_Click);
            // 
            // txtSearchPackage
            // 
            this.txtSearchPackage.Location = new System.Drawing.Point(344, 383);
            this.txtSearchPackage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchPackage.Name = "txtSearchPackage";
            this.txtSearchPackage.Size = new System.Drawing.Size(244, 20);
            this.txtSearchPackage.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label5.Location = new System.Drawing.Point(187, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Enter Package ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 346);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 24);
            this.label4.TabIndex = 69;
            this.label4.Text = "Package Performance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 426);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 71;
            this.label6.Text = "Sales by City:";
            // 
            // pbActive
            // 
            this.pbActive.Location = new System.Drawing.Point(326, 89);
            this.pbActive.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbActive.MarqueeAnimationSpeed = 1;
            this.pbActive.Name = "pbActive";
            this.pbActive.Size = new System.Drawing.Size(273, 19);
            this.pbActive.Step = 1;
            this.pbActive.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbActive.TabIndex = 72;
            this.pbActive.Value = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBestNumbersSold);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTotalPackages);
            this.groupBox1.Controls.Add(this.lblActivePackagesMonthly);
            this.groupBox1.Controls.Add(this.pbActive);
            this.groupBox1.Controls.Add(this.dgvBestPackageOfTheMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1283, 262);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Montly Performance Values";
            // 
            // lblBestNumbersSold
            // 
            this.lblBestNumbersSold.AutoSize = true;
            this.lblBestNumbersSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestNumbersSold.Location = new System.Drawing.Point(1173, 121);
            this.lblBestNumbersSold.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBestNumbersSold.Name = "lblBestNumbersSold";
            this.lblBestNumbersSold.Size = new System.Drawing.Size(80, 55);
            this.lblBestNumbersSold.TabIndex = 76;
            this.lblBestNumbersSold.Text = "60";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1162, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 48);
            this.label7.TabIndex = 75;
            this.label7.Text = "Numbers \r\n    Sold";
            // 
            // lblTotalPackages
            // 
            this.lblTotalPackages.AutoSize = true;
            this.lblTotalPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPackages.Location = new System.Drawing.Point(105, 89);
            this.lblTotalPackages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPackages.Name = "lblTotalPackages";
            this.lblTotalPackages.Size = new System.Drawing.Size(80, 55);
            this.lblTotalPackages.TabIndex = 74;
            this.lblTotalPackages.Text = "60";
            // 
            // lblActivePackagesMonthly
            // 
            this.lblActivePackagesMonthly.AutoSize = true;
            this.lblActivePackagesMonthly.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivePackagesMonthly.Location = new System.Drawing.Point(442, 121);
            this.lblActivePackagesMonthly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActivePackagesMonthly.Name = "lblActivePackagesMonthly";
            this.lblActivePackagesMonthly.Size = new System.Drawing.Size(46, 31);
            this.lblActivePackagesMonthly.TabIndex = 73;
            this.lblActivePackagesMonthly.Text = "45";
            // 
            // dgvPackageByCity
            // 
            this.dgvPackageByCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackageByCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageSales,
            this.City});
            this.dgvPackageByCity.Location = new System.Drawing.Point(190, 458);
            this.dgvPackageByCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPackageByCity.Name = "dgvPackageByCity";
            this.dgvPackageByCity.RowHeadersWidth = 51;
            this.dgvPackageByCity.RowTemplate.Height = 24;
            this.dgvPackageByCity.Size = new System.Drawing.Size(382, 122);
            this.dgvPackageByCity.TabIndex = 74;
            // 
            // PackageSales
            // 
            this.PackageSales.HeaderText = "Package Sales";
            this.PackageSales.MinimumWidth = 10;
            this.PackageSales.Name = "PackageSales";
            this.PackageSales.Width = 125;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 12;
            this.City.Name = "City";
            this.City.Width = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(591, 426);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 24);
            this.label8.TabIndex = 75;
            this.label8.Text = "Average Package Resolution Time:";
            // 
            // lblResolutionTime
            // 
            this.lblResolutionTime.AutoSize = true;
            this.lblResolutionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolutionTime.Location = new System.Drawing.Point(646, 476);
            this.lblResolutionTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResolutionTime.Name = "lblResolutionTime";
            this.lblResolutionTime.Size = new System.Drawing.Size(241, 55);
            this.lblResolutionTime.TabIndex = 75;
            this.lblResolutionTime.Text = "5 minutes";
            // 
            // lblBusinessClients
            // 
            this.lblBusinessClients.AutoSize = true;
            this.lblBusinessClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusinessClients.Location = new System.Drawing.Point(1040, 476);
            this.lblBusinessClients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusinessClients.Name = "lblBusinessClients";
            this.lblBusinessClients.Size = new System.Drawing.Size(80, 55);
            this.lblBusinessClients.TabIndex = 76;
            this.lblBusinessClients.Text = "40";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(980, 403);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 48);
            this.label11.TabIndex = 77;
            this.label11.Text = "% Business Client \r\n   Using Package:";
            // 
            // pbPercentBusinessClients
            // 
            this.pbPercentBusinessClients.Location = new System.Drawing.Point(984, 546);
            this.pbPercentBusinessClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbPercentBusinessClients.Name = "pbPercentBusinessClients";
            this.pbPercentBusinessClients.Size = new System.Drawing.Size(177, 19);
            this.pbPercentBusinessClients.TabIndex = 75;
            this.pbPercentBusinessClients.Value = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(186, 619);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 24);
            this.label12.TabIndex = 78;
            this.label12.Text = "Filter by date:";
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(311, 663);
            this.dateStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(151, 20);
            this.dateStart.TabIndex = 79;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label13.Location = new System.Drawing.Point(187, 663);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 16);
            this.label13.TabIndex = 80;
            this.label13.Text = "Enter Start Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label14.Location = new System.Drawing.Point(500, 664);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 82;
            this.label14.Text = "Enter End Date:";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(625, 664);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(151, 20);
            this.dateEnd.TabIndex = 81;
            // 
            // btnFilterDataByDate
            // 
            this.btnFilterDataByDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilterDataByDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnFilterDataByDate.Location = new System.Drawing.Point(871, 655);
            this.btnFilterDataByDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFilterDataByDate.Name = "btnFilterDataByDate";
            this.btnFilterDataByDate.Size = new System.Drawing.Size(165, 39);
            this.btnFilterDataByDate.TabIndex = 83;
            this.btnFilterDataByDate.Text = "FILTER PACKAGE DATA";
            this.btnFilterDataByDate.UseVisualStyleBackColor = true;
            // 
            // btnBackToPackage
            // 
            this.btnBackToPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToPackage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnBackToPackage.Location = new System.Drawing.Point(521, 736);
            this.btnBackToPackage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToPackage.Name = "btnBackToPackage";
            this.btnBackToPackage.Size = new System.Drawing.Size(340, 39);
            this.btnBackToPackage.TabIndex = 84;
            this.btnBackToPackage.Text = "BACK TO PACKAGE FORM";
            this.btnBackToPackage.UseVisualStyleBackColor = true;
            this.btnBackToPackage.Click += new System.EventHandler(this.btnBackToPackage_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximizeToggle);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1348, 56);
            this.pnlTitleBar.TabIndex = 85;
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
            this.btnMinimize.Location = new System.Drawing.Point(1127, 0);
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
            this.btnMaximizeToggle.FlatAppearance.BorderSize = 0;
            this.btnMaximizeToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeToggle.Location = new System.Drawing.Point(1202, 0);
            this.btnMaximizeToggle.Name = "btnMaximizeToggle";
            this.btnMaximizeToggle.Size = new System.Drawing.Size(75, 56);
            this.btnMaximizeToggle.TabIndex = 4;
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
            this.btnExit.Location = new System.Drawing.Point(1277, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // PackagePerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1348, 794);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.btnBackToPackage);
            this.Controls.Add(this.btnFilterDataByDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pbPercentBusinessClients);
            this.Controls.Add(this.lblBusinessClients);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblResolutionTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvPackageByCity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearchPackage);
            this.Controls.Add(this.txtSearchPackage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PackagePerformance";
            this.Text = "PackagePerformance";
            this.Load += new System.EventHandler(this.PackagePerformance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestPackageOfTheMonth)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageByCity)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBestPackageOfTheMonth;
        private System.Windows.Forms.Button btnSearchPackage;
        private System.Windows.Forms.TextBox txtSearchPackage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalPackages;
        private System.Windows.Forms.Label lblActivePackagesMonthly;
        private System.Windows.Forms.DataGridView dgvPackageByCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResolutionTime;
        private System.Windows.Forms.Label lblBusinessClients;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar pbPercentBusinessClients;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnFilterDataByDate;
        private System.Windows.Forms.Button btnBackToPackage;
        private System.Windows.Forms.Label lblBestNumbersSold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximizeToggle;
        private System.Windows.Forms.Button btnExit;
    }
}