using System;
using System.Windows.Forms;

namespace C_Sharp_Final_Chat
{
    public partial class ChangeUserName : Form
    {
        public ChangeUserName()
        {
            InitializeComponent();
        }

        private void ChangeUserName_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Login.UserName)) labelCurrentUsername.Text = Login.UserName;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Login.UserName = textBox.Text;
            if (string.IsNullOrEmpty(Login.UserName))
            {
                var loginwarn = new LoginWarn();
                loginwarn.ShowDialog();
            }
            else
            {
                labelCurrentUsername.Text = Login.UserName;
                textBox.Text = "";
            }
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            pictureBoxClosed.Visible = true;
            pictureBoxClose.Visible = false;
        }

        private void pictureBoxClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxClosed_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxClosed.Visible = false;
            pictureBoxClose.Visible = true;
        }
    }
}