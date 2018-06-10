namespace ChatLAN
{
    partial class Login
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
            this.ipAddressControl_Box = new IPAddressControlLib.IPAddressControl();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.textBox_NickName = new System.Windows.Forms.TextBox();
            this.button_Connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_IP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipAddressControl_Box
            // 
            this.ipAddressControl_Box.AllowInternalTab = false;
            this.ipAddressControl_Box.AutoHeight = true;
            this.ipAddressControl_Box.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl_Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl_Box.Location = new System.Drawing.Point(103, 22);
            this.ipAddressControl_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipAddressControl_Box.MinimumSize = new System.Drawing.Size(111, 22);
            this.ipAddressControl_Box.Name = "ipAddressControl_Box";
            this.ipAddressControl_Box.ReadOnly = false;
            this.ipAddressControl_Box.Size = new System.Drawing.Size(162, 22);
            this.ipAddressControl_Box.TabIndex = 0;
            this.ipAddressControl_Box.Text = "...";
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(103, 73);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(100, 22);
            this.textBox_Port.TabIndex = 1;
            this.textBox_Port.Text = "1997";
            this.textBox_Port.TextChanged += new System.EventHandler(this.textBox_Port_TextChanged);
            // 
            // textBox_NickName
            // 
            this.textBox_NickName.Location = new System.Drawing.Point(46, 150);
            this.textBox_NickName.Name = "textBox_NickName";
            this.textBox_NickName.Size = new System.Drawing.Size(219, 22);
            this.textBox_NickName.TabIndex = 2;
            this.textBox_NickName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_NickName_KeyUp);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(104, 193);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(86, 23);
            this.button_Connect.TabIndex = 3;
            this.button_Connect.Text = "Kết nối";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mời nhập Nick Name";
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Location = new System.Drawing.Point(1, 27);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(82, 17);
            this.label_IP.TabIndex = 5;
            this.label_IP.Text = "Mời nhập IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mời nhập Port";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 228);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_IP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Connect);
            this.Controls.Add(this.textBox_NickName);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.ipAddressControl_Box);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IPAddressControlLib.IPAddressControl ipAddressControl_Box;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.TextBox textBox_NickName;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Label label2;
    }
}