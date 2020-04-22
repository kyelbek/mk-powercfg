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
        public class Vars
        {
            public int MaxCap = 20;
            public int MinCap;
            public int SleepAfter;
            public int ScreenOff;
        }
        Vars xvar = new Vars();

        #region > Init
        //private ContextMenuStrip traycontext;
        public Main()
        {
            InitializeComponent();
            //traycontext = new ContextMenuStrip();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            //notifyIcon.ContextMenuStrip = traycontext;
            tbx_log.Text += ExtMethods.GetSchemes();
            tbx_log.Text += ExtMethods.GetActiveScheme();
            EnableSafeLimits();
            notifyIcon.BalloonTipText = "Application Minimized.";
            notifyIcon.BalloonTipTitle = "Power Manager";
        }
        #endregion

        #region > Main form controls
        private void btn_apply_Click(object sender, EventArgs e)
        {
            SetVars();
            RefreshUI();
        }
        private void Main_FormClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
        }
        private void trb_maxcap_Scroll(object sender, EventArgs e)
        {
            lbl_maxcap.Text = Convert.ToString(trb_maxcap.Value) + "%";
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                Hide();
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
        }
        private void chkbx_safe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_safe.Checked == true)
            {
                if (MessageBox.Show("You are about to disable CPU power safe limits, are you sure?", "CPU Power", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DisableSafeLimits();
                }
                else
                {
                    chkbx_safe.Checked = false;
                    EnableSafeLimits();
                }
            }
            else
            {
                EnableSafeLimits();
            }
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            tbx_log.Text += ExtMethods.GetSchemes();
        }
        private void updn_screen_ValueChanged(object sender, EventArgs e)
        {

        }
        private void updn_sleep_ValueChanged(object sender, EventArgs e)
        {

        }
        private void cmb_profile_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btn_ok_Click(object sender, EventArgs e)
        {

        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
        private void chkbx_startup_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region > Main form methods
        public void DisableSafeLimits()
        {
            trb_maxcap.Minimum = 0;
            SetVars();
            RefreshUI();
        }
        public void EnableSafeLimits()
        {
            trb_maxcap.Minimum = 20;
            trb_maxcap.Value = 20;
            xvar.MaxCap = 20;
            SetVars();
            RefreshUI();
        }
        public void RefreshUI()
        {
            lbl_maxcap.Text = Convert.ToString(xvar.MaxCap) + "%";
            trb_maxcap.Value = xvar.MaxCap;
        }
        public void SetVars()
        {
            xvar.MaxCap = trb_maxcap.Value;
            xvar.MinCap = 5;
            xvar.ScreenOff = updn_screen.Value;
            xvar.SleepAfter = updn_;
        }
        private void ExitApp()
        {
            notifyIcon.Dispose();
            Dispose();
            Application.Exit();
        }
        #endregion
    }
}
