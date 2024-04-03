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
    public partial class SetReminder : Form
    {

        bool Maximized = false;

        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public SetReminder()
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

        FollowUpBusiness setReminder = new FollowUpBusiness();
        FollowUp Set = new FollowUp();
        
        private void SetReminder_Load(object sender, EventArgs e)
        {
            dataGridVReminder.DataSource = setReminder.ViewSetReminder();
            if (Set.ReminderDate == DateTime.Now)
            {
                MessageBox.Show("Reminder For: " +Set.Reminder);
            }
        }

        private void btnExitReminder_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFollowUpReminder_Click(object sender, EventArgs e)
        {
            FollowUp_Presentation FollowUpForm = new FollowUp_Presentation();
            FollowUpForm.Show();
            this.Close();
        }

        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            Set.ReminderId = Convert.ToInt32(txtReminderId.Text);
            Set.Reminder = txtReminder.Text;
            Set.ReminderDate = dtpReminder.Value;

            setReminder.InsertReminder(int.Parse(txtReminderId.Text), txtReminder.Text, dtpReminder.Value);
        }

        private void btbUpdateR_Click(object sender, EventArgs e)
        {
            Set.ReminderId = Convert.ToInt32(txtReminderId.Text);
            Set.Reminder = txtReminder.Text;
            Set.ReminderDate = dtpReminder.Value;

            setReminder.UpdateReminder(int.Parse(txtReminderId.Text), txtReminder.Text, dtpReminder.Value);
        }

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            Set.ReminderId = Convert.ToInt32(txtReminderId.Text);
            Set.Reminder = txtReminder.Text;
            Set.ReminderDate = dtpReminder.Value;

            setReminder.RemoveReminder(int.Parse(txtReminderId.Text), txtReminder.Text, dtpReminder.Value);
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
