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
using WartornNetworking.Utility;

namespace ChatLAN
{
    public partial class Main : Form
    {
        Client client;
        public delegate void MainThreadOperation(string sender, ClientEventArts e);
        public Main(Client client)
        {
            InitializeComponent();
            this.client = client;
          
            // 2 sự kiện Client phải xử lý
            client.MessageReceived += Client_MessageReceived;
            client.Disconnected += Client_Disconnected;
        }

        private void Client_Disconnected(object sender, ClientEventArts e)
        {
            MainThreadOperation temp = MainThreadListViewLog;
            this.Invoke(temp, "Disconnected", e);
         }

        Dictionary<string, string> clientlist = new Dictionary<string, string>();
        Dictionary<string, PrivateChat> privatechatlist = new Dictionary<string, PrivateChat>();

        private void Client_MessageReceived(object sender, ClientEventArts e)
        {
            MainThreadOperation temp;

            var datas = e.package.data.Split('|');
            string cmd = datas[1];
            
            switch (cmd)
            {
                case "pm":
                
                    break;
                case "sendfile":
                    //xu li nhan file
                    break;
                case "clientlist":
                    //xu li nhan client list
                    clientlist.Clear();
                    int soclient = int.Parse(datas[2]);
                    for (int i = 0; i < soclient; i++)
                    {
                        clientlist.Add(datas[i * 2 + 3], datas[i * 2 + 4]);//format goi tin
                    }
                    temp = MainThreadListBox_ListUser;
                    this.Invoke(temp, "", e);
                    break;
                default:
                    temp = MainThreadListViewLog;
                    this.Invoke(temp, "MessageReceived", e);
                    break;
            }
        }

        private void mainthreadshowprivatechat(string receiverclientID, ClientEventArts e)
        {
            string receivernickname = clientlist[receiverclientID];
            privatechatlist.Add(receiverclientID, new PrivateChat(client, receiverclientID, receivernickname));
            privatechatlist[receiverclientID].Show();
        }

        public void MainThreadListBox_ListUser(string sender,ClientEventArts e)
        {
            listBox_ListUser.Items.Clear();
            //add vào list user
            foreach (var kvp in clientlist)
            {
                listBox_ListUser.Items.Add(kvp.Value);
            }
        }

        public void MainThreadListViewLog(string sender, ClientEventArts e)
        {
            ListViewItem listview = new ListViewItem();
            int stt = listView_log.Items.Count;
            //listview.Text = stt.ToString();
            
            var datas = e.package.data.Split('|');
            listview.Text=(datas[0]);
            listview.SubItems.Add(datas[1]);

            listView_log.Items.Add(listview);//add item vào listview
            listView_log.Items[stt].EnsureVisible();//đảm bảo listview kéo xuống theo stt


        }

        private void SendMessage()
        {
            client.BroadcastMessage(textBox_Chat.Text.Replace("|", string.Empty));
            textBox_Chat.Text = "";
        }

        
        
        private void button_Send_Click_1(object sender, EventArgs e)
        {
            SendMessage();
        }


        private void textBox_Chat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                SendMessage();
            }
        }

        private void listBox_ListUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox_ListUser.SelectedIndex == -1)
            {
                return;
            }

            string nickname = listBox_ListUser.SelectedItem.ToString();
            string clientid =  clientlist.FirstOrDefault(kvp => //lấy nickname đầu tiên thỏa điều kiện
            {
                if (string.Compare(kvp.Value,nickname) == 0) //kiểm tra nick name trong clientlist vs nickname dc chọn có bằng nhau k
                {
                    return true;
                }
                return false;
            }).Key; //lấy clientID

            if (privatechatlist.ContainsKey(clientid))//kiểm tra có clientID trong privatechatlist hay k, tránh trg hợp chat cùng vs 1 người mở ra nhiều cửa số
            {
                return;
            }

            privatechatlist.Add(clientid, new PrivateChat(client,clientid,nickname));
            privatechatlist[clientid].Show();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<string> fonts = new List<string>();

            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                comboBox_Font.Items.Add(font);
            }

        }

        private void comboBox_Font_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FontFamily font = (FontFamily)comboBox_Font.SelectedItem;

            textBox_Chat.Font = new Font(font,8);
            listView_log.Font = new Font(font,8);
        }

       
    }
}
