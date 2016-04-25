namespace serialcom
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.portName = new System.IO.Ports.SerialPort(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chatLog = new System.Windows.Forms.TextBox();
            this.chatBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tempWarning = new System.Windows.Forms.TextBox();
            this.preWarning = new System.Windows.Forms.TextBox();
            this.pres_1 = new System.Windows.Forms.TextBox();
            this.tmp_1 = new System.Windows.Forms.TextBox();
            this.Roll = new System.Windows.Forms.TextBox();
            this.Pitch = new System.Windows.Forms.TextBox();
            this.YAW = new System.Windows.Forms.TextBox();
            this.longitude = new System.Windows.Forms.TextBox();
            this.RXWINDOW = new System.Windows.Forms.TextBox();
            this.PressureBox = new System.Windows.Forms.TextBox();
            this.TempBox = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.DISCONNECT = new System.Windows.Forms.Button();
            this.Select_btn = new System.Windows.Forms.Button();
            this.CONNECT = new System.Windows.Forms.Button();
            this.cmbSerialPorts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // portName
            // 
            this.portName.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.cmbSerialPorts_DataReceived);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.chatLog);
            this.tabPage3.Controls.Add(this.chatBox);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1058, 441);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Chat";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chatLog
            // 
            this.chatLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatLog.Location = new System.Drawing.Point(6, 6);
            this.chatLog.Multiline = true;
            this.chatLog.Name = "chatLog";
            this.chatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatLog.Size = new System.Drawing.Size(737, 313);
            this.chatLog.TabIndex = 50;
            // 
            // chatBox
            // 
            this.chatBox.AllowDrop = true;
            this.chatBox.Location = new System.Drawing.Point(6, 325);
            this.chatBox.Multiline = true;
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(530, 21);
            this.chatBox.TabIndex = 49;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(600, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 48;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.tempWarning);
            this.tabPage1.Controls.Add(this.preWarning);
            this.tabPage1.Controls.Add(this.pres_1);
            this.tabPage1.Controls.Add(this.tmp_1);
            this.tabPage1.Controls.Add(this.Roll);
            this.tabPage1.Controls.Add(this.Pitch);
            this.tabPage1.Controls.Add(this.YAW);
            this.tabPage1.Controls.Add(this.longitude);
            this.tabPage1.Controls.Add(this.RXWINDOW);
            this.tabPage1.Controls.Add(this.PressureBox);
            this.tabPage1.Controls.Add(this.TempBox);
            this.tabPage1.Controls.Add(this.pictureBox5);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.stopBitsComboBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.parityComboBox);
            this.tabPage1.Controls.Add(this.dataBitsComboBox);
            this.tabPage1.Controls.Add(this.baudRateComboBox);
            this.tabPage1.Controls.Add(this.DISCONNECT);
            this.tabPage1.Controls.Add(this.Select_btn);
            this.tabPage1.Controls.Add(this.CONNECT);
            this.tabPage1.Controls.Add(this.cmbSerialPorts);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1058, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tempWarning
            // 
            this.tempWarning.BackColor = System.Drawing.SystemColors.Window;
            this.tempWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.tempWarning.Location = new System.Drawing.Point(267, 253);
            this.tempWarning.Multiline = true;
            this.tempWarning.Name = "tempWarning";
            this.tempWarning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tempWarning.Size = new System.Drawing.Size(183, 41);
            this.tempWarning.TabIndex = 52;
            // 
            // preWarning
            // 
            this.preWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.preWarning.Location = new System.Drawing.Point(456, 253);
            this.preWarning.Multiline = true;
            this.preWarning.Name = "preWarning";
            this.preWarning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.preWarning.Size = new System.Drawing.Size(182, 41);
            this.preWarning.TabIndex = 51;
            // 
            // pres_1
            // 
            this.pres_1.Location = new System.Drawing.Point(615, 38);
            this.pres_1.Name = "pres_1";
            this.pres_1.Size = new System.Drawing.Size(206, 20);
            this.pres_1.TabIndex = 50;
            this.pres_1.Visible = false;
            // 
            // tmp_1
            // 
            this.tmp_1.Location = new System.Drawing.Point(615, 64);
            this.tmp_1.Name = "tmp_1";
            this.tmp_1.Size = new System.Drawing.Size(206, 20);
            this.tmp_1.TabIndex = 49;
            this.tmp_1.Visible = false;
            this.tmp_1.TextChanged += new System.EventHandler(this.tmp_TextChanged);
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(461, 154);
            this.Roll.Multiline = true;
            this.Roll.Name = "Roll";
            this.Roll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Roll.Size = new System.Drawing.Size(177, 93);
            this.Roll.TabIndex = 42;
            this.Roll.TextChanged += new System.EventHandler(this.Roll_TextChanged);
            // 
            // Pitch
            // 
            this.Pitch.Location = new System.Drawing.Point(134, 154);
            this.Pitch.Multiline = true;
            this.Pitch.Name = "Pitch";
            this.Pitch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Pitch.Size = new System.Drawing.Size(156, 93);
            this.Pitch.TabIndex = 36;
            this.Pitch.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // YAW
            // 
            this.YAW.Location = new System.Drawing.Point(296, 154);
            this.YAW.Multiline = true;
            this.YAW.Name = "YAW";
            this.YAW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.YAW.Size = new System.Drawing.Size(159, 93);
            this.YAW.TabIndex = 37;
            this.YAW.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // longitude
            // 
            this.longitude.Location = new System.Drawing.Point(615, 111);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(161, 20);
            this.longitude.TabIndex = 28;
            // 
            // RXWINDOW
            // 
            this.RXWINDOW.AllowDrop = true;
            this.RXWINDOW.Location = new System.Drawing.Point(171, 321);
            this.RXWINDOW.Multiline = true;
            this.RXWINDOW.Name = "RXWINDOW";
            this.RXWINDOW.Size = new System.Drawing.Size(418, 21);
            this.RXWINDOW.TabIndex = 4;
            // 
            // PressureBox
            // 
            this.PressureBox.Location = new System.Drawing.Point(134, 38);
            this.PressureBox.Multiline = true;
            this.PressureBox.Name = "PressureBox";
            this.PressureBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PressureBox.Size = new System.Drawing.Size(156, 93);
            this.PressureBox.TabIndex = 7;
            // 
            // TempBox
            // 
            this.TempBox.Location = new System.Drawing.Point(416, 38);
            this.TempBox.Multiline = true;
            this.TempBox.Name = "TempBox";
            this.TempBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TempBox.Size = new System.Drawing.Size(159, 93);
            this.TempBox.TabIndex = 8;
            this.TempBox.TextChanged += new System.EventHandler(this.TempBox_TextChanged);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(20, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(97, 93);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 48;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(20, 145);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 93);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(366, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 46;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(802, 295);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(933, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(187, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 17);
            this.label14.TabIndex = 39;
            this.label14.Text = "PITCH";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label16.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label16.Location = new System.Drawing.Point(346, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 17);
            this.label16.TabIndex = 40;
            this.label16.Text = "YAW";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(520, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "ROLL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(933, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 46);
            this.button2.TabIndex = 33;
            this.button2.Text = "Heart Pulse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(802, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 32;
            this.button1.Text = "Camera LIVE ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(659, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Heart Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(554, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Stop Bits";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(422, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "Parity Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(91, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "RX WINDOW";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(295, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Data Bits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(161, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Baud Rate";
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(514, 375);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.stopBitsComboBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(35, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Port Name";
            // 
            // parityComboBox
            // 
            this.parityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(387, 375);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(121, 21);
            this.parityComboBox.TabIndex = 21;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(260, 375);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.dataBitsComboBox.TabIndex = 20;
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(133, 375);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(121, 21);
            this.baudRateComboBox.TabIndex = 19;
            // 
            // DISCONNECT
            // 
            this.DISCONNECT.Location = new System.Drawing.Point(219, 401);
            this.DISCONNECT.Name = "DISCONNECT";
            this.DISCONNECT.Size = new System.Drawing.Size(88, 23);
            this.DISCONNECT.TabIndex = 1;
            this.DISCONNECT.Text = "DISCONNECT";
            this.DISCONNECT.UseVisualStyleBackColor = true;
            this.DISCONNECT.Click += new System.EventHandler(this.DISCONNECT_Click);
            // 
            // Select_btn
            // 
            this.Select_btn.Location = new System.Drawing.Point(6, 401);
            this.Select_btn.Name = "Select_btn";
            this.Select_btn.Size = new System.Drawing.Size(75, 23);
            this.Select_btn.TabIndex = 16;
            this.Select_btn.Text = "Select Port";
            this.Select_btn.UseVisualStyleBackColor = true;
            this.Select_btn.Click += new System.EventHandler(this.Select_Click);
            // 
            // CONNECT
            // 
            this.CONNECT.Location = new System.Drawing.Point(109, 401);
            this.CONNECT.Name = "CONNECT";
            this.CONNECT.Size = new System.Drawing.Size(75, 23);
            this.CONNECT.TabIndex = 0;
            this.CONNECT.Text = "CONNECT";
            this.CONNECT.UseVisualStyleBackColor = true;
            this.CONNECT.Click += new System.EventHandler(this.CONNECT_Click);
            // 
            // cmbSerialPorts
            // 
            this.cmbSerialPorts.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbSerialPorts.FormattingEnabled = true;
            this.cmbSerialPorts.Location = new System.Drawing.Point(6, 375);
            this.cmbSerialPorts.Name = "cmbSerialPorts";
            this.cmbSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbSerialPorts.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(166, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "PRESSURE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("SF Intellivised", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(440, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "TEMPERATURE ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 467);
            this.tabControl1.TabIndex = 28;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(214, 246);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(47, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 53;
            this.pictureBox6.TabStop = false;
            // 
            // serialSettingsBindingSource
            // 
            this.serialSettingsBindingSource.DataSource = typeof(SerialPortListener.Serial.SerialSettings);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1067, 452);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Orion - Space station";
            this.Load += new System.EventHandler(this.webBrowser1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

       
        private void cmbSerialPorts_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        private System.IO.Ports.SerialPort portName;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox chatLog;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox pres_1;
        private System.Windows.Forms.TextBox tmp_1;
        private System.Windows.Forms.TextBox Roll;
        private System.Windows.Forms.TextBox Pitch;
        private System.Windows.Forms.TextBox YAW;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.TextBox RXWINDOW;
        private System.Windows.Forms.TextBox PressureBox;
        private System.Windows.Forms.TextBox TempBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.Button DISCONNECT;
        private System.Windows.Forms.Button Select_btn;
        private System.Windows.Forms.Button CONNECT;
        private System.Windows.Forms.ComboBox cmbSerialPorts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox preWarning;
        private System.Windows.Forms.TextBox tempWarning;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}

