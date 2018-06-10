namespace ChatLAN
{
    partial class Main
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
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_Chat = new System.Windows.Forms.TextBox();
            this.listBox_ListUser = new System.Windows.Forms.ListBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.comboBox_Font = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView_log
            // 
            this.listView_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3});
            this.listView_log.Location = new System.Drawing.Point(0, 0);
            this.listView_log.Name = "listView_log";
            this.listView_log.Size = new System.Drawing.Size(718, 384);
            this.listView_log.TabIndex = 0;
            this.listView_log.UseCompatibleStateImageBehavior = false;
            this.listView_log.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ClientID";
            this.columnHeader2.Width = 220;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Package";
            this.columnHeader3.Width = 125;
            // 
            // textBox_Chat
            // 
            this.textBox_Chat.Location = new System.Drawing.Point(0, 419);
            this.textBox_Chat.Multiline = true;
            this.textBox_Chat.Name = "textBox_Chat";
            this.textBox_Chat.Size = new System.Drawing.Size(718, 85);
            this.textBox_Chat.TabIndex = 1;
            this.textBox_Chat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Chat_KeyUp);
            // 
            // listBox_ListUser
            // 
            this.listBox_ListUser.FormattingEnabled = true;
            this.listBox_ListUser.ItemHeight = 16;
            this.listBox_ListUser.Location = new System.Drawing.Point(724, 0);
            this.listBox_ListUser.Name = "listBox_ListUser";
            this.listBox_ListUser.Size = new System.Drawing.Size(198, 244);
            this.listBox_ListUser.TabIndex = 2;
            this.listBox_ListUser.SelectedIndexChanged += new System.EventHandler(this.listBox_ListUser_SelectedIndexChanged);
            // 
            // button_Send
            // 
            this.button_Send.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Send.Location = new System.Drawing.Point(765, 419);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(134, 85);
            this.button_Send.TabIndex = 3;
            this.button_Send.Text = "Gửi";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click_1);
            // 
            // comboBox_Font
            // 
            this.comboBox_Font.DisplayMember = "Name";
            this.comboBox_Font.FormattingEnabled = true;
            this.comboBox_Font.Location = new System.Drawing.Point(597, 389);
            this.comboBox_Font.Name = "comboBox_Font";
            this.comboBox_Font.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Font.TabIndex = 4;
            this.comboBox_Font.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Font_SelectionChangeCommitted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 505);
            this.Controls.Add(this.comboBox_Font);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.listBox_ListUser);
            this.Controls.Add(this.textBox_Chat);
            this.Controls.Add(this.listView_log);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_log;
        private System.Windows.Forms.TextBox textBox_Chat;
        private System.Windows.Forms.ListBox listBox_ListUser;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox comboBox_Font;
    }
}