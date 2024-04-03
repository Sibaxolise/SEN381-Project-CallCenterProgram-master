namespace CallCenterProgram.Presentation
{
    partial class frmServiceRequest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtIncidentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvIncident = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateJob = new System.Windows.Forms.Button();
            this.btnReassignJob = new System.Windows.Forms.Button();
            this.txtCreateJob = new System.Windows.Forms.TextBox();
            this.txtReAssaignJob = new System.Windows.Forms.TextBox();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.Incidents = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximizeToggle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncident)).BeginInit();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtIncidentID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvIncident);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(36, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 303);
            this.panel1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnSearch.Location = new System.Drawing.Point(649, 273);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtIncidentID
            // 
            this.txtIncidentID.Location = new System.Drawing.Point(525, 275);
            this.txtIncidentID.Name = "txtIncidentID";
            this.txtIncidentID.Size = new System.Drawing.Size(118, 20);
            this.txtIncidentID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.label2.Location = new System.Drawing.Point(402, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incident ID:";
            // 
            // dgvIncident
            // 
            this.dgvIncident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncident.Location = new System.Drawing.Point(19, 41);
            this.dgvIncident.Name = "dgvIncident";
            this.dgvIncident.Size = new System.Drawing.Size(705, 228);
            this.dgvIncident.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "View";
            // 
            // btnCreateJob
            // 
            this.btnCreateJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnCreateJob.Location = new System.Drawing.Point(36, 405);
            this.btnCreateJob.Name = "btnCreateJob";
            this.btnCreateJob.Size = new System.Drawing.Size(200, 23);
            this.btnCreateJob.TabIndex = 7;
            this.btnCreateJob.Text = "Create Job";
            this.btnCreateJob.UseVisualStyleBackColor = true;
            this.btnCreateJob.Click += new System.EventHandler(this.btnCreateJob_Click);
            // 
            // btnReassignJob
            // 
            this.btnReassignJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReassignJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.btnReassignJob.Location = new System.Drawing.Point(579, 405);
            this.btnReassignJob.Name = "btnReassignJob";
            this.btnReassignJob.Size = new System.Drawing.Size(200, 23);
            this.btnReassignJob.TabIndex = 9;
            this.btnReassignJob.Text = "Re-Assign Job";
            this.btnReassignJob.UseVisualStyleBackColor = true;
            this.btnReassignJob.Click += new System.EventHandler(this.btnReassignJob_Click);
            // 
            // txtCreateJob
            // 
            this.txtCreateJob.Location = new System.Drawing.Point(36, 379);
            this.txtCreateJob.Name = "txtCreateJob";
            this.txtCreateJob.Size = new System.Drawing.Size(200, 20);
            this.txtCreateJob.TabIndex = 7;
            // 
            // txtReAssaignJob
            // 
            this.txtReAssaignJob.Location = new System.Drawing.Point(579, 379);
            this.txtReAssaignJob.Name = "txtReAssaignJob";
            this.txtReAssaignJob.Size = new System.Drawing.Size(200, 20);
            this.txtReAssaignJob.TabIndex = 19;
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
            this.pnlTitleBar.TabIndex = 21;
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
            this.btnHome.TabIndex = 7;
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
            this.Incidents.Location = new System.Drawing.Point(130, 0);
            this.Incidents.Name = "Incidents";
            this.Incidents.Size = new System.Drawing.Size(362, 58);
            this.Incidents.TabIndex = 5;
            this.Incidents.Text = "Service Request";
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
            // frmServiceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.txtReAssaignJob);
            this.Controls.Add(this.txtCreateJob);
            this.Controls.Add(this.btnReassignJob);
            this.Controls.Add(this.btnCreateJob);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmServiceRequest";
            this.Text = "Service Request";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncident)).EndInit();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtIncidentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvIncident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateJob;
        private System.Windows.Forms.Button btnReassignJob;
        private System.Windows.Forms.TextBox txtCreateJob;
        private System.Windows.Forms.TextBox txtReAssaignJob;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label Incidents;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximizeToggle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHome;
    }
}