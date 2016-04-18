using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
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

            //num_reqOut.Controls[0].Hide(); // hide arrows

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
                    //_clientSocket.Connect(IPAddress.Loopback, _PORT);
                    _clientSocket.Connect(_IP_ADDRESS, _PORT);
                    //_clientSocket.Connect("192.168.1.35", _PORT);
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
        
        private int stringToInt(string value)
        {
            return Int32.Parse(value);
        }

        private string intToString(int value)
        {
            return value.ToString();
        }

        private void SendRequest()
        {
            try
            {
                // pred odeslanim hodnot si upravim sklad a zakazky podle aktualni hodnoty v poli
                //int un_order = (int) num_unfulfilled_orders.Value;
                int un_order = (int)stringToInt(lbl_dluh.Text);
                //int stock = (int) num_stock.Value;
                int stock = (int)stringToInt(lbl_sklad.Text);
                //int customerRequest = (int)num_in_req_box.Value;
                int customerRequest = (int)stringToInt(lbl_reqIn.Text);
                updateCLientStockAndUnfulfilledOrders(un_order, stock);
                //add2CostSum();
                add2Chart(customerRequest);
                _roundNumber++;
                updateScore();

                //Message m = new Message(_ROLE, (Int32)stringToInt(lbl_boxOut.Text), (Int32)num_reqOut.Value, _stock,_unfulfilledOrders ,-500);
                Message m = new Message(_ROLE, (Int32)stringToInt(lbl_boxOut.Text), (Int32)stringToInt(lbl_reqOut.Text), _stock, _unfulfilledOrders, -500);
                byte[] buffer = m.getMessageByteArray();
                // vymazani vsech vstupnich poli (aby doslo ke zmene -> zavola se metoda)
                
                resetAllCells();
                //hideControls();
                
                //posladni dat serveru
                _clientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
                this.label2.Invoke(new MethodInvoker(delegate ()
                { label2.Text = "odeslano"; }));
            }
            catch(Exception e) // nastala chyba -> udelej log
            {
                this.label1.Invoke(new MethodInvoker(delegate ()
                { label1.Text = "chyba pri odeslani"; }));

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

            this.label3.Invoke(new MethodInvoker(delegate ()
            { label3.Text = "kod - " + roundCode.ToString(); }));

            if (roundCode == -300) // start waiting
            {
                //resetAllCells();
                hideControls();
                add2CostSum();

                this.label2.Invoke(new MethodInvoker(delegate ()
                { label2.Text = "data o cekani prijata"; }));
                waitingLoop(); // start timer

                //this.lbl_status.Invoke(new MethodInvoker(delegate ()
                //{ lbl_status.Text = "Čekáš na ostatní hráče"; }));

                //groupBox_panel.Visible = false;

            }
            else if (roundCode == -200) // new round
            {
                stopWaiting(); // stop timer 
                if (_ROLE < 0)
                {
                    setRole(role);
                }
                EnableControls();
                updateRound();
                updateScore();

                //this.lbl_status.Invoke(new MethodInvoker(delegate ()
                //{ lbl_status.Text = "Nové kolo"; }));
                showControls();
                /*
                this.num_in_req_box.Invoke(new MethodInvoker(delegate ()
                { num_in_req_box.Value = reqInOut; }));

                this.num_in_box.Invoke(new MethodInvoker(delegate ()
                { num_in_box.Value = boxInOut; }));
                */

                this.lbl_boxIn.Invoke(new MethodInvoker(delegate ()
                { lbl_boxIn.Text = intToString(boxInOut); }));

                this.lbl_reqIn.Invoke(new MethodInvoker(delegate ()
                { lbl_reqIn.Text = intToString(reqInOut); }));


            } else if (roundCode == -900) // close game
            {
                Exit();
            }else if(roundCode == -1000)
            {
                endGameOccur();
                this.tb_teamTotal.Invoke(new MethodInvoker(delegate ()
                { tb_teamTotal.Text = reqInOut.ToString() + " Kč"; }));

                this.tb_comparison.Invoke(new MethodInvoker(delegate ()
                { tb_comparison.Text = boxInOut.ToString() + " Kč"; }));
            }

            if (waitingTimer.Enabled == true)
            {
                label1.Text = "ANO";
            }
            else
            {
                label1.Text = "NE";
            }
        }

        void hideControls()
        {
            /*
            this.btn_send.Invoke(new MethodInvoker(delegate ()
            { btn_send.Visible = false; }));

            this.btn_increase.Invoke(new MethodInvoker(delegate ()
            { btn_increase.Visible = false; }));

            this.btn_decrease.Invoke(new MethodInvoker(delegate ()
            { btn_decrease.Visible = false; }));
            */

            this.gb_boxIn.Invoke(new MethodInvoker(delegate ()
            { gb_boxIn.Visible = false; }));

            this.gb_boxOut.Invoke(new MethodInvoker(delegate ()
            { gb_boxOut.Visible = false; }));

            this.gb_reqIn.Invoke(new MethodInvoker(delegate ()
            { gb_reqIn.Visible = false; }));

            this.gb_reqOut.Invoke(new MethodInvoker(delegate ()
            { gb_reqOut.Visible = false; }));

            this.gb_sklad.Invoke(new MethodInvoker(delegate ()
            { gb_sklad.Visible = false; }));

            this.gb_dluh.Invoke(new MethodInvoker(delegate ()
            { gb_dluh.Visible = false; }));

            this.lbl_status.Invoke(new MethodInvoker(delegate ()
            { lbl_status.Visible = true; }));
        }

        void showControls()
        {
            /*
            this.btn_send.Invoke(new MethodInvoker(delegate ()
            { btn_send.Visible = true; }));

            this.btn_increase.Invoke(new MethodInvoker(delegate ()
            { btn_increase.Visible = true; }));

            this.btn_decrease.Invoke(new MethodInvoker(delegate ()
            { btn_decrease.Visible = true; }));
            */

            Thread.Sleep(2000); // thread collector

            this.gb_boxIn.Invoke(new MethodInvoker(delegate ()
            { gb_boxIn.Visible = true; }));

            this.gb_boxOut.Invoke(new MethodInvoker(delegate ()
            { gb_boxOut.Visible = true; }));

            this.gb_reqIn.Invoke(new MethodInvoker(delegate ()
            { gb_reqIn.Visible = true; }));

            this.gb_sklad.Invoke(new MethodInvoker(delegate ()
            { gb_sklad.Visible = true; }));

            this.gb_dluh.Invoke(new MethodInvoker(delegate ()
            { gb_dluh.Visible = true; }));

            this.lbl_status.Invoke(new MethodInvoker(delegate ()
            { lbl_status.Visible = false; }));

            //Thread.Sleep(2000); // thread collector

            this.gb_reqOut.Invoke(new MethodInvoker(delegate ()
            { gb_reqOut.Visible = true; }));

            //this.btn_send.Invoke(new MethodInvoker(delegate ()
            //{ btn_send.Visible = false; }));

            //Thread.Sleep(2000); // thread collector

            //this.btn_send.Invoke(new MethodInvoker(delegate ()
            //{ btn_send.Visible = true; }));

        }

        private void setRole(int role)
        {
            if(role >=0 & role <= 10)
            {
                _ROLE = role;
            }          
        }

        private void waitingLoop()
        {
            if (waitingTimer.Enabled == false)
            {
                // waitingTimer.Enabled = true;
                waitingTimer.Stop();
                waitingTimer.Start();
            }
        }

        private void stopWaiting()
        {

            if ( waitingTimer.Enabled == true)
            {
                //waitingTimer.Enabled = false;
                waitingTimer.Stop();
            }       
        }

        private void disableControls()
        {
            /*         
            this.num_out_box.Invoke(new MethodInvoker(delegate ()
            { num_out_box.Value = 0; }));
           
            this.num_reqOut.Invoke(new MethodInvoker(delegate ()
            { num_reqOut.Value = 0; }));
            
            this.num_out_box.Invoke(new MethodInvoker(delegate ()
            { num_out_box.Enabled = false; }));

            this.num_reqOut.Invoke(new MethodInvoker(delegate ()
            { num_reqOut.Enabled = false; }));
            

            this.num_reqOut.Invoke(new MethodInvoker(delegate ()
            { num_reqOut.Enabled = false; }));

            this.num_reqOut.Invoke(new MethodInvoker(delegate ()
            { num_reqOut.Value = 1; }));
            */

            this.lbl_reqOut.Invoke(new MethodInvoker(delegate ()
            { lbl_reqOut.Text = intToString(1); }));

        }

        private void EnableControls()
        {
            /*
            this.num_out_box.Invoke(new MethodInvoker(delegate ()
            { num_out_box.Enabled = true; }));
            
            this.num_reqOut.Invoke(new MethodInvoker(delegate ()
            { num_reqOut.Enabled = true; }));
            */
        }

        private void setScreenLayout(int role)
        {
            switch (_ROLE)
            {
                case 0:
                    
                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Text = "Továrník"; }));

                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Location = new System.Drawing.Point(271, 0); }));


                    /*
                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Text = "Továrna"; }));
                    */

                    this.pictureBox.Invoke(new MethodInvoker(delegate ()
                    { pictureBox.Image = global::Client.Properties.Resources.final_back_role1; }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Location = new System.Drawing.Point(234, 224); }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Size = new System.Drawing.Size (681, 411); }));

                    break;

                case 1:
                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Text = "Distributor"; }));

                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Location = new System.Drawing.Point(260, 0); }));

                    this.pictureBox.Invoke(new MethodInvoker(delegate ()
                    { pictureBox.Image = global::Client.Properties.Resources.final_back_role21; }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Location = new System.Drawing.Point(12, 234); }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Size = new System.Drawing.Size(681, 411); }));
                    break;

                case 2:
                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Text = "Velko-obchodník"; }));

                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Location = new System.Drawing.Point(216, 0); }));

                    this.pictureBox.Invoke(new MethodInvoker(delegate ()
                    { pictureBox.Image = global::Client.Properties.Resources.final_back_role3; }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Location = new System.Drawing.Point(298, 2); }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Size = new System.Drawing.Size(681, 411); }));
                    break;

                case 3:
                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Text = "Malo-obchodník"; }));

                    this.lbl_role.Invoke(new MethodInvoker(delegate ()
                    { lbl_role.Location = new System.Drawing.Point(221, 0); }));

                    this.pictureBox.Invoke(new MethodInvoker(delegate ()
                    { pictureBox.Image = global::Client.Properties.Resources.final_back_role4; }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Location = new System.Drawing.Point(82, 2); }));

                    this.groupBox_panel.Invoke(new MethodInvoker(delegate ()
                    { groupBox_panel.Size = new System.Drawing.Size(681, 411); }));

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

            this.tab_endGame.Invoke(new MethodInvoker(delegate ()
            { tab_endGame.Text = ""; }));

            this.lbl_reqOut.Invoke(new MethodInvoker(delegate ()
            { lbl_reqOut.Text = "1"; }));
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            /*
            if (num_out_box.Value != 0 && num_reqOut.Value != 0 && checkCorrectMove())         
            {
                SendRequest();
                disableControls();
                ReceiveResponse();
            }
            */

            if (stringToInt(lbl_reqOut.Text) != 0 && checkCorrectMove())
            {
                //hideControls();
                //waitingTimer.Enabled = true;
                SendRequest();
                disableControls(); // nastaveni na 1 - predvolba
                ReceiveResponse();
            }


        }

        private void add2Stock(Int32 barrelCount)  // prichozi hodnota z boxIn
        {
            _stock += barrelCount;
            /*
            this.num_stock.Invoke(new MethodInvoker(delegate ()
            { num_stock.Value = _stock; }));*/
            this.lbl_sklad.Invoke(new MethodInvoker(delegate ()
            { lbl_sklad.Text = intToString(_stock); }));

        }

        private void add2unfulfilledOrders(Int32 barrelCount)  // prichozi hodnota z boxIn
        {
            /*
            _unfulfilledOrders += barrelCount;
            string uOrders = intToString(_unfulfilledOrders);
            this.num_unfulfilled_orders.Invoke(new MethodInvoker(delegate ()
            { num_unfulfilled_orders.Value = _unfulfilledOrders; }));
            */

            _unfulfilledOrders += barrelCount;
            string uOrders = intToString(_unfulfilledOrders);
            this.lbl_dluh.Invoke(new MethodInvoker(delegate ()
            { lbl_dluh.Text = uOrders; }));
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            SendWaitingRequest();
            ReceiveResponse();
        }
        
        private bool checkCorrectMove()
        {
            /*
            if(num_stock.Value == 0 || num_unfulfilled_orders.Value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }*/
            if (lbl_sklad.Text == "0" || lbl_dluh.Text == "0")
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
            /*
            num_in_box.Value = 0;
            num_out_box.Value = 0;
            num_in_req_box.Value = 0;
            num_reqOut.Value = 0;
            */
            lbl_boxIn.Text = "0";
            lbl_boxOut.Text = "0";
            lbl_reqIn.Text = "0";
            lbl_reqOut.Text = "0";
            //num_reqOut.Value = 1;
        }

        private void updateCLientStockAndUnfulfilledOrders(Int32 un_orders, Int32 stock)
        {
            _unfulfilledOrders = un_orders;
            _stock = stock;
        }

        private void lbl_boxIn_TextChanged(object sender, EventArgs e)
        {
            int inBox = stringToInt(lbl_boxIn.Text);
            add2Stock((Int32)inBox); // pridej prichozi barely a zobraz

            if (lbl_reqIn.Text != intToString(0))
            {
                setMaxBoxOut();
            }
            
        }

        private void lbl_reqIn_TextChanged(object sender, EventArgs e)
        {
            int inReq = stringToInt(lbl_reqIn.Text);
            add2unfulfilledOrders((Int32)inReq); // pridej prichozi barely a zobraz

            if (lbl_boxIn.Text != intToString(0))
            {
                setMaxBoxOut();
            }
        }
        /*
        // bude obsolete
        private void num_in_box_ValueChanged(object sender, EventArgs e) 
        {
            add2Stock((Int32)num_in_box.Value); // pridej prichozi barely a zobraz
        }
        // bude obsolete
        private void num_in_req_box_ValueChanged(object sender, EventArgs e)
        {
            add2unfulfilledOrders((Int32)num_in_req_box.Value); // pridej prichozi pozadavek a zobraz
        }
        // bude obsolete
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
        */

        private void setMaxBoxOut()
        {
            int sumOfOrders = stringToInt(lbl_dluh.Text); // suma pozadavku
            int stock = stringToInt(lbl_sklad.Text);
            int minValue = Math.Min(_stock, _unfulfilledOrders);

            string minVal = intToString(minValue);
            this.lbl_boxOut.Invoke(new MethodInvoker(delegate ()
            { lbl_boxOut.Text = minVal; }));

            int newOrders = sumOfOrders - minValue;
            int newStock = stock - minValue;

            this.lbl_sklad.Invoke(new MethodInvoker(delegate ()
            { lbl_sklad.Text = intToString(newStock); }));

            this.lbl_dluh.Invoke(new MethodInvoker(delegate ()
            { lbl_dluh.Text = intToString(newOrders); }));

            updateCLientStockAndUnfulfilledOrders(newOrders, newStock);

        }

        public struct Message
        {
            Int32 role;
            Int32 boxOut;
            Int32 boxReqOut;
            Int32 stock;
            Int32 u_orders;
            Int32 mess_Code;

            public Message(Int32 p_role, Int32 p_boxOut, Int32 p_boxReqOut, Int32 p_stock, Int32 p_orders, Int32 p_messCode)
            {
                role = p_role;
                boxOut = p_boxOut;
                boxReqOut = p_boxReqOut;
                stock = p_stock;
                u_orders = p_orders;
                mess_Code = p_messCode;
            }

            public byte[] getMessageByteArray()
            {
                byte[] data1 = BitConverter.GetBytes(role);
                byte[] data2 = BitConverter.GetBytes(boxOut);
                byte[] data3 = BitConverter.GetBytes(boxReqOut);
                byte[] data4 = BitConverter.GetBytes(stock);
                byte[] data5 = BitConverter.GetBytes(u_orders);
                byte[] data6 = BitConverter.GetBytes(mess_Code);

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
            this.tb_round.Invoke(new MethodInvoker(delegate ()
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

        private void endGameOccur()
        {
            _endGame = true;
            //tab_main.SelectedTab = tab_endGame;
            this.tab_main.Invoke(new MethodInvoker(delegate ()
            { tab_main.SelectedTab = tab_endGame; }));

            this.tab_endGame.Invoke(new MethodInvoker(delegate ()
            { tab_endGame.Text = "Výsledek hry"; }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            endGameOccur();
        }

        private void btn_decrease_Click(object sender, EventArgs e)
        {
            /*
            if(num_reqOut.Value > num_reqOut.Minimum)
            {
                num_reqOut.Value--;
            }
            */
            if(stringToInt(lbl_reqOut.Text) > 1)
            {
                int val = stringToInt(lbl_reqOut.Text);
                val--;
                lbl_reqOut.Text = intToString(val);
            }
        }

        private void btn_increase_Click(object sender, EventArgs e)
        {
            /*
            if (num_reqOut.Value < num_reqOut.Maximum)
            {
                num_reqOut.Value++;
            }
            */

            if (stringToInt(lbl_reqOut.Text) < 1000)
            {
                int val = stringToInt(lbl_reqOut.Text);
                val++;
                lbl_reqOut.Text = intToString(val);
            }
        }
    }
}
