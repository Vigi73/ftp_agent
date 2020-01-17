using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BytesRoad.Net.Ftp;
using INIManager;

namespace ftpAgent
{
    public partial class Form1 : Form
    {
        string appPath = AppDomain.CurrentDomain.BaseDirectory;
     

        public Form1()
        {
            InitializeComponent();
            

            //MessageBox.Show(Tim) ///

        }
        
        FtpClient client = new FtpClient();
        string timeWork;

        

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

                    //Проверка показать все или отдел...
                    if (chAll.Checked) 
                        { treeView1.Nodes.Add(node); }
                    else 
                        {
                            if (node.Text.StartsWith(txtNumber.Text.Trim()) || node.Text.StartsWith("+"+txtNumber.Text.Trim()))
                                treeView1.Nodes.Add(node);
                        }
                    
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
                if (txtPath.Text == "")
                    txtPath.Text = "/";

                client.Connect(TimeoutFTP, FTP_SERVER, FTP_PORT);
                client.Login(TimeoutFTP, FTP_USER, FTP_PASSWORD);

                List<string> month = new List<string>  {
                    "",
                    "Январь",
                    "Февраль",
                    "Март",
                    "Апрель",
                    "Май",
                    "Июнь",
                    "Июль",
                    "Август",
                    "СентЯбрь",
                    "ОктЯбрь",
                    "НоЯбрь",
                    "Декабрь",
                    
                };
                //конструктор путя FTP
                string folderData = timeWork.Split(' ')[0].Split('.')[2].Trim();
                int nDate = int.Parse(timeWork.Split(' ')[0].Split('.')[1]);
                string nowDate = timeWork.Split(' ')[0];
                string currentPath = String.Format("{0}{1}/{2}. {3}/{4}", txtPath.Text, folderData, nDate.ToString(), month[nDate], nowDate);
                client.ChangeDirectory(2000, currentPath);


                //client.ChangeDirectory(2000, txtPath.Text); // Начальная папка при старте...
                GetItemsFromFtp();

            }
            catch 
            {
                
                MessageBox.Show("Сбой при подключении");
                client.Disconnect(1000);
            
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
                            
                            {
                                //MessageBox.Show(treeView1.SelectedNode.Text);
                                client.GetFile(2000,
                                    txtSave.Text + @"\" + treeView1.SelectedNode.Text,
                                    treeView1.SelectedNode.Text);
                                
                                string files = txtSave.Text + @"\" + treeView1.SelectedNode.Text;
                                Process.Start(files);

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
            
            getDataFromIni();
           




            connect();
        }

        public void getDataFromIni()
        {
            string basePath = Path.Combine(appPath);
            INIManager.Class1.INIManager manager = new Class1.INIManager(basePath + @"/my.ini");

            txtPath.Text = manager.GetPrivateString("main", "basePath");
            txtServer.Text = manager.GetPrivateString("main", "server");
            txtPort.Text = manager.GetPrivateString("main", "port");
            txtLogin.Text = manager.GetPrivateString("main", "login");
            txtPassword.Text = manager.GetPrivateString("main", "passw");

            if (manager.GetPrivateString("main", "viewAll") == "True")
                chAll.Checked = true;
            else
                chAll.Checked = false;

            txtNumber.Text = manager.GetPrivateString("main", "number");
            txtNumber.Text = manager.GetPrivateString("main", "number");

            if (manager.GetPrivateString("main", "topmost") == "True")
                chTopMost.Checked = true;
            else
                chTopMost.Checked = false;

            txtSave.Text = manager.GetPrivateString("main", "save");
            dateTime1.Text = manager.GetPrivateString("main", "data");
            
            timeWork = manager.GetPrivateString("main", "data").ToString();
          

        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Disconnect(1000);
            saveAllData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnSelectFoler_Click(object sender, EventArgs e) // Selected folder for save file
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSave.Text = folderBrowserDialog1.SelectedPath.Trim();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveAllData();
            getDataFromIni();
            connect();
        }

        public void saveAllData()
        {
            string basePath = Path.Combine(appPath);
            INIManager.Class1.INIManager manager = new Class1.INIManager(basePath + @"/my.ini");
            manager.WritePrivateString("main", "basePath", txtPath.Text.Trim());
            manager.WritePrivateString("main", "server", txtServer.Text.Trim());
            manager.WritePrivateString("main", "port", txtPort.Text.Trim());
            manager.WritePrivateString("main", "login", txtLogin.Text.Trim());
            manager.WritePrivateString("main", "passw", txtPassword.Text.Trim());
            manager.WritePrivateString("main", "viewAll", chAll.Checked.ToString());
            manager.WritePrivateString("main", "number", txtNumber.Text.Trim());
            manager.WritePrivateString("main", "topmost", chTopMost.Checked.ToString());
            manager.WritePrivateString("main", "save", txtSave.Text.Trim());
            manager.WritePrivateString("main", "data", dateTime1.Value.ToString());
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stbDate.Text = String.Format("Дата слежения: {0}", timeWork.Split(' ')[0]);
            this.TopMost = chTopMost.Checked;
        }

        private void upToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            client.ChangeDirectoryUp(2000);
            GetItemsFromFtp();
        }

        private void ваходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            connect();
        }
    }
}
