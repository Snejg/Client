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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_role = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.num_unfulfilled_orders = new System.Windows.Forms.NumericUpDown();
            this.num_in_box = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_stock = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_out_req_box = new System.Windows.Forms.NumericUpDown();
            this.num_out_box = new System.Windows.Forms.NumericUpDown();
            this.btn_send = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.num_in_req_box = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_unfulfilled_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_req_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_req_box)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_log.Location = new System.Drawing.Point(410, 16);
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.Size = new System.Drawing.Size(235, 29);
            this.textBox_log.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Role:";
            // 
            // tb_role
            // 
            this.tb_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_role.Location = new System.Drawing.Point(63, 16);
            this.tb_role.Name = "tb_role";
            this.tb_role.ReadOnly = true;
            this.tb_role.Size = new System.Drawing.Size(235, 29);
            this.tb_role.TabIndex = 28;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(711, 6);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(138, 39);
            this.btn_exit.TabIndex = 29;
            this.btn_exit.Text = "Konec hry";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Status:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(705, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Skóre:";
            // 
            // tb_score
            // 
            this.tb_score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_score.Location = new System.Drawing.Point(772, 16);
            this.tb_score.Name = "tb_score";
            this.tb_score.ReadOnly = true;
            this.tb_score.Size = new System.Drawing.Size(89, 29);
            this.tb_score.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.tb_score);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_role);
            this.groupBox1.Controls.Add(this.textBox_log);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 57);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 450);
            this.tabControl1.TabIndex = 34;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.btn_exit);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(857, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vývoj nákladů";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Interval = 2D;
            chartArea2.AxisX.LineWidth = 2;
            chartArea2.AxisX.Maximum = 50D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.LineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 62);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Celkové náklady";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(843, 344);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Name = "Vývoj celkových nákladů";
            this.chart1.Titles.Add(title2);
            // 
            // num_unfulfilled_orders
            // 
            this.num_unfulfilled_orders.Enabled = false;
            this.num_unfulfilled_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_unfulfilled_orders.Location = new System.Drawing.Point(319, 285);
            this.num_unfulfilled_orders.Name = "num_unfulfilled_orders";
            this.num_unfulfilled_orders.ReadOnly = true;
            this.num_unfulfilled_orders.Size = new System.Drawing.Size(221, 49);
            this.num_unfulfilled_orders.TabIndex = 23;
            // 
            // num_in_box
            // 
            this.num_in_box.Enabled = false;
            this.num_in_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_in_box.Location = new System.Drawing.Point(598, 285);
            this.num_in_box.Name = "num_in_box";
            this.num_in_box.ReadOnly = true;
            this.num_in_box.Size = new System.Drawing.Size(221, 49);
            this.num_in_box.TabIndex = 24;
            this.num_in_box.ValueChanged += new System.EventHandler(this.num_in_box_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Odchozí  požadavek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Počet beden na skladě";
            // 
            // num_stock
            // 
            this.num_stock.Enabled = false;
            this.num_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_stock.Location = new System.Drawing.Point(319, 154);
            this.num_stock.Name = "num_stock";
            this.num_stock.ReadOnly = true;
            this.num_stock.Size = new System.Drawing.Size(221, 49);
            this.num_stock.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nesplněné zakázky";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Počet odhcozích beden";
            // 
            // num_out_req_box
            // 
            this.num_out_req_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_out_req_box.Location = new System.Drawing.Point(598, 154);
            this.num_out_req_box.Name = "num_out_req_box";
            this.num_out_req_box.Size = new System.Drawing.Size(221, 49);
            this.num_out_req_box.TabIndex = 26;
            // 
            // num_out_box
            // 
            this.num_out_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_out_box.Location = new System.Drawing.Point(18, 285);
            this.num_out_box.Name = "num_out_box";
            this.num_out_box.Size = new System.Drawing.Size(221, 49);
            this.num_out_box.TabIndex = 21;
            this.num_out_box.ValueChanged += new System.EventHandler(this.num_out_box_ValueChanged);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(18, 369);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(801, 37);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Odeslat";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(593, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Počet příchozích beden";
            // 
            // num_in_req_box
            // 
            this.num_in_req_box.Enabled = false;
            this.num_in_req_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_in_req_box.Location = new System.Drawing.Point(18, 154);
            this.num_in_req_box.Name = "num_in_req_box";
            this.num_in_req_box.ReadOnly = true;
            this.num_in_req_box.Size = new System.Drawing.Size(221, 49);
            this.num_in_req_box.TabIndex = 25;
            this.num_in_req_box.ValueChanged += new System.EventHandler(this.num_in_req_box_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Příchozí požadavek";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.num_in_req_box);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.num_unfulfilled_orders);
            this.tabPage1.Controls.Add(this.btn_send);
            this.tabPage1.Controls.Add(this.num_in_box);
            this.tabPage1.Controls.Add(this.num_out_box);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.num_out_req_box);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.num_stock);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(857, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hra";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(889, 537);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_unfulfilled_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_req_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_req_box)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_role;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_in_req_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_unfulfilled_orders;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.NumericUpDown num_in_box;
        private System.Windows.Forms.NumericUpDown num_out_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_out_req_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_stock;
        private System.Windows.Forms.Label label1;
    }
}

