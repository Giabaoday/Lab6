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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //nếu textbox 1 chưa có tên, thông báo lỗi
            if (textBox1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên");
                return;
            }
            try
            {
                TcpClient tcpClient = new TcpClient();

                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 8080);
                await tcpClient.ConnectAsync(ipEndPoint);
                richTextBox1.AppendText("Connected to server" + Environment.NewLine);

                // Tạo luồng mạng từ TcpClient
                NetworkStream networkStream = tcpClient.GetStream();

                // gửi tên cho server
                string datatoSend = textBox1.Text;
                byte[] bufferSend = Encoding.ASCII.GetBytes(datatoSend);
                await networkStream.WriteAsync(bufferSend, 0, bufferSend.Length);

                // Khởi tạo buffer để nhận dữ liệu
                byte[] buffer = new byte[1024];

                while (true)
                {
                    // Đọc dữ liệu từ luồng mạng vào buffer
                    int bytesRead = await networkStream.ReadAsync(buffer, 0, buffer.Length);

                    // Chuyển đổi dữ liệu từ buffer sang chuỗi
                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                    // Hiển thị dữ liệu nhận được từ server
                    richTextBox1.AppendText("Server: " + dataReceived + Environment.NewLine);

                    if (dataReceived == "Quay da bi khoa")
                    {
                        //khoá tất cả các control
                        button1.Enabled = false;
                        button2.Enabled = false;
                        checkedListBox1.Enabled = false;
                        comboBox1.Enabled = false;
                        comboBox2.Enabled = false;
                        richTextBox1.Enabled = false;
                        foreach(Control control in this.Controls)
                        {
                            control.Enabled = false;
                        }   
                    }
                    else if (dataReceived == "Quay da mo khoa")
                    {
                        //mở tất cả các control
                        button1.Enabled = true;
                        button2.Enabled = true;
                        checkedListBox1.Enabled = true;
                        comboBox1.Enabled = true;
                        comboBox2.Enabled = true;
                        richTextBox1.Enabled = true;
                    }
                    
                    
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                richTextBox1.AppendText("Error: " + ex.Message + Environment.NewLine);
            }

        }
    }
}
