﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {

        private static readonly Socket _clientSocket = new Socket
        (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static System.Timers.Timer waitingTimer = new System.Timers.Timer();

        private static int _PORT;
        private static int _ROLE = -2;
        private static string _IP_ADDRESS;
        private static int _costSum = 0;
        private static int _roundNumber = 1;

        private static Int32 _stock = 0;
        private static Int32 _unfulfilledOrders = 0;

        private static bool _endGame = false;

        public Form1(int portNumber, string ipAddress)
        {
            _PORT = portNumber;
            _IP_ADDRESS = ipAddress;
            InitializeComponent();
            
            waitingTimer.Interval = 1000;
            waitingTimer.Enabled = false;
            waitingTimer.Elapsed += OnTimedEvent;
        }

        private void ConnectToServer()
        {
            while (!_clientSocket.Connected)
            {
                try
                {
                    _clientSocket.Connect(IPAddress.Loopback, _PORT);
                    //_clientSocket.Connect("192.168.1.3", _PORT);
                }
                catch (SocketException)
                {
                    //textBox_log.Text = "";
                }
            }
            //textBox_log.AppendText("Connected \n");
        }
        
        private void Exit() 
        {           
            _clientSocket.Shutdown(SocketShutdown.Both);
            _clientSocket.Close();
            Environment.Exit(0);
        }
        

        private void SendRequest()
        {
            try
            {            
                // pred odeslanim hodnot si upravim sklad a zakazky podle aktualni hodnoty v poli
                int un_order = (int) num_unfulfilled_orders.Value;
                int stock = (int) num_stock.Value;
                int customerRequest = (int)num_in_req_box.Value;
                updateCLientStockAndUnfulfilledOrders(un_order, stock);
                add2CostSum();
                add2Chart(customerRequest);
                _roundNumber++;
                updateScore();            

                Message m = new Message(_ROLE, (Int32)num_out_box.Value, (Int32)num_out_req_box.Value, _stock,_unfulfilledOrders ,-500);
                byte[] buffer = m.getMessageByteArray();
                // vymazani vsech vstupnich poli (aby doslo ke zmene -> zavola se metoda)
                resetAllCells();
                //posladni dat serveru
                _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
            }
            catch(Exception e) // nastala chyba -> udelej log
            {
                if (!_clientSocket.Connected)
                {
                    Console.WriteLine("Vypadlo internetove spojeni");
                    Environment.Exit(666);
                }
            }
        }

        private void SendWaitingRequest()
        {
            Message m = new Message(_ROLE, 300, 300,300,300,-300);
            byte[] buffer = m.getMessageByteArray();
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private void loadConfigurationRequest()
        {
            Message m = new Message(_ROLE, 600, 600, 600, 600, -600);
            byte[] buffer = m.getMessageByteArray();
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        /*
        private void SendString(string text) // zatim necham
        {
            byte[] buffer = Encoding.ASCII.GetBytes(text);
            _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }
        */
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

            if (roundCode == -300) // start waiting
            {
                waitingLoop();

                this.lbl_status.Invoke(new MethodInvoker(delegate ()
                { lbl_status.Text = "(Čekáš na ostatní hráče)"; }));


            }
            else if (roundCode == -200) // new round
            {
                stopWaiting();
                setRole(role);            
                EnableControls();
                updateRound();
                updateScore();

                this.lbl_status.Invoke(new MethodInvoker(delegate ()
                { lbl_status.Text = "(Nové kolo)"; }));

                this.num_in_req_box.Invoke(new MethodInvoker(delegate ()
                { num_in_req_box.Value = reqInOut; }));

                this.num_in_box.Invoke(new MethodInvoker(delegate ()
                { num_in_box.Value = boxInOut; }));

            } else if (roundCode == -900) // close game
            {
                Exit();
            }
        }

        private void setRole(int role)
        {
            if(role >=0 & role <= 3)
            {
                _ROLE = role;
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
            this.num_out_box.Invoke(new MethodInvoker(delegate ()
            { num_out_box.Value = 0; }));

            this.num_out_req_box.Invoke(new MethodInvoker(delegate ()
            { num_out_req_box.Value = 0; }));

            this.num_out_box.Invoke(new MethodInvoker(delegate ()
            { num_out_box.Enabled = false; }));

            this.num_out_req_box.Invoke(new MethodInvoker(delegate ()
            { num_out_req_box.Enabled = false; }));
        }

        private void EnableControls()
        {
            this.num_out_box.Invoke(new MethodInvoker(delegate ()
            { num_out_box.Enabled = true; }));

            this.num_out_req_box.Invoke(new MethodInvoker(delegate ()
            { num_out_req_box.Enabled = true; }));
        }

        private void setScreenLayout(int role)
        {
            switch (_ROLE)
            {
                case 0:
                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Text = "Továrna"; }));

                    this.pictureBox.Invoke(new MethodInvoker(delegate ()
                    { pictureBox.Image = global::Client.Properties.Resources.bg_14; }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Location = new System.Drawing.Point(727,380); }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Size = new System.Drawing.Size (760, 358); }));

                    break;

                case 1:
                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Text = "Distributor"; }));
                    this.pictureBox.Invoke(new MethodInvoker(delegate ()
                    { pictureBox.Image = global::Client.Properties.Resources.bg_22; }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Location = new System.Drawing.Point(79, 382); }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Size = new System.Drawing.Size(736, 358); }));
                    break;

                case 2:
                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Text = "Velko-obchodník"; }));
                    this.pictureBox.Invoke(new MethodInvoker(delegate ()
                    { pictureBox.Image = global::Client.Properties.Resources.bg_3; }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Location = new System.Drawing.Point(696, 217); }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Size = new System.Drawing.Size(736, 358); }));
                    break;

                case 3:
                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Text = "Malo-obchodník"; }));
                    this.pictureBox.Invoke(new MethodInvoker(delegate ()
                    { pictureBox.Image = global::Client.Properties.Resources.bg_41; }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Location = new System.Drawing.Point(90, 15); }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Size = new System.Drawing.Size(736, 372); }));

                    break;
                default:
                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Text = "Neznámá role"; }));
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectToServer(); // pripojeni k serveru
            add2CostSum();     // nacti si aktualni stav nakladu
            
            //num_in_req_box.Controls[0].Hide();

            /*
            this.num_unfulfilled_orders.Invoke(new MethodInvoker(delegate ()
            { num_unfulfilled_orders.Value = _unfulfilledOrders; }));
            */
            loadConfigurationRequest();
            ReceiveResponse();
            setScreenLayout(_ROLE);
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
            this.num_stock.Invoke(new MethodInvoker(delegate ()
            { num_stock.Value = _stock; }));
        }

        private void add2unfulfilledOrders(Int32 barrelCount)  // prichozi hodnota z boxIn
        {
            _unfulfilledOrders += barrelCount;
            this.num_unfulfilled_orders.Invoke(new MethodInvoker(delegate ()
            { num_unfulfilled_orders.Value = _unfulfilledOrders; }));
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            SendWaitingRequest();
            ReceiveResponse();
        }
        
        private bool checkCorrectMove()
        {
            if(num_stock.Value == 0 || num_unfulfilled_orders.Value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }        

        private void resetAllCells()
        {
            num_in_box.Value = 0;
            num_out_box.Value = 0;
            num_in_req_box.Value = 0;
            num_out_req_box.Value = 0;
        }

        private void updateCLientStockAndUnfulfilledOrders(Int32 un_orders, Int32 stock)
        {
            _unfulfilledOrders = un_orders;
            _stock = stock;
        }

        private void num_in_box_ValueChanged(object sender, EventArgs e)
        {
            add2Stock((Int32)num_in_box.Value); // pridej prichozi barely a zobraz
        }

        private void num_in_req_box_ValueChanged(object sender, EventArgs e)
        {
            add2unfulfilledOrders((Int32)num_in_req_box.Value); // pridej prichozi pozadavek a zobraz
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
            Int32 stock;
            Int32 u_orders;
            Int32 roundCode;

            public Message(Int32 p_role, Int32 p_boxOut, Int32 p_boxReqOut, Int32 p_stock, Int32 p_orders, Int32 p_roudCode)
            {
                role = p_role;
                boxOut = p_boxOut;
                boxReqOut = p_boxReqOut;
                stock = p_stock;
                u_orders = p_orders;
                roundCode = p_roudCode;
            }

            public byte[] getMessageByteArray()
            {
                byte[] data1 = BitConverter.GetBytes(role);
                byte[] data2 = BitConverter.GetBytes(boxOut);
                byte[] data3 = BitConverter.GetBytes(boxReqOut);
                byte[] data4 = BitConverter.GetBytes(stock);
                byte[] data5 = BitConverter.GetBytes(u_orders);
                byte[] data6 = BitConverter.GetBytes(roundCode);

                byte[] data = new byte[data1.Length + data2.Length + data3.Length + data3.Length + data4.Length + data5.Length + data6.Length];
                Buffer.BlockCopy(data1, 0, data, 0, data1.Length);
                Buffer.BlockCopy(data2, 0, data, data1.Length, data2.Length);
                Buffer.BlockCopy(data3, 0, data, data1.Length + data2.Length, data3.Length);
                Buffer.BlockCopy(data4, 0, data, data1.Length + data2.Length + data3.Length, data4.Length);
                Buffer.BlockCopy(data5, 0, data, data1.Length + data2.Length + data3.Length + data4.Length, data5.Length);
                Buffer.BlockCopy(data6, 0, data, data1.Length + data2.Length + data3.Length + data4.Length + data5.Length, data6.Length);
                return data;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);            
        }

        private void add2CostSum()
        {
            int costOfStock = (int) _stock * 50;
            int costOfunOrders = (int) _unfulfilledOrders * 100;
            _costSum = _costSum + costOfStock + costOfunOrders;
        }

        private void add2Chart(int customerRequest)
        {
            chart1.Series["Celkové náklady"].Points.AddXY
                            (_roundNumber, _costSum);
            chart2.Series["Vývoj požadavků"].Points.AddXY
                (_roundNumber, customerRequest);
        }

        private void updateScore()
        {
            this.tb_score.Invoke(new MethodInvoker(delegate ()
            { tb_score.Text = _costSum.ToString(); }));
        }

        private void updateRound()
        {
            this.tb_score.Invoke(new MethodInvoker(delegate ()
            { tb_round.Text = _roundNumber.ToString(); }));
        }

        private void tab_main_Selecting(object sender, TabControlCancelEventArgs e) // blokovani tabu 
        {
            switch (_endGame)
            {
                case true: // je konec hry
                    if ((this.tab_main.SelectedTab == tabPage1) || (this.tab_main.SelectedTab == tabPage2))
                    {
                        e.Cancel = true;
                    }
                    break;
                case false: // neni konec hry
                    if (this.tab_main.SelectedTab == tab_endGame)
                    {
                        e.Cancel = true;
                    }
                    break;
            }

        }
    }
}
