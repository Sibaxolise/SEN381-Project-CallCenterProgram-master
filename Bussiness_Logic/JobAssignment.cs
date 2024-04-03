using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Data_Access;

namespace CallCenterProgram.Bussiness_Logic
{
    class JobAssignment
    {
        public void RunJobAssigner()
        {
            Thread jobAssigner = new Thread(new ThreadStart(JobAssigner));
            jobAssigner.Start();
        }

        static void JobAssigner()
        {
            bool assignJobs = true;           

            JobDataAccess jobData = new JobDataAccess();
            IncidentDataAccess incidentData = new IncidentDataAccess();
            Employee_DataAccess employeeData = new Employee_DataAccess();

            List<Incident> unassignedIncidents = new List<Incident>();

            while (assignJobs)
            {
                //MessageBox.Show("Now running this thing!");
                List<Job> jobs = jobData.DisplayJob();
                List<Incident> incidents = incidentData.DisplayIncident();
                List<int> availableWorkers = new List<int>();
                string skills = string.Empty;

                // Get what incidents are unassigned
                for (int i = 0; i < incidents.Count; i++)
                {
                    bool assign = true;

                    for (int j = 0; j < jobs.Count; j++)
                    {
                        if (incidents[i].IncidentID == jobs[j].IncedentID)
                        {
                            assign = false;
                        }
                    }

                    if (assign)
                    {
                        if (unassignedIncidents.Count == 0)
                        {
                            unassignedIncidents.Add(incidents[i]);
                        }
                        else
                        {
                            foreach (Incident item in unassignedIncidents)
                            {
                                bool add = true;

                                if (incidents[i].IncidentID == item.IncidentID)
                                {
                                    add = false;
                                }

                                if (add)
                                {
                                    unassignedIncidents.Add(incidents[i]);
                                }
                            }
                        }
                        //MessageBox.Show(unassignedIncidents.Count.ToString());
                    }
                }

                // Get workers available on the day the incident is scheduled
                if (unassignedIncidents.Count != 0)
                {
                    // Loop through all unassigned incidents
                    for (int i = 0; i < unassignedIncidents.Count; i++)
                    {
                        // Loop through all jobs for each incident
                        for (int j = 0; j < jobs.Count; j++)
                        {
                            // Index of current jobs incident in the incident list
                            int incidentIndex = 0;

                            // Loop through each incident for the job
                            for (int k = 0; k < incidents.Count; k++)
                            {
                                // if the incident id of the job and incident matches then that is the jobs incident
                                if (jobs[j].IncedentID == incidents[k].IncidentID)
                                {
                                    // MessageBox.Show("Found index: " + incidents[k].IncidentID.ToString());
                                    // Saves index
                                    incidentIndex = k;
                                }
                            }

                            // Uses the saved index to match the unassigned incidents time with the incidents time
                            if (unassignedIncidents[i].TimeIssued.Date != incidents[incidentIndex].TimeIssued.Date || jobs[j].JobStatus)
                            {
                                // If it matches it saves the worker that is available on that day
                                skills = incidents[incidentIndex].AbilityReq[0];
                                //MessageBox.Show("Found skills: " + skills);
                                availableWorkers.Add(jobs[j].WorkerID);
                            }
                        }

                        bool assigned = false;

                        foreach (int employeeID in availableWorkers)
                        {
                            //MessageBox.Show(employeeID.ToString());

                            if (skills == employeeData.DisplayEmployeeSkills(employeeID) && !assigned)
                            {
                                //MessageBox.Show("Inserting job");
                                //MessageBox.Show(skills);
                                jobData.InsertJob(0, unassignedIncidents[i].IncidentID, employeeID);
                                unassignedIncidents.Remove(unassignedIncidents[i]);
                                skills = string.Empty;
                                assigned = true;
                            }
                        }
                    }    
                }

                Thread.Sleep(10000);
            }
        }
    }
}
