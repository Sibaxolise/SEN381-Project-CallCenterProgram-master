using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallCenterProgram.Data_Access;
using CallCenterProgram.Presentation;

namespace CallCenterProgram.Bussiness_Logic
{
    class FollowUp : Call
    {
        private int followUpId;
        private int feedbackId;
        private string status;
        private DateTime followUpDate;
        private string problem;
        private bool helpedOnTime;
        private string comment;
        private DateTime feedbackDate;
        private int reminderId;
        private string reminder;
        private DateTime reminderDate;


        public int FollowUpId { get => followUpId; set => followUpId = value; }
        public int FeedbackId { get => feedbackId; set => feedbackId = value; }
        public string Status { get => status; set => status = value; }
        public DateTime FollowUpDate { get => followUpDate; set => followUpDate = value; }
        public string Problem { get => problem; set => problem = value; }
        public bool HelpedOnTime { get => helpedOnTime; set => helpedOnTime = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime FeedbackDate { get => feedbackDate; set => feedbackDate = value; }
        internal int ReminderId { get => reminderId; set => reminderId = value; }
        internal string Reminder { get => reminder; set => reminder = value; }
        internal DateTime ReminderDate { get => reminderDate; set => reminderDate = value; }

        public FollowUp()
        {

        }



        public FollowUp(int followUpId, string status, DateTime followUpDate)
        {
            this.followUpId = followUpId;
            this.status = status;
            this.followUpDate = followUpDate;
        }

        public FollowUp(int feedbackId, string problem, bool helpedOnTime, string comment, DateTime feedbackDate)
        {
            this.feedbackId = feedbackId;
            this.problem = problem;
            this.helpedOnTime = helpedOnTime;
            this.comment = comment;
            this.feedbackDate = feedbackDate;

        }
    }
}
