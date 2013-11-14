using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Threading;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;


namespace TmShuttle
{
    public partial class FrmMain : KryptonForm
    {
        DateTime firstRunTime;
        //MP3 mp3Player;
        FrmClassGrade frmClassGrade;
        public FrmMain()
        {
            InitializeComponent();
            this.LayoutMdi(MdiLayout.ArrangeIcons);
            this.lbl_SystemCaption.Text = ConfigurationManager.AppSettings["SystemCaption"]; //RegisterUtility.getSerialNum(RegisterUtility.getMvNum());// 
            //mp3Player = new MP3();

            FrmMannualMode mannual = new FrmMannualMode();
            mannual.TopLevel = false;
            mannual.Show();
            mannual.WindowState = FormWindowState.Maximized;
            mannual.Parent = kryptonPage1;

            FrmAutoMode autoMode = new FrmAutoMode();
            autoMode.TopLevel = false;
            autoMode.Show();
            autoMode.Parent = kryptonPage2;

            FrmGlobalConfig globalConfig = new FrmGlobalConfig();
            globalConfig.TopLevel = false;
            globalConfig.Show();
            globalConfig.Parent = kryptonPage3;

            frmClassGrade = new FrmClassGrade();
            frmClassGrade.TopLevel = false;
            frmClassGrade.Show();
            frmClassGrade.Parent = kryptonPage4;

            lbl_Time.Text = DateTime.Now.ToString("HH:mm:ss");
            timer_Clock.Start();
        }

        private string getTime()
        {
            string TimeInString = "";
            int hour = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;

            TimeInString = (hour < 10) ? "0" + hour.ToString() : hour.ToString();
            TimeInString += ":" + ((min < 10) ? "0" + min.ToString() : min.ToString());
            TimeInString += ":" + ((sec < 10) ? "0" + sec.ToString() : sec.ToString());
            return TimeInString;
        }

        private void tbtn_Mannual_Click(object sender, EventArgs e)
        {
            //timer_BgMusic.Start();
        }

        private void btn_AutoMode_Click(object sender, EventArgs e)
        {
            //service.Stop();
        }

        private void timer_BgMusic_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour == 21 && DateTime.Now.Minute == 44 && DateTime.Now.Second == 37)
            {
                //mp3Player.play();
            }
            System.Diagnostics.Debug.WriteLine(DateTime.Now);
            if (DateTime.Now.CompareTo(firstRunTime.AddMinutes(1)) >= 0 && DateTime.Now.CompareTo(firstRunTime.AddMinutes(1).AddSeconds(5)) <= 0)
            {
                
                //mp3Player.StopT();
            }
        }

        private void kryptonNavigator1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (kryptonNavigator1.SelectedIndex == 3)
            {
                frmClassGrade.LoadData();
            }
        }

        private void timer_Clock_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = getTime();
            if ((DateTime.Now - firstRunTime).Seconds == 3)
            {
                if (RegisterUtility.CheckRegister("Techmango", "TmShuttle", IniConfig.ReadValue("SerialNumber")) == false)
                {
                    new FrmRegister().ShowDialog();
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            firstRunTime = DateTime.Now;
        }

        
    }


}
