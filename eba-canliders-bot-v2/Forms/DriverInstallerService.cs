using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.IO;

namespace eba_canliders_bot_v2.Forms
{
    public partial class DriverInstallerService : Form
    {
        public class Driver
        {
            public string Version { get; set; }

            public int SortVersion { get; set; }

            public string DownloadLink { get; set; }
        }

        string _chromePath = @"chromedriver.exe";

        public DriverInstallerService()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        int seconds = 0;
        const string rarPath = @"driver.rar";

        private static Driver GetDriver(int driverVersion)
        {
            List<Driver> drivers = new List<Driver>();

            using (WebClient myPivotsWC = new WebClient())
            {
                string htmlCode = myPivotsWC.DownloadString("https://chromedriver.chromium.org/downloads");

                HtmlDocument doc = new HtmlDocument();

                doc.LoadHtml(htmlCode);

                var list = doc.DocumentNode.SelectNodes(
@"/html/body/div[1]/div/div[2]/div[2]/div[1]/section[2]/div[2]/div/div/div/div/div/div/div/div/ul[1]/li")
.Select(li => li.InnerText).ToList();

                foreach (var item in list)
                {
                    var splittedText = item.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

                    if (splittedText.Length == 11 && splittedText[0] == "If")
                    {
                        string version = splittedText[10];

                        int sortVersion = Convert.ToInt32(version.Split('.')[0]);

                        string downloadLink = @"https://chromedriver.storage.googleapis.com/" + version + "/" + "chromedriver_win32.zip";


                        drivers.Add(new Driver { Version = version, SortVersion = sortVersion, DownloadLink = downloadLink });

                    }
                }
            }

            var driver = drivers.FirstOrDefault(x => x.SortVersion == driverVersion);

            return driver;
        }

        private void LogScroller()
        {
            lstLog.SelectedIndex = lstLog.Items.Count - 1;

            lstLog.SetSelected(lstLog.Items.Count - 1, false);
        }

        private void DriverInstallerService_Load(object sender, EventArgs e)
        {
            try
            {
                string chromePath = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe", "", null).ToString();

                chromePath = FileVersionInfo.GetVersionInfo(chromePath).FileVersion.Split('.')[0];

                string firefoxPath =
                    Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\firefox.exe", "", null).ToString();

                var driver = GetDriver(Convert.ToInt32(chromePath));

                if (driver != null)
                {
                    WebClient web = new WebClient();

                    string adress = driver.DownloadLink;

                    string path = "driver.rar";

                    Uri download = new Uri(adress);

                    web.DownloadFileAsync(download, path);

                    lstLog.Items.Add("Downloading Driver...");

                    LogScroller();

                    web.DownloadFileCompleted += WW_DownloadFileCompleted;

                }
            }
            catch (Exception ex)
            {

                lstLog.Items.Add($"Error {ex}");
            }

        }

        private void formPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();

            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void WW_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            try
            {

                lstLog.Items.Add("Driver Successfully Downloaded!");

                LogScroller();

                bool fileExistChrome = File.Exists(_chromePath);

                if (fileExistChrome)
                {
                    lstLog.Items.Add("");

                    LogScroller();

                    File.Delete(_chromePath);

                    string zipPath = @"driver.rar";

                    string destination = @".\";

                    lstLog.Items.Add($"Extracting Driver from {rarPath}");

                    LogScroller();

                    ZipFile.ExtractToDirectory(zipPath, destination);

                    lstLog.Items.Add($"Driver Extracted from {rarPath} Successfully");

                    LogScroller();

                    lstLog.Items.Add($"Deleting {rarPath} File. Please Wait...");


                    LogScroller();

                    File.Delete(rarPath);

                    lstLog.Items.Add($"{rarPath} File Deleted Successfully!");

                    LogScroller();

                    lstLog.Items.Add("Task Completed. Redirecting...");

                    LogScroller();

                    RedirectController.Start();

                }
            }
            catch (Exception ex)
            {
                lstLog.Items.Add($"Error : {ex}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RedirectController_Tick(object sender, EventArgs e)
        {
            seconds = seconds + 1;

            if (seconds == 3)
            {
                main redirectMain = new main();
                
                this.Hide();
                
                redirectMain.Show();
            }
        }
    }
}