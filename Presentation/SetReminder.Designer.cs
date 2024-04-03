namespace CallCenterProgram.Presentation
{
    partial class SetReminder
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
            this.txtReminderId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExitReminder = new System.Windows.Forms.Button();
            this.btnFollowUpReminder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridVReminder = new System.Windows.Forms.DataGridView();
            this.btnDeleteR = new System.Windows.Forms.Button();
            this.btbUpdateR = new System.Windows.Forms.Button();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReminder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximizeToggle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVReminder)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReminderId
            // 
            this.txtReminderId.Location = new System.Drawing.Point(17, 146);
            this.txtReminderId.Name = "txtReminderId";
            this.txtReminderId.Size = new System.Drawing.Size(204, 21);
            this.txtReminderId.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "ReminderID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Reminder:";
            // 
            // btnExitReminder
            // 
            this.btnExitReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitReminder.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnExitReminder.Location = new System.Drawing.Point(638, 452);
            this.btnExitReminder.Name = "btnExitReminder";
            this.btnExitReminder.Size = new System.Drawing.Size(151, 34);
            this.btnExitReminder.TabIndex = 20;
            this.btnExitReminder.Text = "Exit";
            this.btnExitReminder.UseVisualStyleBackColor = true;
            this.btnExitReminder.Click += new System.EventHandler(this.btnExitReminder_Click);
            // 
            // btnFollowUpReminder
            // 
            this.btnFollowUpReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFollowUpReminder.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFollowUpReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnFollowUpReminder.Location = new System.Drawing.Point(481, 452);
            this.btnFollowUpReminder.Name = "btnFollowUpReminder";
            this.btnFollowUpReminder.Size = new System.Drawing.Size(151, 34);
            this.btnFollowUpReminder.TabIndex = 19;
            this.btnFollowUpReminder.Text = "FollowUp";
            this.btnFollowUpReminder.UseVisualStyleBackColor = true;
            this.btnFollowUpReminder.Click += new System.EventHandler(this.btnFollowUpReminder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridVReminder);
            this.panel1.Controls.Add(this.btnDeleteR);
            this.panel1.Controls.Add(this.btbUpdateR);
            this.panel1.Controls.Add(this.btnAddReminder);
            this.panel1.Location = new System.Drawing.Point(21, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 250);
            this.panel1.TabIndex = 18;
            // 
            // dataGridVReminder
            // 
            this.dataGridVReminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVReminder.Location = new System.Drawing.Point(0, 0);
            this.dataGridVReminder.Name = "dataGridVReminder";
            this.dataGridVReminder.Size = new System.Drawing.Size(765, 207);
            this.dataGridVReminder.TabIndex = 5;
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteR.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnDeleteR.Location = new System.Drawing.Point(499, 213);
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.Size = new System.Drawing.Size(266, 34);
            this.btnDeleteR.TabIndex = 4;
            this.btnDeleteR.Text = "Delete Reminder";
            this.btnDeleteR.UseVisualStyleBackColor = true;
            this.btnDeleteR.Click += new System.EventHandler(this.btnDeleteR_Click);
            // 
            // btbUpdateR
            // 
            this.btbUpdateR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbUpdateR.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbUpdateR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btbUpdateR.Location = new System.Drawing.Point(266, 213);
            this.btbUpdateR.Name = "btbUpdateR";
            this.btbUpdateR.Size = new System.Drawing.Size(236, 34);
            this.btbUpdateR.TabIndex = 3;
            this.btbUpdateR.Text = "Update Reminder";
            this.btbUpdateR.UseVisualStyleBackColor = true;
            this.btbUpdateR.Click += new System.EventHandler(this.btbUpdateR_Click);
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddReminder.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReminder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnAddReminder.Location = new System.Drawing.Point(3, 213);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(266, 34);
            this.btnAddReminder.TabIndex = 1;
            this.btnAddReminder.Text = "Add Reminder";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(184, 441);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 23);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "....";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Current Time:";
            // 
            // txtReminder
            // 
            this.txtReminder.Location = new System.Drawing.Point(224, 147);
            this.txtReminder.Name = "txtReminder";
            this.txtReminder.Size = new System.Drawing.Size(299, 21);
            this.txtReminder.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(254, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 42);
            this.label1.TabIndex = 12;
            this.label1.Text = "Set Reminder";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpReminder
            // 
            this.dtpReminder.Location = new System.Drawing.Point(529, 147);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(257, 21);
            this.dtpReminder.TabIndex = 24;
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
            this.pnlTitleBar.Size = new System.Drawing.Size(800, 56);
            this.pnlTitleBar.TabIndex = 25;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnMinimize.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterminimize;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
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
            this.btnMaximizeToggle.ForeColor = System.Drawing.Color.Black;
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
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(729, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 56);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SetReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.dtpReminder);
            this.Controls.Add(this.txtReminderId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnExitReminder);
            this.Controls.Add(this.btnFollowUpReminder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReminder);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SetReminder";
            this.Text = "SetReminder";
            this.Load += new System.EventHandler(this.SetReminder_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVReminder)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReminderId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExitReminder;
        private System.Windows.Forms.Button btnFollowUpReminder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridVReminder;
        private System.Windows.Forms.Button btnDeleteR;
        private System.Windows.Forms.Button btbUpdateR;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReminder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpReminder;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximizeToggle;
        private System.Windows.Forms.Button btnExit;
    }
}