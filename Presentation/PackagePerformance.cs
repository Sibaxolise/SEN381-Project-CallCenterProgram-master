using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallCenterProgram.Presentation
{
    public partial class PackagePerformance : Form
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

        public PackagePerformance()
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

        BindingSource bsBestSellers = new BindingSource();
        BindingSource bsByCity = new BindingSource();
        private void btnBackToPackage_Click(object sender, EventArgs e)
        {
            Presentation.Package package = new Package();
            this.Hide();
            package.Show();
        }

        private void PackagePerformance_Load(object sender, EventArgs e)
        {
            Bussiness_Logic.Package package = new Bussiness_Logic.Package();
            lblTotalPackages.Text =  package.PackagesInLast30Days().ToString();
            bsBestSellers.DataSource = package.BestPackageOrPackagesOfTheMonth();
            dgvBestPackageOfTheMonth.DataSource = bsBestSellers;
            lblBestNumbersSold.Text = package.MostSoldPackageQuantity().ToString();
        }

        private void btnSearchPackage_Click(object sender, EventArgs e)
        {
            dgvPackageByCity.Rows.Clear();
            int packageID = int.Parse(txtSearchPackage.Text);
            Bussiness_Logic.Package package = new Bussiness_Logic.Package();
            List<string> data = package.PackagePerfromance(packageID);
            for (int i = 0; i < data.Count; i++)
            {
                string[] saleAndCity = data[i].Split(',');
                dgvPackageByCity.Rows.Add(saleAndCity);
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
