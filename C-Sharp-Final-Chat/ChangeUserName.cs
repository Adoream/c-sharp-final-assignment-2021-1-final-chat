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
            if (!string.IsNullOrEmpty(Login.UserName)) label.Text = Login.UserName;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Login.UserName = textBox.Text;
            label.Text = Login.UserName;
            textBox.Text = "";
        }
    }
}