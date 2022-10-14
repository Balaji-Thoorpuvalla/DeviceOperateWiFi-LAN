using System.Windows.Forms;

namespace GUIDemo
{
    public delegate void NotifyEvent();
    public partial class Main : Form
    {
       
        public NotifyEvent notifyDelegate;

        public Main()
        {
            InitializeComponent();
            notifyDelegate += new NotifyEvent(ButtonClickedOnForm2);
            orgTitle.Left = (this.ClientSize.Width - orgTitle.Size.Width) / 2;
            Program.dashboard= new Dashboard();

        }
        public void ButtonClickedOnForm2()
        {
            orgTitle.Text = Program.organizationTitle;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //roundButton1.BackColor = Color.Green;
            //button2.Text = "Device2"+ Environment.NewLine+"OFF";
            //verSeperator1.BackColor = Color.Green;
            //seperator1.BackColor = Color.Green;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //roundButton1.BackColor = Color.Red;
            //button1.Text = "Device1" + Environment.NewLine + "ON";
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Settings settings = new Settings(notifyDelegate);

            settings.TopLevel = false;
            panel2.Controls.Add(settings);
            settings.BringToFront();
            settings.FormBorderStyle = FormBorderStyle.None;
            settings.Dock = DockStyle.Fill;
            settings.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.organizationTitle = orgTitle.Text;
            Settings settings = new Settings(notifyDelegate);
            settings.Show();
            orgTitle.Text = Program.organizationTitle;
        }

        private void orgTitle_SizeChanged(object sender, EventArgs e)
        {
            orgTitle.Left = (this.ClientSize.Width - orgTitle.Size.Width) / 2;
        }

        private void settingdbtn_Click(object sender, EventArgs e)
        {
            Program.organizationTitle = orgTitle.Text;
            Settings settings = new Settings(notifyDelegate);
            settings.TopLevel = false;
            settings.FormBorderStyle = FormBorderStyle.None;
            settings.Dock = DockStyle.Fill;
            settings.BringToFront();
            panel2.Controls.Clear();
            panel2.Controls.Add(settings);
            settings.Show();
     
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {

            // Dashboard dashboard = new Dashboard();
            Program.dashboard.TopLevel = false;
            Program.dashboard.FormBorderStyle = FormBorderStyle.None;
            Program.dashboard.Dock = DockStyle.Fill;
            Program.dashboard.BringToFront();
            panel2.Controls.Clear();
            panel2.Controls.Add(Program.dashboard);
            Program.dashboard.Show();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
           // Dashboard dashboard = new Dashboard();
            Program.dashboard.TopLevel = false;
            Program.dashboard.FormBorderStyle = FormBorderStyle.None;
            Program.dashboard.Dock = DockStyle.Fill;
            Program.dashboard.BringToFront();
            panel2.Controls.Clear();
            panel2.Controls.Add(Program.dashboard);
            Program.dashboard.Show();
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.client1.Dispose();
            Program.client1.Disconnect();

            Program.client2.Dispose();
            Program.client2.Disconnect();

            Program.client3.Dispose();
            Program.client3.Disconnect();

            Program.client4.Dispose();
            Program.client4.Disconnect();

        }
    }
}