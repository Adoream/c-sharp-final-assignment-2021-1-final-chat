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
    public partial class ChatroomWindow : Form
    {
        private const int Port = 54545;
        private const string BroadcastAddress = "255.255.255.255";
        private readonly string _homePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        private string _privateKey;
        private string _publicKey;
        private UdpClient _receivingClient;

        private Thread _receivingThread;
        private UdpClient _sendingClient;

        private string _userName;

        public ChatroomWindow()
        {
            InitializeComponent();
        }

        private void ChatroomWindow_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Login.UserName))
            {
                _userName = Login.UserName;

                InitializeCert();
                InitializeSender();
                InitializeReceiver();
                InitializeListBox();
            }
        }

        private void buttonLeave_Click(object sender, EventArgs e)
        {
            Close();
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
            if (data.Mode == "message")
            {
                var text = data.Info.Sent + "\t" + data.Info.Username + "\n" + data.Info.Text + "\n\n";
                richTextBoxChat.Text += text;
            }

            if (data.Mode == "user-online")
            {
                listBox.Items.Add(data.Info.Username);

                var info = new InfoTemp
                {
                    Username = _userName,
                    Sent = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                };
                SendData("user-list", info);
            }

            if (data.Mode == "user-offline") listBox.Items.Remove(data.Info.Username);

            if (data.Mode == "user-list")
                if (!listBox.Items.Contains(data.Info.Username))
                    listBox.Items.Add(data.Info.Username);

            if (data.Mode == "private-message-exchange-1")
                if (data.Info.From != _userName)
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

            if (data.Mode == "private-message-exchange-2")
                File.WriteAllText(_homePath + "\\.chat\\" + data.Info.From + "_PublicKey", data.Info.PublicKey);

            if (data.Mode == "private-message")
                if (data.Info.To == _userName)
                {
                    var text = data.Info.Sent + "\t" + data.Info.From + "\t(" + data.Info.From + "->" + data.Info.To + ")\n" + Common.DecryptData(_privateKey, data.Info.Text) + "\n\n";
                    richTextBoxChat.Text += text;
                }
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

        private void buttonSend_Click(object sender, EventArgs e)
        {
            richTextBoxMessage.Text = richTextBoxMessage.Text.TrimEnd();
            if (!string.IsNullOrEmpty(richTextBoxMessage.Text))
            {
                var itemSelected = listBox.GetItemText(listBox.SelectedItem);
                if (itemSelected == "")
                {
                    var info = new InfoTemp
                    {
                        Text = richTextBoxMessage.Text,
                        Username = _userName,
                        Sent = DateTime.Now.ToString(CultureInfo.InvariantCulture)
                    };
                    SendData("message", info);
                    richTextBoxMessage.Text = "";
                }
                else
                {
                    var privateKey = File.ReadAllText(_homePath + "\\.chat\\" + itemSelected + "_PublicKey");
                    var info = new InfoTemp
                    {
                        Text = Common.EncryptData(privateKey, richTextBoxMessage.Text),
                        From = _userName,
                        Sent = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                        To = itemSelected
                    };
                    SendData("private-message", info);

                    richTextBoxChat.Text += info.Sent + "\t" + info.From + "\t(" + info.From + "->" + info.To + ")\n" + richTextBoxMessage.Text + "\n\n";
                    
                    richTextBoxMessage.Text = "";
                }
            }

            richTextBoxMessage.Focus();
        }

        private void listBox_MouseClick(object sender, MouseEventArgs e)
        {
            var listBoxIndex = listBox.IndexFromPoint(e.X, e.Y);
            listBox.SelectedIndex = listBoxIndex;
            if (listBoxIndex != -1)
            {
                var itemSelected = listBox.GetItemText(listBox.SelectedItem);
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

        private void Chat_FormClosing(object sender, EventArgs e)
        {
            _receivingClient.Close();
            _receivingThread.Abort();

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