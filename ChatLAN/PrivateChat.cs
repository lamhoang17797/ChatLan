using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WartornNetworking.Client;

namespace ChatLAN
{
    public partial class PrivateChat : Form
  
    {
        public delegate void MainThreadOperation(string sender, ClientEventArts e);
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

        private void Client_MessageReceived(object sender, ClientEventArts e)
        {
            var datas = e.package.data.Split('|');
            if (string.Compare(datas[1],"pm")==0)
            {
                MainThreadOperation temp = MainThreadListViewLog;
                this.Invoke(temp, "MessageReveived", e);
            }
        }

        private void button_Sendfile_Click(object sender, EventArgs e)
        {
            // OpenFileDialog jhj = new OpenFileDialog();
            // jhj.InitialDirectory = "";
            //string filepath = jhj.ShowDialog();


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
        public void MainThreadListViewLog (string sender, ClientEventArts e)
        {
            ListViewItem listview = new ListViewItem();
            int stt = listView_log.Items.Count;
            listview.Text = stt.ToString();
            var datas = e.package.data.Split('|');
            //listview.SubItems.Add(datas[0]); //clientID của ng gửi
            listview.SubItems.Add(datas[3]); //nội dung tin nhắn

            listView_log.Items.Add(listview);
            listView_log.Items[stt].EnsureVisible();
        }

        
    }
}
