using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eba_canliders_bot_v2
{
    public partial class loader : Form
    {
        public loader()
        {
            InitializeComponent();
        }

        bool process = false;

        private void OpacityController_Tick(object sender, EventArgs e)
        {
            if (!process) this.Opacity = this.Opacity + 0.012;

            if (this.Opacity == 1.0) process = true;


            if (process)
            { 
                this.Opacity = this.Opacity -= 0.012;

                if (this.Opacity == 0)
                {
                    Forms.DriverInstallerService RedirectInstaller = new Forms.DriverInstallerService();
                    RedirectInstaller.Show();
                    OpacityController.Enabled = false;
                    this.Hide();
                }
            }
        }

        private void loader_Load(object sender, EventArgs e)
        {

        }
    }
}
