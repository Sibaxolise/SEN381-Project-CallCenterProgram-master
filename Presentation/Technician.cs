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
using System.Runtime.InteropServices;


namespace CallCenterProgram.Presentation
{
    public partial class Technician : Form
    {
        bool Maximized = false;

        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Technician()
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

        Technicians technicians = new Technicians();

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee_Presentation employee = new Employee_Presentation();
            employee.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            HomeForm.instance.Show();
            this.Close();
        }

        private void InsertT_Click(object sender, EventArgs e)
        {
            string abilities = txtability.Text;
            string qualification = txtq.Text;

            technicians.InsertTechnicians(txtability.Text, txtq.Text);
        }

        private void UpdateT_Click(object sender, EventArgs e)
        {
            technicians.Abilities = txtability.Text;
            technicians.Qualification = txtq.Text;

            technicians.InsertTechnicians(txtability.Text, txtq.Text);
        }

        private void DeleteT_Click(object sender, EventArgs e)
        {
            technicians.Abilities = txtability.Text;
            technicians.Qualification = txtq.Text;

            technicians.DeleteTechnicians(txtability.Text, txtq.Text);
        }

        private void Technician_Load(object sender, EventArgs e)
        {

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
