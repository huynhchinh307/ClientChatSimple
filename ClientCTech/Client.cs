using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCTech
{
    public partial class Client : Form
    {
        private Socket client;
        private byte[] data = new byte[1024];
        private int size = 1024;
        //Move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Client(Socket client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Check connect error app close
            if (conStatus.Text.Equals("Error connecting"))
                Application.Exit();
            else
            {
                byte[] message = Encoding.UTF8.GetBytes("/exit");
                try
                {
                    client.BeginSend(message, 0, message.Length, SocketFlags.None,
                                    new AsyncCallback(SendData), client);
                }
                catch
                {
                    Application.Exit();
                }
            }
            //Check if have connect send command exit to server
            
        }

        private void panel_move_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void lbl_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conStatus.Invoke(new Action(() => conStatus.Text = "Connected to: " + client.RemoteEndPoint.ToString()));
            client.BeginReceive(data, 0, size, SocketFlags.None,
                        new AsyncCallback(ReceiveData), client);
            txt_Text.Enabled = true;
            btn_Send.Enabled = true;

        }
        void SendData(IAsyncResult iar)
        {
            try
            {
                Socket remote = (Socket)iar.AsyncState;
                int sent = remote.EndSend(iar);
                
            }
            catch
            {
                conStatus.Invoke(new Action(() => conStatus.Text = "LOST CONNECTING TO SERVER !!!"));
                lstMesseger.Invoke(new Action(() => lstMesseger.Items.Add("Lost connecting to server !!!")));
            }
        }
        void ReceiveData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int recv = remote.EndReceive(iar);
            string stringData = Encoding.UTF8.GetString(data, 0, recv);
            if (stringData.Equals("exit-ok"))
            {
                client.Close();
                Application.Exit();
            } 
            else
            lstMesseger.Invoke(new Action(() => lstMesseger.Items.Add("Server : "+stringData)));
            client.BeginReceive(data, 0, size, SocketFlags.None,
                            new AsyncCallback(ReceiveData), client);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txt_Text.Text != null)
            {
                byte[] message = Encoding.UTF8.GetBytes(txt_Text.Text);
                txt_Text.Clear();
                client.BeginSend(message, 0, message.Length, SocketFlags.None,
                                    new AsyncCallback(SendData), client);
                lstMesseger.Items.Add("Me: " + Encoding.UTF8.GetString(message));
            }
            
        }
    }
}
