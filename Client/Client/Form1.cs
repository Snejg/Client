using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {

        private static readonly Socket _clientSocket = new Socket
        (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static System.Timers.Timer waitingTimer = new System.Timers.Timer();

        private static int _PORT;
        private static int _ROLE;

        public Form1(int portNumber, int roleNumber)
        {
            _PORT = portNumber;
            _ROLE = roleNumber;
            InitializeComponent();
            
            waitingTimer.Interval = 1000;
            waitingTimer.Enabled = false;
            waitingTimer.Elapsed += OnTimedEvent;

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
            /*
            textBox_log.AppendText("Send a request: next round \n");
            string request = "next round";
            SendString(request);
            
            if (request.ToLower() == "exit")
            {
                Exit();
            }
            */

            Message m = new Message(_ROLE, (Int32)num_out_box.Value, (Int32)num_out_req_box.Value);
            byte[] buffer = m.getMessageByteArray();
            SendMessage(buffer);            

        }

        private void SendString(string text)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private void SendMessage(byte[] mes)
        {
            _clientSocket.Send(mes, 0, mes.Length, SocketFlags.None);
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

            if(text == "waiting")
            {
                waitingLoop();
            }
            else if (text == "new")
            {
                stopWaiting();
            }

        }

        private void waitingLoop()
        {
            waitingTimer.Enabled = true;
            waitingTimer.Start();
        }

        private void stopWaiting()
        {
            waitingTimer.Stop();
            waitingTimer.Enabled = false;            
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

        public struct Message
        {
            Int32 role;
            Int32 boxOut;
            Int32 boxReqOut;

            public Message(Int32 p_role, Int32 p_boxOut, Int32 p_boxReqOut)
            {
                role = p_role;
                boxOut = p_boxOut;
                boxReqOut = p_boxReqOut;
            }

            public byte[] getMessageByteArray()
            {
                byte[] data1 = BitConverter.GetBytes(role);
                byte[] data2 = BitConverter.GetBytes(boxOut);
                byte[] data3 = BitConverter.GetBytes(boxReqOut);

                byte[] data = new byte[data1.Length + data2.Length + data3.Length];
                Buffer.BlockCopy(data1, 0, data, 0, data1.Length);
                Buffer.BlockCopy(data2, 0, data, data1.Length, data2.Length);
                Buffer.BlockCopy(data3, 0, data, data1.Length + data2.Length, data3.Length);
                return data;
            }
        }

        private void waitingTimer_Tick(object sender, EventArgs e)
        {
            SendRequest();
            ReceiveResponse();
            textBox_log.AppendText("TICK \n");
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            SendRequest();
            ReceiveResponse();
        }
    }
}
