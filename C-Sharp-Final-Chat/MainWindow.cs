using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace C_Sharp_Final_Chat
{
    public partial class MainWindow : Form
    {
        public Form activeForm;

        private bool beginMove; //初始化鼠标位置
        private int currentXPosition;
        private int currentYPosition;
        private bool timerFlag = true;

        public MainWindow()
        {
            InitializeComponent();
            customizeDesing();
            Opacity = 0;
            timer.Start();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void customizeDesing()
        {
            panelChat.Visible = false;
            panelHelp.Visible = false;
        }

        private void hidePanel()
        {
            if (panelHelp.Visible)
                panelHelp.Visible = false;
            if (panelChat.Visible)
                panelChat.Visible = false;
        }

        private void showPanel(Panel subPanel)
        {
            if (subPanel.Visible == false)
            {
                hidePanel();
                subPanel.Visible = true;
            }
            else
            {
                subPanel.Visible = false;
            }
        }


        private void 打开主面板ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Hide();
            ShowInTaskbar = false;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X; //鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y; //鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                Left += MousePosition.X - currentXPosition; //根据鼠标x坐标确定窗体的左边坐标x
                Top += MousePosition.Y - currentYPosition; //根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timerFlag)
            {
                if (Opacity <= 0.975)
                {
                    Opacity += 0.025;
                }
                else
                {
                    timer.Stop();
                    timerFlag = false;
                }
            }
            else
            {
                if (Opacity >= 0.025)
                {
                    Opacity -= 0.025;
                }
                else
                {
                    timer.Stop();
                    Application.Exit();
                }
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            showPanel(panelChat);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            showPanel(panelHelp);
        }

        private void buttonChatroom_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ChatroomWindow());
        }

        private void buttonChangeUserName_Click(object sender, EventArgs e)
        {
            openChildForm(new ChangeUserName());
        }

        private void ButtonSource_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/SoraJin424/C-Sharp-Final-Chat");
        }

        private void ButtonLicence_Click(object sender, EventArgs e)
        {
            Process.Start("https://opensource.org/licenses/MIT/");
        }
    }
}