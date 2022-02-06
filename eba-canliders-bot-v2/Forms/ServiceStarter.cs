using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Net;
using HtmlAgilityPack;
using RestSharp;
using Newtonsoft.Json;

namespace eba_canliders_bot_v2
{
    public partial class ServiceStarter : Form
    {
        public ServiceStarter()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string password = string.Empty;
        string id = string.Empty;
        string TargetUrl = @"https://giris.eba.gov.tr/EBA_GIRIS/student.jsp";
        int showid = 0;
        int showpass = 0;

        /// <summary>
        /// Form Move Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ClearUserSettings()
        {
            txtID.Text = string.Empty;
            txtPass.Text = string.Empty;
            rdbFirefox.Checked = false;
            rdbChrome.Checked = false;
            showID.Checked = false;
            showPass.Checked = false;
            dataProtectionMode.Checked = false;
            rememberMode.Checked = false;
        }

        /// <summary>
        /// Log Scroller : scrolls the log list down as new record is added
        /// </summary>
        private void LogScroller()
        {
            lstLog.SelectedIndex = lstLog.Items.Count - 1;
            lstLog.SetSelected(lstLog.Items.Count - 1, false);
        }

        private void DriverProcessTerminationService()
        {
            Process[] ChromeIsOpen = Process.GetProcessesByName("chromedriver");
            Process[] GeckoIsOpen = Process.GetProcessesByName("geckodriver");

            try
            {
                if (ChromeIsOpen.Length != 0)
                {
                    foreach (var process in Process.GetProcessesByName("chromedriver")) process.Kill();
                    LoggingService.WriteLog("geckodriver service has been closed.");
                }

                if (GeckoIsOpen.Length != 0)
                {
                    foreach (var process in Process.GetProcessesByName("geckodriver")) process.Kill();
                    LoggingService.WriteLog("geckodriver service has been closed.");
                }

                this.Close();
                LoggingService.WriteLog("Software Has Been Closed.");
                Environment.Exit(0);

            }
            catch (Exception) { return; }
            
        }

        private void DriverExistsController()
        {
            string ChromePath = @"chromedriver.exe";
            string firefoxPath = @"geckodriver.exe";
            bool fileExistChrome = File.Exists(ChromePath);
            bool fileExistFirefox = File.Exists(firefoxPath);
            if (fileExistChrome) rdbChrome.Enabled = true;
            else rdbChrome.Enabled = false;

            if (fileExistFirefox) rdbFirefox.Enabled = true;
            else rdbFirefox.Enabled = false;

        }

        /// <summary>
        /// Bot login client. Authorization processes work here.
        /// </summary>
        /// <returns></returns>
        /// 

        IWebDriver driver;

        private async Task Login()
        {
            try
            {
                var client = new RestClient("http://www.api.qsoft.cf/ebabotconfig.json");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);

                var api = JsonConvert.DeserializeObject<API>(response.Content);

                if (rdbFirefox.Checked)
                {
                    var Firefox = FirefoxDriverService.CreateDefaultService();
                    Firefox.HideCommandPromptWindow = true;
                    driver = new FirefoxDriver(Firefox);
                }
                else if (rdbChrome.Checked)
                {
                    var Chrome = ChromeDriverService.CreateDefaultService();
                    Chrome.HideCommandPromptWindow = true;
                    driver = new ChromeDriver(Chrome);
                }

                lstLog.Items.Add("🌐 Starting IWebDriver Service...");
                LogScroller();
                driver.Navigate().GoToUrl(TargetUrl);
                txtID.Enabled = false;
                txtPass.Enabled = false;
                id = txtID.Text;
                password = txtPass.Text;
                IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);

                if (dataProtectionMode.Checked == true)
                {
                    js.ExecuteScript("document.getElementById('tckn').setAttribute('type', 'password')");
                    lstLog.Items.Add("🔒 Data Protection Enabled");
                    LoggingService.WriteLog("Data Protection Enabled (tckn).setAttribute('type', 'password')");
                }

                LogScroller();
                driver.FindElement(By.Id("tckn")).SendKeys(id);
                lstLog.Items.Add("✔️ ID Number Transferred");
                LoggingService.WriteLog($" ID Number Matching This Filter Has Been Transferred ({id})");
                LogScroller();
                driver.FindElement(By.Id("password")).SendKeys(password);
                LogScroller();
                lstLog.Items.Add("✔️ Password Transferred");
                LoggingService.WriteLog($" Password Matching This Filter Has Been Transferred ({password})");
                driver.FindElement(By.ClassName("nl-form-send-btn")).Click();
                LoggingService.WriteLog("Authorization Button Clicked. Attempting Authorization...");
                lstLog.Items.Add("⌛ Attempting Authorization");
                LogScroller();
                var alert = driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div[2]/div")).Text;
                LogScroller();

                if (!(alert == "Lütfen kendinize uygun giriş seçeneğinden giriniz."))
                {
                    lstLog.Items.Add("✔️ Authorization Successfully");
                    LoggingService.WriteLog("Authorization Successfully");
                    LogScroller();
                }
                else
                {
                    lstLog.Items.Add("❌ Authentication Failed - Check your ID or Password.");
                    LoggingService.WriteLog("Authentication Failed. Try Again.");
                    LogScroller();
                    txtID.Enabled = true;
                    txtPass.Enabled = true;
                }
            }
            catch (Exception) { return; }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Task.Run(Login);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var client = new RestClient("http://www.api.qsoft.cf/ebabotconfig.json");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var api = JsonConvert.DeserializeObject<API>(response.Content);
            LoggingService.WriteLog("--------------------------------------------");
            LoggingService.WriteLog("Eba Bot Opened");
            LoggingService.WriteLog("Eba Bot Service Status : OK");

            if (rememberMode.Checked == false) ClearUserSettings();
            

            inputController.Start();
            driverExistsTimer.Start();
            versionNumber.Text = $"{api.shortVersion}";
        }

        /// <summary>
        /// Checking Browser Versions 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckVersion_Click(object sender, EventArgs e)
        {
            object path;
            lstLog.Items.Add("Checking... Please Wait.");

            try
            {
                path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe", "", null);
                if (path != null) lstLog.Items.Add("Chrome Version : " + FileVersionInfo.GetVersionInfo(path.ToString()).FileVersion);

                path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\firefox.exe", "", null);
                if (path != null) lstLog.Items.Add("Firefox Version : " + FileVersionInfo.GetVersionInfo(path.ToString()).FileVersion);
            }
            catch (Exception) { return; }
            
        }

        private void showID_CheckedChanged(object sender, EventArgs e)
        {
            showid = showid + 1;

            if (showid % 2 == 0) txtID.UseSystemPasswordChar = true;
            else  txtID.UseSystemPasswordChar = false;
        }

        /// <summary>
        /// Input shutdown turns functions off or on based on some criteria.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void inputController_Tick(object sender, EventArgs e)
        {
            if (txtID.Text.Length < 11 || txtPass.Text.Length < 3 || rdbChrome.Checked == false && rdbFirefox.Checked == false)
            {
                btnStart.Enabled = false;
                btnStart.Cursor = Cursors.No;
            }

            else
            {
                btnStart.Enabled = true;
                btnStart.Cursor = Cursors.Hand;
            }
        }

        /// <summary>
        /// When clicking anywhere in the ID textbox, it jumps to the beginning.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtIDSetCursorPosition(object sender, EventArgs e)
        {
            txtID.Select(txtID.Text.Length, 0);
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            showpass = showpass + 1;

            if (showpass % 2 == 0) txtPass.UseSystemPasswordChar = true;
            else txtPass.UseSystemPasswordChar = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void driverExistsTimer_Tick(object sender, EventArgs e)
        {
            DriverExistsController();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
