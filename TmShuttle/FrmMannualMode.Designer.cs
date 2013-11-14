namespace TmShuttle
{
    partial class FrmMannualMode
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
            this.components = new System.ComponentModel.Container();
            this.btnCloseAll = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnOpenAll = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.pl_ButtonGroup = new System.Windows.Forms.Panel();
            this.btnRelay07 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.kryptonContextMenu1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.btnRelay06 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay05 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay04 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay03 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay02 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay01 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay00 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay08 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay09 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay10 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay11 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay12 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay13 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay14 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.btnRelay15 = new ComponentFactory.Krypton.Toolkit.KryptonCheckButton();
            this.checkSet_Switch = new ComponentFactory.Krypton.Toolkit.KryptonCheckSet(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.pl_ButtonGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkSet_Switch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Location = new System.Drawing.Point(163, 361);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(154, 44);
            this.btnCloseAll.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnCloseAll.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCloseAll.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnCloseAll.TabIndex = 74;
            this.btnCloseAll.Tag = "";
            this.btnCloseAll.Values.Text = "断开所有";
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // btnOpenAll
            // 
            this.btnOpenAll.Location = new System.Drawing.Point(394, 361);
            this.btnOpenAll.Name = "btnOpenAll";
            this.btnOpenAll.Size = new System.Drawing.Size(152, 44);
            this.btnOpenAll.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnOpenAll.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpenAll.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnOpenAll.TabIndex = 75;
            this.btnOpenAll.Tag = "";
            this.btnOpenAll.Values.Text = "闭合所有";
            this.btnOpenAll.Click += new System.EventHandler(this.btnOpenAll_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.pl_ButtonGroup);
            this.kryptonPanel1.Controls.Add(this.btnCloseAll);
            this.kryptonPanel1.Controls.Add(this.btnOpenAll);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonStandalone;
            this.kryptonPanel1.Size = new System.Drawing.Size(799, 517);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 76;
            // 
            // pl_ButtonGroup
            // 
            this.pl_ButtonGroup.BackColor = System.Drawing.Color.Transparent;
            this.pl_ButtonGroup.Controls.Add(this.btnRelay07);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay06);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay05);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay04);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay03);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay02);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay01);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay00);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay08);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay09);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay10);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay11);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay12);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay13);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay14);
            this.pl_ButtonGroup.Controls.Add(this.btnRelay15);
            this.pl_ButtonGroup.Location = new System.Drawing.Point(87, 12);
            this.pl_ButtonGroup.Name = "pl_ButtonGroup";
            this.pl_ButtonGroup.Size = new System.Drawing.Size(520, 327);
            this.pl_ButtonGroup.TabIndex = 76;
            // 
            // btnRelay07
            // 
            this.btnRelay07.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay07.Location = new System.Drawing.Point(375, 260);
            this.btnRelay07.Name = "btnRelay07";
            this.btnRelay07.Size = new System.Drawing.Size(100, 35);
            this.btnRelay07.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay07.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay07.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay07.StateTracking.Back.Color2 = System.Drawing.Color.Gold;
            this.btnRelay07.TabIndex = 7;
            this.btnRelay07.Tag = "断开";
            this.btnRelay07.Values.Text = "7";
            this.btnRelay07.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // kryptonContextMenu1
            // 
            this.kryptonContextMenu1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            this.kryptonContextMenu1.Opening += new System.ComponentModel.CancelEventHandler(this.kryptonContextMenu1_Opening);
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem1});
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Text = "编辑按钮名称";
            this.kryptonContextMenuItem1.Click += new System.EventHandler(this.kryptonContextMenuItem1_Click);
            // 
            // btnRelay06
            // 
            this.btnRelay06.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay06.Location = new System.Drawing.Point(266, 260);
            this.btnRelay06.Name = "btnRelay06";
            this.btnRelay06.Size = new System.Drawing.Size(100, 35);
            this.btnRelay06.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay06.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay06.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay06.TabIndex = 6;
            this.btnRelay06.Tag = "断开";
            this.btnRelay06.Values.Text = "6";
            this.btnRelay06.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay05
            // 
            this.btnRelay05.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay05.Location = new System.Drawing.Point(156, 260);
            this.btnRelay05.Name = "btnRelay05";
            this.btnRelay05.Size = new System.Drawing.Size(100, 35);
            this.btnRelay05.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay05.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay05.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay05.TabIndex = 5;
            this.btnRelay05.Tag = "断开";
            this.btnRelay05.Values.Text = "5";
            this.btnRelay05.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay04
            // 
            this.btnRelay04.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay04.Location = new System.Drawing.Point(46, 260);
            this.btnRelay04.Name = "btnRelay04";
            this.btnRelay04.Size = new System.Drawing.Size(100, 35);
            this.btnRelay04.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay04.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay04.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay04.TabIndex = 4;
            this.btnRelay04.Tag = "断开";
            this.btnRelay04.Values.Text = "4";
            this.btnRelay04.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay03
            // 
            this.btnRelay03.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay03.Location = new System.Drawing.Point(375, 188);
            this.btnRelay03.Name = "btnRelay03";
            this.btnRelay03.Size = new System.Drawing.Size(100, 35);
            this.btnRelay03.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay03.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay03.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay03.TabIndex = 3;
            this.btnRelay03.Tag = "断开";
            this.btnRelay03.Values.Text = "3";
            this.btnRelay03.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay02
            // 
            this.btnRelay02.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay02.Location = new System.Drawing.Point(266, 188);
            this.btnRelay02.Name = "btnRelay02";
            this.btnRelay02.Size = new System.Drawing.Size(100, 35);
            this.btnRelay02.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay02.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay02.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay02.TabIndex = 2;
            this.btnRelay02.Tag = "断开";
            this.btnRelay02.Values.Text = "2";
            this.btnRelay02.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay01
            // 
            this.btnRelay01.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay01.Location = new System.Drawing.Point(156, 188);
            this.btnRelay01.Name = "btnRelay01";
            this.btnRelay01.Size = new System.Drawing.Size(100, 35);
            this.btnRelay01.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay01.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay01.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay01.TabIndex = 1;
            this.btnRelay01.Tag = "断开";
            this.btnRelay01.Values.Text = "1";
            this.btnRelay01.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay00
            // 
            this.btnRelay00.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay00.Location = new System.Drawing.Point(46, 188);
            this.btnRelay00.Name = "btnRelay00";
            this.btnRelay00.Size = new System.Drawing.Size(100, 35);
            this.btnRelay00.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay00.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay00.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay00.TabIndex = 0;
            this.btnRelay00.Tag = "断开";
            this.btnRelay00.Values.Text = "0";
            this.btnRelay00.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay08
            // 
            this.btnRelay08.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay08.Location = new System.Drawing.Point(375, 114);
            this.btnRelay08.Name = "btnRelay08";
            this.btnRelay08.Size = new System.Drawing.Size(100, 35);
            this.btnRelay08.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay08.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay08.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay08.TabIndex = 8;
            this.btnRelay08.Tag = "断开";
            this.btnRelay08.Values.Text = "8";
            this.btnRelay08.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay09
            // 
            this.btnRelay09.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay09.Location = new System.Drawing.Point(266, 114);
            this.btnRelay09.Name = "btnRelay09";
            this.btnRelay09.Size = new System.Drawing.Size(100, 35);
            this.btnRelay09.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay09.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay09.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay09.TabIndex = 9;
            this.btnRelay09.Tag = "断开";
            this.btnRelay09.Values.Text = "9";
            this.btnRelay09.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay10
            // 
            this.btnRelay10.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay10.Location = new System.Drawing.Point(156, 114);
            this.btnRelay10.Name = "btnRelay10";
            this.btnRelay10.Size = new System.Drawing.Size(100, 35);
            this.btnRelay10.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay10.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay10.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay10.TabIndex = 10;
            this.btnRelay10.Tag = "断开";
            this.btnRelay10.Values.Text = "10";
            this.btnRelay10.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay11
            // 
            this.btnRelay11.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay11.Location = new System.Drawing.Point(46, 114);
            this.btnRelay11.Name = "btnRelay11";
            this.btnRelay11.Size = new System.Drawing.Size(100, 35);
            this.btnRelay11.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay11.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay11.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay11.TabIndex = 11;
            this.btnRelay11.Tag = "断开";
            this.btnRelay11.Values.Text = "11";
            this.btnRelay11.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay12
            // 
            this.btnRelay12.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay12.Location = new System.Drawing.Point(375, 34);
            this.btnRelay12.Name = "btnRelay12";
            this.btnRelay12.Size = new System.Drawing.Size(100, 35);
            this.btnRelay12.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay12.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay12.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay12.TabIndex = 12;
            this.btnRelay12.Tag = "断开";
            this.btnRelay12.Values.Text = "12";
            this.btnRelay12.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay13
            // 
            this.btnRelay13.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay13.Location = new System.Drawing.Point(266, 34);
            this.btnRelay13.Name = "btnRelay13";
            this.btnRelay13.Size = new System.Drawing.Size(100, 35);
            this.btnRelay13.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay13.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay13.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay13.TabIndex = 13;
            this.btnRelay13.Tag = "断开";
            this.btnRelay13.Values.Text = "13";
            this.btnRelay13.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay14
            // 
            this.btnRelay14.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay14.Location = new System.Drawing.Point(156, 34);
            this.btnRelay14.Name = "btnRelay14";
            this.btnRelay14.Size = new System.Drawing.Size(100, 35);
            this.btnRelay14.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay14.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay14.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay14.TabIndex = 14;
            this.btnRelay14.Tag = "断开";
            this.btnRelay14.Values.Text = "14";
            this.btnRelay14.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // btnRelay15
            // 
            this.btnRelay15.KryptonContextMenu = this.kryptonContextMenu1;
            this.btnRelay15.Location = new System.Drawing.Point(46, 34);
            this.btnRelay15.Name = "btnRelay15";
            this.btnRelay15.Size = new System.Drawing.Size(100, 35);
            this.btnRelay15.StateCheckedNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay15.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelay15.StateCheckedTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnRelay15.TabIndex = 15;
            this.btnRelay15.Tag = "断开";
            this.btnRelay15.Values.Text = "15";
            this.btnRelay15.Click += new System.EventHandler(this.btnRelay_Click);
            // 
            // checkSet_Switch
            // 
            this.checkSet_Switch.AllowUncheck = true;
            this.checkSet_Switch.CheckButtons.Add(this.btnCloseAll);
            this.checkSet_Switch.CheckButtons.Add(this.btnOpenAll);
            // 
            // FrmMannualMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 517);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMannualMode";
            this.ShowInTaskbar = false;
            this.Text = "MannualMode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MannualMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.pl_ButtonGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkSet_Switch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnCloseAll;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnOpenAll;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckSet checkSet_Switch;
        private System.Windows.Forms.Panel pl_ButtonGroup;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay07;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay06;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay05;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay04;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay03;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay02;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay01;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay00;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay08;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay09;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay10;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay11;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay12;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay13;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay14;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckButton btnRelay15;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
    }
}