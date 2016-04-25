/// <summary>
/// This code sets the communication parameters; Baudrate, stop bits,.... and start recieving the data serialy
/// and checks for certain letter in the recieved data then parse this data and saves it in the correspoding textbox with the date and time
/// It also provides warning messages if the pressure and temprature exceeds certain limits, enables chatting between the 
/// space station and the astronaut and logs all the recieved and sent messages
/// </summary>





using SerialPortListener.Serial;
using System.IO.Ports;
using System.Linq;
using System.Diagnostics;
using System;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Threading;
namespace serialcom
{
   
    using System;
    using System.Text;
    using System.Windows.Forms;
    using System.Drawing;

    public partial class Form1 : Form
    {
        SerialPortManager _spManager;

       // int count = 0;

#if Defined
#else

        bool count = false;
        //bool Defined = true;
        bool count_1 = false;
#endif
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            UserInitialization();


        }
       string lon;
       
       string tmp;
       double tmp_no;
       double pres_no;
       string pres;
        
        //Get the initial communication parameters from the GUI
        
        private void UserInitialization()
        {   
            _spManager = new SerialPortManager();
            SerialSettings mySerialSettings = _spManager.CurrentSerialSettings;
            serialSettingsBindingSource.DataSource = mySerialSettings;
            cmbSerialPorts.DataSource = mySerialSettings.PortNameCollection;
            baudRateComboBox.DataSource = mySerialSettings.BaudRateCollection;
            dataBitsComboBox.DataSource = mySerialSettings.DataBitsCollection;
            parityComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.Parity));
            stopBitsComboBox.DataSource = Enum.GetValues(typeof(System.IO.Ports.StopBits));

            _spManager.NewSerialDataRecieved += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            serialPort1.PortName = "COM15";
            serialPort1.BaudRate = 9600;
  
      
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _spManager.Dispose();
        }


        void _spManager_NewSerialDataRecieved(object sender, SerialDataEventArgs e )
        {
            int flag=0;

            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecieved), new object[] { sender, e });
                return;
            }

          
            string str1 = Encoding.ASCII.GetString(e.Data);
            RXWINDOW.AppendText(str1);
            RXWINDOW.ScrollToCaret();

          ////// check for the letter corresponding to each data and set the flag value

            if (RXWINDOW.Text.Contains(','))
                RXWINDOW.Clear();
        
         
            if (RXWINDOW.Text.Contains('P'))
            {  
                
                flag = 1;
                
            }
            else if (RXWINDOW.Text.Contains ('T'))
            {

               

                flag = 2;
                

            }
            else if (RXWINDOW.Text.Contains('E'))
            {
              

                flag = 3;

            }

            else if (RXWINDOW.Text.Contains(':'))
            {

                flag = 5;

            }
        
            else if (RXWINDOW.Text.Contains('H'))
            {
              
                flag = 6;

            }

            else if (RXWINDOW.Text.Contains('B'))
            {

                flag = 7;

            }
            else if (RXWINDOW.Text.Contains('Y'))
            {

                flag = 8;

            }
            else if (RXWINDOW.Text.Contains('R'))
            {

                flag = 9;

            }


            CheckSerial(sender,e,flag);
           
              
        }

        void Form1_Load(object sender, EventArgs e)
        {
            var ports = SerialPort.GetPortNames();
            cmbSerialPorts.DataSource = ports;
           // int count = 0;

        }

        private void Select_Click(object sender, EventArgs e)
        {
            if (cmbSerialPorts.SelectedIndex > -1)
            {
                MessageBox.Show(String.Format("You selected port '{0}'", cmbSerialPorts.SelectedItem));
                //CONNECT_Click(cmbSerialPorts.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a port first");
            }
        }


        private void CONNECT_Click(object sender, EventArgs e)
        {
              _spManager.StartListening();
        }

        private void DISCONNECT_Click(object sender, EventArgs e)
        {
            _spManager.StopListening();
        }

       

     void CheckSerial(object sender , SerialDataEventArgs e , int flag)
    {

       switch (flag)
       {
           case 1: /// pressure case
               {


                   string str = Encoding.ASCII.GetString(e.Data);
                   string d;
                   d = DateTime.Now.ToString("h:mm:ss tt");
                   if (str == "P")
                   {
                       PressureBox.AppendText("\n"+d+"-->");
                   }
                   PressureBox.AppendText(str);
                   PressureBox.ScrollToCaret();

                  pres_1.AppendText(str);
                   pres_1.ScrollToCaret();

                   pres = pres_1.Text;
                   if (pres.StartsWith("P"))
                   {
                       pres = pres.Substring(1);
                   } 

                       break;

                   
               }
           case 2:/// temprature case
               {
                   longitude.Clear();
                   
                string str = Encoding.ASCII.GetString(e.Data);
                string d;
                d = DateTime.Now.ToString("h:mm:ss tt");

                if (str == "T")
                {
                    TempBox.AppendText("\n");
                    TempBox.AppendText( d+"-->");

                }
                TempBox.AppendText(str);
                TempBox.ScrollToCaret();
                tmp_1.AppendText(str);
                tmp_1.ScrollToCaret();
               
                   tmp = tmp_1.Text;
                if (tmp.StartsWith("T"))
                {
                    tmp = tmp.Substring(1);
                } 
                

              


               

                break;
            }

           case 5:////Chat Case
               {
                   string str = Encoding.ASCII.GetString(e.Data);
                   string d;
                   chatLog.Font = new Font(chatLog.Font, FontStyle.Regular);

                   d = DateTime.Now.ToString("h:mm:ss tt");
                   if (str == ":")
                   {
                       chatLog.AppendText("\n");
                       chatLog.AppendText(d + " Astronaut-->   ");
                   }
                   
                   chatLog.AppendText(str);
                   chatLog.ScrollToCaret();
                   ///////Parse temprature reading and check if exceeds safe limits
                
                   
                   ////////
                   break;
               }

           case 6:////Heart rate case
               {
                   string str = Encoding.ASCII.GetString(e.Data);
                   longitude.AppendText(str);
                   longitude.ScrollToCaret();
                   lon = longitude.Text;
                   if (lon.StartsWith("T"))
                   {
                       lon = lon.Substring(1);
                   } 
                
                   

                  


                   break;
               }
           
           case 7:  /// Pitch case
               {
                   string str = Encoding.ASCII.GetString(e.Data);
                   string d;
                   d = DateTime.Now.ToString("h:mm:ss tt");
                   if (str == "B")
                   {
                       Pitch.AppendText("\n");
                       Pitch.AppendText(d + "-->");
                   }
                   Pitch.AppendText(str);
                   Pitch.ScrollToCaret();

                  
                  
               /*    tmp_no = Convert.ToDouble(tmp);
                   if ((tmp_no >= 30 || tmp_no < 0) )
                   {
                       if (count == false)
                       {
                           tempWarning.AppendText("\n");
                           tempWarning.AppendText("Warning:: Critical Temperature ");
                           tempWarning.ScrollToCaret();
                           //MessageBox.Show("Temprature warning", "warning!",
           // MessageBoxButtons.OK, MessageBoxIcon.Error);
                           count = true;
                       }
                   }


                   ///////Parse pressure reading and check if exceeds safe limits
                 

                   pres_no = Convert.ToDouble(pres);
                   // pres_no = Double.Parse(pres);
                   if ((pres_no >= 100000 || pres_no < 10000) && count_1 == false)
                   {
                       preWarning.AppendText("\n");
                       preWarning.AppendText("Warning:: Critical pressure ");
                       preWarning.ScrollToCaret();
                     //  MessageBox.Show("Pressure warning", "warning!",
      //  MessageBoxButtons.OK, MessageBoxIcon.Error);
                       count_1 = true;

                   }*/
                   //////
                   ///////////////////////////////////////////////////////////////////////
                   ////// Parse heart rate readings and send it to the cardiogram drawer com port///
                
                   

                   //////////////////////////////////////////////////////////////////////


                   ///////////////////////////////////////////////////////////////////////
                   break;
               }
           case 8: //// Yaw case
               {
                   string str = Encoding.ASCII.GetString(e.Data);
                   string d;
                   d = DateTime.Now.ToString("h:mm:ss tt");
                   if (str == "Y")
                   {
                       YAW.AppendText("\n");
                       YAW.AppendText(d + "-->");
                   }
                   YAW.AppendText(str);
                   YAW.ScrollToCaret();
                   pres_1.Clear();
                   tmp_1.Clear();

                   break;
               }
           case 9: ///Roll case
               {
                   string str = Encoding.ASCII.GetString(e.Data);
                   string d;
                   d = DateTime.Now.ToString("h:mm:ss tt");
                   if (str == "R")
                   {
                       Roll.AppendText("\n");
                       Roll.AppendText(d + "-->");
                   }
                   Roll.AppendText(str);
                   Roll.ScrollToCaret();
                   pres_1.Clear();
                   tmp_1.Clear();

                   serialPort1.Open();
                   serialPort1.Write(lon);
                   serialPort1.Close();

                   break;
               }
    }
     }

     private void webBrowser1_load()
     {
         throw new NotImplementedException();
     }

      public void webBrowser1_Load(object sender, EventArgs e)
            {
              
             if ( lon == string.Empty)
            {
                this.Dispose();
            }
             //http://192.168.1.2:8080/stream_simple.html
                  
           
                try
            {
                StringBuilder queryAddress = new StringBuilder();
                queryAddress.Append("http://192.168.1.2:8080/stream_simple.html");
 
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

        }
   

        private void button1_Click(object sender, EventArgs e)
        {
            // Open Live video stream from astranout through chrome
            Process proc;
           proc= Process.Start("chrome.exe", "http://192.168.43.167:8080/stream_simple.html");/// Navigate by camera IP address
          


           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open heart rate pulse Display
            ProcessStartInfo processInfo = new ProcessStartInfo();
            processInfo.WorkingDirectory = "E:\\export\\Heart_Rate_Display\\application.windows64";
            processInfo.FileName = "E:\\export\\Heart_Rate_Display\\application.windows64\\Heart_Rate_Display.exe";
            processInfo.ErrorDialog = true;
            processInfo.UseShellExecute = false;
            processInfo.RedirectStandardOutput = true;
            processInfo.RedirectStandardError = true;
            Process proc = Process.Start(processInfo);



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TempBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Roll_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)///Send chat button from space station and save sent data in the chat box
        {
            string chstr = chatBox.Text;
            _spManager.Sendc(chstr);
             string f;
             chatLog.Font = new Font(chatLog.Font, FontStyle.Bold);

            f = DateTime.Now.ToString("h:mm:ss tt");
                chatLog.AppendText("\n");
                chatLog.AppendText(f + " Space station-->   ");

            chatLog.AppendText(chstr);
           // chatLog.AppendText(Environment.NewLine);

            chatLog.ScrollToCaret();
            chatBox.Clear();

        }

        private void tmp_TextChanged(object sender, EventArgs e)
        {

        }

     }    
}