# Graphical User Interface for the Bluetooth sensor

# Imports
import os
import time
import serial
from Tkinter import *
from ScrolledText import *
from PIL import Image, ImageTk
from time import sleep 
from datetime import datetime

# Serial port parameters
serial_speed = 9600
serial_port = '/dev/ttyACM0'

# Test with USB-Serial connection
# serial_port = '/dev/ttyACM0'
ser = serial.Serial(serial_port, serial_speed, timeout=1)

file = open("/home/pi/Desktop/data_log.csv", "a")
if os.stat("/home/pi/Desktop/data_log.csv").st_size == 0:
        chatdata.set="Chat"
        file.write("Temperature,Preasure,Heart rate,Date & Time\n")
        
# Main Tkinter application
class Application(Frame):


        def openkey(self):
                os.system("sh keyboard.sh &")

        def opencamera(self):
                os.system("sh camera.sh &")

        def closecamera(self):
                os.system("sh clos.sh &")
    
        def startchat(self):
                #if(self.chat_state == "OFF"):
                ser.write(",")
                ser.write(":")
                now=datetime.now()
                self.chatLog.insert(END,(str(now)+"Astronaut:\n"))
                #self.chat_state.set(1)

        def stopchat(self):
                #self.chat_state.set(0)
                #if(self.chat_state == "ON"):
                self.chatLog.insert(END,".\n")
                ser.write(",")
        
        # Measure data from the sensor
        def measure(self):
                self.temp_data.set = "Temperature"
                self.preasure_data.set= "Preasure"
                self.heart_rate_data.set = "Heart rate"

	# Request data and read the answer
                #ser.write("m")
                data = ser.readline()
		# If the answer is not empty, process & display data
                if (data[0] == ","):
                        if (data[1] == "T"):
                                now = datetime.now()
                                t_processed_data = data[2:-4]
                                self.tempLog.insert(END,str(now)+'    '+str(t_processed_data)+'\n')
                                #self.temp_data.set("Temperature: " + str(t_processed_data))
                                file.write(str(t_processed_data)+",")
                        elif (data[1] == "P"):
                                now = datetime.now()
                                p_processed_data = data[2:-4]
                                self.preasureLog.insert(END,str(now)+'    '+str(p_processed_data)+'\n')
                                #self.preasure_data.set("Preasure: " + str(p_processed_data))
                                file.write(str(p_processed_data)+",")
                        elif (data[1] == "H"):
                                now = datetime.now()
                                h_processed_data = data[2:-4]
                                self.heartLog.insert(END,str(now)+'    '+str(h_processed_data)+'\n')
                                #self.heart_rate_data.set("Heart rate: " + str(h_processed_data))
                                file.write(str(h_processed_data)+","+str(now)+"\n")
                        elif (data[1] == ":"):
                                now = datetime.now()
                                print "hello amr"
                                self.chatLog.insert(END,(str(now)+"  Spacecraft:\n"+str(data[2:-4])))

                
                #if(self.chat_state == "ON"):
                        #ser.write(event.char)
                        #self.chatLog.insert(END,str(event.char))
                        #if(event.char == "\n"):
                                #self.chatLog.insert(END,"\n")
                                #ser.write(",")
                                #ser.write(",")
                                #ser.write(":")
                                
                file.flush()
                self.after(1,self.measure)


	# Create display elements
        def createWidgets(self):
                allframe = Frame(root, width=800, height =480)
                allframe.grid(row=0, column=0, padx=0, pady=0, sticky=N+S)
                
                backgroundFile = "rpi.jpg"
                bckImage = Image.open(backgroundFile)
                bckImage = bckImage.resize((self.width, self.height), resample=3)
                background = ImageTk.PhotoImage(bckImage)
                bckPanel = Label(allframe, image=background)
                bckPanel.grid(row=0, column=0, padx=0, pady=0, sticky=W)
                bckPanel.image = background

                openkeyBtn = Button(root, text="KeyBoard", command=self.openkey, bg="white") #create a button inside the btnFrame with the given features
                openkeyBtn.place(x=5,y=320)

                CameraBtn = Button(root, text="Camera", command=self.opencamera, bg="white")
                CameraBtn.place(x=280,y=320)

                startchatBtn = Button(root, text="Start chat", command=self.startchat, bg="white") #create a button inside the btnFrame with the given features
                startchatBtn.place(x=95,y=320)

                stopcameraBtn = Button(root, text="stop camera", command=self.closecamera, bg="white") #create a button inside the btnFrame with the given features
                stopcameraBtn.place(x=365,y=320)

                stopchatBtn = Button(root, text="Stop chat", command=self.stopchat, bg="white") #create a button inside the btnFrame with the given features
                stopchatBtn.place(x=190,y=320)

                self.chatLog = ScrolledText(root, width = 115, height = 20, takefocus=0, highlightthickness=1, highlightbackground="#333")
                self.chatLog.place(x=5, y=350)
                
                self.temperature = Label(root, textvariable=self.temp_data, bg="white", font=('Verdana', 15, 'bold'))
                self.temp_data.set("Temperature")
                self.temperature.place(x=80, y=0)

                self.tempLog = ScrolledText(root, width = 35, height = 20, takefocus=0, highlightthickness=1, highlightbackground="#333")
                self.tempLog.place(x=5, y=25)

                self.preasureLog = ScrolledText(root, width = 35, height = 20, takefocus=0, highlightthickness=1, highlightbackground="#333")
                self.preasureLog.place(x=285, y=25)

                self.heartLog = ScrolledText(root, width = 35, height = 20, takefocus=0, highlightthickness=1, highlightbackground="#333")
                self.heartLog.place(x=560, y=25)
                
                self.preasure = Label(root, textvariable=self.preasure_data, bg="white", font=('Verdana', 15, 'bold'))
                self.preasure_data.set("Preasure")
                self.preasure.place(x=370, y=0)

                self.heart_rate = Label(root, textvariable=self.heart_rate_data, bg="white", font=('Verdana', 15, 'bold'))
                self.heart_rate_data.set("Heart rate")
                self.heart_rate.place(x=630, y=0)

                
	# Init the variables & start measurements
        def __init__(self, master=None):
                Frame.__init__(self, master)
                self.master = master
                self.width = self.winfo_screenwidth()
                self.height = self.winfo_screenheight()
                self.temp_data = StringVar()
                self.preasure_data = StringVar()
                self.heart_rate_data = StringVar()
                self.createWidgets()
                #self.pack()
                self.measure()

# Create and run the GUI
root = Tk()
root.wm_title("Orion's Astronaut GUI")
#root.geometry("800x480")
root.configure(background = "black")
app = Application(master=root)
app.mainloop()
file.close()
