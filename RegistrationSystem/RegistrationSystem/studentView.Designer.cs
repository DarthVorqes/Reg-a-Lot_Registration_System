namespace RegistrationSystem
{
    partial class StudentView
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
            this.AddDropSemesterLbl = new System.Windows.Forms.Label();
            this.AddDropCourseLbl = new System.Windows.Forms.Label();
            this.DropSectionBtn = new System.Windows.Forms.Button();
            this.AddSectionBtn = new System.Windows.Forms.Button();
            this.AddDropListBox = new System.Windows.Forms.ListBox();
            this.AddDropCoursesComboBox = new System.Windows.Forms.ComboBox();
            this.persInfo1 = new System.Windows.Forms.TabPage();
            this.InfoGrid = new System.Windows.Forms.DataGridView();
            this.InfoType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateInfoBtn = new System.Windows.Forms.Button();
            this.UserInfoDescriptionLbl = new System.Windows.Forms.Label();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.finance1 = new System.Windows.Forms.TabPage();
            this.UserBillLbl = new System.Windows.Forms.Label();
            this.BillLbl = new System.Windows.Forms.Label();
            this.UserHasPaidLbl = new System.Windows.Forms.Label();
            this.PaidLbl = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.UserViewComboBox = new System.Windows.Forms.ComboBox();
            this.StudentTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.sched1.SuspendLayout();
            this.addDrop1.SuspendLayout();
            this.persInfo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            this.finance1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // sched1
            // 
            this.sched1.Controls.Add(this.webBrowser1);
            this.sched1.Location = new System.Drawing.Point(23, 4);
            this.sched1.Name = "sched1";
            this.sched1.Padding = new System.Windows.Forms.Padding(3);
            this.sched1.Size = new System.Drawing.Size(789, 421);
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
            this.webBrowser1.Size = new System.Drawing.Size(783, 415);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // addDrop1
            // 
            this.addDrop1.BackColor = System.Drawing.SystemColors.Control;
            this.addDrop1.Controls.Add(this.AddDropSemesterComboBox);
            this.addDrop1.Controls.Add(this.AddDropSemesterLbl);
            this.addDrop1.Controls.Add(this.AddDropCourseLbl);
            this.addDrop1.Controls.Add(this.DropSectionBtn);
            this.addDrop1.Controls.Add(this.AddSectionBtn);
            this.addDrop1.Controls.Add(this.AddDropListBox);
            this.addDrop1.Controls.Add(this.AddDropCoursesComboBox);
            this.addDrop1.Location = new System.Drawing.Point(23, 4);
            this.addDrop1.Name = "addDrop1";
            this.addDrop1.Padding = new System.Windows.Forms.Padding(3);
            this.addDrop1.Size = new System.Drawing.Size(789, 421);
            this.addDrop1.TabIndex = 1;
            this.addDrop1.Text = "Add/Drop";
            // 
            // AddDropSemesterComboBox
            // 
            this.AddDropSemesterComboBox.FormattingEnabled = true;
            this.AddDropSemesterComboBox.Location = new System.Drawing.Point(6, 54);
            this.AddDropSemesterComboBox.Name = "AddDropSemesterComboBox";
            this.AddDropSemesterComboBox.Size = new System.Drawing.Size(208, 21);
            this.AddDropSemesterComboBox.TabIndex = 5;
            this.AddDropSemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.AddDropSemesterComboBox_SelectedIndexChanged);
            // 
            // AddDropSemesterLbl
            // 
            this.AddDropSemesterLbl.AutoSize = true;
            this.AddDropSemesterLbl.Location = new System.Drawing.Point(6, 38);
            this.AddDropSemesterLbl.Name = "AddDropSemesterLbl";
            this.AddDropSemesterLbl.Size = new System.Drawing.Size(54, 13);
            this.AddDropSemesterLbl.TabIndex = 4;
            this.AddDropSemesterLbl.Text = "Semester:";
            // 
            // AddDropCourseLbl
            // 
            this.AddDropCourseLbl.AutoSize = true;
            this.AddDropCourseLbl.Location = new System.Drawing.Point(299, 38);
            this.AddDropCourseLbl.Name = "AddDropCourseLbl";
            this.AddDropCourseLbl.Size = new System.Drawing.Size(48, 13);
            this.AddDropCourseLbl.TabIndex = 3;
            this.AddDropCourseLbl.Text = "Courses:";
            // 
            // DropSectionBtn
            // 
            this.DropSectionBtn.Location = new System.Drawing.Point(510, 379);
            this.DropSectionBtn.Name = "DropSectionBtn";
            this.DropSectionBtn.Size = new System.Drawing.Size(130, 23);
            this.DropSectionBtn.TabIndex = 2;
            this.DropSectionBtn.Text = "Drop";
            this.DropSectionBtn.UseVisualStyleBackColor = true;
            this.DropSectionBtn.Click += new System.EventHandler(this.DropSectionBtn_Click);
            // 
            // AddSectionBtn
            // 
            this.AddSectionBtn.Location = new System.Drawing.Point(191, 379);
            this.AddSectionBtn.Name = "AddSectionBtn";
            this.AddSectionBtn.Size = new System.Drawing.Size(130, 23);
            this.AddSectionBtn.TabIndex = 2;
            this.AddSectionBtn.Text = "Add";
            this.AddSectionBtn.UseVisualStyleBackColor = true;
            this.AddSectionBtn.Click += new System.EventHandler(this.AddSectionBtn_Click);
            // 
            // AddDropListBox
            // 
            this.AddDropListBox.FormattingEnabled = true;
            this.AddDropListBox.Location = new System.Drawing.Point(6, 81);
            this.AddDropListBox.Name = "AddDropListBox";
            this.AddDropListBox.Size = new System.Drawing.Size(777, 264);
            this.AddDropListBox.TabIndex = 1;
            // 
            // AddDropCoursesComboBox
            // 
            this.AddDropCoursesComboBox.FormattingEnabled = true;
            this.AddDropCoursesComboBox.Location = new System.Drawing.Point(302, 54);
            this.AddDropCoursesComboBox.Name = "AddDropCoursesComboBox";
            this.AddDropCoursesComboBox.Size = new System.Drawing.Size(315, 21);
            this.AddDropCoursesComboBox.TabIndex = 0;
            this.AddDropCoursesComboBox.SelectedIndexChanged += new System.EventHandler(this.AddDropCoursesComboBox_SelectedIndexChanged);
            // 
            // persInfo1
            // 
            this.persInfo1.Controls.Add(this.InfoGrid);
            this.persInfo1.Controls.Add(this.UpdateInfoBtn);
            this.persInfo1.Controls.Add(this.UserInfoDescriptionLbl);
            this.persInfo1.Controls.Add(this.webBrowser2);
            this.persInfo1.Location = new System.Drawing.Point(23, 4);
            this.persInfo1.Name = "persInfo1";
            this.persInfo1.Size = new System.Drawing.Size(789, 421);
            this.persInfo1.TabIndex = 2;
            this.persInfo1.Text = "Personal Info";
            this.persInfo1.UseVisualStyleBackColor = true;
            // 
            // InfoGrid
            // 
            this.InfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InfoType,
            this.InfoValue});
            this.InfoGrid.Location = new System.Drawing.Point(3, 47);
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.Size = new System.Drawing.Size(245, 325);
            this.InfoGrid.TabIndex = 5;
            // 
            // InfoType
            // 
            this.InfoType.HeaderText = "Info Type";
            this.InfoType.Name = "InfoType";
            this.InfoType.ReadOnly = true;
            // 
            // InfoValue
            // 
            this.InfoValue.HeaderText = "Value";
            this.InfoValue.Name = "InfoValue";
            // 
            // UpdateInfoBtn
            // 
            this.UpdateInfoBtn.Location = new System.Drawing.Point(366, 47);
            this.UpdateInfoBtn.Name = "UpdateInfoBtn";
            this.UpdateInfoBtn.Size = new System.Drawing.Size(116, 23);
            this.UpdateInfoBtn.TabIndex = 3;
            this.UpdateInfoBtn.Text = "Update Info";
            this.UpdateInfoBtn.UseVisualStyleBackColor = true;
            this.UpdateInfoBtn.Click += new System.EventHandler(this.UpdateInfoBtn_Click);
            // 
            // UserInfoDescriptionLbl
            // 
            this.UserInfoDescriptionLbl.AutoSize = true;
            this.UserInfoDescriptionLbl.Location = new System.Drawing.Point(15, 19);
            this.UserInfoDescriptionLbl.Name = "UserInfoDescriptionLbl";
            this.UserInfoDescriptionLbl.Size = new System.Drawing.Size(90, 13);
            this.UserInfoDescriptionLbl.TabIndex = 2;
            this.UserInfoDescriptionLbl.Text = "User Information: ";
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
            this.webBrowser2.Size = new System.Drawing.Size(789, 421);
            this.webBrowser2.TabIndex = 1;
            this.webBrowser2.Url = new System.Uri("C:\\Users\\programmer\\Source\\Repos\\Reg-a-Lot_Registration_System2\\RegistrationSyste" +
        "m\\RegistrationSystem\\info.html", System.UriKind.Absolute);
            this.webBrowser2.WebBrowserShortcutsEnabled = false;
            // 
            // finance1
            // 
            this.finance1.Controls.Add(this.UserBillLbl);
            this.finance1.Controls.Add(this.BillLbl);
            this.finance1.Controls.Add(this.UserHasPaidLbl);
            this.finance1.Controls.Add(this.PaidLbl);
            this.finance1.Location = new System.Drawing.Point(23, 4);
            this.finance1.Name = "finance1";
            this.finance1.Size = new System.Drawing.Size(789, 421);
            this.finance1.TabIndex = 3;
            this.finance1.Text = "Finances";
            this.finance1.UseVisualStyleBackColor = true;
            // 
            // UserBillLbl
            // 
            this.UserBillLbl.AutoSize = true;
            this.UserBillLbl.Location = new System.Drawing.Point(180, 99);
            this.UserBillLbl.Name = "UserBillLbl";
            this.UserBillLbl.Size = new System.Drawing.Size(37, 13);
            this.UserBillLbl.TabIndex = 1;
            this.UserBillLbl.Text = "GetBill";
            // 
            // BillLbl
            // 
            this.BillLbl.AutoSize = true;
            this.BillLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillLbl.Location = new System.Drawing.Point(48, 99);
            this.BillLbl.Name = "BillLbl";
            this.BillLbl.Size = new System.Drawing.Size(23, 13);
            this.BillLbl.TabIndex = 1;
            this.BillLbl.Text = "Bill:";
            // 
            // UserHasPaidLbl
            // 
            this.UserHasPaidLbl.AutoSize = true;
            this.UserHasPaidLbl.Location = new System.Drawing.Point(180, 65);
            this.UserHasPaidLbl.Name = "UserHasPaidLbl";
            this.UserHasPaidLbl.Size = new System.Drawing.Size(47, 13);
            this.UserHasPaidLbl.TabIndex = 0;
            this.UserHasPaidLbl.Text = "HasPaid";
            // 
            // PaidLbl
            // 
            this.PaidLbl.AutoSize = true;
            this.PaidLbl.Location = new System.Drawing.Point(47, 65);
            this.PaidLbl.Name = "PaidLbl";
            this.PaidLbl.Size = new System.Drawing.Size(96, 13);
            this.PaidLbl.TabIndex = 0;
            this.PaidLbl.Text = "Status of Payment:";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(690, 498);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(138, 23);
            this.LogoutBtn.TabIndex = 1;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // UserViewComboBox
            // 
            this.UserViewComboBox.FormattingEnabled = true;
            this.UserViewComboBox.Location = new System.Drawing.Point(12, 36);
            this.UserViewComboBox.Name = "UserViewComboBox";
            this.UserViewComboBox.Size = new System.Drawing.Size(106, 21);
            this.UserViewComboBox.TabIndex = 2;
            this.UserViewComboBox.Text = "View";
            this.UserViewComboBox.SelectedIndexChanged += new System.EventHandler(this.UserViewComboBox_SelectedIndexChanged);
            // 
            // StudentTitle
            // 
            this.StudentTitle.AutoSize = true;
            this.StudentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentTitle.Location = new System.Drawing.Point(187, 6);
            this.StudentTitle.Name = "StudentTitle";
            this.StudentTitle.Size = new System.Drawing.Size(321, 54);
            this.StudentTitle.TabIndex = 3;
            this.StudentTitle.Text = "Student Name";
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(840, 533);
            this.ControlBox = false;
            this.Controls.Add(this.StudentTitle);
            this.Controls.Add(this.UserViewComboBox);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentView";
            this.Text = "Student View";
            this.Load += new System.EventHandler(this.StudentView_Load);
            this.tabControl1.ResumeLayout(false);
            this.sched1.ResumeLayout(false);
            this.addDrop1.ResumeLayout(false);
            this.addDrop1.PerformLayout();
            this.persInfo1.ResumeLayout(false);
            this.persInfo1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            this.finance1.ResumeLayout(false);
            this.finance1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage sched1;
        private System.Windows.Forms.TabPage addDrop1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage persInfo1;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.TabPage finance1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.ComboBox UserViewComboBox;
        private System.Windows.Forms.ListBox AddDropListBox;
        private System.Windows.Forms.ComboBox AddDropCoursesComboBox;
        private System.Windows.Forms.Button DropSectionBtn;
        private System.Windows.Forms.Button AddSectionBtn;
        private System.Windows.Forms.ComboBox AddDropSemesterComboBox;
        private System.Windows.Forms.Label AddDropSemesterLbl;
        private System.Windows.Forms.Label AddDropCourseLbl;
        private System.Windows.Forms.Label UserInfoDescriptionLbl;
        private System.Windows.Forms.Button UpdateInfoBtn;
        private System.Windows.Forms.Label StudentTitle;
        private System.Windows.Forms.Label UserHasPaidLbl;
        private System.Windows.Forms.Label PaidLbl;
        private System.Windows.Forms.Label UserBillLbl;
        private System.Windows.Forms.Label BillLbl;
        private System.Windows.Forms.DataGridView InfoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoType;
        private System.Windows.Forms.DataGridViewTextBoxColumn InfoValue;
    }
}