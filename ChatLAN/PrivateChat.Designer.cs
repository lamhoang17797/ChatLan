namespace ChatLAN
{
    partial class PrivateChat
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_SendMessage = new System.Windows.Forms.TextBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_SendFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView_log
            // 
            this.listView_log.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.listView_log.Location = new System.Drawing.Point(0, 0);
            this.listView_log.Name = "listView_log";
            this.listView_log.Size = new System.Drawing.Size(589, 302);
            this.listView_log.TabIndex = 0;
            this.listView_log.UseCompatibleStateImageBehavior = false;
            this.listView_log.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Package";
            this.columnHeader3.Width = 134;
            // 
            // textBox_SendMessage
            // 
            this.textBox_SendMessage.Location = new System.Drawing.Point(0, 345);
            this.textBox_SendMessage.Multiline = true;
            this.textBox_SendMessage.Name = "textBox_SendMessage";
            this.textBox_SendMessage.Size = new System.Drawing.Size(589, 79);
            this.textBox_SendMessage.TabIndex = 1;
            this.textBox_SendMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_SendMessage_KeyUp);
            // 
            // button_Send
            // 
            this.button_Send.Location = new System.Drawing.Point(595, 345);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(72, 79);
            this.button_Send.TabIndex = 2;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = true;
            this.button_Send.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button_SendFile
            // 
            this.button_SendFile.Location = new System.Drawing.Point(476, 316);
            this.button_SendFile.Name = "button_SendFile";
            this.button_SendFile.Size = new System.Drawing.Size(113, 23);
            this.button_SendFile.TabIndex = 3;
            this.button_SendFile.Text = "Send File";
            this.button_SendFile.UseVisualStyleBackColor = true;
            this.button_SendFile.Click += new System.EventHandler(this.button_Sendfile_Click);
            // 
            // PrivateChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 425);
            this.Controls.Add(this.button_SendFile);
            this.Controls.Add(this.button_Send);
            this.Controls.Add(this.textBox_SendMessage);
            this.Controls.Add(this.listView_log);
            this.Name = "PrivateChat";
            this.Text = "PrivateChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_log;
        private System.Windows.Forms.TextBox textBox_SendMessage;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.Button button_SendFile;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}