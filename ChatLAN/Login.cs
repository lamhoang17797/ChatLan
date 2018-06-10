using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WartornNetworking.Client;

namespace ChatLAN
{
    public partial class Login : Form
    {
        Client client;
        public Login()
        {
            Client.Init();
            InitializeComponent();
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void textBox_Port_TextChanged(object sender, EventArgs e)
        {
            int port = 1997;
            if (!int.TryParse(textBox_Port.Text, out port))
            {
                textBox_Port.Text = "1997";
                return;
            }

            if (port == 0)
            {
                textBox_Port.Text = "1997";
            }
        }

        private void textBox_NickName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                connect();
            }
        }

        private void connect()
        {
            int port = 0;
            if (!int.TryParse(textBox_Port.Text, out port))
            {
                return;
            }
            IPAddress ipaddress = IPAddress.Any; //khai báo biến ipdress = giá trị tạm
            if (!IPAddress.TryParse(ipAddressControl_Box.Text, out ipaddress))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_NickName.Text))
            {
                return;
            }



            client = new Client(ipaddress, port);

            client.SetNickName(textBox_NickName.Text); //set nick name
            this.Hide();
            Main main = new Main(client);

            main.ShowDialog();

            this.Show();
        }

    }

}

