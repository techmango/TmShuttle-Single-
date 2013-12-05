using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace TmShuttle
{
    public partial class FrmRegister : KryptonForm
    {
        public FrmRegister()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string serialNumber = string.Format("{0}-{1}-{2}-{3}-{4}-{5}", txt_serNo1.Text,
                txt_serNo2.Text, txt_serNo3.Text, txt_serNo4.Text, txt_serNo5.Text, txt_serNo6.Text);

            if (RegisterUtility.Register2Computer(txt_MvNum.Text, serialNumber, "Techmango", "TmShuttle") == true)
            {
                MessageBox.Show("注册码成功，欢迎使用！O(∩_∩)O");
                btn_Register.Text = "关闭后继续使用";
            }
            else
            {
                MessageBox.Show("注册码不正确！╮(╯▽╰)╭");
            }
        }

        private void FrmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_Register.Text == "注册")
            {
                Application.Exit();
            }
            else
            {
                this.Hide();
            }
        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {
            txt_MvNum.Text = RegisterUtility.getMvNum();
        }
    }
}
