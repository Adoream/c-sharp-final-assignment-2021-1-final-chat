
using System.Windows.Forms;

namespace C_Sharp_Final_Chat
{
    partial class ChatroomWindow
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
            this.panelChat0 = new System.Windows.Forms.Panel();
            this.panelChatroom1 = new System.Windows.Forms.Panel();
            this.richTextBoxChat = new System.Windows.Forms.RichTextBox();
            this.panelUser0 = new System.Windows.Forms.Panel();
            this.panelUser1 = new System.Windows.Forms.Panel();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMessage0 = new System.Windows.Forms.Panel();
            this.panelMessage1 = new System.Windows.Forms.Panel();
            this.panelMessage2 = new System.Windows.Forms.Panel();
            this.panelMessage3 = new System.Windows.Forms.Panel();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.panelChat0.SuspendLayout();
            this.panelChatroom1.SuspendLayout();
            this.panelUser0.SuspendLayout();
            this.panelUser1.SuspendLayout();
            this.panelMessage0.SuspendLayout();
            this.panelMessage1.SuspendLayout();
            this.panelMessage2.SuspendLayout();
            this.panelMessage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChat0
            // 
            this.panelChat0.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (216)))), ((int) (((byte) (255)))));
            this.panelChat0.Controls.Add(this.panelChatroom1);
            this.panelChat0.Location = new System.Drawing.Point(37, 34);
            this.panelChat0.Name = "panelChat0";
            this.panelChat0.Size = new System.Drawing.Size(707, 471);
            this.panelChat0.TabIndex = 4;
            // 
            // panelChatroom1
            // 
            this.panelChatroom1.BackColor = System.Drawing.Color.White;
            this.panelChatroom1.Controls.Add(this.richTextBoxChat);
            this.panelChatroom1.Location = new System.Drawing.Point(5, 5);
            this.panelChatroom1.Margin = new System.Windows.Forms.Padding(5);
            this.panelChatroom1.Name = "panelChatroom1";
            this.panelChatroom1.Size = new System.Drawing.Size(697, 461);
            this.panelChatroom1.TabIndex = 0;
            // 
            // richTextBoxChat
            // 
            this.richTextBoxChat.BackColor = System.Drawing.Color.White;
            this.richTextBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxChat.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (96)))), ((int) (((byte) (98)))), ((int) (((byte) (102)))));
            this.richTextBoxChat.Location = new System.Drawing.Point(13, 16);
            this.richTextBoxChat.Name = "richTextBoxChat";
            this.richTextBoxChat.ReadOnly = true;
            this.richTextBoxChat.Size = new System.Drawing.Size(667, 432);
            this.richTextBoxChat.TabIndex = 0;
            this.richTextBoxChat.Text = "";
            // 
            // panelUser0
            // 
            this.panelUser0.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (216)))), ((int) (((byte) (255)))));
            this.panelUser0.Controls.Add(this.panelUser1);
            this.panelUser0.Location = new System.Drawing.Point(783, 34);
            this.panelUser0.Name = "panelUser0";
            this.panelUser0.Size = new System.Drawing.Size(212, 596);
            this.panelUser0.TabIndex = 5;
            // 
            // panelUser1
            // 
            this.panelUser1.BackColor = System.Drawing.Color.White;
            this.panelUser1.Controls.Add(this.listBox);
            this.panelUser1.Location = new System.Drawing.Point(5, 5);
            this.panelUser1.Margin = new System.Windows.Forms.Padding(5);
            this.panelUser1.Name = "panelUser1";
            this.panelUser1.Size = new System.Drawing.Size(202, 586);
            this.panelUser1.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.White;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (96)))), ((int) (((byte) (98)))), ((int) (((byte) (102)))));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 41;
            this.listBox.Location = new System.Drawing.Point(12, 16);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(187, 533);
            this.listBox.TabIndex = 0;
            this.listBox.MouseClick += new MouseEventHandler(this.listBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (49)))), ((int) (((byte) (51)))));
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chatroom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (49)))), ((int) (((byte) (51)))));
            this.label2.Location = new System.Drawing.Point(800, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "User";
            // 
            // panelMessage0
            // 
            this.panelMessage0.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (216)))), ((int) (((byte) (255)))));
            this.panelMessage0.Controls.Add(this.panelMessage1);
            this.panelMessage0.Location = new System.Drawing.Point(37, 531);
            this.panelMessage0.Name = "panelMessage0";
            this.panelMessage0.Size = new System.Drawing.Size(707, 99);
            this.panelMessage0.TabIndex = 8;
            // 
            // panelMessage1
            // 
            this.panelMessage1.BackColor = System.Drawing.Color.White;
            this.panelMessage1.Controls.Add(this.panelMessage2);
            this.panelMessage1.Location = new System.Drawing.Point(4, 4);
            this.panelMessage1.Name = "panelMessage1";
            this.panelMessage1.Size = new System.Drawing.Size(700, 92);
            this.panelMessage1.TabIndex = 0;
            // 
            // panelMessage2
            // 
            this.panelMessage2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (216)))), ((int) (((byte) (255)))));
            this.panelMessage2.Controls.Add(this.panelMessage3);
            this.panelMessage2.Location = new System.Drawing.Point(3, 3);
            this.panelMessage2.Name = "panelMessage2";
            this.panelMessage2.Size = new System.Drawing.Size(694, 86);
            this.panelMessage2.TabIndex = 1;
            // 
            // panelMessage3
            // 
            this.panelMessage3.BackColor = System.Drawing.Color.White;
            this.panelMessage3.Controls.Add(this.richTextBoxMessage);
            this.panelMessage3.Location = new System.Drawing.Point(3, 3);
            this.panelMessage3.Name = "panelMessage3";
            this.panelMessage3.Size = new System.Drawing.Size(688, 80);
            this.panelMessage3.TabIndex = 2;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.Color.White;
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessage.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (96)))), ((int) (((byte) (98)))), ((int) (((byte) (102)))));
            this.richTextBoxMessage.Location = new System.Drawing.Point(8, 14);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(667, 53);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.Text = "";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMessage.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (49)))), ((int) (((byte) (51)))));
            this.labelMessage.Location = new System.Drawing.Point(59, 520);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(194, 52);
            this.labelMessage.TabIndex = 9;
            this.labelMessage.Text = "Message";
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (216)))), ((int) (((byte) (255)))));
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(557, 646);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(187, 30);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (179)))), ((int) (((byte) (216)))), ((int) (((byte) (255)))));
            this.buttonLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeave.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.buttonLeave.ForeColor = System.Drawing.Color.White;
            this.buttonLeave.Location = new System.Drawing.Point(339, 646);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(187, 30);
            this.buttonLeave.TabIndex = 11;
            this.buttonLeave.Text = "Leave";
            this.buttonLeave.UseVisualStyleBackColor = false;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // ChatroomWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 688);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMessage0);
            this.Controls.Add(this.panelUser0);
            this.Controls.Add(this.panelChat0);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChatroomWindow";
            this.Text = "ChatroomWindow";
            this.Load += new System.EventHandler(this.ChatroomWindow_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chat_FormClosing);
            this.panelChat0.ResumeLayout(false);
            this.panelChatroom1.ResumeLayout(false);
            this.panelUser0.ResumeLayout(false);
            this.panelUser1.ResumeLayout(false);
            this.panelMessage0.ResumeLayout(false);
            this.panelMessage1.ResumeLayout(false);
            this.panelMessage2.ResumeLayout(false);
            this.panelMessage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelChat0;
        private System.Windows.Forms.Panel panelUser0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelChatroom1;
        private System.Windows.Forms.Panel panelUser1;
        private System.Windows.Forms.Panel panelMessage0;
        private System.Windows.Forms.RichTextBox richTextBoxChat;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Panel panelMessage1;
        private System.Windows.Forms.Panel panelMessage2;
        private System.Windows.Forms.Panel panelMessage3;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonLeave;
    }
}