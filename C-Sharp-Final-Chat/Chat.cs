using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Windows.Forms;

namespace C_Sharp_Final_Chat
{
    public partial class Chat : Form
    {
        private const int Port = 54545;
        private const string BroadcastAddress = "255.255.255.255";
        private readonly string _homePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        
        private string _publicKey;
        private string _privateKey;

        private Thread _receivingThread;
        private UdpClient _sendingClient;
        private UdpClient _receivingClient;

        private string _userName;

        public Chat()
        {
            InitializeComponent();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            using (var login = new UserLogin())
            {
                login.ShowDialog();

                if (login.UserName == "")
                {
                    
                    Close();
                }
                else
                {
                    _userName = login.UserName;
                    InitializeCert();
                    Show();
                }
            }

            InitializeSender();
            InitializeReceiver();
            InitializeListBox();
        }

        private void InitializeSender()
        {
            _sendingClient = new UdpClient(BroadcastAddress, Port) {EnableBroadcast = true};
        }

        private void InitializeReceiver()
        {
            _receivingClient = new UdpClient(Port);

            ThreadStart start = Receiver;
            _receivingThread = new Thread(start) {IsBackground = true};
            _receivingThread.Start();
        }

        private void InitializeListBox()
        {
            var info = new InfoTemp
            {
                Username = _userName,
                Sent = DateTime.Now.ToString(CultureInfo.InvariantCulture)
            };
            SendData("user-online", info);
        }

        private void InitializeCert()
        {
            (_publicKey, _privateKey) = Common.GenerateRsaKeys();
            if (!Directory.Exists(_homePath + "\\.chat")) Directory.CreateDirectory(_homePath + "\\.chat");

            if (!File.Exists(_homePath + "\\.chat\\" + _userName + "_PublicKey") ||
                !File.Exists(_homePath + "\\.chat\\" + _userName + "_PrivateKey"))
            {
                File.WriteAllText(_homePath + "\\.chat\\" + _userName + "_PublicKey", _publicKey);
                File.WriteAllText(_homePath + "\\.chat\\" + _userName + "_PrivateKey", _privateKey);
            }
            else
            {
                _publicKey = File.ReadAllText(_homePath + "\\.chat\\" + _userName + "_PublicKey");
                _privateKey = File.ReadAllText(_homePath + "\\.chat\\" + _userName + "_PrivateKey");
            }
        }

        private void Receiver()
        {
            var endPoint = new IPEndPoint(IPAddress.Any, Port);
            AddMessage messageDelegate = DataReceived;

            while (true)
            {
                var data = _receivingClient.Receive(ref endPoint);
                var message = Encoding.ASCII.GetString(data);
                Invoke(messageDelegate, message);
            }
        }

        private void DataReceived(string data)
        {
            var dataSerializer = JsonSerializer.Deserialize<Data>(data);
            DataReceivedProcess(dataSerializer);
        }

        private void DataReceivedProcess(Data data)
        {
            if (data.Mode == "message") richTextBox1.Text += data.Info.Text + "\n";

            if (data.Mode == "user-online")
            {
                listBox1.Items.Add(data.Info.Username);

                var info = new InfoTemp
                {
                    Username = _userName,
                    Sent = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                };
                SendData("user-list", info);
            }

            if (data.Mode == "user-offline")
            {
                listBox1.Items.Remove(data.Info.Username);
            }

            if (data.Mode == "user-list")
                if (!listBox1.Items.Contains(data.Info.Username))
                    listBox1.Items.Add(data.Info.Username);

            if (data.Mode == "private-message-exchange-1")
                if (data.Info.From != _userName)
                {
                    var dialogResult = MessageBox.Show(data.Info.From + "正在请求私聊", data.Info.From + "正在请求私聊",
                        MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.WriteAllText(_homePath + "\\.chat\\" + data.Info.From + "_PublicKey", data.Info.PublicKey);
                        var info = new InfoTemp
                        {
                            PublicKey = _publicKey,
                            From = _userName,
                            Sent = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                            To = data.Info.From
                        };
                        SendData("private-message-exchange-2", info);
                    }
                }

            if (data.Mode == "private-message-exchange-2")
                File.WriteAllText(_homePath + "\\.chat\\" + data.Info.From + "_PublicKey", data.Info.PublicKey);

            if (data.Mode == "private-message")
                if (data.Info.To == _userName)
                    richTextBox1.Text += Common.DecryptData(_privateKey, data.Info.Text) + "\n";
        }

        private void SendData(string mode, InfoTemp info)
        {
            var data = new Data
            {
                Mode = mode,
                Info = info
            };
            var toSend = JsonSerializer.Serialize(data);
            var toSendData = Encoding.ASCII.GetBytes(toSend);
            _sendingClient.Send(toSendData, toSendData.Length);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.TrimEnd();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                var itemSelected = listBox1.GetItemText(listBox1.SelectedItem);
                if (itemSelected == "")
                {
                    var info = new InfoTemp
                    {
                        Text = textBox1.Text,
                        Username = _userName,
                        Sent = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                    };
                    SendData("message", info);
                    textBox1.Text = "";
                }
                else
                {
                    var PrivateKey = File.ReadAllText(_homePath + "\\.chat\\" + itemSelected + "_PublicKey");
                    var info = new InfoTemp
                    {
                        Text = Common.EncryptData(PrivateKey, textBox1.Text),
                        From = _userName,
                        Sent = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                        To = itemSelected
                    };
                    SendData("private-message", info);
                    textBox1.Text = "";
                }
            }

            textBox1.Focus();
        }

        private void listBox1_Click(object sender, MouseEventArgs e)
        {
            var listBoxIndex = listBox1.IndexFromPoint(e.X, e.Y);
            listBox1.SelectedIndex = listBoxIndex;
            if (listBoxIndex != -1)
            {
                var itemSelected = listBox1.GetItemText(listBox1.SelectedItem);
                if (itemSelected != _userName)
                {
                    var info = new InfoTemp
                    {
                        PublicKey = _publicKey,
                        From = _userName,
                        Sent = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                        To = itemSelected
                    };
                    SendData("private-message-exchange-1", info);
                }
            }
        }
        
        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(_userName))
            {
                var info = new InfoTemp
                {
                    Username = _userName,
                    Sent = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                };
                SendData("user-offline", info);
            }
        }

        private delegate void AddMessage(string message);
    }

    public class InfoTemp
    {
        public string Text { get; set; }
        public string Username { get; set; }
        public string Sent { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string PublicKey { get; set; }
    }

    public class Data
    {
        public string Mode { get; set; }
        public InfoTemp Info { get; set; }
    }
}