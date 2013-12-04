using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TmShuttle
{
    public partial class FrmGlobalConfig : Form
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

        public FrmGlobalConfig()
        {
            InitializeComponent();
            if(!string.IsNullOrEmpty(IniConfig.ReadValue("SerialNum")))
            {
                cboSerialNum.SelectedIndex = int.Parse(IniConfig.ReadValue("SerialNum")) - 1;
            }
            if (!string.IsNullOrEmpty(IniConfig.ReadValue("Baud")))
            {
                cboBaudrate.Text= IniConfig.ReadValue("Baud");
            }
            if (!string.IsNullOrEmpty(IniConfig.ReadValue("Addr")))
            {
                cboPresentAddr.Text = IniConfig.ReadValue("Addr");
            }

            cboSerialNum.SelectedIndex = (int)(GlobaConfigInstance.Instance.SerialNum - 1);
            cboBaudrate.Text = GlobaConfigInstance.Instance.Baud.ToString();
            cboPresentAddr.Text = GlobaConfigInstance.Instance.Addr.ToString();
        }

        private void btnOpenSerial_Click(object sender, EventArgs e)
        {
            if (btnOpenSerial.Text == "打开串口")
            {
                try
                {
                    bool state;
                    uint serialnum = Convert.ToUInt32(cboSerialNum.SelectedIndex + 1);
                   
                    uint baud = Convert.ToUInt32(cboBaudrate.Text);
                   
                    state = SerialOpen(serialnum, baud, 0, 8, 0);
                    if (state == false)
                    {
                        MessageBox.Show("打开失败！");
                        return;
                    }
                    else
                    {
                        //成功后写入配置文件
                        GlobaConfigInstance.Instance.Addr = byte.Parse(cboPresentAddr.SelectedItem.ToString());
                        GlobaConfigInstance.Instance.SerialNum = serialnum;
                        GlobaConfigInstance.Instance.Baud = baud;
                        btnOpenSerial.Text = "关闭串口";
                    }
                }
                catch
                {
                    MessageBox.Show("打开失败！");
                    return;
                }
            }
            else if (btnOpenSerial.Text == "关闭串口")
            {
                try
                {
                    bool state;

                    state = SerialClose();
                    if (state == false)
                    {
                        MessageBox.Show("关闭失败！");
                        return;
                    }
                    else
                    {
                        btnOpenSerial.Text = "打开串口";
                    }
                }
                catch
                {
                    MessageBox.Show("关闭失败！");
                    return;
                }
            }
        }

        private void GlobalConfig_Load(object sender, EventArgs e)
        {
            lbl_HelpInfo.Text = System.Configuration.ConfigurationManager.AppSettings["HelpInfo"];
        }
    }
}
