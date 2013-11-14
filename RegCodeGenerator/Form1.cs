using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace RegCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //txt_MvNum.Text = TmShuttle.RegisterUtility.getMvNum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(!string.IsNullOrEmpty(txt_MvNum.Text.Trim()))
                {
                    txt_SerialNumber.Text = TmShuttle.RegisterUtility.getSerialNum(txt_MvNum.Text.Trim());
                }
                else
                {
                    MessageBox.Show("请输入机器码");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
