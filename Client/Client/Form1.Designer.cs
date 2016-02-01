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
            this.textBox_chat = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(627, 12);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ReadOnly = true;
            this.textBox_log.Size = new System.Drawing.Size(153, 444);
            this.textBox_log.TabIndex = 0;
            // 
            // textBox_chat
            // 
            this.textBox_chat.Location = new System.Drawing.Point(12, 213);
            this.textBox_chat.Multiline = true;
            this.textBox_chat.Name = "textBox_chat";
            this.textBox_chat.ReadOnly = true;
            this.textBox_chat.Size = new System.Drawing.Size(609, 180);
            this.textBox_chat.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(74, 411);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Odeslat";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 468);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.textBox_chat);
            this.Controls.Add(this.textBox_log);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.TextBox textBox_chat;
        private System.Windows.Forms.Button btn_send;
    }
}

