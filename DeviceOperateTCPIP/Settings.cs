using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUIDemo
{
    public partial class Settings : Form
    {
        NotifyEvent notifyDel;

        public Settings(NotifyEvent notify)
        {
            InitializeComponent();
            notifyDel = notify;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.organizationTitle = orgName.Text;
            Program.site1 = site1txt.Text;
            Program.site2 = site2txt.Text;
            Program.site3 = site3txt.Text;
            Program.site4 = site4txt.Text;

            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    Program.S1Device1 = device1txt.Text;
                    Program.S1Device2 = device2txt.Text;
                    Program.S1Device3 = device3txt.Text;
                    Program.S1Device4 = device4txt.Text;
                    break;
                case 1:
                    Program.S2Device1 = device1txt.Text;
                    Program.S2Device2 = device2txt.Text;
                    Program.S2Device3 = device3txt.Text;
                    Program.S2Device4 = device4txt.Text;
                    break;
                case 2:
                    Program.S3Device1 = device1txt.Text;
                    Program.S3Device2 = device2txt.Text;
                    Program.S3Device3 = device3txt.Text;
                    Program.S3Device4 = device4txt.Text;
                    break;
                case 4:
                    Program.S4Device1 = device1txt.Text;
                    Program.S4Device2 = device2txt.Text;
                    Program.S4Device3 = device3txt.Text;
                    Program.S4Device4 = device4txt.Text;
                    break;
            }


            notifyDel.Invoke();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
           orgName.Text = Program.organizationTitle;

            device1IP.Text = Program.IPAddress1;
            device2IP.Text = Program.IPAddress2;
            device3IP.Text = Program.IPAddress3;
            device4IP.Text = Program.IPAddress4;
            if(Program.Site1Connected)
            {
                pingdev1.Enabled = false;
                button6.Enabled = true;
                status1.Text = "Successful";
                status1.ForeColor = Color.Green;

            }
            else
            {
                pingdev1.Enabled = true;
                button6.Enabled = false;
            }

            if (Program.Site2Connected)
            {
                button2.Enabled = false;
                button7.Enabled = true;
                status2.Text = "Successful";
                status2.ForeColor = Color.Green;

            }
            else
            {
                button2.Enabled = true;
                button7.Enabled = false;
            }
        }

        private void pingdev1_Click(object sender, EventArgs e)
        {
            //bool status=PingTest(device1IP.Text);

            //if(status)
            //{
            //    status1.Text = "Successful";
            //    status1.ForeColor = Color.Green;
            //}
            //else
            //{
            //    status1.Text = "Failed";
            //    status1.ForeColor = Color.Red;
            //    return;
            //}

            // Site1
      
            //Connect to server
            try
            {
                Program.IPAddress1 = device1IP.Text;

                Program.client1.Connect(Program.IPAddress1, Convert.ToInt32("8234"));
                pingstatusbar.ForeColor = Color.Gold;
                pingstatusbar.Text = "Connection to server Successful";
                pingdev1.Enabled = false;
                button6.Enabled = true;
                status1.Text = "Successful";
                status1.ForeColor = Color.Green;
                Program.Site1Connected = true;

            }
            catch (Exception ex)
            {
                pingstatusbar.ForeColor = Color.Gold;
                pingstatusbar.Text = "Connection Failure.." +
                   "Please check IP address and Port..Is Server Running?";
                pingdev1.Enabled = true;
                button6.Enabled = false;
                status1.Text = "Failed";
                status1.ForeColor = Color.Red;
                Program.Site1Connected = false;

            }

        }
        private bool PingTest(string ipaddress)
        {
            pingstatusbar.Text = "";
            if (string.IsNullOrWhiteSpace(ipaddress) || ipaddress == "")
            {
                MessageBox.Show("Please use valid IP or web address!!");
                return false;
            }
            try
            {
                Ping p = new Ping();
                PingReply r;
                string s;
                s = ipaddress;
                r = p.Send(s);

                if (r.Status == IPStatus.Success)
                {
                    pingstatusbar.Text = "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Successful"
                       + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                    pingstatusbar.ForeColor = Color.Gold;
                    return true;
                }
                else
                {
                    pingstatusbar.Text = "Ping to " + s.ToString() + "[" + r.Address.ToString() + "]" + " Failed"
                        + " Response delay = " + r.RoundtripTime.ToString() + " ms" + "\n";
                    pingstatusbar.ForeColor = Color.Red;
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please use valid IP or web address!!");
                return false;
            }
        }
        private void device1IP_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(device1IP.Text) || device1IP.Text == "")
            {
                MessageBox.Show("Please provide valid IP or web address!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Site2
            //Connect to server
            try
            {
                Program.IPAddress2 = device2IP.Text;

                Program.client2.Connect(Program.IPAddress2, Convert.ToInt32("8234"));
                pingstatusbar.ForeColor = Color.Gold;
                pingstatusbar.Text = "Connection to server Successful";
                button2.Enabled = false;
                button7.Enabled = true;
                status2.Text = "Successful";
                status2.ForeColor = Color.Green;
                Program.Site2Connected = true;

            }
            catch (Exception ex)
            {
                pingstatusbar.ForeColor = Color.Gold;
                pingstatusbar.Text = "Connection Failure.." +
                   "Please check IP address and Port..Is Server Running?";
                button2.Enabled = true;
                button7.Enabled = false;
                status2.Text = "Failed";
                status2.ForeColor = Color.Red;
                Program.Site2Connected = false;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //Site3
            //Connect to server
            try
            {
                Program.IPAddress3 = device3IP.Text;

                Program.client3.Connect(Program.IPAddress3, Convert.ToInt32("8234"));
                pingstatusbar.ForeColor = Color.Gold;
                pingstatusbar.Text = "Connection to server Successful";
                button3.Enabled = false;
                button8.Enabled = true;
                status3.Text = "Successful";
                status3.ForeColor = Color.Green;
                Program.Site3Connected = true;
            }
            catch (Exception ex)
            {
                pingstatusbar.ForeColor = Color.Gold;
                pingstatusbar.Text = "Connection Failure.." +
                   "Please check IP address and Port..Is Server Running?";
                button3.Enabled = true;
                button8.Enabled = false;
                status3.Text = "Failed";
                status3.ForeColor = Color.Red;
                Program.Site3Connected = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Site4
            //Connect to server
            try
            {
                Program.IPAddress4 = device4IP.Text;

                Program.client4.Connect(Program.IPAddress4, Convert.ToInt32("8234"));
                pingstatusbar.ForeColor = Color.Gold;
                pingstatusbar.Text = "Connection to server Successful";
                button4.Enabled = false;
                button9.Enabled = true;
                status4.Text = "Successful";
                status4.ForeColor = Color.Green;
                Program.Site4Connected = true;

            }
            catch (Exception ex)
            {
                pingstatusbar.ForeColor = Color.Gold;
                pingstatusbar.Text = "Connection Failure.." +
                   "Please check IP address and Port..Is Server Running?";
                button4.Enabled = true;
                button9.Enabled = false;
                status4.Text = "Failed";
                status4.ForeColor = Color.Red;
                Program.Site4Connected = false;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.client1.Dispose();
            Program.client1.Disconnect();
            pingdev1.Enabled = true;
            button6.Enabled = false;
            status1.Text = "Disconnected";
            status1.ForeColor = Color.Red;
            Program.Site1Connected = false;

        }

        private void button7_Click(object sender, EventArgs e)
        {

            Program.client2.Dispose();
            Program.client2.Disconnect();
            button2.Enabled = true;
            button7.Enabled = false;
            status2.Text = "Disconnected";
            status2.ForeColor = Color.Red;
            Program.Site2Connected = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.client3.Dispose();
            Program.client3.Disconnect();
            button3.Enabled = true;
            button8.Enabled = false;
            status3.Text = "Disconnected";
            status3.ForeColor = Color.Red;
            Program.Site3Connected = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Program.client4.Dispose();
            Program.client4.Disconnect();
            button4.Enabled = true;
            button9.Enabled = false;
            status4.Text = "Disconnected";
            status4.ForeColor = Color.Red;
            Program.Site4Connected = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show("volume");
        }
    }
}
