using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BytesRoad.Net.Ftp;

namespace ftpAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(Tim)
            
        }
        
        FtpClient client = new FtpClient();

        private void GetItemsFromFtp()
        {
            foreach (FtpItem item in client.GetDirectoryList(2000))
            {
                TreeNode node = new TreeNode(item.Name);

                node.ImageIndex = 2;
                node.SelectedImageIndex = 2;
                node.Tag = 0;


                if (item.ItemType == FtpItemType.Directory)
                {
                    node.ImageIndex = 0;
                    node.SelectedImageIndex = 0;
                    node.Tag = 1;
                }

                if (item.ItemType == FtpItemType.File)
                {
                    var fileType = item.Name.ToString().Split('.').Last();

                    switch (fileType)
                    {
                        case "avi":
                        case "flv":
                        case "mp4":
                        case "wmv":
                            node.ImageIndex = 5;
                            node.SelectedImageIndex = 5;
                            break;

                        case "mp3":
                        case "OGG":
                            node.ImageIndex = 6;
                            node.SelectedImageIndex = 6;
                            break;

                        case "djvu":
                            node.ImageIndex = 7;
                            node.SelectedImageIndex = 7;
                            break;

                        case "pdf":
                            node.ImageIndex = 8;
                            node.SelectedImageIndex = 8;
                            break;

                        case "jpg":
                            node.ImageIndex = 9;
                            node.SelectedImageIndex = 9;
                            break;

                        case "xlsx":
                            node.ImageIndex = 10;
                            node.SelectedImageIndex = 10;
                            break;

                        default:
                            node.ImageIndex = 1;
                            node.SelectedImageIndex = 1;
                            break;
                    }
                }



                treeView1.Nodes.Add(node);
            }
        }

        private void connect()
        {
            client.PassiveMode = true; //Включаем пассивный режим.
            int TimeoutFTP = 2000; //Таймаут.
            string FTP_SERVER = txtServer.Text.Trim();
            int FTP_PORT = int.Parse(txtPort.Text.Trim());
            string FTP_USER = txtLogin.Text.Trim();
            string FTP_PASSWORD = txtPassword.Text.Trim();

            try
            {
                client.Connect(TimeoutFTP, FTP_SERVER, FTP_PORT);
                client.Login(TimeoutFTP, FTP_USER, FTP_PASSWORD);
                client.ChangeDirectory(2000, txtPath.Text); // Начальная папка при старте...
                GetItemsFromFtp();

            }
            catch 
            {
                
                MessageBox.Show("Сбой при подключении");
                client.Disconnect(1000);
                throw;
            }
            
            //client.Disconnect(TimeoutFTP);
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (treeView1.SelectedNode.Tag.ToString() == "1")
                {
                    client.ChangeDirectory(2000, treeView1.SelectedNode.Text);
                    treeView1.Nodes.Clear();
                    GetItemsFromFtp();
                }
                else
                {
                    try
                    {
                        if (treeView1.SelectedNode.Tag.ToString() == "0")
                        {
                            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                            {
                                //MessageBox.Show(treeView1.SelectedNode.Text);
                                client.GetFile(2000,
                                    folderBrowserDialog1.SelectedPath + @"\" + treeView1.SelectedNode.Text,
                                    treeView1.SelectedNode.Text);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Disconnect(1000);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnSelectFoler_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSave.Text = folderBrowserDialog1.SelectedPath.Trim();
            }
        }
    }
}
