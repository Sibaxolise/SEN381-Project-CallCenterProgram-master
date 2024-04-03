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
    public partial class Service : Form
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

        public Service()
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtUpdateID.Text = dgvServices.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                txtUpdateName.Text = dgvServices.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                txtUpdateExpenses.Text = dgvServices.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                txtUpdateType.Text = dgvServices.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                cmbUpdateAll.Text = dgvServices.Rows[e.RowIndex].Cells[4].FormattedValue.ToString() == "True" ? "Active" : "Not-Active";

                txtUpdate1ID.Text = dgvServices.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                cmbUpdate1.Text = dgvServices.Rows[e.RowIndex].Cells[4].FormattedValue.ToString() == "True" ? "Active" : "Not-Active";
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Hide();
            home.Show();
        }

        private void Service_Load(object sender, EventArgs e)
        {
            bs.DataSource = dataAccess.GetAllServices();
            dgvServices.DataSource = bs;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string equip = txtType.Text;
            string workExpenses = txtExpenses.Text;
            int state = cmbAdd.Text == "Active" ? 1 : 0;
            Bussiness_Logic.Service service = new Bussiness_Logic.Service();
            service.AddService(name, equip, workExpenses, state);
            txtName.Clear();
            txtType.Clear();
            txtExpenses.Clear();
            bs.DataSource = dataAccess.GetAllServices();
            bs.ResetBindings(true);
        }

        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            int serviceId = int.Parse(txtUpdateID.Text);
            string name = txtUpdateName.Text;
            string equip = txtUpdateType.Text;
            string workExpenses = txtUpdateExpenses.Text;
            int state = cmbUpdateAll.Text == "Active" ? 1 : 0;
            Bussiness_Logic.Service service = new Bussiness_Logic.Service();
            service.UpdateService(serviceId, name, equip, workExpenses, state);
            bs.DataSource = dataAccess.GetAllServices();
            bs.ResetBindings(true);
        }

        private void btnUpdateState_Click(object sender, EventArgs e)
        {
            int serviceId = int.Parse(txtUpdate1ID.Text);
            int state = cmbUpdate1.Text == "Active" ? 1 : 0;
            Bussiness_Logic.Service service = new Bussiness_Logic.Service();
            service.UpdateServiceState(serviceId, state);
            bs.DataSource = dataAccess.GetAllServices();
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
