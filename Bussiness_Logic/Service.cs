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
    class Service
    {
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        private string serviceName;
        private int serviceId;
        private string workExpenses;
        private string equipmentType;
        private bool state;

        public Service()
        {
        }

        public Service(string serviceName, int serviceId, string workExpenses, string equipmentType, bool state)
        {
            this.serviceName = serviceName;
            this.serviceId = serviceId;
            this.workExpenses = workExpenses;
            this.equipmentType = equipmentType;
            this.state = state;
        }

        public string ServiceName { get => serviceName; set => serviceName = value; }
        public int ServiceId { get => serviceId; set => serviceId = value; }
        public string WorkExpenses { get => workExpenses; set => workExpenses = value; }
        public string EquipmentType { get => equipmentType; set => equipmentType = value; }
        public bool State { get => state; set => state = value; }

        public void AddService(string name, string equipmentType, string workExpenses, int state)
        {
            dataAccess.InsertService(name, equipmentType, workExpenses, state);
        }

        public void UpdateService(int serviceID, string name, string equipmentType, string workExpenses, int state)
        {
            dataAccess.UpdateService(serviceID, name, equipmentType, workExpenses, state);   
        }

        public void UpdateServiceState(int serviceID, int newState)
        {
            dataAccess.UpdateService(serviceID, newState);
        }
    }
}
