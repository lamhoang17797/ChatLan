﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WartornNetworking.Client;

namespace ChatLAN
{
    public partial class PrivateChat : Form
  
    {
        public delegate void MainThreadOperation(string sender, ClientEventArgs e);
        public string clientID;
        public string Nickname;
        public Client client;
        public PrivateChat(Client client, string clientid, string nickname)
        {
            this.client = client;
            this.clientID = clientid;
            this.Nickname = nickname;

            InitializeComponent();
            this.Text +=" "+ nickname;
            client.MessageReceived += Client_MessageReceived;

        }

        private void Client_MessageReceived(object sender, ClientEventArgs e)
        {
            var datas = e.package.data.Split('|');
            switch (datas[1])
            {
                case "pm":
                {
                    MainThreadOperation temp = MainThreadListViewLog;
                    this.Invoke(temp, "MessageReveived", e);
                }
                    break;
                case "f":
                {
                    MainThreadOperation temp = MainThreadReceiveFile;
                    this.Invoke(temp, "", e);
                }
                    break;
            }
        }

        private void button_Sendfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog jhj = new OpenFileDialog();
            jhj.InitialDirectory = "";
            jhj.Multiselect = false;
            jhj.CheckFileExists = true;
            jhj.CheckPathExists = true;
            if (jhj.ShowDialog() == DialogResult.OK)
            {
                string filepath = jhj.FileName;
                FileInfo fi = new FileInfo(filepath);

                if (fi.Length >= 10000)
                {
                    MessageBox.Show("Quá giới hạn gửi nhận file!");
                    return;
                }

                var fileContent = File.ReadAllBytes(filepath);
                client.SendMessage(clientID, "f|" + Encoding.UTF8.GetString(fileContent));
            }


        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            sendpm();
        }

      

        private void sendpm()
        {
            if (string.IsNullOrWhiteSpace(textBox_SendMessage.Text))
            {
                return;
            }

            client.SendMessage(clientID, "pm|" + textBox_SendMessage.Text);
            textBox_SendMessage.Text = "";
        }

        private void textBox_SendMessage_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                sendpm();
            }
        }
        private void MainThreadListViewLog (string sender, ClientEventArgs e)
        {
            ListViewItem listview = new ListViewItem();
            int stt = listView_log.Items.Count;
            listview.Text = stt.ToString();
            var datas = e.package.data.Split('|');
            //listview.SubItems.Add(datas[0]); //clientID của ng gửi
            //datas[1] = lenh
            //datas[2] = ng nhan
            listview.SubItems.Add(datas[3]); //nội dung tin nhắn

            listView_log.Items.Add(listview);
            listView_log.Items[stt].EnsureVisible();
        }

        private void MainThreadReceiveFile(string sender, ClientEventArgs e)
        {
            var datas = e.package.data.Split('|');

            if (datas[0] == clientID)
            {
                return;
            }


            var data = datas[3];

            SaveFileDialog temp = new SaveFileDialog();
            temp.OverwritePrompt = true;
            temp.InitialDirectory = "";
            if (temp.ShowDialog() == DialogResult.OK)
            {
                var filecontent = Encoding.UTF8.GetBytes(data);
                File.WriteAllBytes(temp.FileName,filecontent);
            }
        }
    }
}
