using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CallCenterProgram.Bussiness_Logic;
using System.Runtime.InteropServices;


namespace CallCenterProgram.Presentation
{
    public partial class FollowUp_Presentation : Form
    {
        bool Maximized = false;

        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public FollowUp_Presentation()
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

        FollowUpBusiness followUp = new FollowUpBusiness();
        FollowUp Set = new FollowUp();
        

        public void datagridView_CellClick(object sender, DataGridViewCellEventArgs e) {

            if (dataGridVFollowUp.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridVFollowUp.CurrentRow.Selected = true;

                txtfollowupid.Text = dataGridVFollowUp.Rows[e.RowIndex].Cells["FollowUpId"].FormattedValue.ToString();
                txtstatus.Text = dataGridVFollowUp.Rows[e.RowIndex].Cells["Status"].FormattedValue.ToString();
                
            }
        }
   
        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeForm.instance.Show();

        }

        private void Feedback_Click(object sender, EventArgs e)
        {
            Feedback Feedback = new Feedback();
            Feedback.Show();
            this.Close();
        }

        private void Exits_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            Set.FollowUpId = Convert.ToInt32(txtfollowupid.Text);
            Set.Status = txtstatus.Text;
            Set.FollowUpDate = dtpFollowUp.Value; 

            followUp.AddFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, dtpFollowUp.Value);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Set.FollowUpId = Convert.ToInt32(txtfollowupid.Text);
            Set.Status = txtstatus.Text;
            Set.FollowUpDate = dtpFollowUp.Value;

            followUp.UpdateFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, dtpFollowUp.Value);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Set.FollowUpId = Convert.ToInt32(txtfollowupid.Text);
            Set.Status = txtstatus.Text;
            Set.FollowUpDate = dtpFollowUp.Value;

            followUp.RemoveFollowUp(int.Parse(txtfollowupid.Text), txtstatus.Text, dtpFollowUp.Value);
        }

        private void FollowUp_Load(object sender, EventArgs e)
        {
            dataGridVFollowUp.DataSource = followUp.ViewFollowUps();

        }

        private void btnSetReminder_Click(object sender, EventArgs e)
        {
            SetReminder reminder = new SetReminder();
            reminder.Show();
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

        
    }
}
