using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eba_canliders_bot_v2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Process[] ChromeIsOpen = Process.GetProcessesByName("chromedriver");

            Process[] GeckoIsOpen = Process.GetProcessesByName("geckodriver");


            if (ChromeIsOpen.Length != 0)

                foreach (var process in Process.GetProcessesByName("chromedriver"))

                    process.Kill();

            if (GeckoIsOpen.Length != 0)

                foreach (var process in Process.GetProcessesByName("geckodriver"))

                    process.Kill();

            Application.Run(new loader());
        }
    }
}
