using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace C_Sharp_Final_Chat
{
    public partial class Login : Form
    {
        public static string UserName = "";

        private bool beginMove; //初始化鼠标位置
        private int currentXPosition;
        private int currentYPosition;
        private bool timerFlag = true;

        public Login()
        {
            InitializeComponent();
            Opacity = 0;
            timer.Start();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserName = textBox.Text;
            if (string.IsNullOrEmpty(UserName))
            {
                var loginwarn = new LoginWarn();
                loginwarn.ShowDialog();
            }
            else
            {
                Hide();
                ShowInTaskbar = false;
                var mainWindows = new MainWindow();
                mainWindows.Show();
            }
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            pictureBoxClosed.Visible = true;
            pictureBoxClose.Visible = false;
        }

        private void pictureBoxClosed_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void pictureBoxClosed_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClosed.Visible = false;
            pictureBoxClose.Visible = true;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X; //鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y; //鼠标的y坐标为当前窗体左上角y坐标
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                Left += MousePosition.X - currentXPosition; //根据鼠标x坐标确定窗体的左边坐标x
                Top += MousePosition.Y - currentYPosition; //根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
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
    }
}