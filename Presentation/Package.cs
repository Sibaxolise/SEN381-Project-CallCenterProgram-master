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
    public partial class Package : Form
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
        public Package()
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

        BindingSource bsPackages = new BindingSource();
        BindingSource bsServices = new BindingSource();
        BindingSource bsServiceLevels = new BindingSource();
        BindingSource bsSecurityLevels = new BindingSource();
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();
        }

        private void Package_Load(object sender, EventArgs e)
        {
            bsServices.DataSource = dataAccess.GetAllServices();
            bsServiceLevels.DataSource = dataAccess.GetAllServiceLevels();
            bsSecurityLevels.DataSource = dataAccess.GetAllSecurityLevels();
            bsPackages.DataSource = dataAccess.GetAllPackages();
            dgvServices.DataSource = bsServices;
            dgvServiceLevels.DataSource = bsServiceLevels;
            dgvSecurityLevels.DataSource = bsSecurityLevels;
            dgvPackages.DataSource = bsPackages;
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            string serviceIDs = txtServiceIDs.Text;
            string serviceLevelIds = txtServiceLevelsIDs.Text;
            string name = txtPackageName.Text;
            Bussiness_Logic.Package package = new Bussiness_Logic.Package();
            package.AddPackage(name, serviceIDs, serviceLevelIds);
            txtServiceIDs.Clear();
            txtServiceLevelsIDs.Clear();
            txtPackageName.Clear();
            bsPackages.DataSource = dataAccess.GetAllPackages();
            bsPackages.ResetBindings(true);
        }

        private void dgvPackages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUpdateID.Text = dgvPackages.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                txtUpdateName.Text = dgvPackages.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtUpdateServiceIDs.Text = dgvPackages.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtUPdateServiceLevelIDs.Text = dgvPackages.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            }
        }

        private void btnUpdatePackage_Click(object sender, EventArgs e)
        {
            int packageID = int.Parse(txtUpdateID.Text);
            string serviceIDs = txtUpdateServiceIDs.Text;
            string serviceLevelIDs = txtUPdateServiceLevelIDs.Text;
            string name = txtUpdateName.Text;
            Bussiness_Logic.Package package = new Bussiness_Logic.Package();
            package.UpdatePackage(packageID, name, serviceIDs, serviceLevelIDs);
            bsPackages.DataSource = dataAccess.GetAllPackages();
            bsPackages.ResetBindings(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Presentation.PackagePerformance performance = new PackagePerformance();
            this.Hide();
            performance.Show();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
