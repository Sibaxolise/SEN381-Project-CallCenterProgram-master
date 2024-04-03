using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;
using CallCenterProgram;


namespace CallCenterProgram.Bussiness_Logic
{
    class ManagerBusiness
    {
        private string authorize;

        public string Authorize { get => authorize; set => authorize = value; }

        Employee_DataAccess EmployeeData = new Employee_DataAccess();
        public void FireEmployee(int employeeId, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            EmployeeData.DeleteEmployee(employeeId, name, surname, address, contactDetails, jobTitle, jobDescription);

        }

        public void UpdateEmployeeInf(int employeeId, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            EmployeeData.UpdateEmployee(employeeId, name, surname, address, contactDetails, jobTitle, jobDescription);
        }


        public void RemoveDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.DeleteDepartment(departmentId, derptmentName, stationNumber);

        }

        public void UpdateDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.UpdateDepartment(departmentId, derptmentName, stationNumber);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public List<Manager> ViewEmployee()
        {
            List<Manager> Employees = EmployeeData.DisplayEmployee();
            return Employees;
        }



        public void AddEmployee(int employeeId, string name, string surname, string address, string contactDetails, string jobTitle, string jobDescription)
        {
            EmployeeData.InsertEmployee(employeeId, name, surname, address, contactDetails, jobTitle, jobDescription);

        }

        public void AddDepartment(int departmentId, string derptmentName, int stationNumber)
        {
            EmployeeData.InsertDepartment(departmentId, derptmentName, stationNumber);

        }

        public void MakeAuthorizarion(string authorize)
        {
            authorize = "M145628";
        }
    }
}
