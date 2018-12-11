namespace RegistrationSystem
{
    partial class studentView
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sched1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.addDrop1 = new System.Windows.Forms.TabPage();
            this.persInfo1 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.finance1 = new System.Windows.Forms.TabPage();
            this.logOut1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.sched1.SuspendLayout();
            this.persInfo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.sched1);
            this.tabControl1.Controls.Add(this.addDrop1);
            this.tabControl1.Controls.Add(this.persInfo1);
            this.tabControl1.Controls.Add(this.finance1);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(-3, 36);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(927, 670);
            this.tabControl1.TabIndex = 0;
            // 
            // sched1
            // 
            this.sched1.Controls.Add(this.webBrowser1);
            this.sched1.Location = new System.Drawing.Point(25, 4);
            this.sched1.Margin = new System.Windows.Forms.Padding(4);
            this.sched1.Name = "sched1";
            this.sched1.Padding = new System.Windows.Forms.Padding(4);
            this.sched1.Size = new System.Drawing.Size(898, 662);
            this.sched1.TabIndex = 0;
            this.sched1.Text = "Schedule";
            this.sched1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(4, 4);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(890, 654);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("C:\\Users\\Rui\\Desktop\\Schedule.html", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // addDrop1
            // 
            this.addDrop1.BackColor = System.Drawing.SystemColors.Control;
            this.addDrop1.Location = new System.Drawing.Point(25, 4);
            this.addDrop1.Margin = new System.Windows.Forms.Padding(4);
            this.addDrop1.Name = "addDrop1";
            this.addDrop1.Padding = new System.Windows.Forms.Padding(4);
            this.addDrop1.Size = new System.Drawing.Size(898, 662);
            this.addDrop1.TabIndex = 1;
            this.addDrop1.Text = "Add/Drop";
            // 
            // persInfo1
            // 
            this.persInfo1.Controls.Add(this.webBrowser2);
            this.persInfo1.Location = new System.Drawing.Point(25, 4);
            this.persInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.persInfo1.Name = "persInfo1";
            this.persInfo1.Size = new System.Drawing.Size(898, 662);
            this.persInfo1.TabIndex = 2;
            this.persInfo1.Text = "Information";
            this.persInfo1.UseVisualStyleBackColor = true;
            // 
            // webBrowser2
            // 
            this.webBrowser2.AllowNavigation = false;
            this.webBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser2.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webBrowser2.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(898, 662);
            this.webBrowser2.TabIndex = 1;
            this.webBrowser2.Url = new System.Uri("C:\\Users\\programmer\\Source\\Repos\\Reg-a-Lot_Registration_System2\\RegistrationSyste" +
        "m\\RegistrationSystem\\info.html", System.UriKind.Absolute);
            this.webBrowser2.WebBrowserShortcutsEnabled = false;
            // 
            // finance1
            // 
            this.finance1.Location = new System.Drawing.Point(25, 4);
            this.finance1.Margin = new System.Windows.Forms.Padding(4);
            this.finance1.Name = "finance1";
            this.finance1.Size = new System.Drawing.Size(898, 662);
            this.finance1.TabIndex = 3;
            this.finance1.Text = "Finances";
            this.finance1.UseVisualStyleBackColor = true;
            // 
            // logOut1
            // 
            this.logOut1.Location = new System.Drawing.Point(824, 713);
            this.logOut1.Margin = new System.Windows.Forms.Padding(4);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(100, 28);
            this.logOut1.TabIndex = 1;
            this.logOut1.Text = "Logout";
            this.logOut1.UseVisualStyleBackColor = true;
            this.logOut1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Professor View",
            "Registrar View"});
            this.comboBox1.Location = new System.Drawing.Point(28, 7);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "View";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 747);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "studentView";
            this.Text = "Student View";
            this.Load += new System.EventHandler(this.studentView_Load);
            this.tabControl1.ResumeLayout(false);
            this.sched1.ResumeLayout(false);
            this.persInfo1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage sched1;
        private System.Windows.Forms.TabPage addDrop1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage persInfo1;
        private System.Windows.Forms.Button logOut1;
        private System.Windows.Forms.TabPage finance1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}