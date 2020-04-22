using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mk_powercfg
{
    public partial class Main : Form
    {
        //private ContextMenuStrip traycontext;
        public Main()
        {
            InitializeComponent();
            //traycontext = new ContextMenuStrip();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //notifyIcon.ContextMenuStrip = traycontext;
            tbx_log.Text += ExtMethods.GetActiveScheme();
        }

        private void Main_FormClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            Hide();
        }

        private void trb_maxcap_Scroll(object sender, EventArgs e)
        {
            lbl_maxcap.Text = Convert.ToString(trb_maxcap.Value) + "%";
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Hide();
            }       
            else
            {
                this.WindowState = FormWindowState.Normal;
                Show();
            }

        }

        private void chkbx_safe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_safe.Checked == true & MessageBox.Show("You are about to disable safe limits, are you sure?","Safe limits",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                DisableSafeLimits();
            }
            else { chkbx_safe.Checked = false; }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            tbx_log.Text += ExtMethods.GetSchemes();
        }


        #region > Main form methods
        public void DisableSafeLimits()
        {

        }

        #endregion
    }
}
