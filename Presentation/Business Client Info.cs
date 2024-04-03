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
using CallCenterProgram;
using CallCenterProgram.Presentation;
using System.Runtime.InteropServices;

namespace CallCenterProgram.Presentation
{
    public partial class Business_Client_Info : Form
    {
        BindingSource source = new BindingSource();

        bool Maximized = false;

        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Business_Client_Info()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Business_Client_Info_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(26, 26, 26);
            ForeColor = Color.FromArgb(102, 112, 233);
            panel3.Enabled = false;
            panel3.Visible = false;
            txtID.Enabled = false;
        }

        private void btnViewIndividualClients_Click(object sender, EventArgs e)
        {
            Individual_Client_Info individualform = new Individual_Client_Info();
            individualform.Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Client_Home homeform = new Client_Home();
            homeform.Show();
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Insert_Business_Client client = new Insert_Business_Client();
            client.Show();
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BusinessClient client = new BusinessClient();
            source.DataSource = client.GetCustomTable();
            dgvBusinessClients.DataSource = source;
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

        private void Business_Client_Info_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvBusinessClients.Rows[dgvBusinessClients.CurrentRow.Index].Cells["ClientID"].Value;
            DialogResult result = MessageBox.Show("Are you sure you want to delete Client " + ID, "Delete Client", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                BusinessClient client = new BusinessClient();
                client.DeleteBusinessClient(ID);
                MessageBox.Show("Client " + ID + " was deleted");
            }
            else
            {
                MessageBox.Show("Client was not deleted");
            }

            BusinessClient client1 = new BusinessClient();
            source.DataSource = client1.GetCustomTable();
            dgvBusinessClients.DataSource = source;
        }

        private void btnUpdateConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text);
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
                client.UpdateBusinessClient(client);

                source.DataSource = client.GetCustomTable();
                dgvBusinessClients.DataSource = source;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not update " + ex.Message);
            }
            finally
            {
                panel3.Enabled = false;
                panel3.Visible = false;
            }

            
        }

        private void dgvBusinessClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvBusinessClients_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvBusinessClients.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dgvBusinessClients.CurrentRow.Cells[1].Value.ToString();
                txtSurname.Text = dgvBusinessClients.CurrentRow.Cells[2].Value.ToString();
                txtRole.Text = dgvBusinessClients.CurrentRow.Cells[3].Value.ToString();
                rtbStatus.Text = dgvBusinessClients.CurrentRow.Cells[4].Value.ToString();
                nudStreetNumber.Value = Convert.ToInt32(dgvBusinessClients.CurrentRow.Cells[5].Value);
                txtStreetName.Text = dgvBusinessClients.CurrentRow.Cells[6].Value.ToString();
                txtCity.Text = dgvBusinessClients.CurrentRow.Cells[7].Value.ToString();
                lstCountries.Text = dgvBusinessClients.CurrentRow.Cells[8].Value.ToString();
                txtEmail.Text = dgvBusinessClients.CurrentRow.Cells[9].Value.ToString();
                txtCellphone.Text = dgvBusinessClients.CurrentRow.Cells[10].Value.ToString();
            }
            catch(Exception es)
            {
                MessageBox.Show("Click inside the DGV " + es.Message);
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            panel3.Enabled = true;
            panel3.Visible = true;

            BusinessClient client = new BusinessClient();
            source.DataSource = client.GetCustomTable();
            dgvBusinessClients.DataSource = source;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            panel3.Visible = false;
        }
    }
}
