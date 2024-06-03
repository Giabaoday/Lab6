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
            listenerSocket.Listen(3);

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

            //3 client kết nối sẽ được phân vào lần lượt các quầy A, B, C và server thực hiện lưu trữ các client dưới dạng tên quầy và số thứ tự socket (ví dụ socket 1, socket 2...)

            string clientName = "";
            if (clientSockets.Count % 3 == 1)
            {
                clientName = "Quầy A";
            }
            else if (clientSockets.Count % 3 == 2)
            {
                clientName = "Quầy B";
            }
            else
            {
                clientName = "Quầy C";
            }
            clients.Add(clientSocket, clientName);
            richTextBox1.AppendText("Client " + clientSocket.RemoteEndPoint + " assigned to " + clientName + Environment.NewLine);

            //mỗi client có 1 số thứ tự socket (ví dụ socket 1, socket 2...) và server thực hiện lưu trữ các client dưới dạng tên quầy và số thứ tự socket
            //server sẽ gửi thông báo đến client về số thứ tự socket của mình
            byte[] buffer = Encoding.ASCII.GetBytes("You are client number " + clientSockets.Count + " and you are assigned to " + clientName);
            clientSocket.Send(buffer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //khi nhấn nút Khoá, server sẽ gửi thông báo đến client ở quầy đó, và khoá tất cả các control của client đó
            //server sẽ gửi thông báo đến client về việc quầy đó đã bị khoá
            foreach (KeyValuePair<Socket, string> client in clients)
            {
                if (client.Value == "Quầy A")
                {
                    richTextBox1.AppendText("Đã khoá quầy A" + Environment.NewLine);
                    byte[] buffer = Encoding.ASCII.GetBytes("Quay da bi khoa");
                    client.Key.Send(buffer);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Socket, string> client in clients)
            {
                if (client.Value == "Quầy A")
                {
                    richTextBox1.AppendText("Đã mở khoá quầy A" + Environment.NewLine);
                    byte[] buffer = Encoding.ASCII.GetBytes("Quay da mo khoa");
                    client.Key.Send(buffer);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Socket, string> client in clients)
            {
                if (client.Value == "Quầy B")
                {
                    richTextBox1.AppendText("Đã khoá quầy B" + Environment.NewLine);
                    byte[] buffer = Encoding.ASCII.GetBytes("Quay da bi khoa");
                    client.Key.Send(buffer);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Socket, string> client in clients)
            {
                if (client.Value == "Quầy B")
                {
                    richTextBox1.AppendText("Đã mở khoá quầy B" + Environment.NewLine);
                    byte[] buffer = Encoding.ASCII.GetBytes("Quay da mo khoa");
                    client.Key.Send(buffer);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Socket, string> client in clients)
            {
                if (client.Value == "Quầy C")
                {
                    richTextBox1.AppendText("Đã khoá quầy C" + Environment.NewLine);
                    byte[] buffer = Encoding.ASCII.GetBytes("Quay da bi khoa");
                    client.Key.Send(buffer);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Socket, string> client in clients)
            {
                if (client.Value == "Quầy C")
                {
                    richTextBox1.AppendText("Đã mở khoá quầy C" + Environment.NewLine);
                    byte[] buffer = Encoding.ASCII.GetBytes("Quay da mo khoa");
                    client.Key.Send(buffer);
                }
            }
        }
    }
}
