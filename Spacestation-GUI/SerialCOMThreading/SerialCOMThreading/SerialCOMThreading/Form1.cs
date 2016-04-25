using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialCOMThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private static string RxString="";

        private void openPort_Click(object sender, EventArgs e)
        {

                try
                {
                    // make sure port isn't open	
                    if (!serialPort.IsOpen && !serialPortRead.IsOpen)
                    {
         
                       // set status
                        readTextBox.Text = serialPort.PortName+" Ready!";
                        readTextBox.AppendText(serialPortRead.PortName + " Ready!");
                        //open serial port 
                        serialPort.Open();
                        serialPortRead.Open();
                        // prevent reinitiation 
                        openPort.Enabled = false;
                     }
                    else
                        readTextBox.Text= "Port isn't openned";
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        // close ports
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
            serialPortRead.Close();
        }
        
        //datareceived handler
        private void serialPortRead_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                RxString = serialPortRead.ReadExisting();
                this.Invoke(new EventHandler(DisplayText));
            }
            catch (System.TimeoutException) { }
        }
        // Read/Update to textbox
        private void DisplayText(object s, EventArgs e)
        {
            readTextBox.AppendText(RxString);
       
        }

        // send message over serial COM
        private void sendButton_Click(object sender, EventArgs e)
        {
            serialPort.Write(writeTextBox.Text);
        }

        private void writeTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            serialPort.Write(writeTextBox.Text);
        }

        private void writeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If the port is closed, don't try to send a character.
            // or not in instance MS mode
            if (!serialPort.IsOpen || !instanceMS.Checked) return;

            // If the port is Open, declare a char[] array with one element.

            char[] buff = new char[1];

            // Load element 0 with the key character.
            buff[0] = e.KeyChar;

            // Send the one character buffer.
            serialPort.Write(buff, 0, 1);

            // Set the KeyPress event as handled so the character won't
            // display locally. If you want it to display, omit the next line.

           // e.Handled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            readTextBox.Text = "";
            writeTextBox.Text = "";
        }







    }
}
