using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WartornNetworking.Server;
using WartornNetworking.Utility;






namespace ServerGUI
{
    public partial class Mainform : Form
    {
        Server server;
        public delegate void Mainthreadoperation(string sender, ServerEventArgs e); //khởi tạo delegate Mainthread

        public Mainform()
        {
            Server.Init();
            InitializeComponent();

        }

        private void button_StartServer_Click(object sender, EventArgs e)
        {
            int port = 0;
            if(!int.TryParse(textBox_port.Text, out port)) // kiểm tra trong textbox port có phải là số hay k
            {
                return;
            }
            //ẩn các nút này khi khởi động server
            button_StartServer.Enabled = false;
            textBox_port.Enabled = false;

            button_Send.Enabled = true;
            textBox_broadcast.Enabled = true;

            server = new Server(port);
            //3 sự kiện duy nhất server cần xử lý
            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
            server.PackageDataReceived += Server_PackageDataReceived;

        }

        private void Server_PackageDataReceived(object sender, ServerEventArgs e)
        {
          
            Mainthreadoperation temp = MainThreadListViewLog;
            this.Invoke(temp, "DataReceived", e);
            
        }

        private void Server_ClientDisconnected(object sender, ServerEventArgs e)
        {
         
            Mainthreadoperation temp = MainThreadListViewLog;
            this.Invoke(temp, "Disconnected", e);
        }

        private void Server_ClientConnected(object sender, ServerEventArgs e)
        {
          
            Mainthreadoperation temp = MainThreadListViewLog;
            this.Invoke(temp, "Connected", e);
       
        }
        private void MainThreadListViewLog(string sender, ServerEventArgs e) //hàm xử lý listview
        {
            RefreshListView();
            ListViewItem listviewitem = new ListViewItem();
            int stt = listView_log.Items.Count;
            Client client = e.client; //thông tin của client (cài đặt sự kiện)
            listviewitem.Text = stt.ToString(); //mỗi dòng là 1 item
            listviewitem.SubItems.Add(client.clientID);

            switch(sender)//xem tình trạng của event, hiện thông tin của các IP kết nối/ngắt kết nối tới Server
            {
                case "Connected":
                    listviewitem.SubItems.Add(sender +":"+(IPEndPoint)(client.tcpclient.Client.RemoteEndPoint));//IPEndPoint = IP+Port
                    break;
                case "Disconnectd":
                    listviewitem.SubItems.Add(sender + ":" + (IPEndPoint)(client.tcpclient.Client.RemoteEndPoint));
                    break;
                case "DataReceived":
                    listviewitem.SubItems.Add(ProcessPackage(client,e.package));
                    break;

            }
            listView_log.Items.Add(listviewitem);
            listView_log.Items[stt].EnsureVisible();// đảm bảo listview tự động lăn xuống dòng cuối/mới nhất

        }
       private string ProcessPackage(Client client, Package package)//xử lý hiển thị nội dung thông tin package
        {
            string result = string.Empty; //đặt result mặc định empty
            if (package.messages == Messages.Request) //Nếu nội dung của package là cái request thì...
            {
                switch (package.commands) //hiển thị nội dung yêu cầu của package
                {
                    //gửi tin nhắn riêng tư đến người dùng khác
                    case Commands.Message:
                        var datas = package.data.Split('|'); //data là nội dung, split('|') dùng để tách kí tự ('|') khi user lỡ tay
                        result = string.Format("{0} sent {1} : {2}", client.clientID, datas[0], datas[1]);
                        break;
                    //gửi tin nhắn để sảnh chung, mọi người đều có thể gửi
                    case Commands.Broadcast:
                        result = string.Format("{0} broadcasted : {1}", client.clientID, package.data);
                        break;
                    //get roomid list của server
                    case Commands.GetRooms:
                        result = string.Format("{0} request the roomID list", client.clientID);
                        break;
                    //get roomid của client/user
                    case Commands.GetRoomID:
                        result = string.Format("{0} request his roomID : {1}", client.clientID, client.roomID);
                        break;
                    //tạo phòng mới
                    case Commands.CreateRoom:
                        result = string.Format("{0} request a new room : {1}", client.clientID, client.roomID);
                        break;
                    //Gia nhập phòng đang tồn tại
                    case Commands.JoinRoom:
                        result = string.Format("{0} join a room : {1}", client.clientID, client.roomID);
                        break;
                    //get client ID
                    case Commands.GetClientID:
                        result = string.Format("{0} request his ID", client.clientID);
                        break;
                    //get clientID list của phòng
                    case Commands.GetClients:
                        result = string.Format("{0} request the clientID list", client.clientID);
                        break;
                    default:
                        break;
                }
            }

                return result;

            
        }
        private void RefreshListView()
        {
            if (listView_Room.Items.Count>0)
            {
                listView_Room.Items.Clear();
            }

            ListViewItem listview;
            // duyệt các room trong server, hiển thị thông tin của room và các room đang tồn tại
            foreach(var kvp in server.rooms)
            {
                listview = new ListViewItem();
                listview.Text = kvp.Key;
                listview.SubItems.Add(kvp.Value.ClientsCount.ToString());
                listView_Room.Items.Add(listview);
            }

            if (listView_Client.Items.Count>0)
            {
                listView_Client.Items.Clear();
            }
         
            foreach (var kvp in server.clients)
            {
                listview = new ListViewItem();
                listview.Text = kvp.Key;
                listview.SubItems.Add(kvp.Value.IP.ToString());
                listview.SubItems.Add(kvp.Value.State.ToString()); //trạng thái kết nối
                listView_Client.Items.Add(listview);

            }
            
        }

        private void BroadcastMessage()
        {
            server.BroadcastMessage(textBox_broadcast.Text.Replace("|",string.Empty));//loại bỏ kí tự "|" trong chatbox
            textBox_broadcast.Text = "";
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            BroadcastMessage();
        }

        private void textBox_broadcast_KeyUp(object sender, KeyEventArgs e) //nhấn enter để gửi
        {
            if (e.KeyCode== Keys.Enter)
            {
                BroadcastMessage();
            }
        }

        private void textBox_port_TextChanged(object sender, EventArgs e)
        {
            int port = 1997;
            if (!int.TryParse(textBox_port.Text, out port))
            {
                textBox_port.Text = "1997";
                return;
            }

            if (port == 0)
            {
                textBox_port.Text = "1997";
            }
        }
    }
}
