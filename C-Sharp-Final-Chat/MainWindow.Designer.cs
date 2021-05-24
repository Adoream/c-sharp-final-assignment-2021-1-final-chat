
namespace C_Sharp_Final_Chat
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开主面板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.ButtonLicence = new System.Windows.Forms.Button();
            this.ButtonSource = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panelChat = new System.Windows.Forms.Panel();
            this.buttonChangeUserName = new System.Windows.Forms.Button();
            this.buttonChatroom = new System.Windows.Forms.Button();
            this.buttonChat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelHelp.SuspendLayout();
            this.panelChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Final Chat";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开主面板ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(154, 52);
            // 
            // 打开主面板ToolStripMenuItem
            // 
            this.打开主面板ToolStripMenuItem.Name = "打开主面板ToolStripMenuItem";
            this.打开主面板ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.打开主面板ToolStripMenuItem.Text = "打开主面板";
            this.打开主面板ToolStripMenuItem.Click += new System.EventHandler(this.打开主面板ToolStripMenuItem_Click_1);
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(153, 24);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Controls.Add(this.buttonMax);
            this.panelTop.Controls.Add(this.buttonMin);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1036, 24);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(997, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(21, 24);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.FlatAppearance.BorderSize = 0;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Image = ((System.Drawing.Image)(resources.GetObject("buttonMax.Image")));
            this.buttonMax.Location = new System.Drawing.Point(963, 0);
            this.buttonMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(26, 24);
            this.buttonMax.TabIndex = 3;
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Image = ((System.Drawing.Image)(resources.GetObject("buttonMin.Image")));
            this.buttonMin.Location = new System.Drawing.Point(931, 0);
            this.buttonMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(24, 24);
            this.buttonMin.TabIndex = 2;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panelSide.Controls.Add(this.panelHelp);
            this.panelSide.Controls.Add(this.buttonHelp);
            this.panelSide.Controls.Add(this.panelChat);
            this.panelSide.Controls.Add(this.buttonChat);
            this.panelSide.Controls.Add(this.pictureBox2);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(244, 720);
            this.panelSide.TabIndex = 2;
            // 
            // panelHelp
            // 
            this.panelHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.panelHelp.Controls.Add(this.ButtonLicence);
            this.panelHelp.Controls.Add(this.ButtonSource);
            this.panelHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHelp.Location = new System.Drawing.Point(0, 264);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(244, 89);
            this.panelHelp.TabIndex = 4;
            // 
            // ButtonLicence
            // 
            this.ButtonLicence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.ButtonLicence.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonLicence.FlatAppearance.BorderSize = 0;
            this.ButtonLicence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLicence.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ButtonLicence.ForeColor = System.Drawing.Color.White;
            this.ButtonLicence.Location = new System.Drawing.Point(0, 41);
            this.ButtonLicence.Name = "ButtonLicence";
            this.ButtonLicence.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.ButtonLicence.Size = new System.Drawing.Size(244, 41);
            this.ButtonLicence.TabIndex = 1;
            this.ButtonLicence.Text = "Licence";
            this.ButtonLicence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLicence.UseVisualStyleBackColor = false;
            this.ButtonLicence.Click += new System.EventHandler(this.ButtonLicence_Click);
            // 
            // ButtonSource
            // 
            this.ButtonSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.ButtonSource.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonSource.FlatAppearance.BorderSize = 0;
            this.ButtonSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSource.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ButtonSource.ForeColor = System.Drawing.Color.White;
            this.ButtonSource.Location = new System.Drawing.Point(0, 0);
            this.ButtonSource.Name = "ButtonSource";
            this.ButtonSource.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.ButtonSource.Size = new System.Drawing.Size(244, 41);
            this.ButtonSource.TabIndex = 0;
            this.ButtonSource.Text = "Source";
            this.ButtonSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSource.UseVisualStyleBackColor = false;
            this.ButtonSource.Click += new System.EventHandler(this.ButtonSource_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(0, 223);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonHelp.Size = new System.Drawing.Size(244, 41);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // panelChat
            // 
            this.panelChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.panelChat.Controls.Add(this.buttonChangeUserName);
            this.panelChat.Controls.Add(this.buttonChatroom);
            this.panelChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChat.Location = new System.Drawing.Point(0, 134);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(244, 89);
            this.panelChat.TabIndex = 2;
            // 
            // buttonChangeUserName
            // 
            this.buttonChangeUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.buttonChangeUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChangeUserName.FlatAppearance.BorderSize = 0;
            this.buttonChangeUserName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeUserName.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.buttonChangeUserName.ForeColor = System.Drawing.Color.White;
            this.buttonChangeUserName.Location = new System.Drawing.Point(0, 41);
            this.buttonChangeUserName.Name = "buttonChangeUserName";
            this.buttonChangeUserName.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonChangeUserName.Size = new System.Drawing.Size(244, 41);
            this.buttonChangeUserName.TabIndex = 1;
            this.buttonChangeUserName.Text = "Change User Name";
            this.buttonChangeUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChangeUserName.UseVisualStyleBackColor = false;
            this.buttonChangeUserName.Click += new System.EventHandler(this.buttonChangeUserName_Click);
            // 
            // buttonChatroom
            // 
            this.buttonChatroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(177)))), ((int)(((byte)(255)))));
            this.buttonChatroom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChatroom.FlatAppearance.BorderSize = 0;
            this.buttonChatroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChatroom.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.buttonChatroom.ForeColor = System.Drawing.Color.White;
            this.buttonChatroom.Location = new System.Drawing.Point(0, 0);
            this.buttonChatroom.Name = "buttonChatroom";
            this.buttonChatroom.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonChatroom.Size = new System.Drawing.Size(244, 41);
            this.buttonChatroom.TabIndex = 0;
            this.buttonChatroom.Text = "Chatroom";
            this.buttonChatroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChatroom.UseVisualStyleBackColor = false;
            this.buttonChatroom.Click += new System.EventHandler(this.buttonChatroom_Click_1);
            // 
            // buttonChat
            // 
            this.buttonChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.buttonChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChat.FlatAppearance.BorderSize = 0;
            this.buttonChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChat.ForeColor = System.Drawing.Color.White;
            this.buttonChat.Location = new System.Drawing.Point(0, 93);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonChat.Size = new System.Drawing.Size(244, 41);
            this.buttonChat.TabIndex = 1;
            this.buttonChat.Text = "Chat";
            this.buttonChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChat.UseVisualStyleBackColor = false;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::C_Sharp_Final_Chat.Properties.Resources.logZ;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelChildForm);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(244, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1036, 720);
            this.panelMain.TabIndex = 3;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Controls.Add(this.pictureBox);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 24);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1036, 696);
            this.panelChildForm.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox.Image = global::C_Sharp_Final_Chat.Properties.Resources.C_logo;
            this.pictureBox.Location = new System.Drawing.Point(266, 181);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(539, 301);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSide);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindows";
            this.contextMenuStrip.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelHelp.ResumeLayout(false);
            this.panelChat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 打开主面板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Button buttonChat;
        private System.Windows.Forms.Button buttonChangeUserName;
        private System.Windows.Forms.Button buttonChatroom;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.Button ButtonLicence;
        private System.Windows.Forms.Button ButtonSource;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}