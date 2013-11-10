namespace TmShuttle
{
    partial class FrmEditRingBell
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnRelay15 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay14 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay13 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay12 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay11 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay10 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRelay09 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRelay08 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRelay00 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRelay01 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRelay02 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.txt_MusicName = new System.Windows.Forms.TextBox();
            this.btnRelay03 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.btnRelay04 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.txt_FilePath = new System.Windows.Forms.TextBox();
            this.btnRelay05 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay06 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.dpk_RingTime = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnRelay07 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btn_Confrm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.nud_Duaration = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.btn_OpenFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pl_ButtonGroup = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pl_ButtonGroup)).BeginInit();
            this.pl_ButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            this.openFile.Filter = "MP3文件|*.mp3|WAV文件|*.wav";
            // 
            // btnRelay15
            // 
            this.btnRelay15.Location = new System.Drawing.Point(13, 153);
            this.btnRelay15.Name = "btnRelay15";
            this.btnRelay15.Size = new System.Drawing.Size(100, 29);
            this.btnRelay15.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay15.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay15.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay15.TabIndex = 15;
            this.btnRelay15.Tag = "32768";
            this.btnRelay15.Values.Text = "15";
            // 
            // btnRelay14
            // 
            this.btnRelay14.Location = new System.Drawing.Point(123, 153);
            this.btnRelay14.Name = "btnRelay14";
            this.btnRelay14.Size = new System.Drawing.Size(100, 29);
            this.btnRelay14.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay14.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay14.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay14.TabIndex = 14;
            this.btnRelay14.Tag = "16384";
            this.btnRelay14.Values.Text = "14";
            // 
            // btnRelay13
            // 
            this.btnRelay13.Location = new System.Drawing.Point(233, 153);
            this.btnRelay13.Name = "btnRelay13";
            this.btnRelay13.Size = new System.Drawing.Size(100, 29);
            this.btnRelay13.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay13.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay13.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay13.TabIndex = 13;
            this.btnRelay13.Tag = "8192";
            this.btnRelay13.Values.Text = "13";
            // 
            // btnRelay12
            // 
            this.btnRelay12.Location = new System.Drawing.Point(342, 153);
            this.btnRelay12.Name = "btnRelay12";
            this.btnRelay12.Size = new System.Drawing.Size(100, 29);
            this.btnRelay12.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay12.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay12.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay12.TabIndex = 12;
            this.btnRelay12.Tag = "4096";
            this.btnRelay12.Values.Text = "12";
            // 
            // btnRelay11
            // 
            this.btnRelay11.Location = new System.Drawing.Point(13, 209);
            this.btnRelay11.Name = "btnRelay11";
            this.btnRelay11.Size = new System.Drawing.Size(100, 29);
            this.btnRelay11.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay11.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay11.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay11.TabIndex = 11;
            this.btnRelay11.Tag = "2048";
            this.btnRelay11.Values.Text = "11";
            // 
            // btnRelay10
            // 
            this.btnRelay10.Location = new System.Drawing.Point(123, 209);
            this.btnRelay10.Name = "btnRelay10";
            this.btnRelay10.Size = new System.Drawing.Size(100, 29);
            this.btnRelay10.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay10.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay10.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay10.TabIndex = 10;
            this.btnRelay10.Tag = "1024";
            this.btnRelay10.Values.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // btnRelay09
            // 
            this.btnRelay09.Location = new System.Drawing.Point(233, 209);
            this.btnRelay09.Name = "btnRelay09";
            this.btnRelay09.Size = new System.Drawing.Size(100, 29);
            this.btnRelay09.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay09.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay09.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay09.TabIndex = 9;
            this.btnRelay09.Tag = "512";
            this.btnRelay09.Values.Text = "9";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "打铃时间";
            // 
            // btnRelay08
            // 
            this.btnRelay08.Location = new System.Drawing.Point(342, 209);
            this.btnRelay08.Name = "btnRelay08";
            this.btnRelay08.Size = new System.Drawing.Size(100, 29);
            this.btnRelay08.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay08.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay08.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay08.TabIndex = 8;
            this.btnRelay08.Tag = "256";
            this.btnRelay08.Values.Text = "8";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(243, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "时长（分钟）";
            // 
            // btnRelay00
            // 
            this.btnRelay00.Location = new System.Drawing.Point(13, 263);
            this.btnRelay00.Name = "btnRelay00";
            this.btnRelay00.Size = new System.Drawing.Size(100, 29);
            this.btnRelay00.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay00.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay00.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay00.TabIndex = 0;
            this.btnRelay00.Tag = "1";
            this.btnRelay00.Values.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(16, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "播放曲目名称";
            // 
            // btnRelay01
            // 
            this.btnRelay01.Location = new System.Drawing.Point(123, 263);
            this.btnRelay01.Name = "btnRelay01";
            this.btnRelay01.Size = new System.Drawing.Size(100, 29);
            this.btnRelay01.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay01.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay01.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay01.TabIndex = 1;
            this.btnRelay01.Tag = "2";
            this.btnRelay01.Values.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(16, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "铃声路径";
            // 
            // btnRelay02
            // 
            this.btnRelay02.Location = new System.Drawing.Point(233, 263);
            this.btnRelay02.Name = "btnRelay02";
            this.btnRelay02.Size = new System.Drawing.Size(100, 29);
            this.btnRelay02.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay02.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay02.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay02.TabIndex = 2;
            this.btnRelay02.Tag = "4";
            this.btnRelay02.Values.Text = "2";
            // 
            // txt_MusicName
            // 
            this.txt_MusicName.Location = new System.Drawing.Point(119, 10);
            this.txt_MusicName.Name = "txt_MusicName";
            this.txt_MusicName.Size = new System.Drawing.Size(323, 21);
            this.txt_MusicName.TabIndex = 5;
            // 
            // btnRelay03
            // 
            this.btnRelay03.Location = new System.Drawing.Point(342, 263);
            this.btnRelay03.Name = "btnRelay03";
            this.btnRelay03.Size = new System.Drawing.Size(100, 29);
            this.btnRelay03.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay03.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay03.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay03.TabIndex = 3;
            this.btnRelay03.Tag = "8";
            this.btnRelay03.Values.Text = "3";
            // 
            // txt_FileName
            // 
            this.txt_FileName.Location = new System.Drawing.Point(119, 66);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.ReadOnly = true;
            this.txt_FileName.Size = new System.Drawing.Size(323, 21);
            this.txt_FileName.TabIndex = 8;
            // 
            // btnRelay04
            // 
            this.btnRelay04.Location = new System.Drawing.Point(13, 316);
            this.btnRelay04.Name = "btnRelay04";
            this.btnRelay04.Size = new System.Drawing.Size(100, 29);
            this.btnRelay04.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay04.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay04.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay04.TabIndex = 4;
            this.btnRelay04.Tag = "16";
            this.btnRelay04.Values.Text = "4";
            // 
            // txt_FilePath
            // 
            this.txt_FilePath.Location = new System.Drawing.Point(119, 93);
            this.txt_FilePath.Name = "txt_FilePath";
            this.txt_FilePath.ReadOnly = true;
            this.txt_FilePath.Size = new System.Drawing.Size(271, 21);
            this.txt_FilePath.TabIndex = 9;
            // 
            // btnRelay05
            // 
            this.btnRelay05.Location = new System.Drawing.Point(123, 316);
            this.btnRelay05.Name = "btnRelay05";
            this.btnRelay05.Size = new System.Drawing.Size(100, 29);
            this.btnRelay05.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay05.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay05.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay05.TabIndex = 5;
            this.btnRelay05.Tag = "32";
            this.btnRelay05.Values.Text = "5";
            // 
            // btnRelay06
            // 
            this.btnRelay06.Location = new System.Drawing.Point(233, 316);
            this.btnRelay06.Name = "btnRelay06";
            this.btnRelay06.Size = new System.Drawing.Size(100, 29);
            this.btnRelay06.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay06.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay06.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay06.TabIndex = 6;
            this.btnRelay06.Tag = "64";
            this.btnRelay06.Values.Text = "6";
            // 
            // dpk_RingTime
            // 
            this.dpk_RingTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpk_RingTime.Location = new System.Drawing.Point(119, 37);
            this.dpk_RingTime.Name = "dpk_RingTime";
            this.dpk_RingTime.ShowUpDown = true;
            this.dpk_RingTime.Size = new System.Drawing.Size(116, 20);
            this.dpk_RingTime.TabIndex = 11;
            // 
            // btnRelay07
            // 
            this.btnRelay07.Location = new System.Drawing.Point(342, 316);
            this.btnRelay07.Name = "btnRelay07";
            this.btnRelay07.Size = new System.Drawing.Size(100, 29);
            this.btnRelay07.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay07.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay07.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay07.StateTracking.Back.Color2 = System.Drawing.Color.Gold;
            this.btnRelay07.TabIndex = 7;
            this.btnRelay07.Tag = "128";
            this.btnRelay07.Values.Text = "7";
            // 
            // btn_Confrm
            // 
            this.btn_Confrm.Location = new System.Drawing.Point(135, 373);
            this.btn_Confrm.Name = "btn_Confrm";
            this.btn_Confrm.Size = new System.Drawing.Size(90, 25);
            this.btn_Confrm.TabIndex = 140;
            this.btn_Confrm.Values.Text = "确定";
            this.btn_Confrm.Click += new System.EventHandler(this.btn_Confrm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(237, 373);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 25);
            this.btn_Cancel.TabIndex = 141;
            this.btn_Cancel.Values.Text = "取消";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // nud_Duaration
            // 
            this.nud_Duaration.Location = new System.Drawing.Point(327, 37);
            this.nud_Duaration.Name = "nud_Duaration";
            this.nud_Duaration.Size = new System.Drawing.Size(115, 20);
            this.nud_Duaration.TabIndex = 142;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(397, 92);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(45, 25);
            this.btn_OpenFile.TabIndex = 143;
            this.btn_OpenFile.Values.ExtraText = "打开";
            this.btn_OpenFile.Values.Text = "";
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // pl_ButtonGroup
            // 
            this.pl_ButtonGroup.Controls.Add(this.btn_OpenFile);
            this.pl_ButtonGroup.Controls.Add(this.nud_Duaration);
            this.pl_ButtonGroup.Controls.Add(this.btn_Cancel);
            this.pl_ButtonGroup.Controls.Add(this.btn_Confrm);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay07);
            this.pl_ButtonGroup.Controls.Add(this.dpk_RingTime);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay06);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay05);
            this.pl_ButtonGroup.Controls.Add(this.txt_FilePath);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay04);
            this.pl_ButtonGroup.Controls.Add(this.txt_FileName);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay03);
            this.pl_ButtonGroup.Controls.Add(this.txt_MusicName);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay02);
            this.pl_ButtonGroup.Controls.Add(this.label5);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay01);
            this.pl_ButtonGroup.Controls.Add(this.label4);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay00);
            this.pl_ButtonGroup.Controls.Add(this.label3);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay08);
            this.pl_ButtonGroup.Controls.Add(this.label2);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay09);
            this.pl_ButtonGroup.Controls.Add(this.label1);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay10);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay11);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay12);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay13);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay14);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay15);
            this.pl_ButtonGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_ButtonGroup.Location = new System.Drawing.Point(0, 0);
            this.pl_ButtonGroup.Name = "pl_ButtonGroup";
            this.pl_ButtonGroup.Size = new System.Drawing.Size(460, 414);
            this.pl_ButtonGroup.TabIndex = 77;
            // 
            // FrmEditRingBell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 414);
            this.Controls.Add(this.pl_ButtonGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmEditRingBell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑打铃设置";
            this.Load += new System.EventHandler(this.FrmEditRingBell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pl_ButtonGroup)).EndInit();
            this.pl_ButtonGroup.ResumeLayout(false);
            this.pl_ButtonGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_SystemCaption;
        private System.Windows.Forms.OpenFileDialog openFile;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay15;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay14;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay13;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay12;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay11;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay10;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay09;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay08;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay00;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay01;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay02;
        private System.Windows.Forms.TextBox txt_MusicName;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay03;
        private System.Windows.Forms.TextBox txt_FileName;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay04;
        private System.Windows.Forms.TextBox txt_FilePath;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay05;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay06;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dpk_RingTime;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay07;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Confrm;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown nud_Duaration;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OpenFile;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pl_ButtonGroup;
    }
}