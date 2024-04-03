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
    class ClientFactory
    {
        public static IClient GetClientInstance(int ID)
        {
            switch(ID)
            {
                case 1: return new IndividualClient();
                case 2: return new BusinessClient();
                default: return null;
            }
        }
    }
}
