using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Bussiness_Logic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CallCenterProgram.Presentation
{
    public partial class Insert_Business_Client : Form
    {

        bool Maximized = false;

        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Insert_Business_Client()
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

        private void txtBack_Click(object sender, EventArgs e)
        {
            Client_Home client = new Client_Home();
            client.Show();
            this.Hide();
        }

        private void btnInsertClient_Click(object sender, EventArgs e)
        {
            //assign values to variables

            try
            {
                int id = Convert.ToInt32(nudID.Value);
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string email = txtEmail.Text;
                string cellphone = txtCellphone.Text;
                if (cellphone == "")
                {
                    cellphone = "Unknown";
                }

                string status = rtbStatus.Text;
                if (status == "")
                {
                    status = "Unknown";
                }
                string role = txtRole.Text;
                if (role == "")
                {
                    role = "Unknown";
                }

                int streetnumber = Convert.ToInt32(nudStreetNumber.Value);

                string streetname = txtStreetName.Text;
                if (streetname == "")
                {
                    streetname = "Unknown";
                }

                string city = txtCity.Text;
                if (city == "")
                {
                    city = "Unknown";
                }

                string country;
                if (lstCountries.SelectedItem == null)
                {
                    country = "Unknown";
                }
                else
                {
                    country = lstCountries.SelectedItem.ToString();
                }

                BusinessClient client = new BusinessClient(id, name, surname, status, role, email, cellphone, streetnumber, streetname, city, country);
                client.SendClientToDataAccess(client);
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an error with one of your values: " + ex.Message);
            }
            finally
            {
                Business_Client_Info client_Info = new Business_Client_Info();
                client_Info.Show();
                this.Close();
            }
        }

        private void Insert_Business_Client_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);

            nudID.Value = 0;
            nudStreetNumber.Value = 0;
            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtCellphone.Clear();
            txtStreetName.Clear();
            txtCity.Clear();
            lstCountries.ClearSelected();
            rtbStatus.Clear();
            txtRole.Clear();
            nudID.Focus();

            btnInsertClient.Enabled = false;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (Maximized == false)
            {
                this.WindowState = FormWindowState.Maximized;
                //btnMax.Text = "Normal";
                Maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                //btnMax.Text = "Maximize";
                Maximized = false;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Insert_Business_Client_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void nudID_ValueChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        public void CheckForm()
        {
            if (nudID != null && txtName.Text != "" && txtSurname.Text != "" && txtEmail.Text != "")
            {
                btnInsertClient.Enabled = true;                
            }
            else
            {
                btnInsertClient.Enabled = false;
            }
        }

        private void Insert_Business_Client_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            CheckForm();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            CheckForm();
        }
    }
}
