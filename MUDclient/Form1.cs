using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MUDclient
{
    public partial class Form1 : Form
    {
        private TcpClient _client;
        private NetworkStream _stream;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToServer("3scapes.org", 3200);
        }

        private void ConnectToServer(string server, int port)
        {
            try
            {
                _client = new TcpClient(server, port);
                _stream = _client.GetStream();
                AppendMessage($"Connected to {server}:{port}");

                Thread receiveThread = new Thread(ReceiveMessages);
                receiveThread.IsBackground = true;
                receiveThread.Start();
            }
            catch (Exception ex)
            {
                AppendMessage($"Error: {ex.Message}");
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];

            while (true)
            {
                try
                {
                    int bytesRead = _stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        AppendMessage(message);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    AppendMessage($"Error: {ex.Message}");
                    break;
                }
            }
        }

        private void AppendMessage(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendMessage), message);
            }
            else
            {
                messageDisplayTextBox.AppendText(message + Environment.NewLine);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = commandInputTextBox.Text;
            SendMessage(message);
            commandInputTextBox.Clear();
        }

        private void SendMessage(string message)
        {
            if (_stream != null)
            {
                byte[] data = Encoding.UTF8.GetBytes(message + "\n");
                _stream.Write(data, 0, data.Length);
            }
        }
    }