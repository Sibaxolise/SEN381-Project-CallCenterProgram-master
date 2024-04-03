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
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace CallCenterProgram.Presentation
{
    public partial class Security_Level : Form
    {
        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //fields
        private bool Maximized = false;

        public Security_Level()
        {
            InitializeComponent();
            CreateMyBorderlessWindow();
            Maximized = false;
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

        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        BindingSource bs = new BindingSource();

        private void button3_Click(object sender, EventArgs e)
        {
            HomeForm main = new HomeForm();
            this.Hide();
            main.Show();
        }

        private void Security_Level_Load(object sender, EventArgs e)
        {
            bs.DataSource = dataAccess.GetAllSecurityLevels();
            dgvExistingSecurityLevels.DataSource = bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string desc = txtAddDesc.Text;
            string email = txtAddEmail.Text;
            string phone = txtAddPhone.Text;
            int availability = cmbAdd.Text == "Available" ? 1 : 0;
            SecurityLevel sl = new SecurityLevel();
            sl.AddSecurityLevel(desc, availability, email, phone);
            txtAddDesc.Clear();
            txtAddEmail.Clear();
            txtAddPhone.Clear();
            bs.DataSource = dataAccess.GetAllSecurityLevels();
            bs.ResetBindings(true);
        }

        private void dgvExistingSecurityLevels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUpdateAllID.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtUpdateAllDesc.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtUpdateAllEmail.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtUpdateAllPhone.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                cmbUpdateAll.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "True" ? "Available" : "Not-Available";

                txtIDUpdate1.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                cmbUpdate1.Text = dgvExistingSecurityLevels.Rows[e.RowIndex].Cells[2].FormattedValue.ToString() == "True" ? "Available" : "Not-Available";
            }
        }

        private void btnUpdateSecurityLevel_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtUpdateAllID.Text);
            string desc = txtUpdateAllDesc.Text;
            string email = txtUpdateAllEmail.Text;
            string phone = txtUpdateAllPhone.Text;
            int availability = cmbUpdateAll.Text == "Available" ? 1 : 0;
            SecurityLevel sl = new SecurityLevel();
            sl.UpdateSecurityLevel(ID, desc, email, phone, availability);
            bs.DataSource = dataAccess.GetAllSecurityLevels();
            bs.ResetBindings(true);
        }

        private void btnUpdateAvailability_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtIDUpdate1.Text);
            int availability = cmbUpdate1.Text == "Available" ? 1 : 0;
            SecurityLevel sl = new SecurityLevel();
            sl.UpdateSecurityLevelAvailability(ID, availability);
            bs.DataSource = dataAccess.GetAllSecurityLevels();
            bs.ResetBindings(true);
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnMaximizeToggle_Click(object sender, EventArgs e)
        {
            if (Maximized == false)
            {
                this.WindowState = FormWindowState.Maximized;
                Maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Maximized = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
