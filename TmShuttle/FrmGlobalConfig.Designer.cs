﻿namespace TmShuttle
{
    partial class FrmGlobalConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.lbl_HelpInfo = new System.Windows.Forms.Label();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label60 = new System.Windows.Forms.Label();
            this.lblSerialNum = new System.Windows.Forms.Label();
            this.cboSerialNum = new System.Windows.Forms.ComboBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.label93 = new System.Windows.Forms.Label();
            this.cboPresentAddr = new System.Windows.Forms.ComboBox();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox2);
            this.kryptonPanel1.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabOneNote;
            this.kryptonPanel1.Size = new System.Drawing.Size(686, 465);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(12, 171);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.lbl_HelpInfo);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(632, 221);
            this.kryptonGroupBox2.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox2.TabIndex = 1;
            this.kryptonGroupBox2.Values.Heading = "帮助";
            // 
            // lbl_HelpInfo
            // 
            this.lbl_HelpInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HelpInfo.Location = new System.Drawing.Point(15, 18);
            this.lbl_HelpInfo.Name = "lbl_HelpInfo";
            this.lbl_HelpInfo.Size = new System.Drawing.Size(591, 163);
            this.lbl_HelpInfo.TabIndex = 0;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonButton2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label60);
            this.kryptonGroupBox1.Panel.Controls.Add(this.lblSerialNum);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cboSerialNum);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cboBaudrate);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label93);
            this.kryptonGroupBox1.Panel.Controls.Add(this.cboPresentAddr);
            this.kryptonGroupBox1.Panel.Controls.Add(this.btnOpenSerial);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(632, 153);
            this.kryptonGroupBox1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonGroupBox1.TabIndex = 0;
            this.kryptonGroupBox1.Values.Heading = "有线设置";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(109, 97);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(90, 25);
            this.kryptonButton2.TabIndex = 34;
            this.kryptonButton2.Values.Text = "保存配置";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Location = new System.Drawing.Point(13, 65);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(53, 12);
            this.label60.TabIndex = 32;
            this.label60.Text = "波特率：";
            // 
            // lblSerialNum
            // 
            this.lblSerialNum.AutoSize = true;
            this.lblSerialNum.BackColor = System.Drawing.Color.Transparent;
            this.lblSerialNum.Location = new System.Drawing.Point(13, 39);
            this.lblSerialNum.Name = "lblSerialNum";
            this.lblSerialNum.Size = new System.Drawing.Size(53, 12);
            this.lblSerialNum.TabIndex = 31;
            this.lblSerialNum.Text = "串口号：";
            // 
            // cboSerialNum
            // 
            this.cboSerialNum.BackColor = System.Drawing.SystemColors.Window;
            this.cboSerialNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSerialNum.FormattingEnabled = true;
            this.cboSerialNum.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20",
            "COM21",
            "COM22"});
            this.cboSerialNum.Location = new System.Drawing.Point(109, 36);
            this.cboSerialNum.Name = "cboSerialNum";
            this.cboSerialNum.Size = new System.Drawing.Size(121, 20);
            this.cboSerialNum.TabIndex = 27;
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.BackColor = System.Drawing.SystemColors.Window;
            this.cboBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "256000"});
            this.cboBaudrate.Location = new System.Drawing.Point(109, 62);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(121, 20);
            this.cboBaudrate.TabIndex = 30;
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.BackColor = System.Drawing.Color.Transparent;
            this.label93.Location = new System.Drawing.Point(13, 11);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(89, 12);
            this.label93.TabIndex = 29;
            this.label93.Text = "设备当前地址：";
            // 
            // cboPresentAddr
            // 
            this.cboPresentAddr.BackColor = System.Drawing.SystemColors.Window;
            this.cboPresentAddr.FormattingEnabled = true;
            this.cboPresentAddr.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cboPresentAddr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32"});
            this.cboPresentAddr.Location = new System.Drawing.Point(109, 8);
            this.cboPresentAddr.Name = "cboPresentAddr";
            this.cboPresentAddr.Size = new System.Drawing.Size(69, 20);
            this.cboPresentAddr.TabIndex = 28;
            this.cboPresentAddr.Text = "1";
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.Location = new System.Drawing.Point(245, 60);
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSerial.TabIndex = 26;
            this.btnOpenSerial.Text = "打开串口";
            this.btnOpenSerial.UseVisualStyleBackColor = true;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // FrmGlobalConfig
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(686, 465);
            this.Controls.Add(this.kryptonPanel1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGlobalConfig";
            this.Text = "GlobalConfig";
            this.Load += new System.EventHandler(this.GlobalConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label lblSerialNum;
        private System.Windows.Forms.ComboBox cboSerialNum;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.ComboBox cboPresentAddr;
        private System.Windows.Forms.Button btnOpenSerial;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.Label lbl_HelpInfo;
    }
}