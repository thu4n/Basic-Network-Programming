using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace week5
{

    public class StatusChangedEventArgs : EventArgs
    {
        private string EventMsg;

        public string EventMessage
        {
            get
            {
                return EventMsg;
            }
            set
            {
                EventMsg = value;
            }
        }

        public StatusChangedEventArgs(string strEventMsg)
        {
            EventMsg = strEventMsg;
        }
    }

    public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);

    class ChatServer1
    {
        // Dùng hash table lưu trữ users và connections của user đó (browsable by user)
        public static Hashtable htUsers = new Hashtable(30);
        public static Hashtable htConnections = new Hashtable(30);

        private IPAddress ipAddress;
        public TcpClient tcpClient = null;
        public static event StatusChangedEventHandler StatusChanged;
        private static StatusChangedEventArgs e;

        public ChatServer1(IPAddress address)
        {
            ipAddress = address;
        }

        private Thread thrListener;

        private TcpListener tlsClient;

        bool ServRunning = false;

        public static async void AddUser(TcpClient tcpUser, string strUsername)
        {
            ChatServer1.htUsers.Add(strUsername, tcpUser);
            ChatServer1.htConnections.Add(tcpUser, strUsername);

            await SendAdminMessage(htConnections[tcpUser] + " đã đăng nhập!");
        }

        // Xóa User
        public static async void RemoveUser(TcpClient tcpUser)
        {
            try
            {
                // If the user còn hoạt động
                if (htConnections[tcpUser] != null)
                {
                    // Hiển thị thông tin user đã ngắt kết nối
                    await SendAdminMessage(htConnections[tcpUser] + " đã đăng xuất!");

                    // Xóa User khỏi the hash table
                    ChatServer1.htUsers.Remove(ChatServer1.htConnections[tcpUser]);
                    ChatServer1.htConnections.Remove(tcpUser);
                }
            }
            catch { }
        }

        // Thêm sự kiện
        public static void OnStatusChanged(StatusChangedEventArgs e)
        {
            StatusChangedEventHandler statusHandler = StatusChanged;
            if (statusHandler != null)
            {
                // Invoke the delegate
                statusHandler(null, e);
            }
        }

        // Gửi Text
        public static async Task SendAdminMessage(string Message)
        {
            StreamWriter swSenderSender;

            e = new StatusChangedEventArgs("Administrator: " + Message);
            OnStatusChanged(e);

            // Tạo số lượng User cho quá trình kết nối
            TcpClient[] tcpClients = new TcpClient[ChatServer1.htUsers.Count];
            // Copy the TcpClient objects into the array
            ChatServer1.htUsers.Values.CopyTo(tcpClients, 0);
            for (int i = 0; i < tcpClients.Length; i++)
            {
                try
                {
                    if (Message.Trim() == "" || tcpClients[i] == null)
                    {
                        continue;
                    }
                    swSenderSender = new StreamWriter(tcpClients[i].GetStream());
                    await swSenderSender.WriteLineAsync("Administrator: " + Message);
                    await swSenderSender.FlushAsync();
                    swSenderSender = null;
                }
                catch
                {
                    RemoveUser(tcpClients[i]);
                }
            }
        }

        public static async Task SendMessage(string From, string Message)
        {
            StreamWriter swSenderSender;

            e = new StatusChangedEventArgs(From + " gửi: " + Message);
            OnStatusChanged(e);

            TcpClient[] tcpClients = new TcpClient[ChatServer1.htUsers.Count];
            ChatServer1.htUsers.Values.CopyTo(tcpClients, 0);
            for (int i = 0; i < tcpClients.Length; i++)
            {
                try
                {
                    if (Message.Trim() == "" || tcpClients[i] == null)
                    {
                        continue;
                    }
                    swSenderSender = new StreamWriter(tcpClients[i].GetStream());

                    await swSenderSender.WriteLineAsync(From + " gửi: " + Message);
                    await swSenderSender.FlushAsync();
                    swSenderSender = null;
                }
                catch
                {
                    RemoveUser(tcpClients[i]);
                }
            }
        }
        public static ManualResetEvent tcpClientConnected = new ManualResetEvent(false);
        public void StartListening()
        {
            tcpClientConnected.Reset();
            IPAddress ipaLocal = ipAddress;
            tlsClient = new TcpListener(ipaLocal, 8888);
            tlsClient.Start();
            ServRunning = true;
            thrListener = new Thread(KeepListening);
            thrListener.Start();
        }
        public void DoAcceptTcpClientCallback(IAsyncResult ar)
        {
            // Get the listener that handles the client request.
            TcpListener listener = (TcpListener)ar.AsyncState;

            // End the operation and display the received data on
            // the console.
            TcpClient client = listener.EndAcceptTcpClient(ar);

        }
        private void KeepListening()
        {
            while (ServRunning == true)
            {
                tcpClient = tlsClient.AcceptTcpClient();
                Connection newConnection = new Connection(tcpClient);
            }
        }
    }

    class Connection
    {
        TcpClient tcpClient;
        private Thread thrSender;
        private StreamReader srReceiver;
        private StreamWriter swSender;
        private string currUser;
        private string strResponse;

        public Connection(TcpClient tcpCon)
        {
            tcpClient = tcpCon;
            thrSender = new Thread(AcceptClient);
            thrSender.Start();
        }

        private void CloseConnection()
        {
            tcpClient.Close();
            srReceiver.Close();
            swSender.Close();
        }

        private async void AcceptClient()
        {
            srReceiver = new System.IO.StreamReader(tcpClient.GetStream());
            swSender = new System.IO.StreamWriter(tcpClient.GetStream());
            currUser = srReceiver.ReadLine();
            if (currUser != "")
            {
                if (ChatServer1.htUsers.Contains(currUser) == true)
                {
                    await swSender.WriteLineAsync("0|This username already exists.");
                    await swSender.FlushAsync();
                    CloseConnection();
                    return;
                }
                else if (currUser == "Administrator")
                {
                    await swSender.WriteLineAsync("0|This username is reserved.");
                    await swSender.FlushAsync();
                    CloseConnection();
                    return;
                }
                else
                {
                    ChatServer1.AddUser(tcpClient, currUser);
                }
            }
            else
            {
                CloseConnection();
                return;
            }

            try // Tiến hành kiểm tra 
            {
                while ((strResponse = srReceiver.ReadLine()) != "")
                {
                    // Phản hồi rỗng
                    if (strResponse == null)
                    {
                        ChatServer1.RemoveUser(tcpClient);
                    }
                    else
                    {
                        // Thông báo Text ra All User
                        await ChatServer1.SendMessage(currUser, strResponse);
                    }
                }
            }
            catch
            {
                // Xảy ra lỗi thì Remove User
                ChatServer1.RemoveUser(tcpClient);
            }
        }
    }


}
