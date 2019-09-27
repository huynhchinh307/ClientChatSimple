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
    public partial class Login : Form
    {
        //Move form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //End move form
        private Socket client;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPasswd.Text != "")
            {
                client = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint iep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5050);
                byte[] message = Encoding.UTF8.GetBytes(txtUsername.Text+" "+txtPasswd.Text);
                client.Connect(iep);
                client.Send(message);
                byte[] data = new byte[1024];
                int recv = client.Receive(data);
                string keylogin = Encoding.UTF8.GetString(data, 0, recv);
                if (keylogin.Equals("1"))
                {
                    MessageBox.Show("Login success :)");
                    Client f = new Client(client);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    client.Close();
                    MessageBox.Show("Username hoặc mật khẩu không tồn tại trong hệ thống");
                }
            }
            else
                MessageBox.Show("Chưa nhập đầy đủ thông tin!!!");
        }

        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
