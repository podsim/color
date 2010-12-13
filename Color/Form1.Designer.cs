namespace Color
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxHtml = new System.Windows.Forms.TextBox();
            this.labelHtml = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericB = new System.Windows.Forms.NumericUpDown();
            this.numericG = new System.Windows.Forms.NumericUpDown();
            this.numericR = new System.Windows.Forms.NumericUpDown();
            this.btnNameColorShow = new System.Windows.Forms.Button();
            this.btnRgbShow = new System.Windows.Forms.Button();
            this.chBMonitorMouse = new System.Windows.Forms.CheckBox();
            this.chBStayTop = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contMSNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureColorBox = new System.Windows.Forms.PictureBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnListVisible = new System.Windows.Forms.Button();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.btnDelColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericR)).BeginInit();
            this.contMSNotifyIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureColorBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // textBoxHtml
            // 
            this.textBoxHtml.AcceptsTab = true;
            this.textBoxHtml.Location = new System.Drawing.Point(3, 29);
            this.textBoxHtml.MaxLength = 7;
            this.textBoxHtml.Name = "textBoxHtml";
            this.textBoxHtml.Size = new System.Drawing.Size(133, 20);
            this.textBoxHtml.TabIndex = 2;
            // 
            // labelHtml
            // 
            this.labelHtml.AutoSize = true;
            this.labelHtml.Location = new System.Drawing.Point(3, 13);
            this.labelHtml.Name = "labelHtml";
            this.labelHtml.Size = new System.Drawing.Size(40, 13);
            this.labelHtml.TabIndex = 6;
            this.labelHtml.Text = "HTML:";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(3, 56);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(18, 13);
            this.labelR.TabIndex = 7;
            this.labelR.Text = "R:";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(47, 56);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(18, 13);
            this.labelG.TabIndex = 8;
            this.labelG.Text = "G:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(96, 56);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(17, 13);
            this.labelB.TabIndex = 9;
            this.labelB.Text = "B:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(107, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 153);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Color ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.numericB);
            this.panel1.Controls.Add(this.numericG);
            this.panel1.Controls.Add(this.numericR);
            this.panel1.Controls.Add(this.btnNameColorShow);
            this.panel1.Controls.Add(this.btnRgbShow);
            this.panel1.Controls.Add(this.labelR);
            this.panel1.Controls.Add(this.labelHtml);
            this.panel1.Controls.Add(this.textBoxHtml);
            this.panel1.Controls.Add(this.labelB);
            this.panel1.Controls.Add(this.labelG);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 128);
            this.panel1.TabIndex = 10;
            // 
            // numericB
            // 
            this.numericB.Location = new System.Drawing.Point(92, 72);
            this.numericB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericB.Name = "numericB";
            this.numericB.Size = new System.Drawing.Size(44, 20);
            this.numericB.TabIndex = 14;
            // 
            // numericG
            // 
            this.numericG.Location = new System.Drawing.Point(46, 72);
            this.numericG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericG.Name = "numericG";
            this.numericG.Size = new System.Drawing.Size(43, 20);
            this.numericG.TabIndex = 13;
            // 
            // numericR
            // 
            this.numericR.Location = new System.Drawing.Point(3, 72);
            this.numericR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericR.Name = "numericR";
            this.numericR.Size = new System.Drawing.Size(40, 20);
            this.numericR.TabIndex = 12;
            // 
            // btnNameColorShow
            // 
            this.btnNameColorShow.Location = new System.Drawing.Point(142, 26);
            this.btnNameColorShow.Name = "btnNameColorShow";
            this.btnNameColorShow.Size = new System.Drawing.Size(25, 23);
            this.btnNameColorShow.TabIndex = 11;
            this.btnNameColorShow.Text = "<-";
            this.btnNameColorShow.UseVisualStyleBackColor = true;
            this.btnNameColorShow.Click += new System.EventHandler(this.BtnNameColorShowClick);
            // 
            // btnRgbShow
            // 
            this.btnRgbShow.Location = new System.Drawing.Point(142, 69);
            this.btnRgbShow.Name = "btnRgbShow";
            this.btnRgbShow.Size = new System.Drawing.Size(25, 23);
            this.btnRgbShow.TabIndex = 10;
            this.btnRgbShow.Text = "<-";
            this.btnRgbShow.UseVisualStyleBackColor = true;
            this.btnRgbShow.Click += new System.EventHandler(this.BtnShowClick);
            // 
            // chBMonitorMouse
            // 
            this.chBMonitorMouse.AutoSize = true;
            this.chBMonitorMouse.Location = new System.Drawing.Point(101, 3);
            this.chBMonitorMouse.Name = "chBMonitorMouse";
            this.chBMonitorMouse.Size = new System.Drawing.Size(96, 17);
            this.chBMonitorMouse.TabIndex = 13;
            this.chBMonitorMouse.Text = "Monitor Mouse";
            this.chBMonitorMouse.UseVisualStyleBackColor = true;
            this.chBMonitorMouse.CheckedChanged += new System.EventHandler(this.ChBMonitorMouseCheckedChanged);
            // 
            // chBStayTop
            // 
            this.chBStayTop.AutoSize = true;
            this.chBStayTop.Location = new System.Drawing.Point(3, 3);
            this.chBStayTop.Name = "chBStayTop";
            this.chBStayTop.Size = new System.Drawing.Size(86, 17);
            this.chBStayTop.TabIndex = 14;
            this.chBStayTop.Text = "Stay On Top";
            this.chBStayTop.UseVisualStyleBackColor = true;
            this.chBStayTop.CheckedChanged += new System.EventHandler(this.ChBStayTopCheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contMSNotifyIcon;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MouseToColor";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1MouseClick);
            // 
            // contMSNotifyIcon
            // 
            this.contMSNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contMSNotifyIcon.Name = "contMSNotifyIcon";
            this.contMSNotifyIcon.Size = new System.Drawing.Size(93, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // pictureColorBox
            // 
            this.pictureColorBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureColorBox.Location = new System.Drawing.Point(12, 12);
            this.pictureColorBox.Name = "pictureColorBox";
            this.pictureColorBox.Size = new System.Drawing.Size(89, 153);
            this.pictureColorBox.TabIndex = 1;
            this.pictureColorBox.TabStop = false;
            this.pictureColorBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureColorBoxMouseDown);
            this.pictureColorBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureColorBoxMouseUp);
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(22, 58);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(57, 39);
            this.labelTip.TabIndex = 15;
            this.labelTip.Text = "Click here \nand hold \nthe button";
            this.labelTip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelTipMouseDown);
            this.labelTip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelTipMouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.chBStayTop);
            this.panel2.Controls.Add(this.chBMonitorMouse);
            this.panel2.Location = new System.Drawing.Point(12, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 24);
            this.panel2.TabIndex = 16;
            // 
            // btnListVisible
            // 
            this.btnListVisible.Location = new System.Drawing.Point(265, 174);
            this.btnListVisible.Name = "btnListVisible";
            this.btnListVisible.Size = new System.Drawing.Size(27, 25);
            this.btnListVisible.TabIndex = 17;
            this.btnListVisible.Text = ">>";
            this.btnListVisible.UseVisualStyleBackColor = true;
            this.btnListVisible.Click += new System.EventHandler(this.BtnListVisibleClick);
            // 
            // listViewHistory
            // 
            this.listViewHistory.FullRowSelect = true;
            this.listViewHistory.Location = new System.Drawing.Point(302, 28);
            this.listViewHistory.MultiSelect = false;
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(121, 140);
            this.listViewHistory.TabIndex = 18;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.List;
            this.listViewHistory.Visible = false;
            this.listViewHistory.SelectedIndexChanged += new System.EventHandler(this.ListViewHistorySelectedIndexChanged);
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(400, 174);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(23, 23);
            this.btnAddColor.TabIndex = 19;
            this.btnAddColor.Text = "+";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Visible = false;
            this.btnAddColor.Click += new System.EventHandler(this.BtnAddColorClick);
            // 
            // btnDelColor
            // 
            this.btnDelColor.Location = new System.Drawing.Point(371, 174);
            this.btnDelColor.Name = "btnDelColor";
            this.btnDelColor.Size = new System.Drawing.Size(23, 23);
            this.btnDelColor.TabIndex = 20;
            this.btnDelColor.Text = "-";
            this.btnDelColor.UseVisualStyleBackColor = true;
            this.btnDelColor.Visible = false;
            this.btnDelColor.Click += new System.EventHandler(this.BtnDelColorClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Color History:";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 207);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelColor);
            this.Controls.Add(this.btnAddColor);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.btnListVisible);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.pictureColorBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MouseToColor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericR)).EndInit();
            this.contMSNotifyIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureColorBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureColorBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxHtml;
        private System.Windows.Forms.Label labelHtml;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chBMonitorMouse;
        private System.Windows.Forms.CheckBox chBStayTop;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contMSNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Button btnRgbShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNameColorShow;
        private System.Windows.Forms.Button btnListVisible;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Button btnDelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericB;
        private System.Windows.Forms.NumericUpDown numericG;
        private System.Windows.Forms.NumericUpDown numericR;
    }
}

