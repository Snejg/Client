using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {

        private static readonly Socket _clientSocket = new Socket
        (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private static int _PORT;

        public Form1(int portNumber)
        {
            _PORT = portNumber;
            InitializeComponent();
        }

        private void ConnectToServer()
        {
            int attempts = 0;

            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    textBox_log.Text = "Connection attempt " + attempts;
                    //_clientSocket.Connect(IPAddress.Loopback, _PORT);
                    _clientSocket.Connect("192.168.1.2", _PORT);

                }
                catch (SocketException)
                {
                    textBox_log.Text = "";
                }
            }

            textBox_log.Text = "";
            textBox_log.AppendText("Connected \n");
            //backgroundWorker1.RunWorkerAsync();
        }

        private void RequestLoop()
        {
            textBox_log.AppendText(" type exit to properly disconnect client \n");

            while (true)
            {
                //SendRequest();
                //ReceiveResponse();
            }

        }

        private void Exit()
        {
            SendString("exit"); // Tell the server we re exiting
            _clientSocket.Shutdown(SocketShutdown.Both);
            _clientSocket.Close();
            Environment.Exit(0);
        }

        private void SendRequest()
        {
            textBox_log.AppendText("Send a request: next round \n");
            string request = "next round";
            SendString(request);

            if (request.ToLower() == "exit")
            {
                Exit();
            }
        }

        private void SendString(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private void ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = _clientSocket.Receive(buffer, SocketFlags.None);
            if (received == 0) return;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string text = Encoding.ASCII.GetString(data);

            this.textBox_log.Invoke(new MethodInvoker(delegate ()
            { textBox_log.AppendText(text + "\n"); }));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToServer();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            SendRequest();
            ReceiveResponse();
        }
    }
}
