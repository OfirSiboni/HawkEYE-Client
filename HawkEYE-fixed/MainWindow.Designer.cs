using Renci.SshNet;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace Hawk_Client {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ConnectAddress = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.Control = new System.Windows.Forms.TabPage();
            this.reboot = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.changeDNS = new System.Windows.Forms.Button();
            this.SetIP = new System.Windows.Forms.Button();
            this.changePass = new System.Windows.Forms.Button();
            this.setDHCP = new System.Windows.Forms.Button();
            this.setPass2 = new System.Windows.Forms.TextBox();
            this.setPass1 = new System.Windows.Forms.TextBox();
            this.changeDNStext = new System.Windows.Forms.TextBox();
            this.setIPtext = new System.Windows.Forms.TextBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.gripLabel = new System.Windows.Forms.Label();
            this.scriptLabel = new System.Windows.Forms.Label();
            this.GRIPpushButton = new System.Windows.Forms.Button();
            this.ScriptPushButton = new System.Windows.Forms.Button();
            this.GRIPdeleteButton = new System.Windows.Forms.Button();
            this.GRIPloader = new System.Windows.Forms.ComboBox();
            this.ScriptDeleteButton = new System.Windows.Forms.Button();
            this.scriptLoader = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.FPSbox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.TeamNumberBox = new System.Windows.Forms.TextBox();
            this.GRIPselect = new System.Windows.Forms.ComboBox();
            this.MLenable = new System.Windows.Forms.CheckBox();
            this.scriptSelect = new System.Windows.Forms.ComboBox();
            this.ML = new System.Windows.Forms.TabPage();
            this.ValuesRefresh = new System.Windows.Forms.Button();
            this.HSVtable = new System.Windows.Forms.GroupBox();
            this.Vmax = new System.Windows.Forms.Label();
            this.Vmin = new System.Windows.Forms.Label();
            this.Smax = new System.Windows.Forms.Label();
            this.Hmax = new System.Windows.Forms.Label();
            this.Smin = new System.Windows.Forms.Label();
            this.Hmin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Hlabel = new System.Windows.Forms.Label();
            this.startConfigButton = new System.Windows.Forms.Button();
            this.CameraControl = new System.Windows.Forms.TabPage();
            this.Refresh = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.Control.SuspendLayout();
            this.Settings.SuspendLayout();
            this.ML.SuspendLayout();
            this.HSVtable.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConnectAddress
            // 
            this.ConnectAddress.Location = new System.Drawing.Point(37, 12);
            this.ConnectAddress.Name = "ConnectAddress";
            this.ConnectAddress.Size = new System.Drawing.Size(126, 20);
            this.ConnectAddress.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(169, 12);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(126, 20);
            this.password.TabIndex = 1;
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.Gray;
            this.ConnectButton.FlatAppearance.BorderSize = 0;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.ForeColor = System.Drawing.Color.White;
            this.ConnectButton.Location = new System.Drawing.Point(301, 10);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.Connect_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.Control);
            this.tabs.Controls.Add(this.Settings);
            this.tabs.Controls.Add(this.ML);
            this.tabs.Controls.Add(this.CameraControl);
            this.tabs.Location = new System.Drawing.Point(37, 62);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(794, 501);
            this.tabs.TabIndex = 4;
            // 
            // Control
            // 
            this.Control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Control.Controls.Add(this.reboot);
            this.Control.Controls.Add(this.restart);
            this.Control.Controls.Add(this.changeDNS);
            this.Control.Controls.Add(this.SetIP);
            this.Control.Controls.Add(this.changePass);
            this.Control.Controls.Add(this.setDHCP);
            this.Control.Controls.Add(this.setPass2);
            this.Control.Controls.Add(this.setPass1);
            this.Control.Controls.Add(this.changeDNStext);
            this.Control.Controls.Add(this.setIPtext);
            this.Control.Location = new System.Drawing.Point(4, 22);
            this.Control.Name = "Control";
            this.Control.Padding = new System.Windows.Forms.Padding(3);
            this.Control.Size = new System.Drawing.Size(786, 475);
            this.Control.TabIndex = 0;
            this.Control.Text = "Control";
            // 
            // reboot
            // 
            this.reboot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.reboot.FlatAppearance.BorderSize = 0;
            this.reboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reboot.Location = new System.Drawing.Point(44, 207);
            this.reboot.Name = "reboot";
            this.reboot.Size = new System.Drawing.Size(318, 23);
            this.reboot.TabIndex = 3;
            this.reboot.Text = "reboot";
            this.reboot.UseVisualStyleBackColor = false;
            this.reboot.Click += new System.EventHandler(this.Reboot);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.restart.FlatAppearance.BorderSize = 0;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Location = new System.Drawing.Point(44, 178);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(318, 23);
            this.restart.TabIndex = 3;
            this.restart.Text = "Restart HawkEye";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // changeDNS
            // 
            this.changeDNS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.changeDNS.FlatAppearance.BorderSize = 0;
            this.changeDNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDNS.Location = new System.Drawing.Point(369, 66);
            this.changeDNS.Name = "changeDNS";
            this.changeDNS.Size = new System.Drawing.Size(75, 20);
            this.changeDNS.TabIndex = 2;
            this.changeDNS.Text = "Set DNS";
            this.changeDNS.UseVisualStyleBackColor = false;
            this.changeDNS.Click += new System.EventHandler(this.setDNS_Click);
            // 
            // SetIP
            // 
            this.SetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.SetIP.FlatAppearance.BorderSize = 0;
            this.SetIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetIP.Location = new System.Drawing.Point(369, 41);
            this.SetIP.Name = "SetIP";
            this.SetIP.Size = new System.Drawing.Size(75, 20);
            this.SetIP.TabIndex = 2;
            this.SetIP.Text = "Set IP";
            this.SetIP.UseVisualStyleBackColor = false;
            this.SetIP.Click += new System.EventHandler(this.SetIP_Click);
            // 
            // changePass
            // 
            this.changePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.changePass.FlatAppearance.BorderSize = 0;
            this.changePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePass.Location = new System.Drawing.Point(256, 115);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(106, 21);
            this.changePass.TabIndex = 1;
            this.changePass.Text = "Change Password";
            this.changePass.UseVisualStyleBackColor = false;
            this.changePass.Click += new System.EventHandler(this.ChangePass_Click);
            // 
            // setDHCP
            // 
            this.setDHCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.setDHCP.FlatAppearance.BorderSize = 0;
            this.setDHCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setDHCP.Location = new System.Drawing.Point(44, 90);
            this.setDHCP.Name = "setDHCP";
            this.setDHCP.Size = new System.Drawing.Size(318, 20);
            this.setDHCP.TabIndex = 1;
            this.setDHCP.Text = "set DHCP";
            this.setDHCP.UseVisualStyleBackColor = false;
            this.setDHCP.Click += new System.EventHandler(this.setDHCP_Click);
            // 
            // setPass2
            // 
            this.setPass2.Location = new System.Drawing.Point(150, 116);
            this.setPass2.Name = "setPass2";
            this.setPass2.Size = new System.Drawing.Size(100, 20);
            this.setPass2.TabIndex = 0;
            this.setPass2.Text = "Confirm";
            this.setPass2.Click += new System.EventHandler(this.cancelHint);
            // 
            // setPass1
            // 
            this.setPass1.Location = new System.Drawing.Point(44, 116);
            this.setPass1.Name = "setPass1";
            this.setPass1.Size = new System.Drawing.Size(100, 20);
            this.setPass1.TabIndex = 0;
            this.setPass1.Text = "New Password";
            this.setPass1.Click += new System.EventHandler(this.cancelHint);
            // 
            // changeDNStext
            // 
            this.changeDNStext.Location = new System.Drawing.Point(44, 67);
            this.changeDNStext.Name = "changeDNStext";
            this.changeDNStext.Size = new System.Drawing.Size(318, 20);
            this.changeDNStext.TabIndex = 0;
            this.changeDNStext.Text = "New DNS";
            this.changeDNStext.Click += new System.EventHandler(this.cancelHint);
            // 
            // setIPtext
            // 
            this.setIPtext.Location = new System.Drawing.Point(44, 41);
            this.setIPtext.Name = "setIPtext";
            this.setIPtext.Size = new System.Drawing.Size(318, 20);
            this.setIPtext.TabIndex = 0;
            this.setIPtext.Text = "New IP";
            this.setIPtext.Click += new System.EventHandler(this.cancelHint);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.Settings.Controls.Add(this.gripLabel);
            this.Settings.Controls.Add(this.scriptLabel);
            this.Settings.Controls.Add(this.GRIPpushButton);
            this.Settings.Controls.Add(this.ScriptPushButton);
            this.Settings.Controls.Add(this.GRIPdeleteButton);
            this.Settings.Controls.Add(this.GRIPloader);
            this.Settings.Controls.Add(this.ScriptDeleteButton);
            this.Settings.Controls.Add(this.scriptLoader);
            this.Settings.Controls.Add(this.SaveButton);
            this.Settings.Controls.Add(this.FPSbox);
            this.Settings.Controls.Add(this.WidthBox);
            this.Settings.Controls.Add(this.HeightBox);
            this.Settings.Controls.Add(this.TeamNumberBox);
            this.Settings.Controls.Add(this.GRIPselect);
            this.Settings.Controls.Add(this.MLenable);
            this.Settings.Controls.Add(this.scriptSelect);
            this.Settings.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(250)));
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(786, 475);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            // 
            // gripLabel
            // 
            this.gripLabel.AutoSize = true;
            this.gripLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gripLabel.ForeColor = System.Drawing.Color.White;
            this.gripLabel.Location = new System.Drawing.Point(598, 40);
            this.gripLabel.Name = "gripLabel";
            this.gripLabel.Size = new System.Drawing.Size(88, 13);
            this.gripLabel.TabIndex = 8;
            this.gripLabel.Text = "GRIP File Loader";
            this.gripLabel.Visible = false;
            // 
            // scriptLabel
            // 
            this.scriptLabel.AutoSize = true;
            this.scriptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.scriptLabel.ForeColor = System.Drawing.Color.White;
            this.scriptLabel.Location = new System.Drawing.Point(409, 40);
            this.scriptLabel.Name = "scriptLabel";
            this.scriptLabel.Size = new System.Drawing.Size(89, 13);
            this.scriptLabel.TabIndex = 8;
            this.scriptLabel.Text = "Script File Loader";
            // 
            // GRIPpushButton
            // 
            this.GRIPpushButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.GRIPpushButton.FlatAppearance.BorderSize = 0;
            this.GRIPpushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GRIPpushButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GRIPpushButton.Location = new System.Drawing.Point(565, 100);
            this.GRIPpushButton.Name = "GRIPpushButton";
            this.GRIPpushButton.Size = new System.Drawing.Size(75, 23);
            this.GRIPpushButton.TabIndex = 7;
            this.GRIPpushButton.Text = "Push";
            this.GRIPpushButton.UseVisualStyleBackColor = false;
            this.GRIPpushButton.Visible = false;
            this.GRIPpushButton.Click += new System.EventHandler(this.ScriptPushButton_Click);
            // 
            // ScriptPushButton
            // 
            this.ScriptPushButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.ScriptPushButton.FlatAppearance.BorderSize = 0;
            this.ScriptPushButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptPushButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ScriptPushButton.Location = new System.Drawing.Point(374, 100);
            this.ScriptPushButton.Name = "ScriptPushButton";
            this.ScriptPushButton.Size = new System.Drawing.Size(75, 23);
            this.ScriptPushButton.TabIndex = 7;
            this.ScriptPushButton.Text = "Push";
            this.ScriptPushButton.UseVisualStyleBackColor = false;
            this.ScriptPushButton.Click += new System.EventHandler(this.ScriptPushButton_Click);
            // 
            // GRIPdeleteButton
            // 
            this.GRIPdeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.GRIPdeleteButton.FlatAppearance.BorderSize = 0;
            this.GRIPdeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GRIPdeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GRIPdeleteButton.Location = new System.Drawing.Point(646, 100);
            this.GRIPdeleteButton.Name = "GRIPdeleteButton";
            this.GRIPdeleteButton.Size = new System.Drawing.Size(75, 23);
            this.GRIPdeleteButton.TabIndex = 7;
            this.GRIPdeleteButton.Text = "Delete";
            this.GRIPdeleteButton.UseVisualStyleBackColor = false;
            this.GRIPdeleteButton.Visible = false;
            this.GRIPdeleteButton.Click += new System.EventHandler(this.GRIPdeleteButton_Click);
            // 
            // GRIPloader
            // 
            this.GRIPloader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GRIPloader.FormattingEnabled = true;
            this.GRIPloader.Location = new System.Drawing.Point(565, 73);
            this.GRIPloader.Name = "GRIPloader";
            this.GRIPloader.Size = new System.Drawing.Size(156, 21);
            this.GRIPloader.TabIndex = 6;
            this.GRIPloader.Visible = false;
            // 
            // ScriptDeleteButton
            // 
            this.ScriptDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.ScriptDeleteButton.FlatAppearance.BorderSize = 0;
            this.ScriptDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ScriptDeleteButton.Location = new System.Drawing.Point(455, 100);
            this.ScriptDeleteButton.Name = "ScriptDeleteButton";
            this.ScriptDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ScriptDeleteButton.TabIndex = 7;
            this.ScriptDeleteButton.Text = "Delete";
            this.ScriptDeleteButton.UseVisualStyleBackColor = false;
            this.ScriptDeleteButton.Click += new System.EventHandler(this.ScriptDeleteButton_Click);
            // 
            // scriptLoader
            // 
            this.scriptLoader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.scriptLoader.FormattingEnabled = true;
            this.scriptLoader.Location = new System.Drawing.Point(374, 73);
            this.scriptLoader.Name = "scriptLoader";
            this.scriptLoader.Size = new System.Drawing.Size(156, 21);
            this.scriptLoader.TabIndex = 6;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SaveButton.Location = new System.Drawing.Point(24, 226);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(209, 27);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FPSbox
            // 
            this.FPSbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FPSbox.Location = new System.Drawing.Point(24, 200);
            this.FPSbox.Name = "FPSbox";
            this.FPSbox.Size = new System.Drawing.Size(209, 20);
            this.FPSbox.TabIndex = 4;
            this.FPSbox.Text = "FPS-(Frame Per Second) : 30";
            this.FPSbox.Click += new System.EventHandler(this.cancelHint);
            // 
            // WidthBox
            // 
            this.WidthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.WidthBox.Location = new System.Drawing.Point(24, 170);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(209, 20);
            this.WidthBox.TabIndex = 4;
            this.WidthBox.Text = "Width : 120";
            this.WidthBox.Click += new System.EventHandler(this.cancelHint);
            // 
            // HeightBox
            // 
            this.HeightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HeightBox.Location = new System.Drawing.Point(24, 139);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(209, 20);
            this.HeightBox.TabIndex = 4;
            this.HeightBox.Text = "Height : 160";
            this.HeightBox.Click += new System.EventHandler(this.cancelHint);
            // 
            // TeamNumberBox
            // 
            this.TeamNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TeamNumberBox.Location = new System.Drawing.Point(24, 111);
            this.TeamNumberBox.Name = "TeamNumberBox";
            this.TeamNumberBox.Size = new System.Drawing.Size(209, 20);
            this.TeamNumberBox.TabIndex = 4;
            this.TeamNumberBox.Text = "Team Number";
            this.TeamNumberBox.Click += new System.EventHandler(this.cancelHint);
            // 
            // GRIPselect
            // 
            this.GRIPselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.GRIPselect.FormattingEnabled = true;
            this.GRIPselect.Location = new System.Drawing.Point(112, 69);
            this.GRIPselect.Name = "GRIPselect";
            this.GRIPselect.Size = new System.Drawing.Size(121, 21);
            this.GRIPselect.TabIndex = 3;
            this.GRIPselect.Text = "GRIP file";
            this.GRIPselect.Visible = false;
            // 
            // MLenable
            // 
            this.MLenable.AutoSize = true;
            this.MLenable.Checked = true;
            this.MLenable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MLenable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MLenable.ForeColor = System.Drawing.Color.White;
            this.MLenable.Location = new System.Drawing.Point(24, 73);
            this.MLenable.Name = "MLenable";
            this.MLenable.Size = new System.Drawing.Size(82, 17);
            this.MLenable.TabIndex = 2;
            this.MLenable.Text = "ML enabled";
            this.MLenable.UseVisualStyleBackColor = true;
            this.MLenable.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // scriptSelect
            // 
            this.scriptSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.scriptSelect.FormattingEnabled = true;
            this.scriptSelect.Items.AddRange(new object[] {
            "Default"});
            this.scriptSelect.Location = new System.Drawing.Point(24, 32);
            this.scriptSelect.Name = "scriptSelect";
            this.scriptSelect.Size = new System.Drawing.Size(212, 21);
            this.scriptSelect.TabIndex = 1;
            this.scriptSelect.Text = "Script File";
            // 
            // ML
            // 
            this.ML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.ML.Controls.Add(this.ValuesRefresh);
            this.ML.Controls.Add(this.HSVtable);
            this.ML.Controls.Add(this.startConfigButton);
            this.ML.Location = new System.Drawing.Point(4, 22);
            this.ML.Name = "ML";
            this.ML.Size = new System.Drawing.Size(786, 475);
            this.ML.TabIndex = 2;
            this.ML.Text = "ML";
            // 
            // ValuesRefresh
            // 
            this.ValuesRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.ValuesRefresh.FlatAppearance.BorderSize = 0;
            this.ValuesRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValuesRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ValuesRefresh.Location = new System.Drawing.Point(64, 45);
            this.ValuesRefresh.Name = "ValuesRefresh";
            this.ValuesRefresh.Size = new System.Drawing.Size(75, 23);
            this.ValuesRefresh.TabIndex = 8;
            this.ValuesRefresh.Text = "Refresh";
            this.ValuesRefresh.UseVisualStyleBackColor = false;
            this.ValuesRefresh.Click += new System.EventHandler(this.ValuesRefresh_Click);
            // 
            // HSVtable
            // 
            this.HSVtable.Controls.Add(this.Vmax);
            this.HSVtable.Controls.Add(this.Vmin);
            this.HSVtable.Controls.Add(this.Smax);
            this.HSVtable.Controls.Add(this.Hmax);
            this.HSVtable.Controls.Add(this.Smin);
            this.HSVtable.Controls.Add(this.Hmin);
            this.HSVtable.Controls.Add(this.label5);
            this.HSVtable.Controls.Add(this.label4);
            this.HSVtable.Controls.Add(this.label3);
            this.HSVtable.Controls.Add(this.label1);
            this.HSVtable.Controls.Add(this.label2);
            this.HSVtable.Controls.Add(this.Hlabel);
            this.HSVtable.ForeColor = System.Drawing.Color.White;
            this.HSVtable.Location = new System.Drawing.Point(128, 74);
            this.HSVtable.Name = "HSVtable";
            this.HSVtable.Size = new System.Drawing.Size(233, 190);
            this.HSVtable.TabIndex = 1;
            this.HSVtable.TabStop = false;
            this.HSVtable.Text = "HSV current values";
            // 
            // Vmax
            // 
            this.Vmax.AutoSize = true;
            this.Vmax.Location = new System.Drawing.Point(158, 146);
            this.Vmax.Name = "Vmax";
            this.Vmax.Size = new System.Drawing.Size(33, 13);
            this.Vmax.TabIndex = 2;
            this.Vmax.Text = "None";
            // 
            // Vmin
            // 
            this.Vmin.AutoSize = true;
            this.Vmin.Location = new System.Drawing.Point(63, 146);
            this.Vmin.Name = "Vmin";
            this.Vmin.Size = new System.Drawing.Size(33, 13);
            this.Vmin.TabIndex = 2;
            this.Vmin.Text = "None";
            // 
            // Smax
            // 
            this.Smax.AutoSize = true;
            this.Smax.Location = new System.Drawing.Point(158, 107);
            this.Smax.Name = "Smax";
            this.Smax.Size = new System.Drawing.Size(33, 13);
            this.Smax.TabIndex = 2;
            this.Smax.Text = "None";
            // 
            // Hmax
            // 
            this.Hmax.AutoSize = true;
            this.Hmax.Location = new System.Drawing.Point(158, 65);
            this.Hmax.Name = "Hmax";
            this.Hmax.Size = new System.Drawing.Size(33, 13);
            this.Hmax.TabIndex = 2;
            this.Hmax.Text = "None";
            // 
            // Smin
            // 
            this.Smin.AutoSize = true;
            this.Smin.Location = new System.Drawing.Point(63, 107);
            this.Smin.Name = "Smin";
            this.Smin.Size = new System.Drawing.Size(33, 13);
            this.Smin.TabIndex = 2;
            this.Smin.Text = "None";
            // 
            // Hmin
            // 
            this.Hmin.AutoSize = true;
            this.Hmin.Location = new System.Drawing.Point(63, 65);
            this.Hmin.Name = "Hmin";
            this.Hmin.Size = new System.Drawing.Size(33, 13);
            this.Hmin.TabIndex = 2;
            this.Hmin.Text = "None";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(123, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 161);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "V";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "S";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(139, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "max";
            // 
            // Hlabel
            // 
            this.Hlabel.AutoSize = true;
            this.Hlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Hlabel.Location = new System.Drawing.Point(61, 16);
            this.Hlabel.Name = "Hlabel";
            this.Hlabel.Size = new System.Drawing.Size(48, 26);
            this.Hlabel.TabIndex = 0;
            this.Hlabel.Text = "min";
            // 
            // startConfigButton
            // 
            this.startConfigButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(188)))), ((int)(((byte)(191)))));
            this.startConfigButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startConfigButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.startConfigButton.Location = new System.Drawing.Point(450, 164);
            this.startConfigButton.Name = "startConfigButton";
            this.startConfigButton.Size = new System.Drawing.Size(254, 46);
            this.startConfigButton.TabIndex = 0;
            this.startConfigButton.Text = "Start ML configuration";
            this.startConfigButton.UseVisualStyleBackColor = false;
            this.startConfigButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CameraControl
            // 
            this.CameraControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.CameraControl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CameraControl.Location = new System.Drawing.Point(4, 22);
            this.CameraControl.Name = "CameraControl";
            this.CameraControl.Size = new System.Drawing.Size(786, 475);
            this.CameraControl.TabIndex = 3;
            this.CameraControl.Text = "Camera Control";
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(115)))), ((int)(((byte)(112)))));
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Location = new System.Drawing.Point(837, 48);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 5;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(1549, 582);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.ConnectAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "HawkEye Client";
            this.tabs.ResumeLayout(false);
            this.Control.ResumeLayout(false);
            this.Control.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.ML.ResumeLayout(false);
            this.HSVtable.ResumeLayout(false);
            this.HSVtable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConnectAddress;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage Control;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TextBox setPass2;
        private System.Windows.Forms.TextBox setPass1;
        private System.Windows.Forms.TextBox changeDNStext;
        private System.Windows.Forms.TextBox setIPtext;
        private System.Windows.Forms.TabPage ML;
        private System.Windows.Forms.TabPage CameraControl;
        private System.Windows.Forms.Button setDHCP;
        private System.Windows.Forms.Button changePass;
        private System.Windows.Forms.Button reboot;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.ComboBox scriptSelect;
        private System.Windows.Forms.CheckBox MLenable;
        private System.Windows.Forms.ComboBox GRIPselect;
        private System.Windows.Forms.TextBox HeightBox;
        private System.Windows.Forms.TextBox TeamNumberBox;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox FPSbox;
        private System.Windows.Forms.Button GRIPpushButton;
        private System.Windows.Forms.Button ScriptPushButton;
        private System.Windows.Forms.Button GRIPdeleteButton;
        private System.Windows.Forms.ComboBox GRIPloader;
        private System.Windows.Forms.Button ScriptDeleteButton;
        private System.Windows.Forms.ComboBox scriptLoader;
        private System.Windows.Forms.Label gripLabel;
        private System.Windows.Forms.Label scriptLabel;
        private System.Windows.Forms.Button changeDNS;
        private System.Windows.Forms.Button SetIP;
        private System.Windows.Forms.Button startConfigButton;
        private System.Windows.Forms.GroupBox HSVtable;
        private System.Windows.Forms.Label Vmax;
        private System.Windows.Forms.Label Vmin;
        private System.Windows.Forms.Label Smax;
        private System.Windows.Forms.Label Hmax;
        private System.Windows.Forms.Label Smin;
        private System.Windows.Forms.Label Hmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Hlabel;
        private Button Refresh;
        private Button ValuesRefresh;
    }
}
