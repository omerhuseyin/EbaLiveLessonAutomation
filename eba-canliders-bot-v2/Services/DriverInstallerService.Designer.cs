
namespace eba_canliders_bot_v2.Forms
{
    partial class DriverInstallerService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverInstallerService));
            this.formPanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnSource = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RedirectController = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.btnExit);
            this.formPanel.Controls.Add(this.btnMinimize);
            this.formPanel.Controls.Add(this.btnSource);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(522, 38);
            this.formPanel.TabIndex = 0;
            this.formPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formPanel_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = global::eba_canliders_bot_v2.Properties.Resources.close;
            this.btnExit.Location = new System.Drawing.Point(48, 11);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(17, 17);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::eba_canliders_bot_v2.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(31, 11);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(17, 17);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnSource
            // 
            this.btnSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSource.Image = global::eba_canliders_bot_v2.Properties.Resources.source;
            this.btnSource.Location = new System.Drawing.Point(14, 11);
            this.btnSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(17, 17);
            this.btnSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSource.TabIndex = 0;
            this.btnSource.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eba-Bot | coded by laweis © 2021 ";
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.lstLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLog.Enabled = false;
            this.lstLog.ForeColor = System.Drawing.Color.White;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(255, 171);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(267, 112);
            this.lstLog.TabIndex = 9;
            this.lstLog.SelectedIndexChanged += new System.EventHandler(this.lstLog_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "All legal responsibility belongs to the user.";
            // 
            // RedirectController
            // 
            this.RedirectController.Interval = 1000;
            this.RedirectController.Tick += new System.EventHandler(this.RedirectController_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(23, 157);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(107, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // DriverInstallerService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(522, 289);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DriverInstallerService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriverInstallerService";
            this.Load += new System.EventHandler(this.DriverInstallerService_Load);
            this.formPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnSource;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer RedirectController;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}