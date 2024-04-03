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
    class SecurityLevel
    {
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        // Security Level Table
        private int securityLevelId;
        private string levelDescription;
        private bool availability;
        private string emailSupport;
        private string phoneSupport;


        public int SecurityLevelId { get => securityLevelId; set => securityLevelId = value; }
        public string LevelDescription { get => levelDescription; set => levelDescription = value; }
        public bool Availability { get => availability; set => availability = value; }
        public string EmailSupport { get => emailSupport; set => emailSupport = value; }
        public string PhoneSupport { get => phoneSupport; set => phoneSupport = value; }

        public SecurityLevel()
        {
        }

        public SecurityLevel(int securityLevelId, string levelDescription, bool availability, string emailSupport, string phoneSupport)
        {
            this.securityLevelId = securityLevelId;
            this.levelDescription = levelDescription;
            this.availability = availability;
            this.emailSupport = emailSupport;
            this.phoneSupport = phoneSupport;
        }

        public void AddSecurityLevel(string desc, int availability, string email, string phone)
        {
            dataAccess.InsertSecuriyLevel(desc, availability, email, phone);
        }

        public void UpdateSecurityLevel(int ID, string  desc, string email, string phone, int availability)
        {
            dataAccess.UpdateSecurityLevel(ID, desc, email, phone, availability);
        }

        public void UpdateSecurityLevelAvailability(int ID, int availability)
        {
            dataAccess.UpdateSecurityLevel(ID, availability);
        }
    }
}
