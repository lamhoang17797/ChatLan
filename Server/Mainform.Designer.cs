namespace ServerGUI
{
    partial class Mainform
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
            this.listView_log = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Package = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_broadcast = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.ipAddressControl_Box = new IPAddressControlLib.IPAddressControl();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_StartServer = new System.Windows.Forms.Button();
            this.label_Status = new System.Windows.Forms.Label();
            this.listView_Room = new System.Windows.Forms.ListView();
            this.RoomID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Client = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_log
            // 
            this.listView_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.ClientID,
            this.Package});
            this.listView_log.Location = new System.Drawing.Point(218, 12);
            this.listView_log.Name = "listView_log";
            this.listView_log.Size = new System.Drawing.Size(667, 428);
            this.listView_log.TabIndex = 0;
            this.listView_log.UseCompatibleStateImageBehavior = false;
            this.listView_log.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "STT";
            // 
            // ClientID
            // 
            this.ClientID.Text = "ClientID";
            this.ClientID.Width = 296;
            // 
            // Package
            // 
            this.Package.Text = "Package";
            this.Package.Width = 222;
            // 
            // textBox_broadcast
            // 
            this.textBox_broadcast.Enabled = false;
            this.textBox_broadcast.Location = new System.Drawing.Point(218, 464);
            this.textBox_broadcast.Name = "textBox_broadcast";
            this.textBox_broadcast.Size = new System.Drawing.Size(667, 22);
            this.textBox_broadcast.TabIndex = 1;
            this.textBox_broadcast.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_broadcast_KeyUp);
            // 
            // button_Send
            // 
            this.button_Send.Enabled = false;
            this.button_Send.Location = new System.Drawing.Point(891, 446);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(71, 40);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // ipAddressControl_Box
            // 
            this.ipAddressControl_Box.AllowInternalTab = false;
            this.ipAddressControl_Box.AutoHeight = true;
            this.ipAddressControl_Box.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl_Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl_Box.Location = new System.Drawing.Point(13, 13);
            this.ipAddressControl_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ipAddressControl_Box.MinimumSize = new System.Drawing.Size(111, 22);
            this.ipAddressControl_Box.Name = "ipAddressControl_Box";
            this.ipAddressControl_Box.ReadOnly = true;
            this.ipAddressControl_Box.Size = new System.Drawing.Size(122, 22);
            this.ipAddressControl_Box.TabIndex = 3;
            this.ipAddressControl_Box.Text = "...";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(142, 13);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(70, 22);
            this.textBox_port.TabIndex = 4;
            this.textBox_port.Text = "1997";
            this.textBox_port.TextChanged += new System.EventHandler(this.textBox_port_TextChanged);
            // 
            // button_StartServer
            // 
            this.button_StartServer.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartServer.Location = new System.Drawing.Point(13, 376);
            this.button_StartServer.Name = "button_StartServer";
            this.button_StartServer.Size = new System.Drawing.Size(184, 110);
            this.button_StartServer.TabIndex = 5;
            this.button_StartServer.Text = "Start Server";
            this.button_StartServer.UseVisualStyleBackColor = true;
            this.button_StartServer.Click += new System.EventHandler(this.button_StartServer_Click);
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(12, 356);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(61, 17);
            this.label_Status.TabIndex = 6;
            this.label_Status.Text = "Stopped";
            // 
            // listView_Room
            // 
            this.listView_Room.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RoomID,
            this.Client});
            this.listView_Room.Location = new System.Drawing.Point(891, 12);
            this.listView_Room.Name = "listView_Room";
            this.listView_Room.Size = new System.Drawing.Size(474, 428);
            this.listView_Room.TabIndex = 7;
            this.listView_Room.UseCompatibleStateImageBehavior = false;
            this.listView_Room.View = System.Windows.Forms.View.Details;
            // 
            // RoomID
            // 
            this.RoomID.Text = "RoomID";
            this.RoomID.Width = 201;
            // 
            // Client
            // 
            this.Client.Text = "Clients";
            this.Client.Width = 197;
            // 
            // listView_Client
            // 
            this.listView_Client.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_Client.Location = new System.Drawing.Point(1371, 13);
            this.listView_Client.Name = "listView_Client";
            this.listView_Client.Size = new System.Drawing.Size(411, 428);
            this.listView_Client.TabIndex = 8;
            this.listView_Client.UseCompatibleStateImageBehavior = false;
            this.listView_Client.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ClientID";
            this.columnHeader1.Width = 167;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "IP";
            this.columnHeader2.Width = 147;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 93;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 498);
            this.Controls.Add(this.listView_Client);
            this.Controls.Add(this.listView_Room);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.button_StartServer);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.ipAddressControl_Box);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_broadcast);
            this.Controls.Add(this.listView_log);
            this.Name = "Mainform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_log;
        private System.Windows.Forms.ColumnHeader ClientID;
        private System.Windows.Forms.ColumnHeader Package;
        private System.Windows.Forms.TextBox textBox_broadcast;
        private System.Windows.Forms.Button button_Send;
        private IPAddressControlLib.IPAddressControl ipAddressControl_Box;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_StartServer;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.ListView listView_Room;
        private System.Windows.Forms.ColumnHeader RoomID;
        private System.Windows.Forms.ColumnHeader Client;
        private System.Windows.Forms.ListView listView_Client;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

