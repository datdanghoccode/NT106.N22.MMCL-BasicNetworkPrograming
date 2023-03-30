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

namespace UDP_Chat
{
    public partial class Client : Form
    {
        private Socket clientSocket;
        private IPEndPoint serverEP;

        public Client()
        {
            InitializeComponent();
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                btnConnect.Text = "Disconnected";
                txtServerIP.Enabled = txtPort.Enabled = false;
                
                serverEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                rtbClient.Text += "Connected to: " + serverEP.ToString() + "\r\n";

            }    
            else
            {
                btnConnect.Text = "Connect";
                txtServerIP.Enabled = txtPort.Enabled = true;
                rtbClient.Text = "";
            }    
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (rtbClientMessage.Text != "")
            {
                byte[] requestByte = Encoding.UTF8.GetBytes(rtbClientMessage.Text);
                clientSocket.SendTo(requestByte, serverEP);
                rtbClientMessage.Text = "";
            }
            else
            {
                MessageBox.Show("Type your message before click Send!");
            }    
        }
    }
}