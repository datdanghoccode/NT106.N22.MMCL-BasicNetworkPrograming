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

namespace UDP_Server
{
    public partial class Server : Form
    {
        private UdpClient Listener;

        public Server()
        {
            InitializeComponent();
            Listener = new UdpClient(8080);
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            if (btnListen.Text == "Listen")
            {
                btnListen.Text = "Stop";
                txtServerIP.Enabled = false;

                Listener.Close();
                Listener = new UdpClient(8080);             
                Listener.BeginReceive(new AsyncCallback(receiving), null);
                
            }
            else
            {
                btnListen.Text = "Listen";
                txtServerIP.Enabled = true;
                rtbServer.Text = "";
            }   
        }

        void receiving(IAsyncResult res)
        {
            IPEndPoint groupEP = new IPEndPoint(IPAddress.Any, 8080);
            byte[] receive_byte_array = Listener.EndReceive(res, ref groupEP);
            string received_data = Encoding.UTF8.GetString(receive_byte_array);

            this.Invoke(new MethodInvoker(delegate
            {
                rtbServer.Text += "From " + groupEP.ToString() + ":  " + received_data + "\n";
            }));

            Listener.BeginReceive(new AsyncCallback(receiving), null);
        } 

    }
}