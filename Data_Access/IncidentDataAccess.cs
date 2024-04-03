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
    class IncidentDataAccess
    {
        //Constuctor
        public IncidentDataAccess()
        {
        }

        //Set Connection String
        string connect = "Data Source=.; Initial Catalog= CallCenterDatabase; Integrated Security= SSPI";
        SqlConnection conn;
        SqlCommand command;
        SqlDataReader readers;

        //Objects
        Incident objIncident = new Incident();

        public void InsertWorkRequest(string reportInfo, DateTime timeIssued, int priority, decimal cost, string[] abilityReq, int clientID, int callEmplpoyeeID)
        {
            string abilityrequirement = string.Empty;

            for (int i = 0; i < abilityReq.Length; i++)
            {
                abilityrequirement += abilityReq[i];

                if (i != abilityReq.Length - 1)
                {
                    abilityrequirement += ",";
                }
            }

            string query = @"INSERT INTO Incident(ClientID, CallEmployeeID, ReportInfo, TimeIssued, [Priority], Cost, AbilityReq) VALUES ( '" + clientID + "', '" + callEmplpoyeeID + "', '" + reportInfo + "', '" + timeIssued + "', '" + priority + "', '" + cost + "', '" + abilityrequirement + "')";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Work request made!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Work request not made: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateWorkRequest(int incidentID, string reportInfo, DateTime timeIssued, int priority, decimal cost, string[] abilityReq)
        {
            string abilityrequirement = string.Empty;

            for (int i = 0; i < abilityReq.Length; i++)
            {
                abilityrequirement += abilityReq[i];

                if (i != abilityReq.Length - 1)
                {
                    abilityrequirement += ",";
                }
            }

            string query = @"INSERT INTO Incident(ReportInfo, TimeIssued, [Priority], Cost, AbilityReq) VALUES ( '" + reportInfo + "', '" + timeIssued + "', '" + priority + "', '" + cost + "', '" + abilityrequirement + "')";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Work request updated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Work request not updated: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void RemoveServiceRequest(int incidentID)
        {
            string query = @"DELETE FROM Incidnet WHERE JobRef = '" + incidentID + "'";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);

            try
            {
                command.BeginExecuteNonQuery();
                MessageBox.Show("Request Closed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Request wasn't closed: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Incident> DisplayIncident(int incidentID)
        {
            string query = @"SELECT * FROM Incident WHERE incidentRef = ( '" + incidentID + "' )";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);
            List<Incident> incidentData = new List<Incident>();

            try
            {
                readers = command.ExecuteReader();

                while (readers.Read())
                {
                    objIncident.IncidentID = int.Parse(readers[0].ToString());
                    objIncident.ReportInfo = readers[3].ToString();
                    objIncident.TimeIssued = DateTime.Parse(readers[4].ToString());
                    objIncident.Cost = Double.Parse(readers[6].ToString());
                    objIncident.ClientID = int.Parse(readers[1].ToString());
                    objIncident.Priority = int.Parse(readers[5].ToString());
                    objIncident.AbilityReq = readers[7].ToString().Split(',');
                    objIncident.CallWorkerID = int.Parse(readers[2].ToString());

                    incidentData.Add(new Incident(objIncident.IncidentID, objIncident.ReportInfo, objIncident.TimeIssued, objIncident.Cost, objIncident.ClientID, objIncident.Priority, objIncident.AbilityReq, objIncident.CallWorkerID));
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

            return incidentData;
        }

        public List<Incident> DisplayIncident()
        {
            string query = @"SELECT * FROM Incident";

            conn = new SqlConnection(connect);

            conn.Open();

            command = new SqlCommand(query, conn);
            List<Incident> incidentData = new List<Incident>();

            try
            {
                readers = command.ExecuteReader();

                while (readers.Read())
                {
                    objIncident.IncidentID = int.Parse(readers[0].ToString());
                    objIncident.ReportInfo = readers[3].ToString();
                    objIncident.TimeIssued = DateTime.Parse(readers[4].ToString());
                    objIncident.Cost = Double.Parse(readers[6].ToString());
                    objIncident.ClientID = int.Parse(readers[1].ToString());
                    objIncident.Priority = int.Parse(readers[5].ToString());
                    objIncident.AbilityReq = readers[7].ToString().Split(',');
                    objIncident.CallWorkerID = int.Parse(readers[2].ToString());

                    incidentData.Add(new Incident(objIncident.IncidentID, objIncident.ReportInfo, objIncident.TimeIssued, objIncident.Cost, objIncident.ClientID, objIncident.Priority, objIncident.AbilityReq, objIncident.CallWorkerID));
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

            return incidentData;
        }
    }
}