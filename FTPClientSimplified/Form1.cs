using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace FTPClientSimplified {
    public partial class Form1 : Form {

        public string Download_Location = "C:\\";
        public Socket clientSocket;
        public byte[] messageRecv = new byte[1024];
        List<byte[]> fileBuff = new List<byte[]>();
        public string files;
        public bool flag = true;

        public Form1() {
            InitializeComponent();
        }

        class StateObject {
            internal byte[] sBuffer;
            internal Socket sSocket;
            internal StateObject(int size, Socket sock) {
                sBuffer = new byte[size];
                sSocket = sock;
            }
        }

        void Connect(string host) {
            flag = false;
            if (host.Length > 0) {
                IPAddress ipAddress = IPAddress.Parse(host);

                IPEndPoint ipEndpoint = new IPEndPoint(ipAddress, 21);

                clientSocket = new Socket(
                  AddressFamily.InterNetwork,
                  SocketType.Stream,
                  ProtocolType.Tcp);

                try {
                    clientSocket.Connect(ipEndpoint);
                    MessageBox.Show("Connected to FTP Server");
                    label_connected.Text = "Connected";
                    label_connected.ForeColor = Color.Green;
                    send_Ready();
                }
                catch (SocketException e) {
                    MessageBox.Show("Error connecting to FTP Server", e.Message);
                    flag = true;
                }
                
            }
        }

        void send_Ready() {
            
            byte[] sendBuffer = Encoding.ASCII.GetBytes("connect");
            clientSocket.Send(sendBuffer, sendBuffer.Length, SocketFlags.None);
            sendCallback();
        }

        void sendCallback() {
            
            clientSocket.Receive(messageRecv, 0, 1024, SocketFlags.None);
            files = (System.Text.Encoding.UTF8.GetString(messageRecv));

            DataTable table = new DataTable();
            table.Columns.Add("File Name");
            table.Columns.Add("File Size");

            string[] files1 = files.Split('\n');
            for (int i = 0; i < files1.Length - 1; i += 2) {
                table.Rows.Add(files1[i], files1[i + 1] + 'B');
            }
            dataGridView_FileList.DataSource = table;
        }

        void download(string tmp) {
            byte[] sendBuffer = Encoding.ASCII.GetBytes(tmp);
            string download_file = Download_Location + '\\' + tmp;
            progressBar_Download.Value = 0;
            clientSocket.Send(sendBuffer, sendBuffer.Length, SocketFlags.None);
            File.Create(download_file).Close();
            FileStream fs = new FileStream(download_file, FileMode.Append);
            


            bool run = true;
            do {
                clientSocket.Receive(messageRecv, 0, 1024, SocketFlags.None);
                string tmp_buffor = System.Text.Encoding.UTF8.GetString(messageRecv);
                    if (tmp_buffor[0] == 'd' && tmp_buffor[1] == 'o' && tmp_buffor[2] == 'n' && tmp_buffor[3] == 'e' && tmp_buffor[4] == '\0') {
                        run = false;
                    }
                    else {
                    fs.Write(messageRecv, 0, messageRecv.Length);
                }
            } while (run);
            fs.Close();
            progressBar_Download.Value = 100;
        }

        private void button_Connect_Click(object sender, EventArgs e) {
            if(flag)
                Connect(textBox_IP.Text);
        }

        private void textBox_IP_KeyDown(object sender, KeyEventArgs e) {
            if(flag)
                if (e.KeyCode == Keys.Enter) {
                    Connect(textBox_IP.Text);
                }
        }

        private void button_ChangeDownloadLocation_Click(object sender, EventArgs e) {
            FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK) {
                Download_Location = FBD.SelectedPath;
                textBox_DownloadLocation.Text = Download_Location;
            }
                
        }

        private void Form1_Load(object sender, EventArgs e) {
            textBox_DownloadLocation.Text = Download_Location;
            
        }

        private void button_Disconnect_Click(object sender, EventArgs e) {
            flag = true;
            clientSocket.Close();
            DataTable table = new DataTable();
            table.Columns.Add("File Name");
            table.Columns.Add("File Size");
            dataGridView_FileList.DataSource = table;
            MessageBox.Show("Disconnected from FTP server");
        }

        private void button_Download_Click(object sender, EventArgs e) {
            if (dataGridView_FileList.SelectedRows.Count == 1) {
                int selectedrowindex = dataGridView_FileList.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_FileList.Rows[selectedrowindex];
                string tmp_file = selectedRow.Cells[0].Value.ToString();
                string download_file = Download_Location + '\\' + tmp_file;

                if (File.Exists(download_file)){
                    File.Delete(download_file);
                    download(tmp_file);
                }
                else
                    download(tmp_file);
                
            }
        }
    }
}
