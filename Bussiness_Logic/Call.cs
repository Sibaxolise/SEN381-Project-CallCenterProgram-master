using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;

namespace CallCenterProgram.Bussiness_Logic
{
    class Call : CallStats
    {
        //classes
        call_DataAccess CallDB = new call_DataAccess();
        ContractMaintenanceAccess contractDB = new ContractMaintenanceAccess();

        //fields
        private DateTime initialTimeStamp;
        private DateTime finalTimeStamp;
        private string callReport;
        private string problemInfo;
        private string workRequest;
        private string faultReport;
        private int stationNumber;
        private int clientID;
        private int callDuration;

        //properties
        public DateTime InitialTimeStamp { get => initialTimeStamp; set => initialTimeStamp = value; }
        public DateTime FinalTimeStamp { get => finalTimeStamp; set => finalTimeStamp = value; }
        public string CallReport { get => callReport; set => callReport = value; }
        public string ProblemInfo { get => problemInfo; set => problemInfo = value; }
        public string WorkRequest { get => workRequest; set => workRequest = value; }
        public string FaultReport { get => faultReport; set => faultReport = value; }
        public int StationNumber { get => stationNumber; set => stationNumber = value; }
        public int ClientID { get => clientID; set => clientID = value; }
        public int CallDuration { get => callDuration; set => callDuration = value; }


        //constructor
        public Call()
        {

        }

        //methods
        public void createInitialTimestamp()
        {
            InitialTimeStamp = CreateTimestamp();
        }
        public void createFinalTimestamp()
        {
            FinalTimeStamp = CreateTimestamp();
        }
        public void CrossReference()
        {
            //ask about this.
            MessageBox.Show("Added call to old system.");
        }
        public int GetCallDuration()
        {
            int timeDiff = 0;

            //Use dateDiff to calculate time difference between final and initial timestamps.
            System.TimeSpan dtDiff = FinalTimeStamp.Subtract(InitialTimeStamp);
            timeDiff = dtDiff.Seconds;

            return timeDiff;
        }
        public DateTime CreateTimestamp()
        {
            DateTime timeStamp = DateTime.Now;
            return timeStamp;
        }
        public void InsertCallIntoDB(int clientID)
        {
            //vars 
            CallDuration = GetCallDuration(); //use RecordCallStats()

            //method
            CallDB.InsertCall(clientID, InitialTimeStamp, FinalTimeStamp, FaultReport, CallReport,ProblemInfo,WorkRequest, CallDuration);
        }

        public List<Call> GetCallHistoryFromDB()
        {
            List<Call> callHistory = CallDB.GetCallHistory(ClientID);
            return callHistory;
        }

        public List<Contract> getAllClientAgreements()
        {
            List<Contract> contractList = contractDB.GetAllContracts(ClientID);
            return contractList;
        }
    }
}
