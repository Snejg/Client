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
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num_out_box = new System.Windows.Forms.NumericUpDown();
            this.num_stock = new System.Windows.Forms.NumericUpDown();
            this.num_unfulfilled_orders = new System.Windows.Forms.NumericUpDown();
            this.num_in_box = new System.Windows.Forms.NumericUpDown();
            this.num_in_req_box = new System.Windows.Forms.NumericUpDown();
            this.num_out_req_box = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_unfulfilled_orders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_req_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_req_box)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(411, 12);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.Size = new System.Drawing.Size(202, 335);
            this.textBox_log.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(31, 310);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(357, 37);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Odeslat";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nesplněné zakázky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Počet beden na skladě";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Příchozí požadavek";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Odchozí  požadavek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Počet odhcozích beden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Počet příchozích beden";
            // 
            // num_out_box
            // 
            this.num_out_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_out_box.Location = new System.Drawing.Point(31, 242);
            this.num_out_box.Name = "num_out_box";
            this.num_out_box.Size = new System.Drawing.Size(102, 49);
            this.num_out_box.TabIndex = 21;
            // 
            // num_stock
            // 
            this.num_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_stock.Location = new System.Drawing.Point(158, 134);
            this.num_stock.Name = "num_stock";
            this.num_stock.ReadOnly = true;
            this.num_stock.Size = new System.Drawing.Size(97, 49);
            this.num_stock.TabIndex = 22;
            // 
            // num_unfulfilled_orders
            // 
            this.num_unfulfilled_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_unfulfilled_orders.Location = new System.Drawing.Point(158, 242);
            this.num_unfulfilled_orders.Name = "num_unfulfilled_orders";
            this.num_unfulfilled_orders.ReadOnly = true;
            this.num_unfulfilled_orders.Size = new System.Drawing.Size(97, 49);
            this.num_unfulfilled_orders.TabIndex = 23;
            // 
            // num_in_box
            // 
            this.num_in_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_in_box.Location = new System.Drawing.Point(284, 242);
            this.num_in_box.Name = "num_in_box";
            this.num_in_box.ReadOnly = true;
            this.num_in_box.Size = new System.Drawing.Size(104, 49);
            this.num_in_box.TabIndex = 24;
            // 
            // num_in_req_box
            // 
            this.num_in_req_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_in_req_box.Location = new System.Drawing.Point(31, 134);
            this.num_in_req_box.Name = "num_in_req_box";
            this.num_in_req_box.ReadOnly = true;
            this.num_in_req_box.Size = new System.Drawing.Size(102, 49);
            this.num_in_req_box.TabIndex = 25;
            // 
            // num_out_req_box
            // 
            this.num_out_req_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.num_out_req_box.Location = new System.Drawing.Point(284, 134);
            this.num_out_req_box.Name = "num_out_req_box";
            this.num_out_req_box.Size = new System.Drawing.Size(104, 49);
            this.num_out_req_box.TabIndex = 26;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 357);
            this.Controls.Add(this.num_out_req_box);
            this.Controls.Add(this.num_in_req_box);
            this.Controls.Add(this.num_in_box);
            this.Controls.Add(this.num_unfulfilled_orders);
            this.Controls.Add(this.num_stock);
            this.Controls.Add(this.num_out_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBox_log);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_out_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_unfulfilled_orders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_in_req_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_out_req_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_out_box;
        private System.Windows.Forms.NumericUpDown num_stock;
        private System.Windows.Forms.NumericUpDown num_unfulfilled_orders;
        private System.Windows.Forms.NumericUpDown num_in_box;
        private System.Windows.Forms.NumericUpDown num_in_req_box;
        private System.Windows.Forms.NumericUpDown num_out_req_box;
    }
}

