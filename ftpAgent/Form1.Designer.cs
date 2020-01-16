namespace ftpAgent
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stbDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chTopMost = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSelectFoler = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.chAll = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ваходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageIndex = 11;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(7, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(508, 26);
            this.button1.TabIndex = 19;
            this.toolTip1.SetToolTip(this.button1, "Сохранить настройки");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_List_132709.png");
            this.imageList1.Images.SetKeyName(2, "connect.png");
            this.imageList1.Images.SetKeyName(3, "door_in.png");
            this.imageList1.Images.SetKeyName(4, "home.png");
            this.imageList1.Images.SetKeyName(5, "iconfinder_General_Office_65_2530844.png");
            this.imageList1.Images.SetKeyName(6, "iconfinder_mp3_47222.png");
            this.imageList1.Images.SetKeyName(7, "iconfinder_djvu_332632.png");
            this.imageList1.Images.SetKeyName(8, "iconfinder_pdf_272699.png");
            this.imageList1.Images.SetKeyName(9, "iconfinder_jpg_7553.png");
            this.imageList1.Images.SetKeyName(10, "iconfinder_22_1555770.png");
            this.imageList1.Images.SetKeyName(11, "iconfinder_floppy_disk_save_103863.png");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(538, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stbDate
            // 
            this.stbDate.Name = "stbDate";
            this.stbDate.Size = new System.Drawing.Size(92, 17);
            this.stbDate.Text = "Дата слежения:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 508);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FTP";
            // 
            // treeView1
            // 
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(524, 476);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Cornsilk;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Настройки";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.chTopMost);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dateTime1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnSelectFoler);
            this.groupBox1.Controls.Add(this.txtSave);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.chAll);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtLogin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки:";
            // 
            // chTopMost
            // 
            this.chTopMost.AutoSize = true;
            this.chTopMost.Location = new System.Drawing.Point(420, 265);
            this.chTopMost.Name = "chTopMost";
            this.chTopMost.Size = new System.Drawing.Size(93, 17);
            this.chTopMost.TabIndex = 18;
            this.chTopMost.Text = "По верх окон";
            this.chTopMost.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Дата проверки:";
            // 
            // dateTime1
            // 
            this.dateTime1.Location = new System.Drawing.Point(296, 370);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(217, 20);
            this.dateTime1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Папка для сохранения:";
            // 
            // btnSelectFoler
            // 
            this.btnSelectFoler.Location = new System.Drawing.Point(466, 304);
            this.btnSelectFoler.Name = "btnSelectFoler";
            this.btnSelectFoler.Size = new System.Drawing.Size(47, 22);
            this.btnSelectFoler.TabIndex = 14;
            this.btnSelectFoler.Text = "...";
            this.btnSelectFoler.UseVisualStyleBackColor = true;
            this.btnSelectFoler.Click += new System.EventHandler(this.btnSelectFoler_Click);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(7, 306);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(453, 20);
            this.txtSave.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(206, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Номер отдела:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(305, 222);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(208, 20);
            this.txtNumber.TabIndex = 11;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chAll
            // 
            this.chAll.Checked = true;
            this.chAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chAll.Location = new System.Drawing.Point(305, 203);
            this.chAll.Name = "chAll";
            this.chAll.Size = new System.Drawing.Size(105, 16);
            this.chAll.TabIndex = 10;
            this.chAll.Text = "Показать все";
            this.chAll.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(254, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(255, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Логин:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(305, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(210, 20);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(305, 142);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(211, 20);
            this.txtLogin.TabIndex = 6;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Порт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FTP сервер:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(425, 101);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(91, 20);
            this.txtPort.TabIndex = 3;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(6, 101);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(404, 20);
            this.txtServer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Базовый путь:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 47);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(510, 20);
            this.txtPath.TabIndex = 0;
            this.txtPath.Text = "/";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.upToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.toolStripMenuItem2,
            this.ваходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 98);
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Image = global::ftpAgent.Properties.Resources.iconfinder_Open_1493293;
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.upToolStripMenuItem.Text = "...";
            this.upToolStripMenuItem.ToolTipText = "Переход на уровень выше";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Image = global::ftpAgent.Properties.Resources.disconnect;
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectToolStripMenuItem.Text = "Подключение";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // ваходToolStripMenuItem
            // 
            this.ваходToolStripMenuItem.Image = global::ftpAgent.Properties.Resources.door_in;
            this.ваходToolStripMenuItem.Name = "ваходToolStripMenuItem";
            this.ваходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ваходToolStripMenuItem.Text = "Выход";
            this.ваходToolStripMenuItem.Click += new System.EventHandler(this.ваходToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 532);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTP-Агент 2.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.CheckBox chAll;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSelectFoler;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chTopMost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ToolStripStatusLabel stbDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ваходToolStripMenuItem;
    }
}

