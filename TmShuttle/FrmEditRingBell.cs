using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace TmShuttle
{
    public partial class FrmEditRingBell : Form
    {
        FrmAutoMode frmAutoMode = null;
        public FrmEditRingBell()
        {
            InitializeComponent();
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confrm_Click(object sender, EventArgs e)
        {
            if (nud_Duaration.Value == 0)
            {
                MessageBox.Show("请输入时长");
                return;
            }
            if (string.IsNullOrEmpty(txt_FilePath.Text))
            {
                MessageBox.Show("请选择一个播放曲目");
                return;
            }

            if (frmAutoMode.DataRowState == DataRowState.Added)
            {
                DataTable dt = frmAutoMode.DataGrid.DataSource as DataTable;
                DataRow newRow = dt.NewRow();
                newRow["Alias"] = txt_MusicName.Text.Trim();
                newRow["RingTime"] = dpk_RingTime.Value;
                newRow["Duaration"] = nud_Duaration.Value;
                newRow["FileName"] = txt_FileName.Text.Trim();
                newRow["FilePath"] = txt_FilePath.Text.Trim();

                int relaySwitchOn = 0;
                foreach (Control control in pl_ButtonGroup.Controls)
                {
                    if (control is KryptonCheckButton)
                    {
                        KryptonCheckButton checkedButton = control as KryptonCheckButton;
                        if (checkedButton.Checked)
                        {
                            relaySwitchOn |= relaySwitchOn * int.Parse(checkedButton.Tag.ToString());
                        }
                    }
                }
                newRow["RelaySwitchOn"] = relaySwitchOn;
                dt.Rows.Add(newRow);
            }
            else if (frmAutoMode.DataRowState == DataRowState.Modified)
            {
                DataRow newRow = (frmAutoMode.DataGrid.CurrentRow.DataBoundItem as DataRowView).Row;
                newRow["Alias"] = txt_MusicName.Text.Trim();
                newRow["RingTime"] = dpk_RingTime.Value;
                newRow["Duaration"] = nud_Duaration.Value;
                newRow["FileName"] = txt_FileName.Text.Trim();
                newRow["FilePath"] = txt_FilePath.Text.Trim();

                int relaySwitchOn = 0;
                foreach (Control control in pl_ButtonGroup.Controls)
                {
                    if (control is KryptonCheckButton)
                    {
                        KryptonCheckButton checkedButton = control as KryptonCheckButton;
                        if (checkedButton.Checked)
                        {
                            relaySwitchOn |= int.Parse(checkedButton.Tag.ToString());
                        }
                    }
                }
                newRow["RelaySwitchOn"] = relaySwitchOn;
            }
            //提交改动
            frmAutoMode.EditRingBellData();
            this.Close();
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_FileName.Text = Path.GetFileName(openFile.FileName);
                txt_FilePath.Text = openFile.FileName;
            }
        }

        private void FrmEditRingBell_Load(object sender, EventArgs e)
        {
            //form加载后从datarow获取数据填充到各个控件中
            frmAutoMode = this.Owner as FrmAutoMode;
            if (frmAutoMode.DataRowState == DataRowState.Modified)
            {
                if (frmAutoMode.DataGrid.CurrentRow != null)
                {
                    DataRowView drv = frmAutoMode.DataGrid.CurrentRow.DataBoundItem as DataRowView;
                    txt_MusicName.Text = drv.Row["Alias"].ToString();
                    dpk_RingTime.Value = DateTime.Parse(drv.Row["RingTime"].ToString());
                    nud_Duaration.Value = decimal.Parse(drv.Row["Duaration"].ToString());
                    txt_FileName.Text = drv.Row["FileName"].ToString();
                    txt_FilePath.Text = drv.Row["FilePath"].ToString();
                    int relaySwitchOn = int.Parse(drv.Row["RelaySwitchOn"].ToString());
                    foreach (Control control in pl_ButtonGroup.Controls)
                    {
                        if (control is KryptonCheckButton)
                        {
                            KryptonCheckButton checkedButton = control as KryptonCheckButton;
                            if ((relaySwitchOn | int.Parse(checkedButton.Tag.ToString())) == relaySwitchOn)
                            {
                                checkedButton.Checked = true;
                            }
                        }
                    }
                }
            }
        }
    }

    public enum RelaySwitchs
    {
        Relay0 = 1,
        Relay1 = 2,
        Relay2 = 4,
        Relay3 = 8,
        Relay4 = 16,
        Relay5 = 32,
        Relay6 = 64,
        Relay7 = 128,
        Relay8 = 256,
        Relay9 = 512,
        Relay10 = 1024,
        Relay11 = 2048,
        Relay12 = 4096,
        Relay13 = 8192,
        Relay14 = 16384,
        Relay15 = 32768
    }
}
