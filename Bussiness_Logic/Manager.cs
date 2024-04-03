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
    class Manager : Employee
    {
        
        public Manager()
        {
        }


        public Manager(int employeeId, string name, string surname, string address, string contactDetails, string jobtitle, string jobDescription, int departmentId)
        { 
            EmployeeId = employeeId;
            Name = name;
            Surname = surname;
            Address = address;
            ContactDetails = contactDetails;
            Jobtitle = jobtitle;
            JobDescription = jobDescription;
            DepartmentId = departmentId;
            //DepartmentName = departmentName;
            //StationNumber = stationNumber;
        }
    }
    }
