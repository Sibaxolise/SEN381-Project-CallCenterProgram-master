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
using CallCenterProgram.Presentation;

namespace CallCenterProgram
{
    public partial class HomeForm : Form
    {
        //classes
        public static HomeForm instance;
        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //fields
        private bool Maximized = false;

        //constructor
        public HomeForm()
        {
            InitializeComponent();
            instance = this;
            CreateMyBorderlessWindow();
            Maximized = false;
        }

        //methods
        private void showForm(Form form)
        {
            form.Show();
            this.Hide();
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

        //form events
        //call
        private void btnCallForm_Click(object sender, EventArgs e)
        {
            callForm callForm = new callForm();
            showForm(callForm);
        }
        //client
        private void btnClientHome_Click(object sender, EventArgs e)
        {
            Client_Home clienthomeform = new Client_Home();
            showForm(clienthomeform);
        }

        //contract
        private void btnContract_Click(object sender, EventArgs e)
        {
            Contract frmContract = new Contract();
            showForm(frmContract);
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            Package frmPackage = new Package();
            showForm(frmPackage);
        }

        private void btnSecurityLevel_Click(object sender, EventArgs e)
        {
            Security_Level form = new Security_Level();
            showForm(form);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Service form = new Service();
            showForm(form);
        }

        //incident
        private void btnIncident_Click(object sender, EventArgs e)
        {
            frmIncident form = new frmIncident();
            showForm(form);
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            job form = new job();
            showForm(form);
        }

        private void btnServiceRequest_Click(object sender, EventArgs e)
        {
            frmServiceRequest form = new frmServiceRequest();
            showForm(form);
        }

        //follow up
        private void btnFollowUp_Click(object sender, EventArgs e)
        {
            FollowUp_Presentation form = new FollowUp_Presentation();
            showForm(form);
        }

        private void btnEmployeeForm_Click(object sender, EventArgs e)
        {
            Employee_Presentation form = new Employee_Presentation();
            showForm(form);
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Manager_Presentation form = new Manager_Presentation();
            showForm(form);
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Feedback form = new Feedback();
            showForm(form);
        }

        private void btnTechnician_Click(object sender, EventArgs e)
        {
            Technician form = new Technician();
            showForm(form);
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //title Bar buttons
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

        private void btnServiceLevel_Click(object sender, EventArgs e)
        {
            Service_Level service = new Service_Level();
            this.Hide();
            service.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
