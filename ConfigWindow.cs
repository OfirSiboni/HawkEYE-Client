using Renci.SshNet;
using System;
using System.Windows.Forms;

namespace Hawk_Client {
    public partial class ConfigWindow : Form {
        public bool prev_value, next_value, set_conf_value, add_pt_value, done_value;
        public SshClient ssh_client;
        private string address;
        public ConfigWindow(string Address, SshClient client) {
            InitializeComponent();
            prev_value = next_value = set_conf_value = add_pt_value = done_value = false;

      
            ssh_client = client;
            address = Address;
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
            prev_value = true;
            changed_values();
        }
        private void next_click(object sender, EventArgs e) {
            next_value = true;
            changed_values();
        }
        private void setConf_click(object sender, EventArgs e) {
            set_conf_value = true;
            changed_values();
        }


        private void addPt_click(object sender, EventArgs e) {
            add_pt_value = true;
            changed_values();
        }
        private void button_done_clicked(object sender, EventArgs e) {
            done_value = true;
            changed_values();
            this.Close();
        }

        public void changed_values() {
            SshCommand c = ssh_client.RunCommand("python3 -c'import main;main.changed_vals(" + get_prev_value() + ',' + get_next_value() + ',' + get_set_conf_value() + ',' + get_add_pt_value() + ',' + get_done_value() + ')');
            c.Execute();
            
        }

        public bool ischanged() {
            return get_prev_value() || get_next_value() || get_set_conf_value() || get_add_pt_value() || get_done_value();
        }




    }
}
