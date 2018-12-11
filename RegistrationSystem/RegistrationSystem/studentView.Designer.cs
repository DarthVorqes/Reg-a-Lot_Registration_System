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
            this.AddDropSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.AddDropSemesterlbl = new System.Windows.Forms.Label();
            this.AddDropCourselbl = new System.Windows.Forms.Label();
            this.DropSectionBtn = new System.Windows.Forms.Button();
            this.AddSectionBtn = new System.Windows.Forms.Button();
            this.AddDropListBox = new System.Windows.Forms.ListBox();
            this.AddDropCoursesComboBox = new System.Windows.Forms.ComboBox();
            this.persInfo1 = new System.Windows.Forms.TabPage();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.finance1 = new System.Windows.Forms.TabPage();
            this.logOut1 = new System.Windows.Forms.Button();
            this.UserViewComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.sched1.SuspendLayout();
            this.addDrop1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(-2, 29);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // sched1
            // 
            this.sched1.Controls.Add(this.webBrowser1);
            this.sched1.Location = new System.Drawing.Point(23, 4);
            this.sched1.Name = "sched1";
            this.sched1.Padding = new System.Windows.Forms.Padding(3);
            this.sched1.Size = new System.Drawing.Size(803, 442);
            this.sched1.TabIndex = 0;
            this.sched1.Text = "Schedule";
            this.sched1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(797, 436);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("C:\\Users\\programmer\\Source\\Repos\\Reg-a-Lot_Registration_System2\\RegistrationSyste" +
        "m\\RegistrationSystem\\schedule.html", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // addDrop1
            // 
            this.addDrop1.BackColor = System.Drawing.SystemColors.Control;
            this.addDrop1.Controls.Add(this.AddDropSemesterComboBox);
            this.addDrop1.Controls.Add(this.AddDropSemesterlbl);
            this.addDrop1.Controls.Add(this.AddDropCourselbl);
            this.addDrop1.Controls.Add(this.DropSectionBtn);
            this.addDrop1.Controls.Add(this.AddSectionBtn);
            this.addDrop1.Controls.Add(this.AddDropListBox);
            this.addDrop1.Controls.Add(this.AddDropCoursesComboBox);
            this.addDrop1.Location = new System.Drawing.Point(23, 4);
            this.addDrop1.Name = "addDrop1";
            this.addDrop1.Padding = new System.Windows.Forms.Padding(3);
            this.addDrop1.Size = new System.Drawing.Size(803, 442);
            this.addDrop1.TabIndex = 1;
            this.addDrop1.Text = "Add/Drop";
            // 
            // AddDropSemesterComboBox
            // 
            this.AddDropSemesterComboBox.FormattingEnabled = true;
            this.AddDropSemesterComboBox.Location = new System.Drawing.Point(22, 61);
            this.AddDropSemesterComboBox.Name = "AddDropSemesterComboBox";
            this.AddDropSemesterComboBox.Size = new System.Drawing.Size(188, 21);
            this.AddDropSemesterComboBox.TabIndex = 5;
            this.AddDropSemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.AddDropSemesterComboBox_SelectedIndexChanged);
            // 
            // AddDropSemesterlbl
            // 
            this.AddDropSemesterlbl.AutoSize = true;
            this.AddDropSemesterlbl.Location = new System.Drawing.Point(22, 41);
            this.AddDropSemesterlbl.Name = "AddDropSemesterlbl";
            this.AddDropSemesterlbl.Size = new System.Drawing.Size(54, 13);
            this.AddDropSemesterlbl.TabIndex = 4;
            this.AddDropSemesterlbl.Text = "Semester:";
            // 
            // AddDropCourselbl
            // 
            this.AddDropCourselbl.AutoSize = true;
            this.AddDropCourselbl.Location = new System.Drawing.Point(314, 45);
            this.AddDropCourselbl.Name = "AddDropCourselbl";
            this.AddDropCourselbl.Size = new System.Drawing.Size(48, 13);
            this.AddDropCourselbl.TabIndex = 3;
            this.AddDropCourselbl.Text = "Courses:";
            // 
            // DropSectionBtn
            // 
            this.DropSectionBtn.Location = new System.Drawing.Point(468, 358);
            this.DropSectionBtn.Name = "DropSectionBtn";
            this.DropSectionBtn.Size = new System.Drawing.Size(75, 23);
            this.DropSectionBtn.TabIndex = 2;
            this.DropSectionBtn.Text = "Drop";
            this.DropSectionBtn.UseVisualStyleBackColor = true;
            this.DropSectionBtn.Click += new System.EventHandler(this.DropSectionBtn_Click);
            // 
            // AddSectionBtn
            // 
            this.AddSectionBtn.Location = new System.Drawing.Point(254, 358);
            this.AddSectionBtn.Name = "AddSectionBtn";
            this.AddSectionBtn.Size = new System.Drawing.Size(75, 23);
            this.AddSectionBtn.TabIndex = 2;
            this.AddSectionBtn.Text = "Add";
            this.AddSectionBtn.UseVisualStyleBackColor = true;
            this.AddSectionBtn.Click += new System.EventHandler(this.AddSectionBtn_Click);
            // 
            // AddDropListBox
            // 
            this.AddDropListBox.FormattingEnabled = true;
            this.AddDropListBox.Location = new System.Drawing.Point(22, 88);
            this.AddDropListBox.Name = "AddDropListBox";
            this.AddDropListBox.Size = new System.Drawing.Size(762, 238);
            this.AddDropListBox.TabIndex = 1;
            // 
            // AddDropCoursesComboBox
            // 
            this.AddDropCoursesComboBox.FormattingEnabled = true;
            this.AddDropCoursesComboBox.Location = new System.Drawing.Point(317, 61);
            this.AddDropCoursesComboBox.Name = "AddDropCoursesComboBox";
            this.AddDropCoursesComboBox.Size = new System.Drawing.Size(280, 21);
            this.AddDropCoursesComboBox.TabIndex = 0;
            this.AddDropCoursesComboBox.SelectedIndexChanged += new System.EventHandler(this.AddDropCoursesComboBox_SelectedIndexChanged);
            // 
            // persInfo1
            // 
            this.persInfo1.Controls.Add(this.webBrowser2);
            this.persInfo1.Location = new System.Drawing.Point(23, 4);
            this.persInfo1.Name = "persInfo1";
            this.persInfo1.Size = new System.Drawing.Size(803, 442);
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
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(803, 442);
            this.webBrowser2.TabIndex = 1;
            this.webBrowser2.Url = new System.Uri("C:\\Users\\programmer\\Source\\Repos\\Reg-a-Lot_Registration_System2\\RegistrationSyste" +
        "m\\RegistrationSystem\\info.html", System.UriKind.Absolute);
            this.webBrowser2.WebBrowserShortcutsEnabled = false;
            // 
            // finance1
            // 
            this.finance1.Location = new System.Drawing.Point(23, 4);
            this.finance1.Name = "finance1";
            this.finance1.Size = new System.Drawing.Size(803, 442);
            this.finance1.TabIndex = 3;
            this.finance1.Text = "Finances";
            this.finance1.UseVisualStyleBackColor = true;
            // 
            // logOut1
            // 
            this.logOut1.Location = new System.Drawing.Point(753, 498);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(75, 23);
            this.logOut1.TabIndex = 1;
            this.logOut1.Text = "Logout";
            this.logOut1.UseVisualStyleBackColor = true;
            this.logOut1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserViewComboBox
            // 
            this.UserViewComboBox.FormattingEnabled = true;
            this.UserViewComboBox.Location = new System.Drawing.Point(21, 6);
            this.UserViewComboBox.Name = "UserViewComboBox";
            this.UserViewComboBox.Size = new System.Drawing.Size(121, 21);
            this.UserViewComboBox.TabIndex = 2;
            this.UserViewComboBox.Text = "View";
            this.UserViewComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // studentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(840, 533);
            this.ControlBox = false;
            this.Controls.Add(this.UserViewComboBox);
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.tabControl1);
            this.Name = "studentView";
            this.Text = "Student View";
            this.tabControl1.ResumeLayout(false);
            this.sched1.ResumeLayout(false);
            this.addDrop1.ResumeLayout(false);
            this.addDrop1.PerformLayout();
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
        private System.Windows.Forms.ComboBox UserViewComboBox;
        private System.Windows.Forms.ListBox AddDropListBox;
        private System.Windows.Forms.ComboBox AddDropCoursesComboBox;
        private System.Windows.Forms.Button DropSectionBtn;
        private System.Windows.Forms.Button AddSectionBtn;
        private System.Windows.Forms.ComboBox AddDropSemesterComboBox;
        private System.Windows.Forms.Label AddDropSemesterlbl;
        private System.Windows.Forms.Label AddDropCourselbl;
    }
}