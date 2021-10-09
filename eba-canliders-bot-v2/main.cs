using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace eba_canliders_bot_v2
{
    public partial class main : Form
    {
        public main()
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
        
        string target = "https://giris.eba.gov.tr/EBA_GIRIS/student.jsp";
        
        string TargetUrl = @"https://giris.eba.gov.tr/EBA_GIRIS/student.jsp";
        
        int errorCount = 0;
        
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

        /// <summary>
        /// Saving User Settings
        /// </summary>
        private void SaveUserSettings()
        {
            try
            {
                Properties.Settings.Default.IdNumber = long.Parse(txtID.Text);

                Properties.Settings.Default.Password = txtPass.Text;

                Properties.Settings.Default.IWebFirefox = rdbFirefox.Checked;

                Properties.Settings.Default.IWebChrome = rdbChrome.Checked;

                Properties.Settings.Default.IsShowId = showID.Checked;

                Properties.Settings.Default.IsShowPassword = showPass.Checked;

                Properties.Settings.Default.IsDataProtectionMode = dataProtectionMode.Checked;

                Properties.Settings.Default.IsRememberMeMode = rememberMode.Checked;

                Properties.Settings.Default.Save();

            }
            catch (Exception)
            {
                MessageBox.Show("something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Getting User Settings
        /// </summary>
        private void GetUserSettings()
        {
            try
            {
                txtID.Text = Convert.ToString(Properties.Settings.Default.IdNumber);

                txtPass.Text = Properties.Settings.Default.Password;

                rdbFirefox.Checked = Properties.Settings.Default.IWebFirefox;

                rdbChrome.Checked = Properties.Settings.Default.IWebChrome;

                showID.Checked = Properties.Settings.Default.IsShowId;

                showPass.Checked = Properties.Settings.Default.IsShowPassword;

                dataProtectionMode.Checked = Properties.Settings.Default.IsDataProtectionMode;

                rememberMode.Checked = Properties.Settings.Default.IsRememberMeMode;
            }

            catch (Exception)
            {
                MessageBox.Show("something went wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void DriverExistsController()
        {
            string ChromePath = @"chromedriver.exe";
           
            string firefoxPath = @"geckodriver.exe";

            bool fileExistChrome = File.Exists(ChromePath);
            
            bool fileExistFirefox = File.Exists(firefoxPath);

            if (fileExistChrome)

                rdbChrome.Enabled = true;
            
            else

                rdbChrome.Enabled = false;

            if (fileExistFirefox)

                rdbFirefox.Enabled = true;
         
            else
         
                rdbFirefox.Enabled = false;
            
        }

        /// <summary>
        /// Bot login client. Authorization processes work here.
        /// </summary>
        /// <returns></returns>
        private async Task Login()
        {
            try
            {
                if (rdbFirefox.Checked == true)
                {

                    var FirefoxService = FirefoxDriverService.CreateDefaultService();

                    FirefoxService.HideCommandPromptWindow = true;

                    IWebDriver geckodriver = new FirefoxDriver(FirefoxService);
                                        
                    lstLog.Items.Add("🌐 Starting IWebDriver Service...");
                    
                    File.AppendAllText("log.txt", Environment.UserName + " " + Environment.NewLine + " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm" + " " + "Starting IWebDriver Service..." + " " + Environment.NewLine + "--------------------------------------------------------------------" + Environment.NewLine));
                    
                    LogScroller();
                    
                    geckodriver.Navigate().GoToUrl(TargetUrl);
                    
                    txtID.Enabled = false;
                    
                    txtPass.Enabled = false;
                    
                    id = txtID.Text;
                    
                    password = txtPass.Text;
                    
                    IJavaScriptExecutor js = ((IJavaScriptExecutor)geckodriver);

                    if (dataProtectionMode.Checked == true)
                    {

                        js.ExecuteScript("document.getElementById('tckn').setAttribute('type', 'password')");
                    
                        lstLog.Items.Add("🔒 Data Protection Enabled");
                   
                    }

                    
                    LogScroller();
                    
                    geckodriver.FindElement(By.Id("tckn")).SendKeys(id);
                    
                    lstLog.Items.Add("✔️ ID Number Transferred");
                    
                    LogScroller();
                    
                    geckodriver.FindElement(By.Id("password")).SendKeys(password);
                    
                    LogScroller();
                    
                    lstLog.Items.Add("✔️ Password Transferred");
                    
                    geckodriver.FindElement(By.ClassName("nl-form-send-btn")).Click();
                    
                    lstLog.Items.Add("⌛ Attempting Authorization");
                    
                    LogScroller();

                    if (geckodriver.Url == target)
                    {
                        lstLog.Items.Add("✔️ Authorization Successfully");
                    
                        LogScroller();
                    }

                    else
                    {
                        lstLog.Items.Add("❌ Authentication Failed - Check your ID or Password.");
                        
                        LogScroller();
                        
                        txtID.Enabled = true;
                        
                        txtPass.Enabled = true;
                    }
                }

                else if (rdbChrome.Checked == true)
                {
                    var ChromeService = ChromeDriverService.CreateDefaultService();

                    ChromeService.HideCommandPromptWindow = true;

                    IWebDriver chromedriver = new ChromeDriver(ChromeService);
                    
                    lstLog.Items.Add("🌐 Starting IWebDriver Service...");
                    File.AppendAllText("log.txt", Environment.UserName + " " + Environment.NewLine + " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + " Starting IWebDriver Service..." + " " + Environment.NewLine + "--------------------------------------------------------------------" + Environment.NewLine);
                    
                    LogScroller();
                    
                    chromedriver.Navigate().GoToUrl(TargetUrl);
                    
                    txtID.Enabled = false;
                    
                    txtPass.Enabled = false;
                    
                    id = txtID.Text;
                    
                    password = txtPass.Text;

                    IJavaScriptExecutor js = ((IJavaScriptExecutor)chromedriver);

                    if (dataProtectionMode.Checked == true)
                    {

                        js.ExecuteScript("document.getElementById('tckn').setAttribute('type', 'password')");

                        lstLog.Items.Add("🔒 Data Protection Enabled");

                    }

                    
                    LogScroller();
                    
                    chromedriver.FindElement(By.Id("tckn")).SendKeys(id);
                    
                    lstLog.Items.Add("✔️ ID Number Transferred");
                    
                    LogScroller();
                    
                    chromedriver.FindElement(By.Id("password")).SendKeys(password);
                    
                    LogScroller();
                    
                    lstLog.Items.Add("✔️ Password Transferred");
                    
                    chromedriver.FindElement(By.ClassName("nl-form-send-btn")).Click();
                    
                    lstLog.Items.Add("⌛ Attempting Authorization");
                    
                    LogScroller();


                    if (chromedriver.Url != target)
                    {
                        lstLog.Items.Add("✔️ Authorization Successfully");
                    
                        LogScroller();
                    }
                    else
                    {
                        lstLog.Items.Add("❌ Authentication Failed - Check your ID or Password.");
                        
                        LogScroller();
                        
                        txtID.Enabled = true;
                    
                        txtPass.Enabled = true;
                    }

                }
            }
            
            catch (Exception ex)
            {
                errorCount = errorCount + 1;
                
                lstLog.Items.Add("❌ Error " + errorCount + " " + ex);
                
                LogScroller();
                
                File.AppendAllText("log.txt", Environment.UserName + " " + Environment.NewLine + " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm" + " " + ex + " " + Environment.NewLine + "--------------------------------------------------------------------" + Environment.NewLine));
            }
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            Task.Run(Login);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetUserSettings();

            if (rememberMode.Checked == false)
            {
                ClearUserSettings();
            }

            inputController.Start();
            
            driverExistsTimer.Start();
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
            
            path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\Software\Microsoft\Windows\CurrentVersion\App Paths\chrome.exe", "", null);
            
            if (path != null)
                lstLog.Items.Add("Chrome Version : " + FileVersionInfo.GetVersionInfo(path.ToString()).FileVersion);

            path = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\firefox.exe", "", null);
            
            if (path != null)
                lstLog.Items.Add("Firefox Version : " + FileVersionInfo.GetVersionInfo(path.ToString()).FileVersion);
        }

        private void showID_CheckedChanged(object sender, EventArgs e)
        {
            showid = showid + 1;
            
            if (showid % 2 == 0)
            
                txtID.UseSystemPasswordChar = true;
            
            else
               
                txtID.UseSystemPasswordChar = false;
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
            
            if (showpass % 2 == 0)
                
                txtPass.UseSystemPasswordChar = true;
            
            else
                
                txtPass.UseSystemPasswordChar = false;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Process[] ChromeIsOpen = Process.GetProcessesByName("chromedriver");
            Process[] GeckoIsOpen = Process.GetProcessesByName("geckodriver");


            if (ChromeIsOpen.Length == 0)

                this.Close();

            else

                foreach (var process in Process.GetProcessesByName("chromedriver"))
                
                    process.Kill();

            
            if (GeckoIsOpen.Length == 0)

                this.Close();
            else
            
                foreach (var process in Process.GetProcessesByName("geckodriver"))
                    process.Kill();

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
            SaveUserSettings();
        }
    }
}
