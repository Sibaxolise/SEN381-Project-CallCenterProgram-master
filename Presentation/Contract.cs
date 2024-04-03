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
    public partial class Contract : Form
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
        public Contract()
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
        BindingSource bsContracts = new BindingSource();
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();

        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            int packageId = int.Parse(txtPackageID.Text);
            int clientID = int.Parse(txtClientID.Text);
            int state = cmbAdd.Text == "Active" ? 1 : 0;
            Bussiness_Logic.Contract contract = new Bussiness_Logic.Contract();
            contract.CreateContract(packageId,clientID,state);  
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            int searchID = int.Parse(txtSearchContract.Text);
            Bussiness_Logic.Contract contract = new Bussiness_Logic.Contract();
            bsContracts.DataSource = contract.SearchContract(searchID);
            dgvClientContract.DataSource = bsContracts;
        }

        private void Contract_Load(object sender, EventArgs e)
        {
            bsPackages.DataSource = dataAccess.GetAllPackages();
            dgvPackages.DataSource = bsPackages;
        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            int contractID = int.Parse(txtContractID.Text);
            int state = cmbUpdate.Text == "Active" ? 1 : 0;
            Bussiness_Logic.Contract contract = new Bussiness_Logic.Contract();
            contract.UpdateContract(contractID, state);
            int searchID = int.Parse(txtSearchContract.Text);
            bsContracts.DataSource = contract.SearchContract(searchID);
            bsContracts.ResetBindings(true);
        }

        private void dgvClientContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtContractID.Text = dgvClientContract.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cmbUpdate.Text = dgvClientContract.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() == "True" ? "Active" : "Not-Active";

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
