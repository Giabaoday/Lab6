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

namespace Lab6
{
    public partial class Server : Form
    {

        private List<Socket> clientSockets = new List<Socket>();
        private Dictionary<Socket, string> clients = new Dictionary<Socket, string>();
        public Server()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread serverThread = new Thread(new ThreadStart(StartUnsafeThread));
            serverThread.Start();
            richTextBox1.AppendText("Server started" + Environment.NewLine);
        }

        private void StartUnsafeThread()
        {
            Socket listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
            listenerSocket.Bind(ipEndPoint);
            listenerSocket.Listen(10);

            while (true)
            {
                int clientNumber = clientSockets.Count + 1;
                Socket clientSocket = listenerSocket.Accept();
                clientSockets.Add(clientSocket);
                richTextBox1.AppendText("Connection accepted from client " + clientNumber + clientSocket.RemoteEndPoint + Environment.NewLine);
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClient));
                clientThread.Start(clientSocket);

            }
        }

        private void HandleClient(object? clientSocketObj)
        {
            Socket clientSocket = (Socket)clientSocketObj!;
            //nhận dữ liệu từ server
            byte[] bufferReceive = new byte[1024];
            int bytesRead = clientSocket.Receive(bufferReceive);
            string receivedClientName = Encoding.ASCII.GetString(bufferReceive, 0, bytesRead);
            //3 client kết nối sẽ được phân vào lần lượt các quầy A, B, C và server thực hiện lưu trữ các client dưới dạng tên quầy và số thứ tự socket (ví dụ socket 1, socket 2...)

            string clientName = receivedClientName;
            clients.Add(clientSocket, clientName);
            richTextBox1.AppendText("Client " + clientSocket.RemoteEndPoint + " assigned to " + clientName + Environment.NewLine);

            byte[] buffer = Encoding.ASCII.GetBytes("Hello" + clientName + "You are client number:" + clientSockets.Count);
            checkedListBox1.Items.Add(clientName);
            clientSocket.Send(buffer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //khi nhấn nút Khoá, server sẽ gửi thông báo đến client ở quầy đó
            if (checkedListBox1.SelectedItem == null)
            {
                richTextBox1.AppendText("Hãy chọn 1 client để khoá" + Environment.NewLine);
                return;
            }
            foreach (KeyValuePair<Socket, string> client in clients)
            {
                //duyệt qua tất cả các checkedListBox được chọn để kiểm tra xem client nào được chọn
                foreach (var item in checkedListBox1.CheckedItems)
                {
                        if (client.Value == item.ToString())
                        {
                            byte[] buffer = Encoding.ASCII.GetBytes("Quay da bi khoa");
                            client.Key.Send(buffer);
                        }
                }
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //khi nhấn nút Khoá, server sẽ gửi thông báo đến client ở quầy đó
            if (checkedListBox1.SelectedItem == null)
            {
                richTextBox1.AppendText("Hãy chọn 1 client để mở khoá" + Environment.NewLine);
                return;
            }
            foreach (KeyValuePair<Socket, string> client in clients)
            {
                //duyệt qua tất cả các checkedListBox được chọn để kiểm tra xem client nào được chọn
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    if (client.Value == item.ToString())
                    {
                        byte[] buffer = Encoding.ASCII.GetBytes("Quay da mo khoa");
                        client.Key.Send(buffer);
                    }
                }


            }
        }
    }
}
