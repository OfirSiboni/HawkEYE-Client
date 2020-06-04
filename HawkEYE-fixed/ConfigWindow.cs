using Renci.SshNet;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace HawkEYE_fixed {
    public partial class ConfigWindow : Form {
        public bool prev_value, next_value, set_conf_value, add_pt_value, done_value;
        public SshClient ssh_client;
        private string address;
        private Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        private IPAddress broadcast;
        private IPEndPoint ep;
        public ConfigWindow(string Address) {
            InitializeComponent();
            prev_value = next_value = set_conf_value = add_pt_value = done_value = false;
            broadcast = IPAddress.Parse(Address);
            ep = new IPEndPoint(broadcast, 5000);
            address = Address;
            sock.SendTo(System.Text.Encoding.UTF8.GetBytes("START"), ep);
            Thread noneThread = new Thread(sendNull);
            noneThread.Start();
        }
        private bool get_prev_value() {
            if (prev_value) {
                prev_value = false;
                return true;
            }
            return false;
        }
        private bool get_next_value() {
            if (next_value) {
                next_value = false;
                return true;
            }
            return false;
        }
        private bool get_set_conf_value() {
            if (set_conf_value) {
                set_conf_value = false;
                return true;
            }
            return false;
        }
        private bool get_add_pt_value() {
            if (add_pt_value) {
                add_pt_value = false;
                return true;
            }
            return false;
        }
        private bool get_done_value() {
            if (done_value) {
                done_value = false;
                return true;
            }
            return false;
        }

        private void prev_click(object sender, EventArgs e) {
            changed_values("PREV");
        }
        private void next_click(object sender, EventArgs e) {
            changed_values("NEX");
        }
        private void setConf_click(object sender, EventArgs e) {
            changed_values("SET_CONF");
        }
        private void addPt_click(object sender, EventArgs e) {
            changed_values("ADD_PT");
        }
        private void button_done_clicked(object sender, EventArgs e) {
            changed_values("DONE");
            this.Close();
        }
        public void changed_values(string variable) {
            byte[] msg = System.Text.Encoding.UTF8.GetBytes(variable);
            sock.SendTo(msg, ep);
            this.label2.Text += $"\n{variable}";
        }
        public string boolToString(bool str) {
            if (str.ToString()[0] == 'f') return "False";
            return "True";
        }
        public bool ischanged() {
            return get_prev_value() || get_next_value() || get_set_conf_value() || get_add_pt_value() || get_done_value();
        }
        byte[] nullMsg = System.Text.Encoding.UTF8.GetBytes("null");
        public void sendNull() {
            while(true){
                Thread.Sleep(512);
                sock.SendTo(nullMsg, ep);

            }
        }




    }
}
