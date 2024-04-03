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
    class Caller : Employee
    {
        private int stationNumber;

        public int StationNumber { get => stationNumber; set => stationNumber = value; }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Display()
        {
            //method for displaying
        }
    }
}
