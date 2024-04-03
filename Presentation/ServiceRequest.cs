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
using CallCenterProgram;
using System.Runtime.InteropServices;

namespace CallCenterProgram.Presentation
{
    public partial class frmServiceRequest : Form
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
        ServiceRequest serviceReqObj = new ServiceRequest();

        public frmServiceRequest()
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtIncidentID.Text != "")
            {
                dgvIncident.DataSource = serviceReqObj.ViewRequest(int.Parse(txtIncidentID.Text));
            }
            else
            {
                dgvIncident.DataSource = serviceReqObj.ViewRequest();
            }
        }

        private void btnCreateJob_Click(object sender, EventArgs e)
        {
            serviceReqObj.AssignJob(int.Parse(txtCreateJob.Text));
        }

        private void btnReassignJob_Click(object sender, EventArgs e)
        {
            serviceReqObj.ReassignJob(int.Parse(txtReAssaignJob.Text));
        }

        private void btnEscalateJob_Click(object sender, EventArgs e)
        {
            frmIncident incidentForm = new frmIncident();
            incidentForm.Show();
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
