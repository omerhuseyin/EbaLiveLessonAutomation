
namespace eba_canliders_bot_v2
{
    partial class main
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
            this.formPanel = new System.Windows.Forms.Panel();
            this.btnSourceCode = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rememberMode = new System.Windows.Forms.CheckBox();
            this.dataProtectionMode = new System.Windows.Forms.CheckBox();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.showID = new System.Windows.Forms.CheckBox();
            this.rdbChrome = new System.Windows.Forms.RadioButton();
            this.rdbFirefox = new System.Windows.Forms.RadioButton();
            this.btnCheckVersion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.inputController = new System.Windows.Forms.Timer(this.components);
            this.driverExistsTimer = new System.Windows.Forms.Timer(this.components);
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSourceCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.btnSourceCode);
            this.formPanel.Controls.Add(this.label1);
            this.formPanel.Controls.Add(this.btnMinimize);
            this.formPanel.Controls.Add(this.btnQuit);
            this.formPanel.Controls.Add(this.pictureBox1);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(860, 56);
            this.formPanel.TabIndex = 0;
            this.formPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formPanel_MouseDown);
            // 
            // btnSourceCode
            // 
            this.btnSourceCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSourceCode.Image = global::eba_canliders_bot_v2.Properties.Resources.source;
            this.btnSourceCode.Location = new System.Drawing.Point(778, 18);
            this.btnSourceCode.Name = "btnSourceCode";
            this.btnSourceCode.Size = new System.Drawing.Size(20, 20);
            this.btnSourceCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSourceCode.TabIndex = 3;
            this.btnSourceCode.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eba Canlı Ders Bot - WinForm Version";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::eba_canliders_bot_v2.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(797, 18);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.Image = global::eba_canliders_bot_v2.Properties.Resources.close;
            this.btnQuit.Location = new System.Drawing.Point(817, 18);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(20, 20);
            this.btnQuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnQuit.TabIndex = 1;
            this.btnQuit.TabStop = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::eba_canliders_bot_v2.Properties.Resources.zoom;
            this.pictureBox1.Location = new System.Drawing.Point(28, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Details";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(210, 70);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(125, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(210, 35);
            this.txtID.Mask = "00000000000";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 22);
            this.txtID.TabIndex = 1;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.UseSystemPasswordChar = true;
            this.txtID.ValidatingType = typeof(int);
            this.txtID.Click += new System.EventHandler(this.txtIDSetCursorPosition);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "System Login Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "TR Identification Number :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLog);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(28, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 205);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.lstLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLog.ForeColor = System.Drawing.Color.White;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 17;
            this.lstLog.Location = new System.Drawing.Point(2, 16);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(802, 187);
            this.lstLog.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(101, 18);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rememberMode);
            this.groupBox3.Controls.Add(this.dataProtectionMode);
            this.groupBox3.Controls.Add(this.showPass);
            this.groupBox3.Controls.Add(this.showID);
            this.groupBox3.Controls.Add(this.rdbChrome);
            this.groupBox3.Controls.Add(this.rdbFirefox);
            this.groupBox3.Controls.Add(this.btnCheckVersion);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(413, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 128);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Functions";
            // 
            // rememberMode
            // 
            this.rememberMode.AutoSize = true;
            this.rememberMode.Location = new System.Drawing.Point(308, 94);
            this.rememberMode.Name = "rememberMode";
            this.rememberMode.Size = new System.Drawing.Size(92, 21);
            this.rememberMode.TabIndex = 9;
            this.rememberMode.Text = "Remember";
            this.rememberMode.UseVisualStyleBackColor = true;
            // 
            // dataProtectionMode
            // 
            this.dataProtectionMode.AutoSize = true;
            this.dataProtectionMode.Location = new System.Drawing.Point(180, 94);
            this.dataProtectionMode.Name = "dataProtectionMode";
            this.dataProtectionMode.Size = new System.Drawing.Size(123, 21);
            this.dataProtectionMode.TabIndex = 8;
            this.dataProtectionMode.Text = "Data Protection";
            this.dataProtectionMode.UseVisualStyleBackColor = true;
            // 
            // showPass
            // 
            this.showPass.AutoSize = true;
            this.showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPass.Location = new System.Drawing.Point(90, 94);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(87, 21);
            this.showPass.TabIndex = 7;
            this.showPass.Text = "Show Pass";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // showID
            // 
            this.showID.AutoSize = true;
            this.showID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showID.Location = new System.Drawing.Point(10, 94);
            this.showID.Name = "showID";
            this.showID.Size = new System.Drawing.Size(74, 21);
            this.showID.TabIndex = 6;
            this.showID.Text = "Show ID";
            this.showID.UseVisualStyleBackColor = true;
            this.showID.CheckedChanged += new System.EventHandler(this.showID_CheckedChanged);
            // 
            // rdbChrome
            // 
            this.rdbChrome.AutoSize = true;
            this.rdbChrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbChrome.Location = new System.Drawing.Point(232, 64);
            this.rdbChrome.Name = "rdbChrome";
            this.rdbChrome.Size = new System.Drawing.Size(144, 21);
            this.rdbChrome.TabIndex = 5;
            this.rdbChrome.TabStop = true;
            this.rdbChrome.Text = "Chrome Web Driver";
            this.rdbChrome.UseVisualStyleBackColor = true;
            // 
            // rdbFirefox
            // 
            this.rdbFirefox.AutoSize = true;
            this.rdbFirefox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbFirefox.Location = new System.Drawing.Point(41, 64);
            this.rdbFirefox.Name = "rdbFirefox";
            this.rdbFirefox.Size = new System.Drawing.Size(136, 21);
            this.rdbFirefox.TabIndex = 4;
            this.rdbFirefox.TabStop = true;
            this.rdbFirefox.Text = "Firefox Web Driver";
            this.rdbFirefox.UseVisualStyleBackColor = true;
            // 
            // btnCheckVersion
            // 
            this.btnCheckVersion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckVersion.FlatAppearance.BorderSize = 0;
            this.btnCheckVersion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckVersion.Location = new System.Drawing.Point(232, 18);
            this.btnCheckVersion.Name = "btnCheckVersion";
            this.btnCheckVersion.Size = new System.Drawing.Size(103, 35);
            this.btnCheckVersion.TabIndex = 2;
            this.btnCheckVersion.Text = "Check Version";
            this.btnCheckVersion.UseVisualStyleBackColor = true;
            this.btnCheckVersion.Click += new System.EventHandler(this.btnCheckVersion_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 70);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::eba_canliders_bot_v2.Properties.Resources.twitter;
            this.pictureBox4.Location = new System.Drawing.Point(455, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::eba_canliders_bot_v2.Properties.Resources.github;
            this.pictureBox3.Location = new System.Drawing.Point(434, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::eba_canliders_bot_v2.Properties.Resources.instagram;
            this.pictureBox2.Location = new System.Drawing.Point(413, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "coded by laweis | © 2021";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "All legal responsibility belongs to the user.";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputController
            // 
            this.inputController.Interval = 10;
            this.inputController.Tick += new System.EventHandler(this.inputController_Tick);
            // 
            // driverExistsTimer
            // 
            this.driverExistsTimer.Tick += new System.EventHandler(this.driverExistsTimer_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(15)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(860, 482);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.formPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eba-Bot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSourceCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnQuit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btnSourceCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCheckVersion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdbChrome;
        private System.Windows.Forms.RadioButton rdbFirefox;
        private System.Windows.Forms.CheckBox showPass;
        private System.Windows.Forms.CheckBox showID;
        private System.Windows.Forms.Timer inputController;
        private System.Windows.Forms.Timer driverExistsTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox dataProtectionMode;
        private System.Windows.Forms.CheckBox rememberMode;
    }
}

