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

namespace Week04_TCP_Chatroom
{
    
        // Holds the arguments for the StatusChanged event
        public class StatusChangedEventArgs : EventArgs
        {
            // The argument we're interested in is a message describing the event
            private string EventMsg;

            // Property for retrieving and setting the event message
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

            // Constructor for setting the event message
            public StatusChangedEventArgs(string strEventMsg)
            {
                EventMsg = strEventMsg;
            }
        }

        // This delegate is needed to specify the parameters we're passing with our event
        public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);

        class ChatServer1
        {
            // Dùng hash table lưu trữ users và connections của user đó (browsable by user)
            public static Hashtable htUsers = new Hashtable(30); // 30 users at one time limit
                                                                 // This hash table stores connections and users (browsable by connection)
            public static Hashtable htConnections = new Hashtable(30); // 30 users at one time limit
                                                                       // Will store the IP address passed to it
            private IPAddress ipAddress;
            private TcpClient tcpClient;
            // The event and its argument will notify the form when a user has connected, disconnected, send message, etc.
            public static event StatusChangedEventHandler StatusChanged;
            private static StatusChangedEventArgs e;

            // The constructor sets the IP address to the one retrieved by the instantiating object
            public ChatServer1(IPAddress address)
            {   
                ipAddress = address;
            }

            // The thread that will hold the connection listener
            private Thread thrListener;

            // The TCP object that listens for connections
            private TcpListener tlsClient;

            // Will tell the while loop to keep monitoring for connections
            bool ServRunning = false;

            // Add the user to the hash tables
            public static void AddUser(TcpClient tcpUser, string strUsername)
            {
                // First add the username and associated connection to both hash tables
                ChatServer1.htUsers.Add(strUsername, tcpUser);
                ChatServer1.htConnections.Add(tcpUser, strUsername);

                // Tell of the new connection to all other users and to the server form
                SendAdminMessage(htConnections[tcpUser] + " đã đăng nhập!");
            }

            // Xóa User
            public static void RemoveUser(TcpClient tcpUser)
            {
                // If the user còn hoạt động
                if (htConnections[tcpUser] != null)
                {
                    // Hiển thị thông tin user đã ngắt kết nối
                    SendAdminMessage(htConnections[tcpUser] + " đã đăng xuất!");

                    // Xóa User khỏi the hash table
                    ChatServer1.htUsers.Remove(ChatServer1.htConnections[tcpUser]);
                    ChatServer1.htConnections.Remove(tcpUser);
                }
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
            public static void SendAdminMessage(string Message)
            {
                StreamWriter swSenderSender;

                // First of all, show in our application who says what
                e = new StatusChangedEventArgs("Administrator: " + Message);
                OnStatusChanged(e);

                // Tạo số lượng User cho quá trình kết nối
                TcpClient[] tcpClients = new TcpClient[ChatServer1.htUsers.Count];
                // Copy the TcpClient objects into the array
                ChatServer1.htUsers.Values.CopyTo(tcpClients, 0);
                // Loop through the list of TCP clients
                for (int i = 0; i < tcpClients.Length; i++)
                {
                    // Try sending a message to each
                    try
                    {
                        // If the message is blank or the connection is null, break out
                        if (Message.Trim() == "" || tcpClients[i] == null)
                        {
                            continue;
                        }
                        // Send the message to the current user in the loop
                        swSenderSender = new StreamWriter(tcpClients[i].GetStream());
                        swSenderSender.WriteLine("Administrator: " + Message);
                        swSenderSender.Flush();
                        swSenderSender = null;
                    }
                    catch // Nếu có vấn đề thì remove
                    {
                        RemoveUser(tcpClients[i]);
                    }
                }
            }

            // Send messages from one user to all the others
            public static void SendMessage(string From, string Message)
            {
                StreamWriter swSenderSender;

                // First of all, show in our application who says what
                e = new StatusChangedEventArgs(From + " gửi: " + Message);
                OnStatusChanged(e);

                // Create an array of TCP clients, the size of the number of users we have
                TcpClient[] tcpClients = new TcpClient[ChatServer1.htUsers.Count];
                // Copy the TcpClient objects into the array
                ChatServer1.htUsers.Values.CopyTo(tcpClients, 0);
                // Loop through the list of TCP clients
                for (int i = 0; i < tcpClients.Length; i++)
                {
                    // Try sending a message to each
                    try
                    {
                        // If the message is blank or the connection is null, break out
                        if (Message.Trim() == "" || tcpClients[i] == null)
                        {
                            continue;
                        }
                        // Send the message to the current user in the loop
                        swSenderSender = new StreamWriter(tcpClients[i].GetStream());
                        swSenderSender.WriteLine(From + " gửi: " + Message);
                        swSenderSender.Flush();
                        swSenderSender = null;
                    }
                    catch // If there was a problem, the user is not there anymore, remove him
                    {
                        RemoveUser(tcpClients[i]);
                    }
                }
            }

            public void StartListening()
            {

                // Get the IP of the first network device, however this can prove unreliable on certain configurations
                IPAddress ipaLocal = ipAddress;

                // Create the TCP listener object using the IP of the server and the specified port
                tlsClient = new TcpListener(ipaLocal, 8888);

                // Start the TCP listener and listen for connections
                tlsClient.Start();

                // The while loop will check for true in this before checking for connections
                ServRunning = true;

                // Start the new tread that hosts the listener
                thrListener = new Thread(KeepListening);
                thrListener.Start();
            }

            private void KeepListening()
            {
                // While the server is running
                while (ServRunning == true)
                {
                    // Accept a pending connection
                    tcpClient = tlsClient.AcceptTcpClient();
                    // Create a new instance of Connection
                    Connection newConnection = new Connection(tcpClient);
                }
            }
        }

        // This class handels connections; there will be as many instances of it as there will be connected users
        class Connection
        {
            TcpClient tcpClient;
            // The thread that will send information to the client
            private Thread thrSender;
            private StreamReader srReceiver;
            private StreamWriter swSender;
            private string currUser;
            private string strResponse;

            // The constructor of the class takes in a TCP connection
            public Connection(TcpClient tcpCon)
            {
                tcpClient = tcpCon;
                // The thread that accepts the client and awaits messages
                thrSender = new Thread(AcceptClient);
                // The thread calls the AcceptClient() method
                thrSender.Start();
            }

            private void CloseConnection()
            {
                // Close the currently open objects
                tcpClient.Close();
                srReceiver.Close();
                swSender.Close();
            }

            // Occures when a new client is accepted
            private void AcceptClient()
            {
                srReceiver = new System.IO.StreamReader(tcpClient.GetStream());
                swSender = new System.IO.StreamWriter(tcpClient.GetStream());

                // Read the account information from the client
                currUser = srReceiver.ReadLine();

                // We got a response from the client
                if (currUser != "")
                {
                    // Store the user name in the hash table
                    if (ChatServer1.htUsers.Contains(currUser) == true)
                    {
                        // 0 means not connected
                        swSender.WriteLine("0|This username already exists.");
                        swSender.Flush();
                        CloseConnection();
                        return;
                    }
                    else if (currUser == "Administrator")
                    {
                        // 0 means not connected
                        swSender.WriteLine("0|This username is reserved.");
                        swSender.Flush();
                        CloseConnection();
                        return;
                    }
                    else
                    {   
                        // Add the user to the hash tables and start listening for messages from him
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
                    // Keep waiting for a message from the user
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
                            ChatServer1.SendMessage(currUser, strResponse);
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
