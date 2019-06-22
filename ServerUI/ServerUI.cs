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

namespace ServerUI
{
    public partial class ServerUI : Form
    {

        public AsyncCallback backgroundWorker;
        private Socket mainSocket;
        private Socket[] activeSockets = new Socket[10];
        private int nrSocket = 0;
        private byte[] buffer = new byte[256];

        delegate void SetTextCallback(string text);
        delegate void SetReceivedMsgCallBack(string text);

        private void SetText(string text)
        {
            if (this.textBoxMsg.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxMsg.Text = text;
            }
        }

        private void SetReceivedMsg(string text)
        {
            if (this.chatList.InvokeRequired)
            {
                SetReceivedMsgCallBack d = new SetReceivedMsgCallBack(SetReceivedMsg);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                chatList.Items.Add("Client:" + text);
            }
        }

        public ServerUI()
        {
            InitializeComponent();
            IPTextBox.Text = GetIP();
        }

        private void startListenBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (portTextBox.Text == "")
                {
                    MessageBox.Show("Setati portul!!!");
                    return;
                }
                string portStr = portTextBox.Text;
                int port = System.Convert.ToInt32(portStr);
                mainSocket = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
                IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, port);
                mainSocket.Bind(ipLocal);
                mainSocket.Listen(5);
                mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);

                UpdateControls(true);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateControls(bool listening)
        {
            startListenBtn.Enabled = !listening;
            stopListenBtn.Enabled = listening;
        }
        public void OnClientConnect(IAsyncResult asyn)
        {
            try
            {
                activeSockets[nrSocket] = mainSocket.EndAccept(asyn);
                WaitForData(activeSockets[nrSocket]);
                ++nrSocket;
                String str = String.Format("Clientul {0} s-a conectat", nrSocket);
                SetText(str.ToString());

                mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void WaitForData(System.Net.Sockets.Socket soc)
        {
            try
            {
                if (backgroundWorker == null)
                {
                    backgroundWorker = new AsyncCallback(OnDataReceived);
                }
                Socket newSocket = soc;

                SetupRecieveCallback(soc);
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
            }

        }
        public void OnDataReceived(IAsyncResult asyn)
        {
            try
            {
                Socket socketData = (Socket)asyn.AsyncState;

                int bytesRead = 0;
                bytesRead = socketData.EndReceive(asyn);


                if (bytesRead > 0)
                {
                    string receivedStr = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    SetReceivedMsg(receivedStr.ToString());
                    SetupRecieveCallback(socketData);
                }
                else
                {
                    Console.WriteLine("Clientul {0} s-a deconectat", socketData.RemoteEndPoint);
                    socketData.Shutdown(SocketShutdown.Both);
                    socketData.Close();
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

        private void sendMsgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var msg = richTextBoxSendMsg.Text;
                chatList.Items.Add("Server:" + msg);
                byte[] byData = System.Text.Encoding.ASCII.GetBytes(msg.ToString());
                for (int i = 0; i < nrSocket; i++)
                {
                    if (activeSockets[i] != null)
                    {
                        if (activeSockets[i].Connected)
                        {
                            activeSockets[i].Send(byData);
                        }
                    }
                }
                richTextBoxSendMsg.Clear();

            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void stopListenBtn_Click(object sender, EventArgs e)
        {
            CloseSockets();
            UpdateControls(false);
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            CloseSockets();
            Close();
        }
        void CloseSockets()
        {
            if (mainSocket != null)
            {
                mainSocket.Close();
            }
            for (int i = 0; i < nrSocket; i++)
            {
                if (activeSockets[i] != null)
                {
                    activeSockets[i].Close();
                    activeSockets[i] = null;
                }
            }
        }
    }
}
