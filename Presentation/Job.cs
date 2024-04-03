using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Bussiness_Logic;
using CallCenterProgram.Data_Access;
using CallCenterProgram;
using System.Runtime.InteropServices;

namespace CallCenterProgram.Presentation
{
    public partial class job : Form
    {
        bool Maximized = false;

        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Objects
        JobBussinessLogic jobObj = new JobBussinessLogic();

        public job()
        {
            InitializeComponent();
            Maximized = false;
            CreateMyBorderlessWindow();
        }

        public void CreateMyBorderlessWindow()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area.
            this.ControlBox = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtJobID.Text != "")
            {
                jobObj.CloseJob(int.Parse(txtJobID.Text));
            }
            else
            {
                MessageBox.Show("Please enter the jobs ID!", "Wrong Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtWorkerID.Text != "")
            {
                dgvIncident.DataSource = jobObj.ViewJob(int.Parse(txtWorkerID.Text));
            }
            else
            {
                dgvIncident.DataSource = jobObj.ViewJob();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm.instance.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizeToggle_Click(object sender, EventArgs e)
        {
            if (Maximized == false)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaximizeToggle.Text = "Normal";
                Maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                btnMaximizeToggle.Text = "Maximize";
                Maximized = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            //go to home form
            HomeForm.instance.Show();
            this.Close();
        }
    }
}
