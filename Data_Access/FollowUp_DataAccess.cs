using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using CallCenterProgram.Bussiness_Logic;

namespace CallCenterProgram.Data_Access
{
    class FollowUp_DataAccess
    { //Set Connection String
        string connect = "Data Source =.; Initial Catalog = CallCenterDatabase; Integrated Security = SSPI";
        SqlConnection Conn;
        SqlCommand Command;
        SqlDataReader Reader;

        //object
        FollowUp objFollowUp = new FollowUp();

        #region Insert Data
        public void InsertFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            string query = @"INSERT INTO FollowUp VALUES('" + followUpId + "','" + status + "', '" + followUpDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Follow up inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Follow up is not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }


        public void InsertFeedback(int feedbackId, string problem, bool helpedOnTime, string comment, DateTime feedbackDate)
        {
            string query = @"INSERT INTO Feedback VALUES('" + feedbackId + "','" + problem + "','" + helpedOnTime + "','" + comment + "', '" + feedbackDate + ")";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Feedback inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Feedback up is not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        public void InsertSetReminder(int reminderId, string reminder, DateTime reminderDate)
        {
            string query = @"INSERT INTO Reminder VALUES('" + reminderId + "','" + reminder + "','" + reminderDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Reminder inserted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is and error, Reminder is not added!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }
        #endregion

        #region Update Data
        public void UpdateFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            string query = @"UPDATE INTO FollowUp VALUES('" + followUpId + "','" + status + "', '" + followUpDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Follow up updated!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Follow up is not updated!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        public void UpdateSetReminder(int reminderId, string reminder, DateTime reminderDate)
        {
            string query = @"UPDATE INTO Reminder VALUES('" + reminderId + "','" + reminder + "','" + reminderDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.ExecuteNonQuery();
                MessageBox.Show("Reminder Updated!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is and error, Reminder is not updated!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        #endregion

        #region Delete Data
        public void DeleteFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            string query = @"DELETE INTO FollowUp VALUES('" + followUpId + "','" + status + "', '" + followUpDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Follow up deleted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("Follow up is not deleted!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        public void DeleteSetReminder(int reminderId, string reminder, DateTime reminderDate)
        {
            string query = @"DELETE INTO Reminder VALUES('" + reminderId + "','" + reminder + "','" + reminderDate + "')";
            Conn = new SqlConnection(connect);
            Conn.Open();
            Command = new SqlCommand(query, Conn);

            try
            {
                Command.BeginExecuteNonQuery();
                MessageBox.Show("Reminder Deleted!");
            }
            catch (Exception e)
            {

                MessageBox.Show("There is and error, Reminder is not deleted!" + e.Message);
            }

            finally
            {
                Conn.Close();
            }
        }

        #endregion

        #region DisplayData
        public List<FollowUp> DisplayFollowUps()
        {
            string query = @"SELECT FollowUpID, ClientID, Status, FollowUpDate FROM FollowUp "; 

            Conn = new SqlConnection(connect);

            Conn.Open();

            Command = new SqlCommand(query, Conn);
            List<FollowUp> FollowUpData = new List<FollowUp>();

            try
            {
                Reader = Command.ExecuteReader();

                while(Reader.Read())
                {
                    objFollowUp.FollowUpId = int.Parse(Reader[0].ToString());
                    objFollowUp.Status = Reader[2].ToString();
                    objFollowUp.FollowUpDate = DateTime.Parse(Reader[3].ToString());


                    FollowUpData.Add(new FollowUp(objFollowUp.FollowUpId, objFollowUp.Status, objFollowUp.FollowUpDate));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            return FollowUpData;
        }

        public List<FollowUp> DisplayFeedbacks()
        {
            string query = @"SELECT FeedbackID, ClientID, HelpedOnTime, Problem, Comment, FeedbackDate FROM Feedback";

            Conn = new SqlConnection(connect);

            Conn.Open();

            Command = new SqlCommand(query, Conn);
            List<FollowUp> FeedbackData = new List<FollowUp>();

            try
            {
                Reader = Command.ExecuteReader();

                while(Reader.Read())
                {
                    objFollowUp.FeedbackId = int.Parse(Reader[0].ToString());
                    objFollowUp.HelpedOnTime = bool.Parse(Reader[2].ToString());
                    objFollowUp.Problem = Reader[3].ToString();
                    objFollowUp.Comment = Reader[4].ToString();
                    objFollowUp.FeedbackDate = DateTime.Parse(Reader[5].ToString());


                    FeedbackData.Add(new FollowUp(objFollowUp.FeedbackId, objFollowUp.Problem, objFollowUp.HelpedOnTime, objFollowUp.Comment, objFollowUp.FeedbackDate));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            return FeedbackData;
        }

        public List<FollowUp> DisplayReminder()
        {
            string query = @"SELECT ReminderId, Reminder, ReminderDate FROM  Reminder"; 

            Conn = new SqlConnection(connect);

            Conn.Open();

            Command = new SqlCommand(query, Conn);
            List<FollowUp> ReminderData = new List<FollowUp>();

            try
            {
                Reader = Command.ExecuteReader();

                while(Reader.Read())
                {
                    objFollowUp.ReminderId = int.Parse(Reader[0].ToString());
                    objFollowUp.Reminder = Reader[1].ToString();
                    objFollowUp.ReminderDate = DateTime.Parse(Reader[2].ToString());


                    ReminderData.Add(new FollowUp(objFollowUp.FeedbackId, objFollowUp.Problem, objFollowUp.HelpedOnTime, objFollowUp.Comment, objFollowUp.FeedbackDate));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Details could not be found: " + ex.Message);
            }
            finally
            {
                Conn.Close();
            }

            return ReminderData;
        }

        #endregion

    }
}
