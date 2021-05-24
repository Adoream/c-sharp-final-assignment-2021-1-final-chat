using System;
using System.Globalization;
using System.Windows.Forms;

namespace C_Sharp_Final_Chat
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        public string UserName { get; private set; } = "";

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserName = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserName = textBox1.Text;

            if (string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("Please select a user name up to 32 characters.");
                return;
            }

            FormClosing -= LoginForm_FormClosing;
            Close();
        }
    }
}