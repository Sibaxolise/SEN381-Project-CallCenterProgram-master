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
using CallCenterProgram.Data_Access;
using CallCenterProgram;
using System.Runtime.InteropServices;

namespace CallCenterProgram.Presentation
{
    public partial class Manager_Presentation : Form
    {
        bool Maximized = false;
        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Manager_Presentation()
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

        ManagerBusiness manager = new ManagerBusiness();
        Employee Set = new Manager();
        Authorization authorize = new Authorization();
        public void datagridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridVEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridVEmployee.CurrentRow.Selected = true;

                txtEmployeeId.Text= dataGridVEmployee.Rows[e.RowIndex].Cells["EmployeeId"].FormattedValue.ToString();
                txtEmployeename.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                txtEmployeesurname.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["Surname"].FormattedValue.ToString();
                txtEmployeeAddress.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                txtContactDetails.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["ContactDetails"].FormattedValue.ToString();
                txtMjobtitle.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["JobTitle"].FormattedValue.ToString();
                txtMjobDespription.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["JobDescription"].FormattedValue.ToString();
                txtidDepartment.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["DepartmentId"].FormattedValue.ToString();
                txtNameDepartment.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["DepartmentName"].FormattedValue.ToString();
                txtSationNo.Text = dataGridVEmployee.Rows[e.RowIndex].Cells["StationNumber"].FormattedValue.ToString();
            }
        }


        private void UpdateEm_Click(object sender, EventArgs e)
        {
            
            Set.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
            Set.Name = txtEmployeename.Text;
            Set.Surname = txtEmployeesurname.Text;
            Set.Address = txtEmployeeAddress.Text;
            Set.ContactDetails = txtContactDetails.Text;
            Set.Jobtitle = txtMjobtitle.Text;
            Set.JobDescription = txtMjobDespription.Text;

            
            authorize.Show();

            try
            {
                if (manager.Authorize == "M145628")
                {
                    manager.UpdateEmployeeInf(int.Parse(txtEmployeeId.Text), txtEmployeename.Text, txtEmployeesurname.Text, txtEmployeeAddress.Text, txtContactDetails.Text, txtMjobtitle.Text, txtMjobDespription.Text);
                }
                else
                {
                    throw new Exception();
                }

            }
             catch(Exception ex)
            {
                MessageBox.Show(ex + "Invalid Pin!!");
            }

        }

        private void DeleteEm_Click(object sender, EventArgs e)
        {
            Set.EmployeeId = Convert.ToInt32(txtEmployeeId.Text);
            Set.Name = txtEmployeename.Text;
            Set.Surname = txtEmployeesurname.Text;
            Set.Address = txtEmployeeAddress.Text;
            Set.ContactDetails = txtContactDetails.Text;
            Set.Jobtitle = txtMjobtitle.Text;
            Set.JobDescription = txtMjobDespription.Text;

           

            try
            {
                authorize.Show();

                if (manager.Authorize == "M145628")
                {
                    manager.FireEmployee(int.Parse(txtEmployeeId.Text), txtEmployeename.Text, txtEmployeesurname.Text, txtEmployeeAddress.Text, txtContactDetails.Text, txtMjobtitle.Text, txtMjobDespription.Text);

                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Invalid Pin!!");
            }
        }

        private void UpdateDp_Click(object sender, EventArgs e)
        {
            Set.DepartmentId = Convert.ToInt32(txtidDepartment.Text);
            Set.DepartmentName = txtNameDepartment.Text;
            Set.StationNumber = Convert.ToInt32(txtSationNo.Text);

            

            try
            {
                authorize.Show();

                if (manager.Authorize == "M145628")
                {
                    manager.UpdateDepartment(int.Parse(txtidDepartment.Text), txtNameDepartment.Text, int.Parse(txtSationNo.Text));
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Invalid Pin!!");
            }
           
        }

        private void DeleteDp_Click(object sender, EventArgs e)
        {
            Set.DepartmentId = Convert.ToInt32(txtidDepartment.Text);
            Set.DepartmentName = txtNameDepartment.Text;
            Set.StationNumber = Convert.ToInt32(txtSationNo.Text);

            

            try
            {
                authorize.Show();

                if (manager.Authorize == "M145628")
                {
                    manager.RemoveDepartment(int.Parse(txtidDepartment.Text), txtNameDepartment.Text, int.Parse(txtSationNo.Text));
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Invalid Pin!!");
            }
            
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            HomeForm.instance.Show();
            this.Close();
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            Employee_Presentation EmployeeForm = new Employee_Presentation();
            EmployeeForm.Show();
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            dataGridVEmployee.DataSource = manager.ViewEmployee();

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
