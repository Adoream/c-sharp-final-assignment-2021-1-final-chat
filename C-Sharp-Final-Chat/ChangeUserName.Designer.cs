
namespace C_Sharp_Final_Chat
{
    partial class ChangeUserName
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxClosed = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.labelCurrentUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxClosed);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Controls.Add(this.labelCurrentUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 500);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxClosed
            // 
            this.pictureBoxClosed.Image = global::C_Sharp_Final_Chat.Properties.Resources.返回副本;
            this.pictureBoxClosed.Location = new System.Drawing.Point(289, 446);
            this.pictureBoxClosed.Name = "pictureBoxClosed";
            this.pictureBoxClosed.Size = new System.Drawing.Size(32, 35);
            this.pictureBoxClosed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClosed.TabIndex = 8;
            this.pictureBoxClosed.TabStop = false;
            this.pictureBoxClosed.Visible = false;
            this.pictureBoxClosed.Click += new System.EventHandler(this.pictureBoxClosed_Click);
            this.pictureBoxClosed.MouseLeave += new System.EventHandler(this.pictureBoxClosed_MouseLeave);
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = global::C_Sharp_Final_Chat.Properties.Resources.返回;
            this.pictureBoxClose.Location = new System.Drawing.Point(289, 446);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(32, 35);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 7;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBoxClose_MouseHover);
            // 
            // labelCurrentUsername
            // 
            this.labelCurrentUsername.AutoSize = true;
            this.labelCurrentUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.labelCurrentUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCurrentUsername.ForeColor = System.Drawing.Color.White;
            this.labelCurrentUsername.Location = new System.Drawing.Point(68, 237);
            this.labelCurrentUsername.Name = "labelCurrentUsername";
            this.labelCurrentUsername.Size = new System.Drawing.Size(57, 27);
            this.labelCurrentUsername.TabIndex = 6;
            this.labelCurrentUsername.Text = "label";
            this.labelCurrentUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(60, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Username";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(168)))), ((int)(((byte)(238)))));
            this.button.FlatAppearance.BorderSize = 0;
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(110, 385);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(130, 34);
            this.button.TabIndex = 3;
            this.button.Text = "Change";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(187)))), ((int)(((byte)(255)))));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(65, 338);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(220, 27);
            this.textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(60, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C_Sharp_Final_Chat.Properties.Resources.realLogo;
            this.pictureBox1.Location = new System.Drawing.Point(40, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(354, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 508);
            this.panel2.TabIndex = 2;
            // 
            // ChangeUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1036, 696);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangeUserName";
            this.Text = "ChangeUserName";
            this.Load += new System.EventHandler(this.ChangeUserName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClosed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelCurrentUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.PictureBox pictureBoxClosed;
    }
}