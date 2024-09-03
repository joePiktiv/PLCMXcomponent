namespace PLCM
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
            this.btn_connect = new System.Windows.Forms.Button();
            this.label_ip = new System.Windows.Forms.Label();
            this.label_port = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_sn = new System.Windows.Forms.TextBox();
            this.label_sn = new System.Windows.Forms.Label();
            this.txt_device = new System.Windows.Forms.TextBox();
            this.label_device = new System.Windows.Forms.Label();
            this.btn_write = new System.Windows.Forms.Button();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.label_value = new System.Windows.Forms.Label();
            this.btn_read = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.ForeColor = System.Drawing.Color.Black;
            this.btn_connect.Location = new System.Drawing.Point(82, 151);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(256, 47);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "button1";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label_ip
            // 
            this.label_ip.Location = new System.Drawing.Point(82, 40);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(100, 23);
            this.label_ip.TabIndex = 1;
            this.label_ip.Text = "IP:";
            // 
            // label_port
            // 
            this.label_port.Location = new System.Drawing.Point(82, 74);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(100, 23);
            this.label_port.TabIndex = 2;
            this.label_port.Text = "Port;";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(148, 37);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(190, 20);
            this.txt_ip.TabIndex = 3;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(148, 71);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(190, 20);
            this.txt_port.TabIndex = 4;
            // 
            // txt_sn
            // 
            this.txt_sn.Location = new System.Drawing.Point(148, 109);
            this.txt_sn.Name = "txt_sn";
            this.txt_sn.Size = new System.Drawing.Size(190, 20);
            this.txt_sn.TabIndex = 6;
            // 
            // label_sn
            // 
            this.label_sn.Location = new System.Drawing.Point(82, 112);
            this.label_sn.Name = "label_sn";
            this.label_sn.Size = new System.Drawing.Size(100, 23);
            this.label_sn.TabIndex = 5;
            this.label_sn.Text = "Station No:";
            // 
            // txt_device
            // 
            this.txt_device.Location = new System.Drawing.Point(148, 265);
            this.txt_device.Name = "txt_device";
            this.txt_device.Size = new System.Drawing.Size(190, 20);
            this.txt_device.TabIndex = 9;
            // 
            // label_device
            // 
            this.label_device.Location = new System.Drawing.Point(82, 265);
            this.label_device.Name = "label_device";
            this.label_device.Size = new System.Drawing.Size(100, 23);
            this.label_device.TabIndex = 8;
            this.label_device.Text = "Device";
            // 
            // btn_write
            // 
            this.btn_write.ForeColor = System.Drawing.Color.Black;
            this.btn_write.Location = new System.Drawing.Point(82, 375);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(105, 47);
            this.btn_write.TabIndex = 7;
            this.btn_write.Text = "Write";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(148, 316);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(190, 20);
            this.txt_value.TabIndex = 12;
            // 
            // label_value
            // 
            this.label_value.Location = new System.Drawing.Point(82, 316);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(100, 23);
            this.label_value.TabIndex = 11;
            this.label_value.Text = "Value";
            // 
            // btn_read
            // 
            this.btn_read.ForeColor = System.Drawing.Color.Black;
            this.btn_read.Location = new System.Drawing.Point(233, 375);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(105, 47);
            this.btn_read.TabIndex = 10;
            this.btn_read.Text = "Read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 488);
            this.Controls.Add(this.txt_value);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.txt_device);
            this.Controls.Add(this.label_device);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.txt_sn);
            this.Controls.Add(this.label_sn);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.btn_connect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txt_device;
        private System.Windows.Forms.Label label_device;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.Button btn_read;

        private System.Windows.Forms.TextBox txt_sn;
        private System.Windows.Forms.Label label_sn;

        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;

        private System.Windows.Forms.Button btn_connect;

        #endregion
    }
}