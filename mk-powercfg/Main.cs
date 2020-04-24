using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mk_powercfg
{
    public partial class Main : Form
    {
        public class SchemeParts
        {
            public int[] number;
            public string[] GUID;
            public string[] Name;
            public string SchemeList = null;
        }

        public class Vars
        {
            public int MaxCap = 20;
            public int MinCap;
            public int SleepAfter;
            public int ScreenOff;
        }

        readonly Vars xvar = new Vars();

        #region > Init
        //private ContextMenuStrip traycontext;
        public Main()
        {
            InitializeComponent();
            //traycontext = new ContextMenuStrip();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            AutoTrigger();
            //notifyIcon.ContextMenuStrip = traycontext;
            //tbx_log.Text += ExtMethods.GetSchemes();
            //tbx_log.Text += Environment.NewLine;
            //tbx_log.Text += ExtMethods.GetActiveScheme();
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
            //tbx_log.Text += "Max cap:" + Convert.ToString(xvar.MaxCap) + Environment.NewLine;
            //tbx_log.Text += "Min cap:" + Convert.ToString(xvar.MinCap) + Environment.NewLine;
            //tbx_log.Text += "Screen:" + Convert.ToString(xvar.ScreenOff) + Environment.NewLine;
            //tbx_log.Text += "Sleep:" + Convert.ToString(xvar.SleepAfter) + Environment.NewLine;
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
            //string GUIDrx = @"(\w{8}\x2d)(\w{4}\x2d)(\w{4}\x2d)(\w{4}\x2d)(\w{12})";
            //string tmpSCHEMErx = @"(\x28)[^*]\D+(\x29)";
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
            Gex();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
        private void chkbx_startup_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region > Main form methods
        private void DisableSafeLimits()
        {
            trb_maxcap.Minimum = 0;
            SetVars();
            RefreshUI();
        }
        private void EnableSafeLimits()
        {
            trb_maxcap.Minimum = 20;
            if (trb_maxcap.Value < 20) { trb_maxcap.Value = 20; }
            xvar.MaxCap = 20;
            SetVars();
            RefreshUI();
        }
        private void RefreshUI()
        {
            lbl_maxcap.Text = Convert.ToString(xvar.MaxCap) + "%";
            trb_maxcap.Value = xvar.MaxCap;
        }
        private void SetVars()
        {
            xvar.MaxCap = trb_maxcap.Value;
            xvar.MinCap = 5;
            xvar.ScreenOff = Convert.ToInt32(updn_screen.Value);
            xvar.SleepAfter = Convert.ToInt32(updn_sleep.Value);
        }
        private void ExitApp()
        {
            notifyIcon.Dispose();
            Dispose();
            Application.Exit();
        }
        #endregion

        #region >-----> Test func collections
        public void AutoTrigger()
        {
            DebugPrints();
        }

        public void ManualTrigger()
        {
            Gex();
        }

        public void Gex()
        {
            SchemeParts SchemeTab = new SchemeParts();
            Regex SchemeRX = new Regex(@"\w{8}\x2d\w{4}\x2d\w{4}\x2d\w{4}\x2d\w{12}|\x28([^*].+)\x29");
            SchemeTab.SchemeList = ExtMethods.GetSchemes();
            MatchCollection SchemeCollection = SchemeRX.Matches(SchemeTab.SchemeList);
            int item = 0;
            string[,] SchemeList = new string[SchemeCollection.Count / 2, 4];
            for (int row = 0; row < SchemeCollection.Count / 2; row++)
            {
                for (int col = 0; col <= 2; col += 2)
                {
                    SchemeList[row, col] = SchemeCollection[item].Groups[0].Value;
                    SchemeList[row, col + 1] = SchemeCollection[item].Groups[1].Value;
                    item++;
                }
            }
        }
        public void DebugPrints()
        {
            Console.WriteLine("Console output initialized...");
        }
    #endregion
}
}