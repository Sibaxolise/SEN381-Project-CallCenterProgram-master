using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CallCenterProgram;
using CallCenterProgram.Presentation;
using CallCenterProgram.Bussiness_Logic;

namespace CallCenterProgram.Data_Access
{
    class JobDataAccess
    {
        //Constuctor
        public JobDataAccess()
        {
        }

        //Set Connection String
        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader readers;

        //Objects
        Job objJob = new Job();

        public void InsertJob(int jobStatus, int incidentRef, int assignedWorkerID)
        {
            string query = @"INSERT INTO Job(IncidentRef, AssignedWorkerID, JobStatus) VALUES ( '" + incidentRef + "', '" + assignedWorkerID + "', '" + jobStatus + "')";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Job Made!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job wasn't made: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateJob(int jobRef, int jobStatus, int assignedWorkerID)
        {
            string query = @"UPDATE Job SET JobStatus = '" + jobStatus + "', AssignedWorkerID = '" + assignedWorkerID + "' WHERE IncidentRef = '" + jobRef + "'";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Job updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job not updated: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void CloseJob(int jobID)
        {
            string query = @"UPDATE Job SET JobStatus = ( '" + true + "' ) WHERE JobRef = ( '" + jobID + "' )";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Job Closed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job wasn't closed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteJob(int jobID)
        {
            string query = @"DELETE FROM Job Where JobRef = ( '" + jobID + "' )";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Job Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Job wasn't closed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void FindAvailableWorkers()
        {
        }

        public List<Job> DisplayJob()
        {
            string query = @"SELECT * FROM Job";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);
            List<Job> jobData = new List<Job>();

            try
            {
                readers = command.ExecuteReader();

                while (readers.Read())
                {
                    objJob.JobID = int.Parse(readers[0].ToString());
                    objJob.WorkerID = int.Parse(readers[2].ToString());
                    objJob.IncedentID = int.Parse(readers[1].ToString());
                    objJob.JobStatus = bool.Parse(readers[3].ToString());

                    jobData.Add(new Job(objJob.JobID, objJob.WorkerID, objJob.JobStatus, objJob.IncedentID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return jobData;
        }

        public List<Job> DisplayJob(int employeeID)
        {
            string query = @"SELECT * FROM Job WHERE AssignedWorkerID = ( '" + employeeID + "' )";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);
            List<Job> jobData = new List<Job>();

            try
            {
                readers = command.ExecuteReader();

                while (readers.Read())
                {
                    objJob.JobID = int.Parse(readers[0].ToString());
                    objJob.WorkerID = int.Parse(readers[2].ToString());
                    objJob.IncedentID = int.Parse(readers[1].ToString());
                    objJob.JobStatus = bool.Parse(readers[3].ToString());

                    jobData.Add(new Job(objJob.JobID ,objJob.WorkerID, objJob.JobStatus, objJob.IncedentID));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return jobData;
        }
    }
}
