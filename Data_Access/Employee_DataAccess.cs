using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CallCenterProgram;
using CallCenterProgram.Bussiness_Logic;


namespace CallCenterProgram.Data_Access
{
    class Employee_DataAccess
    {
        //Set Connection String
        string connect = "Data Source =.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection Conn;
        SqlCommand Command;
        SqlDataReader Reader;

        //object
        Employee objEmployee = new Manager();

        //Insering Employee details
        public void InsertEmployee(int employeeID, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            string query = @"INSERT INTO Employee VALUES('" + employeeID + "','" + name + "','" + surname + "', '" + address + "','" + contactDetails + "','" + jobTitle + "','" + jobDescription + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("New Employee inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is an error, Employee is not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //Insering Department details
        public void InsertDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            string query = @"INSERT INTO Department VALUES('" + departmentId + "','" + derptmentName + "', '" + stationNumber + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Department inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Department Details are not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }
        //inserting technicial info
        public void InsertTechnicians(string abilities, string qualification)
        {
            string query = @"INSERT INTO Employee VALUES('" + abilities + "','" + qualification + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Technician info inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is an error,Technician info is not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //Updating Employee details
        public void UpdateEmployee(int employeeID, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescriptiont)
        {
            string query = @"UPDATE INTO Employee VALUES('" + employeeID + "','" + name + "','" + surname + "', '" + address + "','" + contactDetails + "','" + jobTitle + "','" + jobDescriptiont + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Employee details are updated!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Employee details are not updated!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //Updating Department details
        public void UpdateDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            string query = @"UPDATE INTO Department VALUES('" + departmentId + "','" + derptmentName + "', '" + stationNumber + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Department is updated!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Department details are not updated!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //update technian info
        public void UpdateTechnicians(string abilities, string qualification)
        {
            string query = @"UPDATE INTO Employee VALUES('" + abilities + "','" + qualification + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Technician info Updated!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is an error,Technician info is not updated!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //Deleting Employee details
        public void DeleteEmployee(int employeeID, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            string query = @"DELETE INTO Employee VALUES('" + employeeID + "','" + name + "','" + surname + "', '" + address + "','" + contactDetails + "','" + jobTitle + "','" + jobDescription + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("The Employee is Remove From the system!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Employee is not removed!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        //Deleting Derpartment details
        public void DeleteDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            string query = @"DELETE INTO Department VALUES('" + departmentId + "','" + derptmentName + "', '" + stationNumber + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("The Department is Remove From the system!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Department is not removed!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        public string DisplayEmployeeSkills(int employeeID)
        {
            string query = @"SELECT Qualification FROM Employee WHERE EmployeeID = ( '" + employeeID + "' )";

            Conn = new SqlConnection(connect);

            Conn.Open();

            Command = new SqlCommand(query, Conn);
            string qualifications = string.Empty;

            try
            {
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    qualifications = Reader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            return qualifications;
        }

        public List<string> DisplayEmployeeSkills()
        {
            string query = @"SELECT EmployeeID, Qualification FROM Employee";

            Conn = new SqlConnection(connect);

            Conn.Open();

            Command = new SqlCommand(query, Conn);
            List<string> info = new List<string>();

            try
            {
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    string infoStr;
                    infoStr = Reader[0].ToString();
                    infoStr += ',' + Reader[1].ToString();

                    info.Add(infoStr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            return info;
        }
        //delete technician info
        public void DeleteTechnicians(string abilities, string qualification)
        {
            string query = @"DELETE INTO Employee VALUES('" + abilities + "','" + qualification + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Technician info deleted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is an error,Technician info is not deleted!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        public List<Manager> DisplayEmployee()
        {
            string query = @"SELECT * FROM Employee";

            Conn = new SqlConnection(connect);

            Conn.Open();

            Command = new SqlCommand(query, Conn);
            List<Manager> EmployeeData = new List<Manager>();


            try
            {
                Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    objEmployee.EmployeeId = int.Parse(Reader[0].ToString());
                    objEmployee.Name = Reader[2].ToString();
                    objEmployee.Surname = Reader[3].ToString();
                    objEmployee.Address = Reader[4].ToString();
                    objEmployee.ContactDetails = Reader[5].ToString();
                    objEmployee.Jobtitle = Reader[6].ToString();
                    objEmployee.JobDescription = Reader[7].ToString();
                    objEmployee.DepartmentId = int.Parse(Reader[1].ToString());
                    //objEmployee.DepartmentName = Reader[8].ToString();
                    //objEmployee.StationNumber = int.Parse(Reader[9].ToString());

                    EmployeeData.Add(new Manager(objEmployee.EmployeeId, objEmployee.Name, objEmployee.Surname, objEmployee.Address, objEmployee.ContactDetails, objEmployee.Jobtitle, objEmployee.JobDescription, objEmployee.DepartmentId));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            return EmployeeData;
        }
    }
}

