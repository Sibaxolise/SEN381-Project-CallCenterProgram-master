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
    class Technicians : Employee
    {
        private string abilities;
        private string qualification;


        public string Abilities { get => abilities; set => abilities = value; }
        public string Qualification { get => qualification; set => qualification = value; }


        public override string ToString()
        {
            return base.ToString();
        }

        Employee_DataAccess EmployeeData = new Employee_DataAccess();

        public void DeleteTechnicians(string abilities, string qualification)
        {
            EmployeeData.DeleteTechnicians(abilities, qualification);

        }

        public void InsertTechnicians(string abilities, string qualification)
        {
            EmployeeData.InsertTechnicians(abilities, qualification);

        }

        public void UpdateTechnicians(string abilities, string qualification)
        {
            EmployeeData.UpdateTechnicians(abilities, qualification);

        }
    }
}
