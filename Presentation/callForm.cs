using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallCenterProgram.Bussiness_Logic;
using System.Runtime.InteropServices;

namespace CallCenterProgram.Presentation
{
    public partial class callForm : System.Windows.Forms.Form
    {
        //classes
        Call call = new Call();
        colors RGB = new colors();
        //fields
        bool Maximized = false;
        //DLL stuff
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //constructor
        public callForm()
        {
            InitializeComponent();
            Maximized = false;
            CreateMyBorderlessWindow();
        }
        //methods
        //styling methods
        private void colorButtons()
        {
            //btn Insert Into DB
            btnInsertIntoDB.ForeColor = RGB.accentColorLighterColor;
            btnInsertIntoDB.FlatAppearance.MouseDownBackColor = RGB.accentDarkerColor;
            //btn home
            btnHome.ForeColor = RGB.accentColor;
            btnHome.FlatAppearance.BorderColor = RGB.accentColorLighterColor;
            btnHome.FlatAppearance.MouseDownBackColor = RGB.accentDarkerColor;
            //btn make call
            btnMakeCall.FlatAppearance.MouseDownBackColor = RGB.green;
            btnMakeCall.FlatAppearance.MouseOverBackColor = RGB.hoverGreen;
            //btn take call
            btnTakeCall.FlatAppearance.MouseDownBackColor = RGB.green;
            btnTakeCall.FlatAppearance.MouseOverBackColor = RGB.hoverGreen;
            //btn end call
            btnEndCall.FlatAppearance.MouseDownBackColor = RGB.red;
            btnEndCall.FlatAppearance.MouseOverBackColor = RGB.hoverRed;
            //btn find client info
            btnFindClientInfo.ForeColor = RGB.accentColor;
            btnFindClientInfo.FlatAppearance.MouseDownBackColor = RGB.accentDarkerColor;
            btnFindClientInfo.FlatAppearance.MouseOverBackColor = RGB.hoverAccent;

        }

        private void colorPanels()
        {
            pnlReports.BackColor = RGB.bgLighterColor;
            pnlClientInfo.BackColor = RGB.bgLighterColor;
            pnlTitleBar.BackColor = RGB.bgDarkerColor;
            pnlRightSide.BackColor = RGB.bgDarkerColor;
            pnlRightBottom.BackColor = RGB.bgLighterColor;
        }

        private void colorLabels()
        {
            //header labels
            lblTitle.ForeColor = RGB.accentColor;
            lblReports.ForeColor = RGB.accentColor;
            lblClientInfo.ForeColor = RGB.accentColor;

            //labels
            lblFaultReport.ForeColor = RGB.grey;
            lblCallReport.ForeColor = RGB.grey;
            lblProblemInfo.ForeColor = RGB.grey;
            lblWorkRequest.ForeColor = RGB.grey;
            lblClientCallHistory.ForeColor = RGB.grey;
            lblAgreements.ForeColor = RGB.grey;
            lblClientNumber.ForeColor = RGB.grey;
        }

        private void colorReportRichTextBoxs()
        {
            colorRichTextBox(rtxtCallReport);
            colorRichTextBox(rtxtFaultReport);
            colorRichTextBox(rtxtProblemInfo);
            colorRichTextBox(rtxtWorkRequest);
        }

        private void colorRichTextBox(RichTextBox rtb)
        {
            rtb.BackColor = RGB.bgColor;
            rtb.ForeColor = RGB.grey;
        }

        private void colorTextbox()
        {
            numClientID.BackColor = RGB.bgColor;
            numClientID.ForeColor = RGB.grey;
        }

        public void CreateMyBorderlessWindow()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            // Remove the control box so the form will only display client area.
            this.ControlBox = false;
        }

        //logic methods
        private void setValues()
        {
            //set call values
            call.CallReport = rtxtCallReport.Text;
            call.ProblemInfo = rtxtProblemInfo.Text;
            call.WorkRequest = rtxtWorkRequest.Text;
            call.FaultReport = rtxtFaultReport.Text;
        }

        //form components
        private void call_Load(object sender, EventArgs e)
        {
            this.BackColor = RGB.bgColor;
            colorButtons();
            colorPanels();
            colorLabels();
            colorTextbox();
            colorReportRichTextBoxs();
        }

        private void btnTakeCall_Click(object sender, EventArgs e)
        {
            call.createInitialTimestamp();
            MessageBox.Show("Call Started");
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            call.createInitialTimestamp();
            MessageBox.Show("Call Started");
        }

        private void btnEndCall_Click(object sender, EventArgs e)
        {
            call.createFinalTimestamp();
            MessageBox.Show("Call ended");
        }

        private void btnInsertIntoDB_Click(object sender, EventArgs e)
        {
            call.CallReport = rtxtCallReport.Text;
            call.WorkRequest = rtxtWorkRequest.Text;
            call.FaultReport = rtxtFaultReport.Text;
            call.ProblemInfo = rtxtProblemInfo.Text;
            try
            {
                call.InsertCallIntoDB((int) numClientID.Value);
            }
            catch (Exception er)
            {
                MessageBox.Show("could not find client id due to error: " + er.Message);
            }
            
        }

        private void btnFindClientInfo_Click(object sender, EventArgs e)
        {
            try
            {
                //find clients info based on client ID
                call.ClientID = (int) numClientID.Value;
                List<Call> callHistory = call.GetCallHistoryFromDB();
                List<Bussiness_Logic.Contract> contractList = call.getAllClientAgreements();

                //display the information in the data grid views
                dgvCallHistory.DataSource = callHistory;
                dgvAgreements.DataSource = contractList;

            }
            catch (Exception er)
            {
                MessageBox.Show("could not find client id due to error: " + er.Message);
            }
            
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //go to home form
            HomeForm.instance.Show();
            this.Close();
        }

        private void btnSetStationNumber_Click(object sender, EventArgs e)
        {
            try
            {
                call.StationNumber = (int)numStationNumber.Value;
            }
            catch (Exception er)
            {
                MessageBox.Show("Could not set station number due to error: " + er.Message);
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizeToggle_Click(object sender, EventArgs e)
        {
            if (Maximized == false)
            {
                this.WindowState = FormWindowState.Maximized;
                Maximized = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Maximized = false;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
