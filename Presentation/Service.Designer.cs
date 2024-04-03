
namespace CallCenterProgram.Presentation
{
    partial class Service
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
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAdd = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnUpdateState = new System.Windows.Forms.Button();
            this.cmbUpdate1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdate1ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            this.txtUpdateExpenses = new System.Windows.Forms.TextBox();
            this.txtUpdateType = new System.Windows.Forms.TextBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.cmbUpdateAll = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximizeToggle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Existing Services:";
            // 
            // dgvServices
            // 
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(22, 109);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(2);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.Size = new System.Drawing.Size(586, 191);
            this.dgvServices.TabIndex = 1;
            this.dgvServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 330);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(569, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADD SERVICE SECTION: (ALL FIELDS TO BE FILLED IN!)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Service Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Service Equipment Type: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 443);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Work Expenses:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 477);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Select State Of The Service:";
            // 
            // cmbAdd
            // 
            this.cmbAdd.FormattingEnabled = true;
            this.cmbAdd.Items.AddRange(new object[] {
            "Active",
            "Not-Active"});
            this.cmbAdd.Location = new System.Drawing.Point(227, 478);
            this.cmbAdd.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAdd.Name = "cmbAdd";
            this.cmbAdd.Size = new System.Drawing.Size(152, 21);
            this.cmbAdd.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(227, 367);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(366, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(227, 407);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(366, 20);
            this.txtType.TabIndex = 9;
            // 
            // txtExpenses
            // 
            this.txtExpenses.Location = new System.Drawing.Point(227, 442);
            this.txtExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.Size = new System.Drawing.Size(366, 20);
            this.txtExpenses.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(659, 404);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(429, 40);
            this.label7.TabIndex = 11;
            this.label7.Text = "UPDATE SERVICE STATE ONLY SECTION: \r\n(ALL FIELDS TO BE FILLED IN!)";
            // 
            // btnAddService
            // 
            this.btnAddService.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAddService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.Location = new System.Drawing.Point(482, 515);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(110, 39);
            this.btnAddService.TabIndex = 12;
            this.btnAddService.Text = "ADD SERVICE";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnUpdateState
            // 
            this.btnUpdateState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateState.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateState.Location = new System.Drawing.Point(1121, 525);
            this.btnUpdateState.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateState.Name = "btnUpdateState";
            this.btnUpdateState.Size = new System.Drawing.Size(110, 39);
            this.btnUpdateState.TabIndex = 15;
            this.btnUpdateState.Text = "UPDATE SERVICE";
            this.btnUpdateState.UseVisualStyleBackColor = true;
            this.btnUpdateState.Click += new System.EventHandler(this.btnUpdateState_Click);
            // 
            // cmbUpdate1
            // 
            this.cmbUpdate1.FormattingEnabled = true;
            this.cmbUpdate1.Items.AddRange(new object[] {
            "Active",
            "Not-Active"});
            this.cmbUpdate1.Location = new System.Drawing.Point(867, 487);
            this.cmbUpdate1.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdate1.Name = "cmbUpdate1";
            this.cmbUpdate1.Size = new System.Drawing.Size(152, 21);
            this.cmbUpdate1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(658, 486);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Select State Of The Service:";
            // 
            // txtUpdate1ID
            // 
            this.txtUpdate1ID.Location = new System.Drawing.Point(867, 454);
            this.txtUpdate1ID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdate1ID.Name = "txtUpdate1ID";
            this.txtUpdate1ID.Size = new System.Drawing.Size(366, 20);
            this.txtUpdate1ID.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(658, 455);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Service ID:";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(455, 583);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(416, 44);
            this.btnMainMenu.TabIndex = 18;
            this.btnMainMenu.Text = "MAIN MENU";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUpdateAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAll.Location = new System.Drawing.Point(1122, 304);
            this.btnUpdateAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(110, 39);
            this.btnUpdateAll.TabIndex = 28;
            this.btnUpdateAll.Text = "UPDATE SERVICE";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // txtUpdateExpenses
            // 
            this.txtUpdateExpenses.Location = new System.Drawing.Point(868, 231);
            this.txtUpdateExpenses.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateExpenses.Name = "txtUpdateExpenses";
            this.txtUpdateExpenses.Size = new System.Drawing.Size(366, 20);
            this.txtUpdateExpenses.TabIndex = 27;
            // 
            // txtUpdateType
            // 
            this.txtUpdateType.Location = new System.Drawing.Point(868, 196);
            this.txtUpdateType.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateType.Name = "txtUpdateType";
            this.txtUpdateType.Size = new System.Drawing.Size(366, 20);
            this.txtUpdateType.TabIndex = 26;
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(868, 157);
            this.txtUpdateName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(366, 20);
            this.txtUpdateName.TabIndex = 25;
            // 
            // cmbUpdateAll
            // 
            this.cmbUpdateAll.FormattingEnabled = true;
            this.cmbUpdateAll.Items.AddRange(new object[] {
            "Active",
            "Not-Active"});
            this.cmbUpdateAll.Location = new System.Drawing.Point(868, 267);
            this.cmbUpdateAll.Margin = new System.Windows.Forms.Padding(2);
            this.cmbUpdateAll.Name = "cmbUpdateAll";
            this.cmbUpdateAll.Size = new System.Drawing.Size(152, 21);
            this.cmbUpdateAll.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(659, 266);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Select State Of The Service:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(661, 232);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Work Expenses:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(661, 196);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Service Equipment Type: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(661, 157);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Service Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(659, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(607, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "UPDATE SERVICE SECTION: (ALL FIELDS TO BE FILLED IN!)";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(868, 125);
            this.txtUpdateID.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(366, 20);
            this.txtUpdateID.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(661, 126);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "Service ID:";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnMaximizeToggle);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1284, 64);
            this.pnlTitleBar.TabIndex = 65;
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
            this.btnMinimize.Location = new System.Drawing.Point(1063, 0);
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
            this.btnMaximizeToggle.Location = new System.Drawing.Point(1138, 0);
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
            this.btnExit.Location = new System.Drawing.Point(1213, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 64);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.txtUpdateID);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnUpdateAll);
            this.Controls.Add(this.txtUpdateExpenses);
            this.Controls.Add(this.txtUpdateType);
            this.Controls.Add(this.txtUpdateName);
            this.Controls.Add(this.cmbUpdateAll);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.txtUpdate1ID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnUpdateState);
            this.Controls.Add(this.cmbUpdate1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtExpenses);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvServices);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Service";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnUpdateState;
        private System.Windows.Forms.ComboBox cmbUpdate1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdate1ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnUpdateAll;
        private System.Windows.Forms.TextBox txtUpdateExpenses;
        private System.Windows.Forms.TextBox txtUpdateType;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.ComboBox cmbUpdateAll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximizeToggle;
        private System.Windows.Forms.Button btnExit;
    }
}