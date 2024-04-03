using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;

namespace CallCenterProgram.Bussiness_Logic
{
    class FollowUpBusiness
    {
        FollowUp_DataAccess FollowUpData = new FollowUp_DataAccess();
        FollowUp PopUp = new FollowUp();

        public void InsertReminder(int reminderId, string reminder, DateTime reminderDate)
        {

            FollowUpData.InsertSetReminder(reminderId, reminder, reminderDate);
        }
        public void UpdateReminder(int reminderId, string reminder, DateTime reminderDate)
        {

            FollowUpData.UpdateSetReminder(reminderId, reminder, reminderDate);
        }

        public void RemoveReminder(int reminderId, string reminder, DateTime reminderDate)
        {

            FollowUpData.DeleteSetReminder(reminderId, reminder, reminderDate);
        }



        public void AddFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            FollowUpData.InsertFollowUp(followUpId, status, followUpDate);

        }

        public void UpdateFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            FollowUpData.UpdateFollowUp(followUpId, status, followUpDate);

        }

        public void RemoveFollowUp(int followUpId, string status, DateTime followUpDate)
        {
            FollowUpData.DeleteFollowUp(followUpId, status, followUpDate);

        }

        public void AddFeedback(int feedbackId, string problem, bool helpedOnTime, string comment, DateTime feedbackDate)
        {
            FollowUpData.InsertFeedback(feedbackId, problem, helpedOnTime, comment, feedbackDate);

        }

        public List<FollowUp> ViewFollowUps()
        {
            List<FollowUp> followUps = FollowUpData.DisplayFollowUps();
            return followUps;
        }

        public List<FollowUp> ViewFeedback()
        {
            List<FollowUp> followUps = FollowUpData.DisplayFeedbacks();
            return followUps;
        }

        public List<FollowUp> ViewSetReminder()
        {
            List<FollowUp> setReminder = FollowUpData.DisplayReminder();
            return setReminder;

        }

      
    }
}
