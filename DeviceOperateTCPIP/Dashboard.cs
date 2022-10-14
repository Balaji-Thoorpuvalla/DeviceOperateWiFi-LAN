using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDemo
{ 
    public partial class Dashboard : Form
    {
        string feedbackmsgs1 = "";
        string feedbackmsgs2 = "";
        string feedbackmsgs3 = "";
        string feedbackmsgs4 = "";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            site1Date.Text = now.Date.ToString();
            Site1Time.Text = now.TimeOfDay.ToString();
            label1.Text = Program.site1;
            label74.Text = Program.site2;
            label112.Text = Program.site3;
            label150.Text = Program.site4;
            //site1
            //site1Relay1.Text = Program.S1Device1+"\r\nON";
            //site1Relay2.Text = Program.S1Device2+"\r\nOFF"; ;
            //site1Relay3.Text = Program.S1Device3 + "\r\nON"; ; 
            //site1Relay4.Text = Program.S1Device4+"\r\nOFF";
            ////site2
            //site2Relay1.Text = Program.S2Device1 + "\r\nON";
            //site2Relay2.Text = Program.S2Device2 + "\r\nOFF"; ;
            //site2Relay3.Text = Program.S2Device3 + "\r\nON"; ;
            //site2Relay4.Text = Program.S2Device4 + "\r\nOFF";
            ////site3
            //site3Relay1.Text = Program.S3Device1 + "\r\nON";
            //site3Relay2.Text = Program.S3Device2 + "\r\nOFF"; ;
            //site3Relay3.Text = Program.S3Device3 + "\r\nON"; ;
            //site3Relay4.Text = Program.S3Device4 + "\r\nOFF";
            ////site4
            //site4Relay1.Text = Program.S4Device1 + "\r\nON";
            //site4Relay2.Text = Program.S4Device2 + "\r\nOFF"; ;
            //site4Relay3.Text = Program.S4Device3 + "\r\nON"; ;
            //site4Relay4.Text = Program.S4Device4 + "\r\nOFF";


            // Site1
           
            Program.client1.StringEncoder = Encoding.ASCII;
            Program.client1.DataReceived += Client1_DataReceived;

            // Site2
            Program.client2.StringEncoder = Encoding.ASCII;
            Program.client2.DataReceived += Client2_DataReceived;

            // Site3
            Program.client3.StringEncoder = Encoding.ASCII;
            Program.client3.DataReceived += Client3_DataReceived;

            // Site4
            Program.client4.StringEncoder = Encoding.ASCII;
            Program.client4.DataReceived += Client4_DataReceived;

            Program.dashboard.comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;

            if(Program.Site1Connected)
            {
                Program.dashboard.site1Relay1.Enabled =  true;
                Program.dashboard.site1Relay2.Enabled = true;
                Program.dashboard.site1Relay3.Enabled = true;
                Program.dashboard.site1Relay4.Enabled = true;
            }
            else
            {
                Program.dashboard.site1Relay1.Enabled = false;
                Program.dashboard.site1Relay2.Enabled = false;
                Program.dashboard.site1Relay3.Enabled = false;
                Program.dashboard.site1Relay4.Enabled = false;
            }

            if (Program.Site2Connected)
            {
                site2Relay1.Enabled = true;
                site2Relay2.Enabled = true;
                site2Relay3.Enabled = true;
                site2Relay4.Enabled = true;
            }
            else
            {
                site2Relay1.Enabled = false;
                site2Relay2.Enabled = false;
                site2Relay3.Enabled = false;
                site2Relay4.Enabled = false;
            }

            if (Program.Site3Connected)
            {
                site3Relay1.Enabled = true;
                site3Relay2.Enabled = true;
                site3Relay3.Enabled = true;
                site3Relay4.Enabled = true;
            }
            else
            {
                site3Relay1.Enabled = false;
                site3Relay2.Enabled = false;
                site3Relay3.Enabled = false;
                site3Relay4.Enabled = false;
            }

            if (Program.Site4Connected)
            {
                site4Relay1.Enabled = true;
                site4Relay2.Enabled = true;
                site4Relay3.Enabled = true;
                site4Relay4.Enabled = true;
            }
            else
            {
                site4Relay1.Enabled = false;
                site4Relay2.Enabled = false;
                site4Relay3.Enabled = false;
                site4Relay4.Enabled = false;
            }
        }

        private void Client4_DataReceived(object? sender, SimpleTCP.Message e)
        {
            feedbackmsgs4 = e.MessageString;
            switch (feedbackmsgs4)
            {
                //Relay1 
                case ">01_DDMMYYHHMMSS_CS_ON":
                    roundButton60.BackColor = Color.Green;
                    roundButton50.BackColor = Color.Green;
                    break;
                case ">01_DDMMYYHHMMSS_CS_OFF":
                    roundButton60.BackColor = Color.Green;
                    roundButton50.BackColor = Color.Red;
                    break;
                case ">No_Reply1":
                    roundButton60.BackColor = Color.Red;
                    roundButton50.BackColor = Color.Red;
                    break;
                //Relay2
                case ">02_DDMMYYHHMMSS_CS_ON":
                    roundButton59.BackColor = Color.Green;
                    roundButton49.BackColor = Color.Green;
                    break;
                case ">02_DDMMYYHHMMSS_CS_OFF":
                    roundButton59.BackColor = Color.Green;
                    roundButton49.BackColor = Color.Red;
                    break;
                case ">No_Reply2":
                    roundButton59.BackColor = Color.Red;
                    roundButton49.BackColor = Color.Red;
                    break;
                //Relay3
                case ">03_DDMMYYHHMMSS_CS_ON":
                    roundButton58.BackColor = Color.Green;
                    roundButton48.BackColor = Color.Green;
                    break;
                case ">03_DDMMYYHHMMSS_CS_OFF":
                    roundButton58.BackColor = Color.Green;
                    roundButton48.BackColor = Color.Red;
                    break;
                case ">No_Reply3":
                    roundButton58.BackColor = Color.Red;
                    roundButton47.BackColor = Color.Red;
                    break;
                //Relay4
                case ">04_DDMMYYHHMMSS_CS_ON":
                    roundButton57.BackColor = Color.Green;
                    roundButton47.BackColor = Color.Green;
                    break;
                case ">04_DDMMYYHHMMSS_CS_OFF":
                    roundButton57.BackColor = Color.Green;
                    roundButton47.BackColor = Color.Red;
                    break;
                case ">No_Reply4":
                    roundButton57.BackColor = Color.Red;
                    roundButton47.BackColor = Color.Red;
                    break;

            }
        }

        private void Client3_DataReceived(object? sender, SimpleTCP.Message e)
        {
            feedbackmsgs3 = e.MessageString;
            switch (feedbackmsgs3)
            {
                //Relay1 
                case ">01_DDMMYYHHMMSS_CS_ON":
                    roundButton45.BackColor = Color.Green;
                    roundButton35.BackColor = Color.Green;
                    break;
                case ">01_DDMMYYHHMMSS_CS_OFF":
                    roundButton45.BackColor = Color.Green;
                    roundButton35.BackColor = Color.Red;
                    break;
                case ">No_Reply1":
                    roundButton45.BackColor = Color.Red;
                    roundButton35.BackColor = Color.Red;
                    break;
                //Relay2
                case ">02_DDMMYYHHMMSS_CS_ON":
                    roundButton44.BackColor = Color.Green;
                    roundButton34.BackColor = Color.Green;
                    break;
                case ">02_DDMMYYHHMMSS_CS_OFF":
                    roundButton44.BackColor = Color.Green;
                    roundButton34.BackColor = Color.Red;
                    break;
                case ">No_Reply2":
                    roundButton44.BackColor = Color.Red;
                    roundButton34.BackColor = Color.Red;
                    break;
                //Relay3
                case ">03_DDMMYYHHMMSS_CS_ON":
                    roundButton43.BackColor = Color.Green;
                    roundButton33.BackColor = Color.Green;
                    break;
                case ">03_DDMMYYHHMMSS_CS_OFF":
                    roundButton43.BackColor = Color.Green;
                    roundButton33.BackColor = Color.Red;
                    break;
                case ">No_Reply3":
                    roundButton43.BackColor = Color.Red;
                    roundButton33.BackColor = Color.Red;
                    break;
                //Relay4
                case ">04_DDMMYYHHMMSS_CS_ON":
                    roundButton42.BackColor = Color.Green;
                    roundButton32.BackColor = Color.Green;
                    break;
                case ">04_DDMMYYHHMMSS_CS_OFF":
                    roundButton42.BackColor = Color.Green;
                    roundButton32.BackColor = Color.Red;
                    break;
                case ">No_Reply4":
                    roundButton42.BackColor = Color.Red;
                    roundButton32.BackColor = Color.Red;
                    break;

            }
        }

        private void Client2_DataReceived(object? sender, SimpleTCP.Message e)
        {
            feedbackmsgs2 = e.MessageString;
            switch (feedbackmsgs2)
            {
                //Relay1 
                case ">01_DDMMYYHHMMSS_CS_ON":
                    roundButton30.BackColor = Color.Green;
                    roundButton20.BackColor = Color.Green;
                    break;
                case ">01_DDMMYYHHMMSS_CS_OFF":
                    roundButton30.BackColor = Color.Green;
                    roundButton20.BackColor = Color.Red;
                    break;
                case ">No_Reply1":
                    roundButton30.BackColor = Color.Red;
                    roundButton20.BackColor = Color.Red;
                    break;
                //Relay2
                case ">02_DDMMYYHHMMSS_CS_ON":
                    roundButton29.BackColor = Color.Green;
                    roundButton19.BackColor = Color.Green;
                    break;
                case ">02_DDMMYYHHMMSS_CS_OFF":
                    roundButton29.BackColor = Color.Green;
                    roundButton19.BackColor = Color.Red;
                    break;
                case ">No_Reply2":
                    roundButton29.BackColor = Color.Red;
                    roundButton19.BackColor = Color.Red;
                    break;
                //Relay3
                case ">03_DDMMYYHHMMSS_CS_ON":
                    roundButton28.BackColor = Color.Green;
                    roundButton18.BackColor = Color.Green;
                    break;
                case ">03_DDMMYYHHMMSS_CS_OFF":
                    roundButton28.BackColor = Color.Green;
                    roundButton18.BackColor = Color.Red;
                    break;
                case ">No_Reply3":
                    roundButton28.BackColor = Color.Red;
                    roundButton18.BackColor = Color.Red;
                    break;
                //Relay4
                case ">04_DDMMYYHHMMSS_CS_ON":
                    roundButton27.BackColor = Color.Green;
                    roundButton17.BackColor = Color.Green;
                    break;
                case ">04_DDMMYYHHMMSS_CS_OFF":
                    roundButton27.BackColor = Color.Green;
                    roundButton17.BackColor = Color.Red;
                    break;
                case ">No_Reply4":
                    roundButton27.BackColor = Color.Red;
                    roundButton17.BackColor = Color.Red;
                    break;

            }
        }

        private void Client1_DataReceived(object? sender, SimpleTCP.Message e)
        {
            feedbackmsgs1 = e.MessageString;

            switch(feedbackmsgs1)
            {
                //Relay1
                case ">01_DDMMYYHHMMSS_CS_ON":
                    roundButton1.BackColor = Color.Green;
                    roundButton11.BackColor = Color.Green;
                    break;
                case ">01_DDMMYYHHMMSS_CS_OFF":
                    roundButton1.BackColor = Color.Green;
                    roundButton11.BackColor = Color.Red;
                    break;
                case ">No_Reply1":
                    roundButton1.BackColor = Color.Red;
                    roundButton11.BackColor = Color.Red;
                    break;
                    //Relay2
                case ">02_DDMMYYHHMMSS_CS_ON":
                    roundButton2.BackColor = Color.Green;
                    roundButton12.BackColor = Color.Green;
                    break;
                case ">02_DDMMYYHHMMSS_CS_OFF":
                    roundButton2.BackColor = Color.Green;
                    roundButton12.BackColor = Color.Red;
                    break;
                case ">No_Reply2":
                    roundButton2.BackColor = Color.Red;
                    roundButton12.BackColor = Color.Red;
                    break;
                //Relay3
                case ">03_DDMMYYHHMMSS_CS_ON":
                    roundButton3.BackColor = Color.Green;
                    roundButton13.BackColor = Color.Green;
                    break;
                case ">03_DDMMYYHHMMSS_CS_OFF":
                    roundButton3.BackColor = Color.Green;
                    roundButton13.BackColor = Color.Red;
                    break;
                case ">No_Reply3":
                    roundButton3.BackColor = Color.Red;
                    roundButton13.BackColor = Color.Red;
                    break;
                //Relay4
                case ">04_DDMMYYHHMMSS_CS_ON":
                    roundButton4.BackColor = Color.Green;
                    roundButton14.BackColor = Color.Green;
                    break;
                case ">04_DDMMYYHHMMSS_CS_OFF":
                    roundButton4.BackColor = Color.Green;
                    roundButton14.BackColor = Color.Red;
                    break;
                case ">No_Reply4":
                    roundButton4.BackColor = Color.Red;
                    roundButton14.BackColor = Color.Red;
                    break;

            }


        }

        private void Clear(object sender, EventArgs e)
        {
           // panel1.Visible = false;
            panel1.Controls.Clear();
            panel1.BackColor = Color.Azure;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel1.Visible = true;
              
            }
            else
            {
                panel1.Visible = false;
     
            }

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void site1Relay1_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s1R1OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client1.Write(command);
                site1Relay1.BackColor = Color.Green;
                Program.s1R1OnOff = true;
                site1Relay1.Text = Program.S1Device1 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client1.Write(command);
                site1Relay1.BackColor = Color.Red;
                Program.s1R1OnOff = false;
                site1Relay1.Text = Program.S1Device1 + Environment.NewLine + "OFF";
            }

        }

        private void site1Relay2_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s1R2OnOff)
            {
                command = "#02_ON" + Environment.NewLine;
                Program.client1.Write(command);
                site1Relay2.BackColor = Color.Green;
                Program.s1R2OnOff = true;
                site1Relay2.Text = Program.S1Device2 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#02_OFF" + Environment.NewLine;
                Program.client1.Write(command);
                site1Relay2.BackColor = Color.Red;
                Program.s1R2OnOff = false;
                site1Relay2.Text = Program.S1Device2 + Environment.NewLine + "OFF";
            }

        }

        private void site1Relay3_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s1R3OnOff)
            {
                command = "#03_ON" + Environment.NewLine;
                Program.client1.Write(command);
                site1Relay3.BackColor = Color.Green;
                Program.s1R3OnOff = true;
                site1Relay3.Text = Program.S1Device3 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#03_OFF" + Environment.NewLine;
                Program.client1.Write(command);
                site1Relay3.BackColor = Color.Red;
                Program.s1R3OnOff = false;
                site1Relay3.Text = Program.S1Device3 + Environment.NewLine + "OFF";
            }
        }

        private void site1Relay4_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s1R4OnOff)
            {
                command = "#04_ON" + Environment.NewLine;
                Program.client1.Write(command);
                site1Relay4.BackColor = Color.Green;
                Program.s1R4OnOff = true;
                site1Relay4.Text = Program.S1Device4 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#04_OFF" + Environment.NewLine;
                Program.client1.Write(command);
                site1Relay4.BackColor = Color.Red;
                Program.s1R4OnOff = false;
                site1Relay4.Text = Program.S1Device4 + Environment.NewLine + "OFF";
            }
        }

        private void site1Audio_Click(object sender, EventArgs e)
        {
             string command = "";

            int selection = comboBox1.SelectedIndex;
            switch(selection)
            {
                case 0:
                    command = "$01_ON" + Environment.NewLine;
                    Program.client1.Write(command);
                    site1Audio.BackColor = Color.Green;
                    Program.s1Audio = true;
                    site1Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 1:
                    command = "$02_ON" + Environment.NewLine;
                    Program.client1.Write(command);
                    site1Audio.BackColor = Color.Green;
                    Program.s1Audio = true;
                    site1Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 2:
                    command = "$03_ON" + Environment.NewLine;
                    Program.client1.Write(command);
                    site1Audio.BackColor = Color.Green;
                    Program.s1Audio = true;
                    site1Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 3:
                    command = "$01_OFF" + Environment.NewLine;
                    Program.client1.Write(command);
                    site1Audio.BackColor = Color.Green;
                    Program.s1Audio = false;
                    site1Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;
                case 4:
                    command = "$02_OFF" + Environment.NewLine;
                    Program.client1.Write(command);
                    site1Audio.BackColor = Color.Green;
                    Program.s1Audio = false;
                    site1Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;
                case 5:
                    command = "$03_OFF" + Environment.NewLine;
                    Program.client1.Write(command);
                    site1Audio.BackColor = Color.Green;
                    Program.s1Audio = false;
                    site1Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();  
                    break;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (site1Audio.BackColor == Color.Green)
            {
                site1Audio.BackColor = Color.Gray;
            }
            else
            {
                site1Audio.BackColor = Color.Green;
            }
        }

        private void site2Relay1_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s2R1OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client2.Write(command);
                site2Relay1.BackColor = Color.Green;
                Program.s2R1OnOff = true;
                site2Relay1.Text = Program.S2Device1 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client2.Write(command);
                site2Relay1.BackColor = Color.Red;
                Program.s2R1OnOff = false;
                site2Relay1.Text = Program.S2Device1 + Environment.NewLine + "OFF";
            }
        }

        private void site2Relay2_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s2R2OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client2.Write(command);
                site2Relay2.BackColor = Color.Green;
                Program.s2R2OnOff = true;
                site2Relay2.Text = Program.S2Device2 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client2.Write(command);
                site2Relay2.BackColor = Color.Red;
                Program.s2R2OnOff = false;
                site2Relay2.Text = Program.S2Device2 + Environment.NewLine + "OFF";
            }
        }

        private void site2Relay3_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s2R3OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client2.Write(command);
                site2Relay3.BackColor = Color.Green;
                Program.s2R3OnOff = true;
                site2Relay3.Text = Program.S2Device3 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client2.Write(command);
                site2Relay3.BackColor = Color.Red;
                Program.s2R3OnOff = false;
                site2Relay3.Text = Program.S2Device3 + Environment.NewLine + "OFF";
            }
        }

        private void site2Relay4_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s2R4OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client2.Write(command);
                site2Relay4.BackColor = Color.Green;
                Program.s2R4OnOff = true;
                site2Relay4.Text = Program.S2Device4 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client2.Write(command);
                site2Relay4.BackColor = Color.Red;
                Program.s2R4OnOff = false;
                site2Relay4.Text = Program.S2Device4 + Environment.NewLine + "OFF";
            }

        }

        private void site2Audio_Click(object sender, EventArgs e)
        {

            string command = "";

            int selection = comboBox2.SelectedIndex;
            switch (selection)
            {
                case 0:
                    command = "$01_ON" + Environment.NewLine;
                    Program.client2.Write(command);
                    site2Audio.BackColor = Color.Green;
                    Program.s2Audio = true;
                    site2Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 1:
                    command = "$02_ON" + Environment.NewLine;
                    Program.client2.Write(command);
                    site2Audio.BackColor = Color.Green;
                    Program.s2Audio = true;
                    site2Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 2:
                    command = "$03_ON" + Environment.NewLine;
                    Program.client2.Write(command);
                    site2Audio.BackColor = Color.Green;
                    Program.s2Audio = true;
                    site2Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 3:
                    command = "$01_OFF" + Environment.NewLine;
                    Program.client2.Write(command);
                    site2Audio.BackColor = Color.Green;
                    Program.s2Audio = false;
                    site2Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;
                case 4:
                    command = "$02_OFF" + Environment.NewLine;
                    Program.client2.Write(command);
                    site2Audio.BackColor = Color.Green;
                    Program.s2Audio = false;
                    site2Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;
                case 5:
                    command = "$03_OFF" + Environment.NewLine;
                    Program.client2.Write(command);
                    site2Audio.BackColor = Color.Green;
                    Program.s2Audio = false;
                    site2Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;

            }

        }

        private void site3Relay1_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s3R1OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client3.Write(command);
                site3Relay1.BackColor = Color.Green;
                Program.s3R1OnOff = true;
                site3Relay1.Text = Program.S3Device1 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client3.Write(command);
                site3Relay1.BackColor = Color.Red;
                Program.s3R1OnOff = false;
                site3Relay1.Text = Program.S3Device1 + Environment.NewLine + "OFF";
            }

        }

        private void site3Relay2_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s3R2OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client3.Write(command);
                site3Relay2.BackColor = Color.Green;
                Program.s3R2OnOff = true;
                site3Relay2.Text = Program.S3Device2 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client3.Write(command);
                site3Relay2.BackColor = Color.Red;
                Program.s3R2OnOff = false;
                site3Relay2.Text = Program.S3Device2 + Environment.NewLine + "OFF";
            }

        }

        private void site3Relay3_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s3R3OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client3.Write(command);
                site3Relay3.BackColor = Color.Green;
                Program.s3R3OnOff = true;
                site3Relay3.Text = Program.S3Device4 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client3.Write(command);
                site3Relay3.BackColor = Color.Red;
                Program.s3R3OnOff = false;
                site3Relay3.Text = Program.S3Device3 + Environment.NewLine + "OFF";
            }

        }

        private void site3Relay4_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s3R4OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client3.Write(command);
                site3Relay4.BackColor = Color.Green;
                Program.s3R4OnOff = true;
                site3Relay4.Text = Program.S3Device4 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client3.Write(command);
                site3Relay4.BackColor = Color.Red;
                Program.s3R4OnOff = false;
                site3Relay4.Text = Program.S3Device4 + Environment.NewLine + "OFF";
            }
        }

        private void site3Audio_Click(object sender, EventArgs e)
        {
            string command = "";

            int selection = comboBox3.SelectedIndex;
            switch (selection)
            {
                case 0:
                    command = "$01_ON" + Environment.NewLine;
                    Program.client3.Write(command);
                    site3Audio.BackColor = Color.Green;
                    Program.s3Audio = true;
                    site3Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 1:
                    command = "$02_ON" + Environment.NewLine;
                    Program.client3.Write(command);
                    site3Audio.BackColor = Color.Green;
                    Program.s3Audio = true;
                    site3Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 2:
                    command = "$03_ON" + Environment.NewLine;
                    Program.client3.Write(command);
                    site3Audio.BackColor = Color.Green;
                    Program.s3Audio = true;
                    site3Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 3:
                    command = "$01_OFF" + Environment.NewLine;
                    Program.client3.Write(command);
                    site3Audio.BackColor = Color.Green;
                    Program.s3Audio = false;
                    site3Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;
                case 4:
                    command = "$02_OFF" + Environment.NewLine;
                    Program.client3.Write(command);
                    site3Audio.BackColor = Color.Green;
                    Program.s3Audio = false;
                    site3Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;
                case 5:
                    command = "$03_OFF" + Environment.NewLine;
                    Program.client3.Write(command);
                    site3Audio.BackColor = Color.Green;
                    Program.s3Audio = false;
                    site3Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;

            }
        }

        private void site4Relay1_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s4R1OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client4.Write(command);
                site4Relay1.BackColor = Color.Green;
                Program.s4R1OnOff = true;
                site4Relay1.Text = Program.S4Device1 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client4.Write(command);
                site4Relay1.BackColor = Color.Red;
                Program.s4R1OnOff = false;
                site4Relay1.Text = Program.S4Device1 + Environment.NewLine + "OFF";
            }
        }

        private void site4Relay2_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s4R2OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client4.Write(command);
                site4Relay2.BackColor = Color.Green;
                Program.s4R2OnOff = true;
                site4Relay2.Text = Program.S4Device2 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client4.Write(command);
                site4Relay2.BackColor = Color.Red;
                Program.s4R2OnOff = false;
                site4Relay2.Text = Program.S4Device2 + Environment.NewLine + "OFF";
            }
        }

        private void site4Relay3_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s4R3OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client4.Write(command);
                site4Relay3.BackColor = Color.Green;
                Program.s4R3OnOff = true;
                site4Relay3.Text = Program.S4Device3 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client4.Write(command);
                site4Relay3.BackColor = Color.Red;
                Program.s4R3OnOff = false;
                site4Relay3.Text = Program.S4Device3 + Environment.NewLine + "OFF";
            }

        }

        private void site4Relay4_Click(object sender, EventArgs e)
        {
            string command = "";
            if (!Program.s4R4OnOff)
            {
                command = "#01_ON" + Environment.NewLine;
                Program.client4.Write(command);
                site4Relay4.BackColor = Color.Green;
                Program.s4R4OnOff = true;
                site4Relay4.Text = Program.S4Device4 + Environment.NewLine + "ON";
            }
            else
            {
                command = "#01_OFF" + Environment.NewLine;
                Program.client4.Write(command);
                site4Relay4.BackColor = Color.Red;
                Program.s4R4OnOff = false;
                site4Relay4.Text = Program.S4Device4 + Environment.NewLine + "OFF";
            }
        }

        private void site4Audio_Click(object sender, EventArgs e)
        {
            string command = "";

            int selection = comboBox4.SelectedIndex;
            switch (selection)
            {
                case 0:
                    command = "$01_ON" + Environment.NewLine;
                    Program.client4.Write(command);
                    site4Audio.BackColor = Color.Green;
                    Program.s4Audio = true;
                    site4Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 1:
                    command = "$02_ON" + Environment.NewLine;
                    Program.client4.Write(command);
                    site4Audio.BackColor = Color.Green;
                    Program.s4Audio = true;
                    site4Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 2:
                    command = "$03_ON" + Environment.NewLine;
                    Program.client4.Write(command);
                    site4Audio.BackColor = Color.Green;
                    Program.s4Audio = true;
                    site4Audio.Text = "Audio" + Environment.NewLine + "ON";
                    timer1.Start();
                    break;
                case 3:
                    command = "$01_OFF" + Environment.NewLine;
                    Program.client4.Write(command);
                    site4Audio.BackColor = Color.Green;
                    Program.s4Audio = false;
                    site4Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;
                case 4:
                    command = "$02_OFF" + Environment.NewLine;
                    Program.client4.Write(command);
                    site4Audio.BackColor = Color.Green;
                    Program.s4Audio = false;
                    site4Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;
                case 5:
                    command = "$03_OFF" + Environment.NewLine;
                    Program.client4.Write(command);
                    site4Audio.BackColor = Color.Green;
                    Program.s4Audio = false;
                    site4Audio.Text = "Audio" + Environment.NewLine + "OFF";
                    timer1.Stop();
                    break;

            }
        }

        private void Dashboard_Shown(object sender, EventArgs e)
        {
            if (Program.Site1Connected)
            {
                site1Relay1.Enabled = true;
                site1Relay2.Enabled = true;
                site1Relay3.Enabled = true;
                site1Relay4.Enabled = true;
            }
            else
            {
                site1Relay1.Enabled = false;
                site1Relay2.Enabled = false;
                site1Relay3.Enabled = false;
                site1Relay4.Enabled = false;
            }

            if (Program.Site2Connected)
            {
                site2Relay1.Enabled = true;
                site2Relay2.Enabled = true;
                site2Relay3.Enabled = true;
                site2Relay4.Enabled = true;
            }
            else
            {
                site2Relay1.Enabled = false;
                site2Relay2.Enabled = false;
                site2Relay3.Enabled = false;
                site2Relay4.Enabled = false;
            }

            if (Program.Site3Connected)
            {
                site3Relay1.Enabled = true;
                site3Relay2.Enabled = true;
                site3Relay3.Enabled = true;
                site3Relay4.Enabled = true;
            }
            else
            {
                site3Relay1.Enabled = false;
                site3Relay2.Enabled = false;
                site3Relay3.Enabled = false;
                site3Relay4.Enabled = false;
            }

            if (Program.Site4Connected)
            {
                site4Relay1.Enabled = true;
                site4Relay2.Enabled = true;
                site4Relay3.Enabled = true;
                site4Relay4.Enabled = true;
            }
            else
            {
                site4Relay1.Enabled = false;
                site4Relay2.Enabled = false;
                site4Relay3.Enabled = false;
                site4Relay4.Enabled = false;
            }
        }

        private void Dashboard_MouseEnter(object sender, EventArgs e)
        {
            if (Program.Site1Connected)
            {
                site1Relay1.Enabled = true;
                site1Relay2.Enabled = true;
                site1Relay3.Enabled = true;
                site1Relay4.Enabled = true;
            }
            else
            {
                site1Relay1.Enabled = false;
                site1Relay2.Enabled = false;
                site1Relay3.Enabled = false;
                site1Relay4.Enabled = false;
            }

            if (Program.Site2Connected)
            {
                site2Relay1.Enabled = true;
                site2Relay2.Enabled = true;
                site2Relay3.Enabled = true;
                site2Relay4.Enabled = true;
            }
            else
            {
                site2Relay1.Enabled = false;
                site2Relay2.Enabled = false;
                site2Relay3.Enabled = false;
                site2Relay4.Enabled = false;
            }

            if (Program.Site3Connected)
            {
                site3Relay1.Enabled = true;
                site3Relay2.Enabled = true;
                site3Relay3.Enabled = true;
                site3Relay4.Enabled = true;
            }
            else
            {
                site3Relay1.Enabled = false;
                site3Relay2.Enabled = false;
                site3Relay3.Enabled = false;
                site3Relay4.Enabled = false;
            }

            if (Program.Site4Connected)
            {
                site4Relay1.Enabled = true;
                site4Relay2.Enabled = true;
                site4Relay3.Enabled = true;
                site4Relay4.Enabled = true;
            }
            else
            {
                site4Relay1.Enabled = false;
                site4Relay2.Enabled = false;
                site4Relay3.Enabled = false;
                site4Relay4.Enabled = false;
            }
        }

        private void Site1AllDevbtn_Click(object sender, EventArgs e)
        {

        }

        private void Site2AllDevbtn_Click(object sender, EventArgs e)
        {

        }

        private void Site3AllDevbtn_Click(object sender, EventArgs e)
        {

        }

        private void Site4AllDevbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
