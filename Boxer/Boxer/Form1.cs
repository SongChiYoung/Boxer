using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Boxer
{
    public partial class Boxer : Form
    {
        public Boxer()
        {
            InitializeComponent();
        }

        private void ip_update()
        {
            int many = Util.Client_IP.get_many;
            string[] ips = Util.Client_IP.get_ip_list;
            ip_address_label.Text = "";
            for (int i = 0; i < many; i++)
            {
                if (ips[i] == null) continue;
                ip_address_label.Text += ips[i] + "  ";
            }

        }

        private void Boxer_Load(object sender, EventArgs e)
        {
            ip_update();
            client_panel.Enabled = false;
            this.MaximumSize = this.Size;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                server_panel.Enabled = true;
                ip_update();
            }
            else
            {
                server_panel.Enabled = false;
            }
        }

        private void configureCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDo dlg = new ToDo(sender.ToString());
            dlg.ShowDialog();
        }

        private void boxerBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDo dlg = new ToDo(sender.ToString());
            dlg.ShowDialog();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                client_panel.Enabled = true;
            }
            else
            {
                client_panel.Enabled = false;
            }
        }

        private void open_box()
        {
            box dlg = new box();
            dlg.Show();
        }

        private void run_server_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            open_box();
        }
    }
}
