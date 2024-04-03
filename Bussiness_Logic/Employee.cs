using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Presentation;
using CallCenterProgram;

namespace CallCenterProgram.Bussiness_Logic
{

    public abstract class Employee
    {
        private int employeeId;
        private string name;
        private string surname;
        private string address;
        private string contactDetails;
        private string jobTitle;
        private string jobDescription;
        private int departmentId;
        private string derptmentName;
        private int stationNumber;
       

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Address { get => address; set => address = value; }
        public string ContactDetails { get => contactDetails; set => contactDetails = value; }
        public string Jobtitle { get => jobTitle; set => jobTitle = value; }
        public string JobDescription { get => jobDescription; set => jobDescription = value; }
        public int DepartmentId { get => departmentId; set => departmentId = value; }
        public string DepartmentName { get => derptmentName; set => derptmentName = value; }
        public int StationNumber { get => stationNumber; set => stationNumber = value; }
        

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


}