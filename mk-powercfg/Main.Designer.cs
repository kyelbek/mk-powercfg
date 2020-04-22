namespace mk_powercfg
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_apply = new System.Windows.Forms.Button();
            this.cmb_profile = new System.Windows.Forms.ComboBox();
            this.chkbx_startup = new System.Windows.Forms.CheckBox();
            this.trb_maxcap = new System.Windows.Forms.TrackBar();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tbx_log = new System.Windows.Forms.TextBox();
            this.lbl_cap = new System.Windows.Forms.Label();
            this.lbl_screenoff = new System.Windows.Forms.Label();
            this.lbl_sleep = new System.Windows.Forms.Label();
            this.updn_screen = new System.Windows.Forms.NumericUpDown();
            this.updn_sleep = new System.Windows.Forms.NumericUpDown();
            this.lbl_maxcap = new System.Windows.Forms.Label();
            this.lbl_scheme = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.chkbx_safe = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trb_maxcap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_sleep)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(713, 415);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // cmb_profile
            // 
            this.cmb_profile.FormattingEnabled = true;
            this.cmb_profile.Location = new System.Drawing.Point(642, 13);
            this.cmb_profile.Name = "cmb_profile";
            this.cmb_profile.Size = new System.Drawing.Size(146, 21);
            this.cmb_profile.TabIndex = 1;
            this.cmb_profile.SelectedIndexChanged += new System.EventHandler(this.cmb_profile_SelectedIndexChanged);
            // 
            // chkbx_startup
            // 
            this.chkbx_startup.AutoSize = true;
            this.chkbx_startup.Location = new System.Drawing.Point(93, 419);
            this.chkbx_startup.Name = "chkbx_startup";
            this.chkbx_startup.Size = new System.Drawing.Size(117, 17);
            this.chkbx_startup.TabIndex = 2;
            this.chkbx_startup.Text = "Start with Windows";
            this.chkbx_startup.UseVisualStyleBackColor = true;
            this.chkbx_startup.CheckedChanged += new System.EventHandler(this.chkbx_startup_CheckedChanged);
            // 
            // trb_maxcap
            // 
            this.trb_maxcap.Location = new System.Drawing.Point(743, 80);
            this.trb_maxcap.Maximum = 100;
            this.trb_maxcap.Name = "trb_maxcap";
            this.trb_maxcap.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trb_maxcap.Size = new System.Drawing.Size(45, 299);
            this.trb_maxcap.SmallChange = 5;
            this.trb_maxcap.TabIndex = 4;
            this.trb_maxcap.TabStop = false;
            this.trb_maxcap.TickFrequency = 10;
            this.trb_maxcap.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trb_maxcap.Scroll += new System.EventHandler(this.trb_maxcap_Scroll);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(632, 415);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(551, 415);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tbx_log
            // 
            this.tbx_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tbx_log.Location = new System.Drawing.Point(12, 12);
            this.tbx_log.Multiline = true;
            this.tbx_log.Name = "tbx_log";
            this.tbx_log.ReadOnly = true;
            this.tbx_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_log.Size = new System.Drawing.Size(511, 397);
            this.tbx_log.TabIndex = 7;
            this.tbx_log.WordWrap = false;
            // 
            // lbl_cap
            // 
            this.lbl_cap.AutoSize = true;
            this.lbl_cap.Location = new System.Drawing.Point(740, 382);
            this.lbl_cap.Name = "lbl_cap";
            this.lbl_cap.Size = new System.Drawing.Size(48, 13);
            this.lbl_cap.TabIndex = 8;
            this.lbl_cap.Text = "Max cap";
            this.lbl_cap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_screenoff
            // 
            this.lbl_screenoff.AutoSize = true;
            this.lbl_screenoff.Location = new System.Drawing.Point(531, 64);
            this.lbl_screenoff.Name = "lbl_screenoff";
            this.lbl_screenoff.Size = new System.Drawing.Size(105, 13);
            this.lbl_screenoff.TabIndex = 10;
            this.lbl_screenoff.Text = "Screen off (Minutes):";
            // 
            // lbl_sleep
            // 
            this.lbl_sleep.AutoSize = true;
            this.lbl_sleep.Location = new System.Drawing.Point(529, 87);
            this.lbl_sleep.Name = "lbl_sleep";
            this.lbl_sleep.Size = new System.Drawing.Size(107, 13);
            this.lbl_sleep.TabIndex = 11;
            this.lbl_sleep.Text = "Sleep after (Minutes):";
            // 
            // updn_screen
            // 
            this.updn_screen.Location = new System.Drawing.Point(642, 61);
            this.updn_screen.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.updn_screen.Name = "updn_screen";
            this.updn_screen.Size = new System.Drawing.Size(48, 20);
            this.updn_screen.TabIndex = 15;
            this.updn_screen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updn_screen.ValueChanged += new System.EventHandler(this.updn_screen_ValueChanged);
            // 
            // updn_sleep
            // 
            this.updn_sleep.Location = new System.Drawing.Point(642, 85);
            this.updn_sleep.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.updn_sleep.Name = "updn_sleep";
            this.updn_sleep.Size = new System.Drawing.Size(48, 20);
            this.updn_sleep.TabIndex = 16;
            this.updn_sleep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updn_sleep.ValueChanged += new System.EventHandler(this.updn_sleep_ValueChanged);
            // 
            // lbl_maxcap
            // 
            this.lbl_maxcap.Location = new System.Drawing.Point(740, 64);
            this.lbl_maxcap.Name = "lbl_maxcap";
            this.lbl_maxcap.Size = new System.Drawing.Size(45, 13);
            this.lbl_maxcap.TabIndex = 17;
            this.lbl_maxcap.Text = "100%";
            this.lbl_maxcap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_scheme
            // 
            this.lbl_scheme.AutoSize = true;
            this.lbl_scheme.Location = new System.Drawing.Point(587, 16);
            this.lbl_scheme.Name = "lbl_scheme";
            this.lbl_scheme.Size = new System.Drawing.Size(49, 13);
            this.lbl_scheme.TabIndex = 18;
            this.lbl_scheme.Text = "Scheme:";
            this.lbl_scheme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(12, 415);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(75, 23);
            this.btn_settings.TabIndex = 19;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Power Manager";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // chkbx_safe
            // 
            this.chkbx_safe.AutoSize = true;
            this.chkbx_safe.Location = new System.Drawing.Point(216, 419);
            this.chkbx_safe.Name = "chkbx_safe";
            this.chkbx_safe.Size = new System.Drawing.Size(60, 17);
            this.chkbx_safe.TabIndex = 20;
            this.chkbx_safe.Text = "Unsafe";
            this.chkbx_safe.UseVisualStyleBackColor = true;
            this.chkbx_safe.CheckedChanged += new System.EventHandler(this.chkbx_safe_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkbx_safe);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.lbl_scheme);
            this.Controls.Add(this.lbl_maxcap);
            this.Controls.Add(this.updn_sleep);
            this.Controls.Add(this.updn_screen);
            this.Controls.Add(this.lbl_sleep);
            this.Controls.Add(this.lbl_screenoff);
            this.Controls.Add(this.lbl_cap);
            this.Controls.Add(this.tbx_log);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.trb_maxcap);
            this.Controls.Add(this.chkbx_startup);
            this.Controls.Add(this.cmb_profile);
            this.Controls.Add(this.btn_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Power Manager";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trb_maxcap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updn_sleep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.ComboBox cmb_profile;
        private System.Windows.Forms.CheckBox chkbx_startup;
        private System.Windows.Forms.TrackBar trb_maxcap;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox tbx_log;
        private System.Windows.Forms.Label lbl_cap;
        private System.Windows.Forms.Label lbl_screenoff;
        private System.Windows.Forms.Label lbl_sleep;
        private System.Windows.Forms.NumericUpDown updn_screen;
        private System.Windows.Forms.NumericUpDown updn_sleep;
        private System.Windows.Forms.Label lbl_maxcap;
        private System.Windows.Forms.Label lbl_scheme;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox chkbx_safe;
    }
}

