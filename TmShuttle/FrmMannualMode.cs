using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ComponentFactory.Krypton.Toolkit;

using System.IO.Ports;
using System.Threading;  

namespace TmShuttle
{
    public partial class FrmMannualMode : Form
    {
        [DllImport("ASeries.dll")]
        public static extern bool SerialOpen(uint portnr, uint baud, uint parity, uint databits, uint stopbit);

        [DllImport("ASeries.dll")]
        public static extern bool SerialClose();

        [DllImport("ASeries.dll")]
        public static extern uint SerialSend(byte[] data, uint datalen);

        [DllImport("ASeries.dll")]
        public static extern uint SerialRecv(byte[] data, uint datalen);

        [DllImport("ASeries.dll")]
        public static extern bool SerialSetReadTimeOut(uint dwMilliSecond);

        [DllImport("ASeries.dll")]
        public static extern bool Write_A101_RelayBit(byte addr, byte relaybit, byte state);

        [DllImport("ASeries.dll")]
        public static extern bool Write_A101_RelayAll(byte addr, byte state);

        [DllImport("ASeries.dll")]
        public static extern UInt32 Read_A101_RelayAll(byte addr);

        byte addr = 1;
        uint serialnum = 0;
        uint baud = 0;
        KryptonCheckButton callerButton;
        DAL.ClassesDAL dal;

        public FrmMannualMode()
        {
            InitializeComponent();
            dal = new DAL.ClassesDAL();
            readConfigs();

            setText2Buttons();
           
        }

        private void setText2Buttons()
        {
            DataTable dt = new TmShuttle.DAL.ClassesDAL().GetList("").Tables[0];
            foreach (Control checkButton in pl_ButtonGroup.Controls)
            {
                if (checkButton is KryptonCheckButton)
                {
                    KryptonCheckButton thisButton = checkButton as KryptonCheckButton;
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["relay_id"].ToString() == thisButton.TabIndex.ToString())
                        {
                            thisButton.Text = dr["class_name"].ToString();
                            break;
                        }
                    }
                }
            }
        }

        private void readConfigs()
        {
            addr = GlobaConfigInstance.Instance.Addr;
            serialnum = GlobaConfigInstance.Instance.SerialNum;
            baud = GlobaConfigInstance.Instance.Baud;
        }

        private void MannualMode_Load(object sender, EventArgs e)
        {
            openSerial();
            readState();
        }

        private void openSerial()
        {
            try
            {

                bool state;
                state = SerialOpen(serialnum, baud, 0, 8, 0);
                if (state == false)
                {
                    MessageBox.Show("打开失败！");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("打开失败！");
                return;
            }
        }

        private void click2Check(object sender)
        {
            KryptonCheckButton checkButton = (KryptonCheckButton)sender;
            byte port = (byte)checkButton.TabIndex;
            if (checkButton.Tag.ToString() == "断开")
            {
                Write_A101_RelayBit(addr, port, 1);//打开单路继电器

                byte[] recbuf = new byte[255];

                SerialSetReadTimeOut(1000);//设置读超时为1秒
                if (SerialRecv(recbuf, 8) == 0)//如果读取8个字节返回字节数为0
                {
                    MessageBox.Show("读取失败！");
                    return;
                }
                else
                {
                    if (recbuf[0] == addr)//如果第一个字节为当前地址号
                    {
                        checkButton.Tag = "闭合";
                        checkButton.Checked = true;
                    }
                }
            }
            else
            {
                Write_A101_RelayBit(addr, port, 0);//关闭单路继电器
                byte[] recbuf = new byte[255];

                SerialSetReadTimeOut(1000);//设置读超时为1秒
                if (SerialRecv(recbuf, 8) == 0)//如果读取8个字节返回字节数为0
                {
                    MessageBox.Show("读取失败！");
                    return;
                }
                else
                {
                    if (recbuf[0] == addr)//如果第一个字节为当前地址号
                    {
                        checkButton.Tag = "断开";
                        checkButton.Checked = false;
                    }
                }
            }
            autoCheckByClickState();
        }

        private void btnRelay_Click(object sender, EventArgs e)
        {
            click2Check(sender);
        }

        private void btnOpenAll_Click(object sender, EventArgs e)
        {
            Write_A101_RelayAll(addr, 1);//闭合所有继电器

            byte[] recbuf = new byte[8];

            SerialSetReadTimeOut(1000);//设置读超时为1秒
            if (SerialRecv(recbuf, 8) == 0)//如果读取8个字节返回字节数为0
            {
                MessageBox.Show("读取失败！");
                return;
            }
            else
            {
                if (recbuf[0] == addr)//如果第一个字节为当前地址号
                {
                    foreach (Control checkButton in pl_ButtonGroup.Controls)
                    {
                        if (checkButton is KryptonCheckButton)
                        {
                            ((KryptonCheckButton)checkButton).Checked = true;
                        }
                    }
                }
            }

        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            Write_A101_RelayAll(addr, 0);//断开所有继电器

            byte[] recbuf = new byte[8];

            SerialSetReadTimeOut(1000);//设置读超时为1秒
            if (SerialRecv(recbuf, 8) == 0)//如果读取8个字节返回字节数为0
            {
                MessageBox.Show("读取失败！");
                return;
            }
            else
            {
                if (recbuf[0] == addr)//如果第一个字节为当前地址号
                {
                    foreach (Control checkButton in pl_ButtonGroup.Controls)
                    {
                        if (checkButton is KryptonCheckButton)
                        {
                            ((KryptonCheckButton)checkButton).Checked = false;
                        }
                    }
                    
                }
            }
        }


        private UInt32 GetRegBit(UInt32 Reg, byte Mask)//取寄存器某位状态
        {
            return (Reg >> Mask) & 0x01;
        }

        private void readState()
        {
            UInt32 RelayState = 0;
            RelayState = Read_A101_RelayAll(addr);
            if (RelayState != 0xffffffff)//读取成功
            {
                int countCheck = 0, countUnCheck = 0;
                foreach (Control checkButton in pl_ButtonGroup.Controls)
                {
                    if (checkButton is KryptonCheckButton)
                    {
                        KryptonCheckButton currentButton = (KryptonCheckButton)checkButton;
                        byte mask = (byte)checkButton.TabIndex;
                        if (GetRegBit(RelayState, mask) == 1)
                        {
                            currentButton.Checked = true;
                            currentButton.Tag = "闭合";
                            countCheck++;
                        }
                        else
                        {
                            currentButton.Checked = false;
                            currentButton.Tag = "断开";
                            countUnCheck++;
                        }
                       
                    }
                }
                if (countCheck == 16)
                {
                    btnOpenAll.Checked = true;
                }
                if (countUnCheck == 16)
                {
                    btnCloseAll.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("读取失败！");
                return;
            }
        }

        /// <summary>
        /// 根据统计按钮列表的checked个数，自动设置“闭合所有”或“断开所有”的checked
        /// </summary>
        void autoCheckByClickState()
        {
            int countCheck = 0, countUnCheck = 0;
            foreach (Control checkButton in pl_ButtonGroup.Controls)
            {
                if (checkButton is KryptonCheckButton)
                {
                    KryptonCheckButton currentButton = (KryptonCheckButton)checkButton;
                    if (currentButton.Checked == true)
                    {
                        countCheck++;
                    }
                    else
                    {
                        countUnCheck++;
                    }
                }
            }
            if (countCheck == 16)
            {
                btnOpenAll.Checked = true;
            }
            else
            {
                btnOpenAll.Checked = false;
            }
            if (countUnCheck == 16)
            {
                btnCloseAll.Checked = true;
            }
            else
            {
                btnCloseAll.Checked = false;
            }
        }

        private void kryptonContextMenu1_Opening(object sender, CancelEventArgs e)
        {
            callerButton = (sender as KryptonContextMenu).Caller as KryptonCheckButton;
        }

        private void kryptonContextMenuItem1_Click(object sender, EventArgs e)
        {
           // Model.Classes class = dal.get
            string inputClassName = KryptonInputBox.Show("请输入新的名称");
            dal.UpdateByRelayId(inputClassName, callerButton.TabIndex.ToString());
            this.setText2Buttons();
        }
    }




}
