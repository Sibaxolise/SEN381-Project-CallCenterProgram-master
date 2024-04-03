using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Data_Access;
using CallCenterProgram;

namespace CallCenterProgram.Bussiness_Logic
{
    class ServiceRequest
    {
        IncidentDataAccess incidentData = new IncidentDataAccess();
        JobDataAccess jobData = new JobDataAccess();
        Employee_DataAccess employeeData = new Employee_DataAccess();

        public void CreateServiceRequest(string reportInfo, DateTime timeIssued, int priority, decimal cost, string[] abilityReq, int clientID, int callEmplpoyeeID)
        {
            incidentData.InsertWorkRequest(reportInfo, timeIssued, priority, cost, abilityReq, clientID, callEmplpoyeeID);
        }

        public void UpdateServiceRequest(int incidentID, string reportInfo, DateTime timeIssued, int priority, decimal cost, string[] abilityReq)
        {
            incidentData.UpdateWorkRequest(incidentID, reportInfo, timeIssued, priority, cost, abilityReq);
        }

        public List<Incident> ViewRequest()
        {
            List<Incident> incidents = incidentData.DisplayIncident();
            return incidents;
        }

        public List<Incident> ViewRequest(int incidentID)
        {
            List<Incident> incidents = incidentData.DisplayIncident(incidentID);
            return incidents;
        }

        public void AssignJob(int incidentID)
        {
            jobData.InsertJob(0, incidentID, getAvailableWorkers(incidentData.DisplayIncident(incidentID)[0].AbilityReq));
        }

        public void ReassignJob(int incidentID)
        {
            List<Job> jobs = jobData.DisplayJob();
            int jobToDelete = 0;

            foreach (Job item in jobs)
            {
                if (item.IncedentID == incidentID)
                {
                    jobToDelete = item.JobID;
                }
            }

            jobData.DeleteJob(jobToDelete);

            AssignJob(incidentID);
        }

        public void EscalateJob(int jobID, int jobStatus, int assignedWorkerID)
        {
            jobData.UpdateJob(jobID, jobStatus, assignedWorkerID);
        }

        private int getAvailableWorkers(string[] abilityReq)
        {
            List<string> employees = employeeData.DisplayEmployeeSkills();

            foreach (string item in employees)
            {
                string[] currentEmployee = item.Split(',');

                if (currentEmployee[1] == abilityReq[0])
                {
                    return int.Parse(currentEmployee[0]);
                }
            }

            return 0;
        }
    }
}