namespace LogitechRestarterConfig
{
    partial class FrmLogitechRestarterConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogitechRestarterConfig));
            this.lblLogitechExe = new System.Windows.Forms.Label();
            this.txtLogitechExe = new System.Windows.Forms.TextBox();
            this.lblRunning = new System.Windows.Forms.Label();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.chkStartOnLogin = new System.Windows.Forms.CheckBox();
            this.lblInstalled = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblBitness = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.txtInstalled = new System.Windows.Forms.TextBox();
            this.txtBitness = new System.Windows.Forms.TextBox();
            this.lblRestarterRunning = new System.Windows.Forms.Label();
            this.lblRestarterPid = new System.Windows.Forms.Label();
            this.checkTimer = new System.Windows.Forms.Timer(this.components);
            this.LcoreFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnPickLcore = new System.Windows.Forms.Button();
            this.chkRegSearch = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblLogitechExe
            // 
            this.lblLogitechExe.AutoSize = true;
            this.lblLogitechExe.Location = new System.Drawing.Point(73, 15);
            this.lblLogitechExe.Name = "lblLogitechExe";
            this.lblLogitechExe.Size = new System.Drawing.Size(107, 13);
            this.lblLogitechExe.TabIndex = 3;
            this.lblLogitechExe.Text = "Logitech Executable:";
            // 
            // txtLogitechExe
            // 
            this.txtLogitechExe.Location = new System.Drawing.Point(183, 12);
            this.txtLogitechExe.Name = "txtLogitechExe";
            this.txtLogitechExe.Size = new System.Drawing.Size(301, 20);
            this.txtLogitechExe.TabIndex = 2;
            this.txtLogitechExe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtLogitechExe_MouseClick);
            this.txtLogitechExe.TextChanged += new System.EventHandler(this.txtLogitechExe_TextChanged);
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Location = new System.Drawing.Point(89, 162);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(91, 13);
            this.lblRunning.TabIndex = 4;
            this.lblRunning.Text = "Restarter running:";
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(183, 182);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(100, 26);
            this.btnStartStop.TabIndex = 6;
            this.btnStartStop.Text = "Start Restarter";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // chkStartOnLogin
            // 
            this.chkStartOnLogin.AutoSize = true;
            this.chkStartOnLogin.Location = new System.Drawing.Point(183, 116);
            this.chkStartOnLogin.Name = "chkStartOnLogin";
            this.chkStartOnLogin.Size = new System.Drawing.Size(129, 17);
            this.chkStartOnLogin.TabIndex = 7;
            this.chkStartOnLogin.Text = "Start restarter on login";
            this.chkStartOnLogin.UseVisualStyleBackColor = true;
            this.chkStartOnLogin.CheckedChanged += new System.EventHandler(this.chkStartOnLogin_CheckedChanged);
            // 
            // lblInstalled
            // 
            this.lblInstalled.AutoSize = true;
            this.lblInstalled.Location = new System.Drawing.Point(3, 41);
            this.lblInstalled.Name = "lblInstalled";
            this.lblInstalled.Size = new System.Drawing.Size(177, 13);
            this.lblInstalled.TabIndex = 8;
            this.lblInstalled.Text = "Logitech Gaming Software Installed:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(135, 67);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(45, 13);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.Text = "Version:";
            // 
            // lblBitness
            // 
            this.lblBitness.AutoSize = true;
            this.lblBitness.Location = new System.Drawing.Point(116, 93);
            this.lblBitness.Name = "lblBitness";
            this.lblBitness.Size = new System.Drawing.Size(64, 13);
            this.lblBitness.TabIndex = 10;
            this.lblBitness.Text = "32 or 64 Bit:";
            // 
            // txtVersion
            // 
            this.txtVersion.Enabled = false;
            this.txtVersion.Location = new System.Drawing.Point(183, 64);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(301, 20);
            this.txtVersion.TabIndex = 11;
            // 
            // txtInstalled
            // 
            this.txtInstalled.Enabled = false;
            this.txtInstalled.Location = new System.Drawing.Point(183, 38);
            this.txtInstalled.Name = "txtInstalled";
            this.txtInstalled.Size = new System.Drawing.Size(301, 20);
            this.txtInstalled.TabIndex = 12;
            this.txtInstalled.Text = "(none detected)";
            // 
            // txtBitness
            // 
            this.txtBitness.Enabled = false;
            this.txtBitness.Location = new System.Drawing.Point(183, 90);
            this.txtBitness.Name = "txtBitness";
            this.txtBitness.Size = new System.Drawing.Size(301, 20);
            this.txtBitness.TabIndex = 13;
            // 
            // lblRestarterRunning
            // 
            this.lblRestarterRunning.AutoSize = true;
            this.lblRestarterRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestarterRunning.ForeColor = System.Drawing.Color.Red;
            this.lblRestarterRunning.Location = new System.Drawing.Point(178, 153);
            this.lblRestarterRunning.Name = "lblRestarterRunning";
            this.lblRestarterRunning.Size = new System.Drawing.Size(25, 26);
            this.lblRestarterRunning.TabIndex = 14;
            this.lblRestarterRunning.Text = "●";
            // 
            // lblRestarterPid
            // 
            this.lblRestarterPid.AutoSize = true;
            this.lblRestarterPid.Location = new System.Drawing.Point(209, 162);
            this.lblRestarterPid.Name = "lblRestarterPid";
            this.lblRestarterPid.Size = new System.Drawing.Size(0, 13);
            this.lblRestarterPid.TabIndex = 15;
            // 
            // checkTimer
            // 
            this.checkTimer.Enabled = true;
            this.checkTimer.Interval = 1000;
            this.checkTimer.Tick += new System.EventHandler(this.checkTimer_Tick);
            // 
            // LcoreFileDialog
            // 
            this.LcoreFileDialog.FileName = "C:\\Program Files\\Logitech Gaming Software\\LCore.exe";
            this.LcoreFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LcoreFileDialog_FileOk);
            // 
            // btnPickLcore
            // 
            this.btnPickLcore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPickLcore.BackgroundImage")));
            this.btnPickLcore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPickLcore.Location = new System.Drawing.Point(490, 8);
            this.btnPickLcore.Name = "btnPickLcore";
            this.btnPickLcore.Size = new System.Drawing.Size(28, 26);
            this.btnPickLcore.TabIndex = 16;
            this.btnPickLcore.UseVisualStyleBackColor = true;
            this.btnPickLcore.Click += new System.EventHandler(this.btnPickLcore_Click);
            // 
            // chkRegSearch
            // 
            this.chkRegSearch.AutoSize = true;
            this.chkRegSearch.Location = new System.Drawing.Point(183, 139);
            this.chkRegSearch.Name = "chkRegSearch";
            this.chkRegSearch.Size = new System.Drawing.Size(168, 17);
            this.chkRegSearch.TabIndex = 17;
            this.chkRegSearch.Text = "Search registry for LGS details";
            this.chkRegSearch.UseVisualStyleBackColor = true;
            this.chkRegSearch.CheckedChanged += new System.EventHandler(this.chkRegSearch_CheckedChanged);
            // 
            // FrmLogitechRestarterConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 215);
            this.Controls.Add(this.chkRegSearch);
            this.Controls.Add(this.btnPickLcore);
            this.Controls.Add(this.lblRestarterPid);
            this.Controls.Add(this.lblRestarterRunning);
            this.Controls.Add(this.txtBitness);
            this.Controls.Add(this.txtInstalled);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.lblBitness);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblInstalled);
            this.Controls.Add(this.chkStartOnLogin);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.lblLogitechExe);
            this.Controls.Add(this.txtLogitechExe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogitechRestarterConfig";
            this.Text = "Logitech Restarter Configuration";
            this.Load += new System.EventHandler(this.FrmLogitechRestarterConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogitechExe;
        private System.Windows.Forms.TextBox txtLogitechExe;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.CheckBox chkStartOnLogin;
        private System.Windows.Forms.Label lblInstalled;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblBitness;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtInstalled;
        private System.Windows.Forms.TextBox txtBitness;
        private System.Windows.Forms.Label lblRestarterRunning;
        private System.Windows.Forms.Label lblRestarterPid;
        private System.Windows.Forms.Timer checkTimer;
        private System.Windows.Forms.OpenFileDialog LcoreFileDialog;
        private System.Windows.Forms.Button btnPickLcore;
        private System.Windows.Forms.CheckBox chkRegSearch;
    }
}

