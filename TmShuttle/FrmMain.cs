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
        DateTime currentTime;
        MP3 mp3Player;
        FrmClassGrade frmClassGrade;
        public FrmMain()
        {
            InitializeComponent();
            this.LayoutMdi(MdiLayout.ArrangeIcons);
            this.lbl_SystemCaption.Text = ConfigurationManager.AppSettings["SystemCaption"];
            mp3Player = new MP3();

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
            webBrowser1.Url = new Uri(Environment.CurrentDirectory + @"\clock.swf");
            //webBrowser1.Url = new Uri(@"C:\Users\Administrator\Desktop\10701707zs\makepic.swf");

            frmClassGrade = new FrmClassGrade();
            frmClassGrade.TopLevel = false;
            frmClassGrade.Show();
            frmClassGrade.Parent = kryptonPage4;

        }

        private void tbtn_Mannual_Click(object sender, EventArgs e)
        {
            

            currentTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 21, 44, 37);
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
                mp3Player.play();
            }
            System.Diagnostics.Debug.WriteLine(DateTime.Now);
            if (DateTime.Now.CompareTo(currentTime.AddMinutes(1)) >= 0 && DateTime.Now.CompareTo(currentTime.AddMinutes(1).AddSeconds(5)) <= 0)
            {
                
                mp3Player.StopT();
            }
        }

        private void kryptonNavigator1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (kryptonNavigator1.SelectedIndex == 3)
            {
                frmClassGrade.LoadData();
            }
        }

        //private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    TabControl tcTab = (TabControl)sender;
        //    SolidBrush bru = new SolidBrush(Color.White);
        //    SolidBrush bruFont = new SolidBrush(Color.Red);// 标签字体颜色 
        //    SolidBrush bruTabBg = new SolidBrush(SystemColors.ActiveCaption);// 标签背景颜色 
        //    SolidBrush bruTabBg1 = new SolidBrush(SystemColors.GrayText);// 标签背景颜色 
        //    Pen pen = new Pen(bru);
        //    Font font = new System.Drawing.Font("宋体", 10F, FontStyle.Bold);//设置标签字体样式 

        //    //绘制主控件的背景 
        //    //e.Graphics.FillRectangle(bruTabBg, 0, 0, tcTab.Width, tcTab.Height);

        //    StringFormat sfForamt = new StringFormat();
        //    sfForamt.LineAlignment = StringAlignment.Center;
        //    sfForamt.Alignment = StringAlignment.Center;

        //    if (tcTab.SelectedIndex == e.Index)
        //    {
        //        //绘制标签样式 
        //        //获取标签头的工作区域 
        //        Rectangle recChild = tcTab.GetTabRect(tcTab.SelectedIndex);
        //        //绘制标签头背景颜色 
        //        e.Graphics.FillRectangle(bru, recChild);
        //        //绘制标签头的文字 
        //        e.Graphics.DrawString(tcTab.TabPages[tcTab.SelectedIndex].Text, font, bruFont, recChild, sfForamt);
        //    }
        //    else
        //    {
        //        e.Graphics.DrawString(tcTab.TabPages[e.Index].Text, new Font(new FontFamily("宋体"), 9, FontStyle.Regular), new SolidBrush(Color.Black), e.Bounds, sfForamt);
        //        //e.Graphics.FillRectangle(bruTabBg1, tcTab.GetTabRect(e.Index));
        //    }
        //}

    }


}
