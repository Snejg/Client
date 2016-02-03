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

        private static Int32 _stock = 0;
        private static Int32 _stockArchive = 0;
        private static Int32 _unfulfilledOrders = 20;
        private static Int32 _unfulfilledOrdersArchive = 2;

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
                    _clientSocket.Connect("192.168.1.3", _PORT);

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
            //_stockArchive -= (Int32)num_out_box.Value;
            //resetStock((Int32)num_out_box.Value);

            int un_order = (int) num_unfulfilled_orders.Value;
            int stock = (int) num_stock.Value;
            updateCLientStockAndUnfulfilledOrders(un_order, stock);

            Message m = new Message(_ROLE, (Int32)num_out_box.Value, (Int32)num_out_req_box.Value, 500);
            byte[] buffer = m.getMessageByteArray();
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);

        }

        private void SendWaitingRequest()
        {
            Message m = new Message(_ROLE, 300, 300, 300);
            byte[] buffer = m.getMessageByteArray();
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private void loadConfigurationRequest()
        {
            Message m = new Message(_ROLE, 600, 600, 600);
            byte[] buffer = m.getMessageByteArray();
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private void SendString(string text) // zatim necham
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
            Int32 role = BitConverter.ToInt32(data, 0);
            Int32 boxInOut = BitConverter.ToInt32(data, 4);
            Int32 reqInOut = BitConverter.ToInt32(data, 8);
            Int32 roundCode = BitConverter.ToInt32(data, 12);

            //this.textBox_log.Invoke(new MethodInvoker(delegate ()
            //{ textBox_log.AppendText(text + "\n"); }));

            if (roundCode == 300) // start waiting
            {
                waitingLoop();
                this.textBox_log.Invoke(new MethodInvoker(delegate ()
                { textBox_log.AppendText("Waiting \n"); }));
            }
            else if (roundCode == 200) // new round
            {
                stopWaiting();
                EnableControls();

                this.textBox_log.Invoke(new MethodInvoker(delegate ()
                { textBox_log.AppendText("New \n"); }));

                this.textBox_log.Invoke(new MethodInvoker(delegate ()
                { num_in_req_box.Value = reqInOut; }));

                this.textBox_log.Invoke(new MethodInvoker(delegate ()
                { num_in_box.Value = boxInOut; }));


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

        private void disableControls()
        {            
            this.textBox_log.Invoke(new MethodInvoker(delegate ()
            { num_out_box.Value = 0; }));

            this.textBox_log.Invoke(new MethodInvoker(delegate ()
            { num_out_req_box.Value = 0; }));

            this.textBox_log.Invoke(new MethodInvoker(delegate ()
            { num_out_box.Enabled = false; }));

            this.textBox_log.Invoke(new MethodInvoker(delegate ()
            { num_out_req_box.Enabled = false; }));
        }

        private void EnableControls()
        {
            this.textBox_log.Invoke(new MethodInvoker(delegate ()
            { num_out_box.Enabled = true; }));

            this.textBox_log.Invoke(new MethodInvoker(delegate ()
            { num_out_req_box.Enabled = true; }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToServer();

            this.num_unfulfilled_orders.Invoke(new MethodInvoker(delegate ()
            { num_unfulfilled_orders.Value = _unfulfilledOrders; }));

            switch (_ROLE)
            {
                case 0:
                    this.textBox_log.Invoke(new MethodInvoker(delegate ()
                    { tb_role.Text = "Továrna"; }));
                    break;
                case 1:
                    this.textBox_log.Invoke(new MethodInvoker(delegate ()
                    { tb_role.Text = "Distributor"; }));
                    break;
                case 2:
                    this.textBox_log.Invoke(new MethodInvoker(delegate ()
                    { tb_role.Text = "Velko-obchodník"; }));
                    break;
                case 3:
                    this.textBox_log.Invoke(new MethodInvoker(delegate ()
                    { tb_role.Text = "Malo-obchodník"; }));
                    break;
                default:
                    this.textBox_log.Invoke(new MethodInvoker(delegate ()
                    { tb_role.Text = "Neznámá role"; }));
                    break;
            }
            loadConfigurationRequest();
            ReceiveResponse();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (num_out_box.Value != 0 && num_out_req_box.Value != 0 && checkCorrectMove())         
            {
                SendRequest();
                disableControls();
                ReceiveResponse();
            }
        }

        private void add2Stock(Int32 barrelCount)  // prichozi hodnota z boxIn
        {
            _stock += barrelCount;
            //_stockArchive = _stock;
            this.num_stock.Invoke(new MethodInvoker(delegate ()
            { num_stock.Value = _stock; }));
        }

        private void add2unOrders(Int32 barrelCount)  // prichozi hodnota z boxIn
        {
            _unfulfilledOrders += barrelCount;
            //_stockArchive = _stock;
            this.num_unfulfilled_orders.Invoke(new MethodInvoker(delegate ()
            { num_unfulfilled_orders.Value = _unfulfilledOrders; }));
        }

        /*
        private void resetStock(int val) // novy stav zasob pro dalsi kolo - VYMAZAT
        {
            _stock -= val;
            _stockArchive -= val;
            //_stock = _stockArchive;
        }
        
        private void removeFromStock(Int32 barrelCount) // pro zobrazeni - VYMAZAT
        {
            _stock -= barrelCount;
            if(_stock < 0)
            {
                _stock = 0;
            }
            this.num_stock.Invoke(new MethodInvoker(delegate ()
            { num_stock.Value = _stock; }));
            _stock = _stockArchive;
        }

        private void removeFromUnOrders(Int32 barrelCount, Int32 incomeOrder) // pro zobrazeni - VYMAZAT
        {   
            
            _unfulfilledOrders -= barrelCount;
            if (_unfulfilledOrders < 0)
            {
                _unfulfilledOrders = 0;
            }
            
            this.num_unfulfilled_orders.Invoke(new MethodInvoker(delegate ()
            { num_unfulfilled_orders.Value = _unfulfilledOrders + incomeOrder; }));
            //_unfulfilledOrders = _unfulfilledOrdersArchive;
        }
        */
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            SendWaitingRequest();
            ReceiveResponse();
        }
        
        private bool checkCorrectMove()
        {
            if(num_stock.Value == 0 || _unfulfilledOrders == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        

        private void updateCLientStockAndUnfulfilledOrders(Int32 un_orders, Int32 stock)
        {
            _unfulfilledOrders = un_orders;
            _stock = stock;
        }

        private void num_in_box_ValueChanged(object sender, EventArgs e)
        {
            add2Stock((Int32)num_in_box.Value);

            //this.num_unfulfilled_orders.Invoke(new MethodInvoker(delegate ()
            //{ num_unfulfilled_orders.Value = _unfulfilledOrders + (int)num_in_req_box.Value; }));
        }

        private void num_in_req_box_ValueChanged(object sender, EventArgs e)
        {
            add2unOrders((Int32)num_in_req_box.Value);
        }

        private void num_out_box_ValueChanged(object sender, EventArgs e)
        {
            int sumOfOrders = (int) num_unfulfilled_orders.Value; // suma pozadavku
            int stock = (int)num_stock.Value;
            int minValue = Math.Min(_stock, _unfulfilledOrders);

            if(minValue - (int) num_out_box.Value <= 0)
            {
                num_out_box.Value = minValue;
            }
            num_stock.Value = _stock;
            num_unfulfilled_orders.Value = _unfulfilledOrders;
            num_stock.Value -= num_out_box.Value;
            num_unfulfilled_orders.Value-= num_out_box.Value;

        }


        public struct Message
        {
            Int32 role;
            Int32 boxOut;
            Int32 boxReqOut;
            Int32 roundCode;

            public Message(Int32 p_role, Int32 p_boxOut, Int32 p_boxReqOut, Int32 p_roudCode)
            {
                role = p_role;
                boxOut = p_boxOut;
                boxReqOut = p_boxReqOut;
                roundCode = p_roudCode;
            }

            public byte[] getMessageByteArray()
            {
                byte[] data1 = BitConverter.GetBytes(role);
                byte[] data2 = BitConverter.GetBytes(boxOut);
                byte[] data3 = BitConverter.GetBytes(boxReqOut);
                byte[] data4 = BitConverter.GetBytes(roundCode);

                byte[] data = new byte[data1.Length + data2.Length + data3.Length + data3.Length];
                Buffer.BlockCopy(data1, 0, data, 0, data1.Length);
                Buffer.BlockCopy(data2, 0, data, data1.Length, data2.Length);
                Buffer.BlockCopy(data3, 0, data, data1.Length + data2.Length, data3.Length);
                Buffer.BlockCopy(data4, 0, data, data1.Length + data2.Length + data3.Length, data4.Length);
                return data;
            }
        }

    }
}
