using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;

namespace CallCenterProgram.Bussiness_Logic
{
    class JobBussinessLogic
    {
        JobDataAccess jobData = new JobDataAccess();

        public List<Job> ViewJob()
        {
            List<Job> jobs = jobData.DisplayJob();
            return jobs;
        }

        public List<Job> ViewJob(int jobID)
        {
            List<Job> jobs = jobData.DisplayJob(jobID);
            return jobs;
        }

        public void CloseJob(int jobID)
        {
            jobData.CloseJob(jobID);
        }
    }
}