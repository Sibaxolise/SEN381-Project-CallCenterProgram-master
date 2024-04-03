
namespace CallCenterProgram.Presentation
{
    partial class Client_Home
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
            this.btnViewBusinessClients = new System.Windows.Forms.Button();
            this.btnViewIndividualClients = new System.Windows.Forms.Button();
            this.btnMain = new System.Windows.Forms.Button();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnViewBusinessClients
            // 
            this.btnViewBusinessClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBusinessClients.Location = new System.Drawing.Point(12, 12);
            this.btnViewBusinessClients.Name = "btnViewBusinessClients";
            this.btnViewBusinessClients.Size = new System.Drawing.Size(150, 43);
            this.btnViewBusinessClients.TabIndex = 0;
            this.btnViewBusinessClients.Text = "View Business Clients";
            this.btnViewBusinessClients.UseVisualStyleBackColor = true;
            this.btnViewBusinessClients.Click += new System.EventHandler(this.btnViewBusinessClients_Click);
            // 
            // btnViewIndividualClients
            // 
            this.btnViewIndividualClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIndividualClients.Location = new System.Drawing.Point(216, 12);
            this.btnViewIndividualClients.Name = "btnViewIndividualClients";
            this.btnViewIndividualClients.Size = new System.Drawing.Size(150, 43);
            this.btnViewIndividualClients.TabIndex = 1;
            this.btnViewIndividualClients.Text = "View Individual Clients";
            this.btnViewIndividualClients.UseVisualStyleBackColor = true;
            this.btnViewIndividualClients.Click += new System.EventHandler(this.btnViewIndividualClients_Click);
            // 
            // btnMain
            // 
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Location = new System.Drawing.Point(12, 73);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(354, 23);
            this.btnMain.TabIndex = 2;
            this.btnMain.Text = "Main Page";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.btnMin);
            this.pnlTitleBar.Controls.Add(this.btnMax);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(641, 50);
            this.pnlTitleBar.TabIndex = 3;
            this.pnlTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseMove);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterminimize;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(470, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(62, 50);
            this.btnMin.TabIndex = 5;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcentermaximize;
            this.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Location = new System.Drawing.Point(532, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(59, 50);
            this.btnMax.TabIndex = 4;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::CallCenterProgram.Properties.Resources.callcenterexit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(591, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnViewBusinessClients);
            this.panel1.Controls.Add(this.btnViewIndividualClients);
            this.panel1.Controls.Add(this.btnMain);
            this.panel1.Location = new System.Drawing.Point(128, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 114);
            this.panel1.TabIndex = 4;
            // 
            // Client_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(641, 224);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Roboto Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(112)))), ((int)(((byte)(233)))));
            this.Name = "Client_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client_Home";
            this.Load += new System.EventHandler(this.Client_Home_Load);
            this.pnlTitleBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewBusinessClients;
        private System.Windows.Forms.Button btnViewIndividualClients;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
    }
}