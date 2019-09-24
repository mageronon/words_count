namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.connect_btn = new System.Windows.Forms.Button();
            this.send_btn = new System.Windows.Forms.Button();
            this.Host = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.port_txt = new System.Windows.Forms.TextBox();
            this.host_txt = new System.Windows.Forms.TextBox();
            this.text_send = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.open_file_btn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.name = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(480, 66);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(75, 23);
            this.connect_btn.TabIndex = 0;
            this.connect_btn.Text = "Connect";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(480, 220);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 1;
            this.send_btn.Text = "Send";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.Send_btn_Click);
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(96, 69);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(35, 13);
            this.Host.TabIndex = 2;
            this.Host.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // port_txt
            // 
            this.port_txt.Location = new System.Drawing.Point(355, 66);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(100, 20);
            this.port_txt.TabIndex = 4;
            this.port_txt.Text = "8888";
            // 
            // host_txt
            // 
            this.host_txt.Location = new System.Drawing.Point(155, 66);
            this.host_txt.Name = "host_txt";
            this.host_txt.Size = new System.Drawing.Size(100, 20);
            this.host_txt.TabIndex = 5;
            this.host_txt.Text = "127.0.0.1";
            // 
            // text_send
            // 
            this.text_send.Location = new System.Drawing.Point(99, 117);
            this.text_send.Multiline = true;
            this.text_send.Name = "text_send";
            this.text_send.Size = new System.Drawing.Size(370, 300);
            this.text_send.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // open_file_btn
            // 
            this.open_file_btn.Location = new System.Drawing.Point(632, 383);
            this.open_file_btn.Name = "open_file_btn";
            this.open_file_btn.Size = new System.Drawing.Size(75, 23);
            this.open_file_btn.TabIndex = 7;
            this.open_file_btn.Text = "Open File";
            this.open_file_btn.UseVisualStyleBackColor = true;
            this.open_file_btn.Click += new System.EventHandler(this.Open_file_btn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(527, 140);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(115, 20);
            this.name.TabIndex = 9;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.name);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.open_file_btn);
            this.Controls.Add(this.text_send);
            this.Controls.Add(this.host_txt);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.connect_btn);
            this.Name = "Client";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Client_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox port_txt;
        private System.Windows.Forms.TextBox host_txt;
        private System.Windows.Forms.TextBox text_send;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button open_file_btn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox name;
    }
}

