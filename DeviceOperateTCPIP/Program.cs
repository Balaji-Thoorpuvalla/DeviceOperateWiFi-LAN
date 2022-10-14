using SimpleTCP;

namespace GUIDemo
{
    internal static class Program
    {

        public static string organizationTitle = "";
        public static string site1 = "Site 1";
        public static string site2 = "Site 2";
        public static string site3 = "Site 3";
        public static string site4 = "Site 4";

        public static string S1Device1 = "Device 1";
        public static string S1Device2 = "Device 2";
        public static string S1Device3 = "Device 3";
        public static string S1Device4 = "Device 4";

        public static string S2Device1 = "Device 1";
        public static string S2Device2 = "Device 2";
        public static string S2Device3 = "Device 3";
        public static string S2Device4 = "Device 4";

        public static string S3Device1 = "Device 1";
        public static string S3Device2 = "Device 2";
        public static string S3Device3 = "Device 3";
        public static string S3Device4 = "Device 4";

        public static string S4Device1 = "Device 1";
        public static string S4Device2 = "Device 2";
        public static string S4Device3 = "Device 3";
        public static string S4Device4 = "Device 4";

        public static string IPAddress1 = "192.168.1.3";
        public static string IPAddress2 = "127.0.0.1";
        public static string IPAddress3 = "127.0.0.1";
        public static string IPAddress4 = "127.0.0.1";

        public static SimpleTcpClient client1;
        public static SimpleTcpClient client2;
        public static SimpleTcpClient client3;
        public static SimpleTcpClient client4;


        public static bool s1R1OnOff =false;
        public static bool s1R2OnOff = false;
        public static bool s1R3OnOff = false;
        public static bool s1R4OnOff = false;
        public static bool s1Audio = false;

        public static bool s2R1OnOff = false;
        public static bool s2R2OnOff = false;
        public static bool s2R3OnOff = false;
        public static bool s2R4OnOff = false;
        public static bool s2Audio = false;

        public static bool s3R1OnOff = false;
        public static bool s3R2OnOff = false;
        public static bool s3R3OnOff = false;
        public static bool s3R4OnOff = false;
        public static bool s3Audio = false;

        public static bool s4R1OnOff = false;
        public static bool s4R2OnOff = false;
        public static bool s4R3OnOff = false;
        public static bool s4R4OnOff = false;
        public static bool s4Audio = false;

        public static bool Site1Connected = false;
        public static bool Site2Connected = false;
        public static bool Site3Connected = false;
        public static bool Site4Connected = false;

        public static Dashboard dashboard;




        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Program.client1 = new SimpleTcpClient();
            Program.client2 = new SimpleTcpClient();
            Program.client3 = new SimpleTcpClient();
            Program.client4 = new SimpleTcpClient();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}