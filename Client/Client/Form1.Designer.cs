namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_exit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_panel = new System.Windows.Forms.GroupBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.num_in_box = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_unfulfilled_orders = new System.Windows.Forms.NumericUpDown();
            this.num_in_req_box = new System.Windows.Forms.NumericUpDown();
            this.num_out_box = new System.Windows.Forms.NumericUpDown();
            this.num_out_req_box = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_stock = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tb_round = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_stock = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_unfulfilled_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_req_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_req_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(1438, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(124, 42);
            this.btn_exit.TabIndex = 29;
            this.btn_exit.Text = "Konec hry";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1181, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 37);
            this.label9.TabIndex = 32;
            this.label9.Text = "Skóre:";
            // 
            // tb_score
            // 
            this.tb_score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_score.Enabled = false;
            this.tb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_score.Location = new System.Drawing.Point(1287, 9);
            this.tb_score.Name = "tb_score";
            this.tb_score.ReadOnly = true;
            this.tb_score.Size = new System.Drawing.Size(104, 29);
            this.tb_score.TabIndex = 31;
            this.tb_score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1576, 840);
            this.tabControl1.TabIndex = 34;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox_panel);
            this.tabPage1.Controls.Add(this.pictureBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1568, 790);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hra";
            // 
            // groupBox_panel
            // 
            this.groupBox_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_panel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox_panel.Controls.Add(this.lbl_status);
            this.groupBox_panel.Controls.Add(this.label6);
            this.groupBox_panel.Controls.Add(this.lbl_role);
            this.groupBox_panel.Controls.Add(this.btn_send);
            this.groupBox_panel.Controls.Add(this.num_in_box);
            this.groupBox_panel.Controls.Add(this.label4);
            this.groupBox_panel.Controls.Add(this.num_unfulfilled_orders);
            this.groupBox_panel.Controls.Add(this.num_in_req_box);
            this.groupBox_panel.Controls.Add(this.num_out_box);
            this.groupBox_panel.Controls.Add(this.num_out_req_box);
            this.groupBox_panel.Controls.Add(this.label5);
            this.groupBox_panel.Controls.Add(this.pictureBox2);
            this.groupBox_panel.Controls.Add(this.pictureBox1);
            this.groupBox_panel.Controls.Add(this.label2);
            this.groupBox_panel.Controls.Add(this.label1);
            this.groupBox_panel.Controls.Add(this.num_stock);
            this.groupBox_panel.Controls.Add(this.label3);
            this.groupBox_panel.Controls.Add(this.pb_stock);
            this.groupBox_panel.Controls.Add(this.pictureBox4);
            this.groupBox_panel.Controls.Add(this.pictureBox5);
            this.groupBox_panel.Controls.Add(this.pictureBox3);
            this.groupBox_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_panel.Location = new System.Drawing.Point(90, 15);
            this.groupBox_panel.Name = "groupBox_panel";
            this.groupBox_panel.Size = new System.Drawing.Size(736, 372);
            this.groupBox_panel.TabIndex = 30;
            this.groupBox_panel.TabStop = false;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(5, 5);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(79, 25);
            this.lbl_status.TabIndex = 38;
            this.lbl_status.Text = "Status";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Přichozí láhve";
            // 
            // lbl_role
            // 
            this.lbl_role.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_role.ForeColor = System.Drawing.Color.White;
            this.lbl_role.Location = new System.Drawing.Point(312, 5);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(197, 37);
            this.lbl_role.TabIndex = 35;
            this.lbl_role.Text = "Hračská role";
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.AutoSize = true;
            this.btn_send.BackColor = System.Drawing.Color.Transparent;
            this.btn_send.Location = new System.Drawing.Point(284, 291);
            this.btn_send.Name = "btn_send";
            this.btn_send.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_send.Size = new System.Drawing.Size(222, 72);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Odeslat";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // num_in_box
            // 
            this.num_in_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.num_in_box.BackColor = System.Drawing.Color.LightGreen;
            this.num_in_box.Enabled = false;
            this.num_in_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_in_box.ForeColor = System.Drawing.Color.Black;
            this.num_in_box.Location = new System.Drawing.Point(601, 236);
            this.num_in_box.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_in_box.Name = "num_in_box";
            this.num_in_box.ReadOnly = true;
            this.num_in_box.Size = new System.Drawing.Size(109, 49);
            this.num_in_box.TabIndex = 24;
            this.num_in_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_in_box.ValueChanged += new System.EventHandler(this.num_in_box_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Požaduji";
            // 
            // num_unfulfilled_orders
            // 
            this.num_unfulfilled_orders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.num_unfulfilled_orders.BackColor = System.Drawing.Color.LightSalmon;
            this.num_unfulfilled_orders.Enabled = false;
            this.num_unfulfilled_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_unfulfilled_orders.ForeColor = System.Drawing.Color.Black;
            this.num_unfulfilled_orders.Location = new System.Drawing.Point(272, 208);
            this.num_unfulfilled_orders.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_unfulfilled_orders.Name = "num_unfulfilled_orders";
            this.num_unfulfilled_orders.ReadOnly = true;
            this.num_unfulfilled_orders.Size = new System.Drawing.Size(108, 49);
            this.num_unfulfilled_orders.TabIndex = 23;
            this.num_unfulfilled_orders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_in_req_box
            // 
            this.num_in_req_box.AutoSize = true;
            this.num_in_req_box.BackColor = System.Drawing.Color.LightSalmon;
            this.num_in_req_box.Enabled = false;
            this.num_in_req_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_in_req_box.ForeColor = System.Drawing.Color.Black;
            this.num_in_req_box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.num_in_req_box.Location = new System.Drawing.Point(41, 85);
            this.num_in_req_box.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_in_req_box.Name = "num_in_req_box";
            this.num_in_req_box.ReadOnly = true;
            this.num_in_req_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.num_in_req_box.Size = new System.Drawing.Size(108, 49);
            this.num_in_req_box.TabIndex = 25;
            this.num_in_req_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_in_req_box.ValueChanged += new System.EventHandler(this.num_in_req_box_ValueChanged);
            // 
            // num_out_box
            // 
            this.num_out_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.num_out_box.BackColor = System.Drawing.Color.Khaki;
            this.num_out_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_out_box.Location = new System.Drawing.Point(95, 236);
            this.num_out_box.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_out_box.Name = "num_out_box";
            this.num_out_box.Size = new System.Drawing.Size(108, 49);
            this.num_out_box.TabIndex = 21;
            this.num_out_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_out_box.ValueChanged += new System.EventHandler(this.num_out_box_ValueChanged);
            // 
            // num_out_req_box
            // 
            this.num_out_req_box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_out_req_box.BackColor = System.Drawing.Color.Khaki;
            this.num_out_req_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_out_req_box.Location = new System.Drawing.Point(585, 85);
            this.num_out_req_box.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_out_req_box.Name = "num_out_req_box";
            this.num_out_req_box.Size = new System.Drawing.Size(108, 49);
            this.num_out_req_box.TabIndex = 26;
            this.num_out_req_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 31);
            this.label5.TabIndex = 11;
            this.label5.Text = "Odchozí láhve";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sklad";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dluh";
            // 
            // num_stock
            // 
            this.num_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.num_stock.BackColor = System.Drawing.Color.LightGreen;
            this.num_stock.Enabled = false;
            this.num_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_stock.ForeColor = System.Drawing.Color.Black;
            this.num_stock.Location = new System.Drawing.Point(386, 208);
            this.num_stock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_stock.Name = "num_stock";
            this.num_stock.ReadOnly = true;
            this.num_stock.Size = new System.Drawing.Size(108, 49);
            this.num_stock.TabIndex = 22;
            this.num_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Požadavek";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.btn_exit);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1568, 790);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vývoj nákladů";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.chart1.BorderlineColor = System.Drawing.Color.MediumSeaGreen;
            chartArea5.AxisX.Interval = 2D;
            chartArea5.AxisX.LineWidth = 2;
            chartArea5.AxisX.Maximum = 50D;
            chartArea5.AxisX.Minimum = 0D;
            chartArea5.AxisY.LineWidth = 2;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(6, 62);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Celkové náklady";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1556, 722);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            title5.BackColor = System.Drawing.Color.Transparent;
            title5.BorderColor = System.Drawing.Color.Transparent;
            title5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title5.Name = "Vývoj celkových nákladů";
            this.chart1.Titles.Add(title5);
            // 
            // tb_round
            // 
            this.tb_round.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_round.Enabled = false;
            this.tb_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_round.Location = new System.Drawing.Point(1482, 10);
            this.tb_round.Name = "tb_round";
            this.tb_round.ReadOnly = true;
            this.tb_round.Size = new System.Drawing.Size(104, 29);
            this.tb_round.TabIndex = 33;
            this.tb_round.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(1396, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 37);
            this.label10.TabIndex = 34;
            this.label10.Text = "Kolo:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(560, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // pb_stock
            // 
            this.pb_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pb_stock.Image = ((System.Drawing.Image)(resources.GetObject("pb_stock.Image")));
            this.pb_stock.ImageLocation = "";
            this.pb_stock.Location = new System.Drawing.Point(394, 112);
            this.pb_stock.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.pb_stock.Name = "pb_stock";
            this.pb_stock.Size = new System.Drawing.Size(72, 87);
            this.pb_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_stock.TabIndex = 27;
            this.pb_stock.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.Image = global::Client.Properties.Resources.truck_with_bottles2;
            this.pictureBox4.Location = new System.Drawing.Point(11, 223);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(206, 106);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(520, 223);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(206, 106);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(276, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Silver;
            this.pictureBox.Image = global::Client.Properties.Resources.bg_41;
            this.pictureBox.Location = new System.Drawing.Point(2, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1495, 783);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 31;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.tb_round);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_score);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_panel.ResumeLayout(false);
            this.groupBox_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_unfulfilled_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_req_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_req_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tb_round;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox_panel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.NumericUpDown num_in_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_unfulfilled_orders;
        private System.Windows.Forms.NumericUpDown num_in_req_box;
        private System.Windows.Forms.NumericUpDown num_out_box;
        private System.Windows.Forms.NumericUpDown num_out_req_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pb_stock;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_status;
    }
}

