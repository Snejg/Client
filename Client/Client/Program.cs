using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                int portNumber = int.Parse(args[0]);
                string ipAddress = args[1];
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(portNumber, ipAddress));
            }
            catch(IndexOutOfRangeException)
            {
                System.Console.WriteLine("Please set port to listen");
            }

        }
    }
}
