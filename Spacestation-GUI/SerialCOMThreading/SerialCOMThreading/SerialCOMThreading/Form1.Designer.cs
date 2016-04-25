namespace SerialCOMThreading
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.writeTextBox = new System.Windows.Forms.RichTextBox();
            this.readTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.openPort = new System.Windows.Forms.Button();
            this.serialPortRead = new System.IO.Ports.SerialPort(this.components);
            this.clearButton = new System.Windows.Forms.Button();
            this.instanceMS = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.PortName = "COM7";
            this.serialPort.ReadTimeout = 500;
            this.serialPort.WriteTimeout = 500;
            // 
            // writeTextBox
            // 
            this.writeTextBox.Location = new System.Drawing.Point(93, 28);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.Size = new System.Drawing.Size(281, 87);
            this.writeTextBox.TabIndex = 0;
            this.writeTextBox.Text = "";
            this.writeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.writeTextBox_KeyPress);
            this.writeTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.writeTextBox_MouseDoubleClick);
            // 
            // readTextBox
            // 
            this.readTextBox.Location = new System.Drawing.Point(90, 168);
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.Size = new System.Drawing.Size(283, 102);
            this.readTextBox.TabIndex = 1;
            this.readTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(401, 81);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(72, 34);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "sendButton";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // openPort
            // 
            this.openPort.Location = new System.Drawing.Point(401, 28);
            this.openPort.Name = "openPort";
            this.openPort.Size = new System.Drawing.Size(72, 34);
            this.openPort.TabIndex = 3;
            this.openPort.Text = "openPort";
            this.openPort.UseVisualStyleBackColor = true;
            this.openPort.Click += new System.EventHandler(this.openPort_Click);
            // 
            // serialPortRead
            // 
            this.serialPortRead.BaudRate = 115200;
            this.serialPortRead.PortName = "COM11";
            this.serialPortRead.ReadTimeout = 500;
            this.serialPortRead.WriteTimeout = 500;
            this.serialPortRead.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortRead_DataReceived);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(401, 135);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 32);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // instanceMS
            // 
            this.instanceMS.AutoSize = true;
            this.instanceMS.Location = new System.Drawing.Point(401, 188);
            this.instanceMS.Name = "instanceMS";
            this.instanceMS.Size = new System.Drawing.Size(86, 17);
            this.instanceMS.TabIndex = 5;
            this.instanceMS.Text = "Instance MS";
            this.instanceMS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 299);
            this.Controls.Add(this.instanceMS);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.openPort);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.writeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.RichTextBox writeTextBox;
        private System.Windows.Forms.RichTextBox readTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button openPort;
        private System.IO.Ports.SerialPort serialPortRead;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.CheckBox instanceMS;
    }
}

