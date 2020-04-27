using Renci.SshNet;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Hawk_Client {
    public partial class MainWindow : Form {

        #region colors
        Color backgroundColor = Color.FromArgb(35, 41, 49);
        Color buttonColor = Color.FromArgb(96, 32, 128);
        Color TrueColor = Color.FromArgb(78, 204, 163);
        Color FalseColor = Color.FromArgb(132, 20, 45);
        #endregion
        #region ssh and connection 
        private String HOST = "";
        private String USER = "";
        private String PASSWORD = "";
        private SshClient sshClient = new SshClient("none", 0, "none", "none");
        private string path = AppDomain.CurrentDomain.BaseDirectory;
        #endregion
        public MainWindow() {
            InitializeComponent();

            this.scriptSelect.SelectedItem = "Default";
            
            this.mainBrowser.Navigate(new Uri("file://" + path + "notConnected.html"));
        }
        #region Control Tab methods
        private void Connect_Click(object sender, EventArgs e) { //TODO: add disconnect method
            int index = this.ConnectAddress.Text.IndexOf("@");
            String address = this.ConnectAddress.Text;
            if (index > 0) {
                USER = address.Substring(0, index);
                HOST = address.Substring(index + 1);
                PASSWORD = this.password.Text;
                try {
                    sshClient = new SshClient(HOST, 22, USER, PASSWORD); //default port = 22
                    sshClient.Connect();
                    sshClient.RunCommand("mkdir ~/.hawk");
                    sshClient.RunCommand("mkdir ~/.hawk/grips");
                    sshClient.RunCommand("mkdir ~/.hawk/scripts").Execute();
                    sshClient.RunCommand("mkdir ~/.hawk/cameras").Execute();
                }
                catch (Exception) {
                    showError("faild to connect " + USER + " at " + HOST, "Connection error");
                }
                if (sshClient.IsConnected) this.ConnectButton.BackColor = TrueColor;
                else this.ConnectButton.BackColor = FalseColor;
                // create MJPEG video source
                string url = "file://" + path + "stream.html";
                mainBrowser.Navigate(new Uri(@url));
                // start the video source
            }
            else {
                showError("address should be in template 'usr@host'", "Address not valid");
            }

        }
        private void showError(string text, string title) {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void cancelHint(object sender, EventArgs e) {
            ((Control)sender).Text = "";
        }

        private void SetIP_Click(object sender, EventArgs e) {
            if (!sshClient.IsConnected) { showError("You are not connected!", "invalid action"); return; }
            String address = this.setIPtext.Text;
            sshClient.RunCommand("~/HawkEYE/scripts/set_static_ip.sh " + address).Execute();
            int index = this.ConnectAddress.Text.IndexOf("@");
            USER = address.Substring(0, index);
            HOST = address.Substring(index + 1);
            if (MessageBox.Show("set IP successfull , press Ok to reboot(recommended) or Cancel to do nothing.", "success", MessageBoxButtons.OKCancel) == DialogResult.OK) sshClient.RunCommand("reboot");
        }
        private void setDNS_Click(object sender, EventArgs e) {
            if (!sshClient.IsConnected) { showError("You are not connected!", "invalid action"); return; }
            String DNS = this.setIPtext.Text;
            sshClient.RunCommand("hostnamectl set-hostname " + DNS).Execute();
            if (MessageBox.Show("set DNS successfull , press Ok to reboot(recommended) or Cancel to do nothing.", "success", MessageBoxButtons.OKCancel) == DialogResult.OK) sshClient.RunCommand("reboot");
        }
        private void setDHCP_Click(object sender, EventArgs e) {
            if (!sshClient.IsConnected) { showError("You are not connected!", "invalid action"); return; }
            sshClient.RunCommand("~/HawkEYE/scripts/remove_static_ip.sh").Execute();
            if (MessageBox.Show("static IP removal successfull , press Ok to reboot(recommended) or Cancel to do nothing.", "success", MessageBoxButtons.OKCancel) == DialogResult.OK) sshClient.RunCommand("reboot");
        }

        private void ChangePass_Click(object sender, EventArgs e) {
            if (!sshClient.IsConnected) { showError("You are not connected!", "invalid action"); return; }
            String pass = this.setPass1.Text;
            if (pass != setPass2.Text) { showError("Password don`t match!", "not equal passwords"); return; }
            sshClient.RunCommand("~/HawkEYE/scripts/change_password.sh " + pass).Execute();
            PASSWORD = pass;
            if (MessageBox.Show("static IP removal successfull , press Ok to reboot(recommended) or Cancel to do nothing.", "success", MessageBoxButtons.OKCancel) == DialogResult.OK) sshClient.RunCommand("reboot");

        }

        private void Restart_Click(object sender, EventArgs e) {
            if (!sshClient.IsConnected) { showError("You are not connected!", "invalid action"); return; }
            sshClient.RunCommand("pkill -9 python3").Execute();
            sshClient.RunCommand("python3 ~/HawkEYE/source/main.py").Execute();
            showError("HawkEYE restart successfull", "success");
        }


        #endregion

        private void CheckBox1_CheckedChanged(object sender, EventArgs e) {
            bool ok = !this.checkBox1.Checked;
            this.GRIPselect.Visible = ok;
            this.gripLabel.Visible = ok;
            this.GRIPloader.Visible = ok;
            this.GRIPpushButton.Visible = ok;
            this.GRIPdeleteButton.Visible = ok;
        }

        private void Button1_Click(object sender, EventArgs e) {
            if (!sshClient.IsConnected) { showError("You are not connected!", "invalid Action"); return; }
            ConfigWindow w = new ConfigWindow(HOST, sshClient);
            w.Show();
        }

        private void Reboot_Click(object sender, EventArgs e) {
            if (!sshClient.IsConnected) { showError("You are not connected!", "invalid Action"); return; }
            sshClient.RunCommand("reboot");
        }
    }
}
