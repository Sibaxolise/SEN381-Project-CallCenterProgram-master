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
    class Contract
    {
        ContractMaintenanceAccess dataAccess = new ContractMaintenanceAccess();
        private bool state;
        private int packageID;
        private int clientID;
        private int contractID;

        public bool State { get => state; set => state = value; }
        public int PackageID { get => packageID; set => packageID = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int ContractID { get => contractID; set => contractID = value; }

        public Contract()
        {
        }

        public Contract(bool state, int packageID, int clientID, int contractID)
        {
            this.state = state;
            this.packageID = packageID;
            this.clientID = clientID;
            this.contractID = contractID;
        }

        public void CreateContract(int contractTypeID, int clientID, int state)
        {
            dataAccess.InsertContract(contractTypeID, clientID, state);
        }
        public void UpdateContract(int contractID, int state)
        {
            dataAccess.UpdateContract(contractID, state);
        }

        public List<Bussiness_Logic.Contract> SearchContract(int clientID)
        {
            List<Bussiness_Logic.Contract> contracts = dataAccess.GetAllContracts(clientID);
            return contracts;
        }
    }
}
