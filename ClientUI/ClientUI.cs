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

namespace ClientUI
{
    public partial class ClientUI : Form
    {
        public AsyncCallback backgroundWorker;
        public Socket clientSocket;

        private byte[] buffer = new byte[256];


        delegate void SetTextCallback(string text);

        public ClientUI()
        {
            InitializeComponent();
            ipTextBox.Text = GetIP();
        }
        private void SetText(string text)
        {
            if (chatList.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                chatList.Items.Add("Server:" + text);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (clientSocket != null)
            {
                clientSocket.Close();
                clientSocket = null;
            }
            Close();
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            if (ipTextBox.Text == "" || portTextBox.Text == "")
            {
                MessageBox.Show("Completati adresa si IP-ul\n");
                return;
            }
            try
            {
                UpdateControls(false);
                clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                IPAddress ip = IPAddress.Parse(ipTextBox.Text);
                int port = System.Convert.ToInt16(portTextBox.Text);
                IPEndPoint ipEnd = new IPEndPoint(ip, port);
                clientSocket.Connect(ipEnd);
                if (clientSocket.Connected)
                {

                    UpdateControls(true); 
                    WaitForData();
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                UpdateControls(false);
            }
        }

        private void sendMessageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = msgSendRichTextBox.Text;
                chatList.Items.Add("Client:" + msg);
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(msg.ToString());
                if (clientSocket != null)
                {
                    clientSocket.Send(byData);
                }
                msgSendRichTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void WaitForData()
        {
            try
            {
                if (backgroundWorker == null)
                {
                    backgroundWorker = new AsyncCallback(OnDataReceived);
                }
                Socket newSocket = clientSocket;

                SetupRecieveCallback(newSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void OnDataReceived(IAsyncResult asyn)
        {
            try
            {
                Socket newSocket = (Socket)asyn.AsyncState;
                int bytesRead = newSocket.EndReceive(asyn);

                if (bytesRead > 0)
                {
                    string sRecieved = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    SetText(sRecieved.ToString());
                    SetupRecieveCallback(newSocket);
                }
                else
                {
                    Console.WriteLine("Clientul {0} s-a deconectat", newSocket.RemoteEndPoint);
                    newSocket.Shutdown(SocketShutdown.Both);
                    newSocket.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SetupRecieveCallback(Socket socket)
        {
            try
            {
                AsyncCallback recieveData = new AsyncCallback(OnDataReceived);
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, recieveData, socket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateControls(bool connected)
        {
            connectBtn.Enabled = !connected;
            disconnectBtn.Enabled = connected;
            string connectStatus = connected ? "Conectat" : "Deconectat";
            connectStatusTextBox.Text = connectStatus;
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            if (clientSocket != null)
            {
                clientSocket.Close();
                clientSocket = null;
                UpdateControls(false);
            }
        }
        String GetIP()
        {
            String strHostName = Dns.GetHostName();
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            String IPStr = "";
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                IPStr = ipaddress.ToString();
                return IPStr;
            }
            return IPStr;
        }
    }
}
