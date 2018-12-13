namespace RegistrationSystem
{
    partial class ProfessorView
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
            this.ProfessorTabControl = new System.Windows.Forms.TabControl();
            this.ProfessorScheduleTab = new System.Windows.Forms.TabPage();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleSectionComboBoxlbl = new System.Windows.Forms.Label();
            this.SemesterComboBoxlbl = new System.Windows.Forms.Label();
            this.UpdateStudentButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ScheduleSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.ScheduleSectionsComboBox = new System.Windows.Forms.ComboBox();
            this.ProfessorAddDropTab = new System.Windows.Forms.TabPage();
            this.AddDropSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DropButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddDropListBox = new System.Windows.Forms.ListBox();
            this.AddDropCoursesComboBox = new System.Windows.Forms.ComboBox();
            this.ProfessorPersonalInfoTab = new System.Windows.Forms.TabPage();
            this.LastNamelbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PhoneNumberLbl = new System.Windows.Forms.Label();
            this.AddressLbl = new System.Windows.Forms.Label();
            this.IDNumberlbl = new System.Windows.Forms.Label();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.UpdateInfoBtn = new System.Windows.Forms.Button();
            this.UserPhoneNumberLbl = new System.Windows.Forms.Label();
            this.UserEmailLbl = new System.Windows.Forms.Label();
            this.UserAddressLbl = new System.Windows.Forms.Label();
            this.UserIDNumberLbl = new System.Windows.Forms.Label();
            this.UserLastNameLbl = new System.Windows.Forms.Label();
            this.UserInfoDescriptionLbl = new System.Windows.Forms.Label();
            this.UserFirstNameLbl = new System.Windows.Forms.Label();
            this.ProfessorTitle = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.UserViewComboBox = new System.Windows.Forms.ComboBox();
            this.ProfessorTabControl.SuspendLayout();
            this.ProfessorScheduleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.ProfessorAddDropTab.SuspendLayout();
            this.ProfessorPersonalInfoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfessorTabControl
            // 
            this.ProfessorTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.ProfessorTabControl.Controls.Add(this.ProfessorScheduleTab);
            this.ProfessorTabControl.Controls.Add(this.ProfessorAddDropTab);
            this.ProfessorTabControl.Controls.Add(this.ProfessorPersonalInfoTab);
            this.ProfessorTabControl.HotTrack = true;
            this.ProfessorTabControl.Location = new System.Drawing.Point(12, 59);
            this.ProfessorTabControl.Multiline = true;
            this.ProfessorTabControl.Name = "ProfessorTabControl";
            this.ProfessorTabControl.SelectedIndex = 0;
            this.ProfessorTabControl.Size = new System.Drawing.Size(816, 429);
            this.ProfessorTabControl.TabIndex = 0;
            // 
            // ProfessorScheduleTab
            // 
            this.ProfessorScheduleTab.Controls.Add(this.StudentGridView);
            this.ProfessorScheduleTab.Controls.Add(this.ScheduleSectionComboBoxlbl);
            this.ProfessorScheduleTab.Controls.Add(this.SemesterComboBoxlbl);
            this.ProfessorScheduleTab.Controls.Add(this.UpdateStudentButton);
            this.ProfessorScheduleTab.Controls.Add(this.webBrowser1);
            this.ProfessorScheduleTab.Controls.Add(this.ScheduleSemesterComboBox);
            this.ProfessorScheduleTab.Controls.Add(this.ScheduleSectionsComboBox);
            this.ProfessorScheduleTab.Location = new System.Drawing.Point(23, 4);
            this.ProfessorScheduleTab.Name = "ProfessorScheduleTab";
            this.ProfessorScheduleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfessorScheduleTab.Size = new System.Drawing.Size(789, 421);
            this.ProfessorScheduleTab.TabIndex = 0;
            this.ProfessorScheduleTab.Text = "Schedule";
            this.ProfessorScheduleTab.UseVisualStyleBackColor = true;
            // 
            // StudentGridView
            // 
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.Grade});
            this.StudentGridView.Location = new System.Drawing.Point(161, 220);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.Size = new System.Drawing.Size(441, 150);
            this.StudentGridView.TabIndex = 6;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // Grade
            // 
            this.Grade.HeaderText = "Grade";
            this.Grade.Name = "Grade";
            // 
            // ScheduleSectionComboBoxlbl
            // 
            this.ScheduleSectionComboBoxlbl.AutoSize = true;
            this.ScheduleSectionComboBoxlbl.Location = new System.Drawing.Point(477, 160);
            this.ScheduleSectionComboBoxlbl.Name = "ScheduleSectionComboBoxlbl";
            this.ScheduleSectionComboBoxlbl.Size = new System.Drawing.Size(46, 13);
            this.ScheduleSectionComboBoxlbl.TabIndex = 5;
            this.ScheduleSectionComboBoxlbl.Text = "Section:";
            // 
            // SemesterComboBoxlbl
            // 
            this.SemesterComboBoxlbl.AutoSize = true;
            this.SemesterComboBoxlbl.Location = new System.Drawing.Point(72, 160);
            this.SemesterComboBoxlbl.Name = "SemesterComboBoxlbl";
            this.SemesterComboBoxlbl.Size = new System.Drawing.Size(54, 13);
            this.SemesterComboBoxlbl.TabIndex = 5;
            this.SemesterComboBoxlbl.Text = "Semester:";
            // 
            // UpdateStudentButton
            // 
            this.UpdateStudentButton.Location = new System.Drawing.Point(327, 376);
            this.UpdateStudentButton.Name = "UpdateStudentButton";
            this.UpdateStudentButton.Size = new System.Drawing.Size(109, 23);
            this.UpdateStudentButton.TabIndex = 4;
            this.UpdateStudentButton.Text = "Update Student";
            this.UpdateStudentButton.UseVisualStyleBackColor = true;
            this.UpdateStudentButton.Click += new System.EventHandler(this.UpdateStudentButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(768, 145);
            this.webBrowser1.TabIndex = 3;
            // 
            // ScheduleSemesterComboBox
            // 
            this.ScheduleSemesterComboBox.FormattingEnabled = true;
            this.ScheduleSemesterComboBox.Location = new System.Drawing.Point(75, 176);
            this.ScheduleSemesterComboBox.Name = "ScheduleSemesterComboBox";
            this.ScheduleSemesterComboBox.Size = new System.Drawing.Size(220, 21);
            this.ScheduleSemesterComboBox.TabIndex = 1;
            this.ScheduleSemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.ScheduleSemesterComboBox_SelectedIndexChanged);
            // 
            // ScheduleSectionsComboBox
            // 
            this.ScheduleSectionsComboBox.FormattingEnabled = true;
            this.ScheduleSectionsComboBox.Location = new System.Drawing.Point(480, 176);
            this.ScheduleSectionsComboBox.Name = "ScheduleSectionsComboBox";
            this.ScheduleSectionsComboBox.Size = new System.Drawing.Size(220, 21);
            this.ScheduleSectionsComboBox.TabIndex = 1;
            this.ScheduleSectionsComboBox.SelectedIndexChanged += new System.EventHandler(this.ScheduleSectionComboBox_SelectedIndexChanged);
            // 
            // ProfessorAddDropTab
            // 
            this.ProfessorAddDropTab.Controls.Add(this.AddDropSemesterComboBox);
            this.ProfessorAddDropTab.Controls.Add(this.label1);
            this.ProfessorAddDropTab.Controls.Add(this.label10);
            this.ProfessorAddDropTab.Controls.Add(this.DropButton);
            this.ProfessorAddDropTab.Controls.Add(this.AddButton);
            this.ProfessorAddDropTab.Controls.Add(this.AddDropListBox);
            this.ProfessorAddDropTab.Controls.Add(this.AddDropCoursesComboBox);
            this.ProfessorAddDropTab.Location = new System.Drawing.Point(23, 4);
            this.ProfessorAddDropTab.Name = "ProfessorAddDropTab";
            this.ProfessorAddDropTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfessorAddDropTab.Size = new System.Drawing.Size(789, 421);
            this.ProfessorAddDropTab.TabIndex = 1;
            this.ProfessorAddDropTab.Text = "Add/Drop";
            this.ProfessorAddDropTab.UseVisualStyleBackColor = true;
            // 
            // AddDropSemesterComboBox
            // 
            this.AddDropSemesterComboBox.FormattingEnabled = true;
            this.AddDropSemesterComboBox.Location = new System.Drawing.Point(6, 54);
            this.AddDropSemesterComboBox.Name = "AddDropSemesterComboBox";
            this.AddDropSemesterComboBox.Size = new System.Drawing.Size(208, 21);
            this.AddDropSemesterComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Semester:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Courses:";
            // 
            // DropButton
            // 
            this.DropButton.Location = new System.Drawing.Point(510, 379);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(130, 23);
            this.DropButton.TabIndex = 4;
            this.DropButton.Text = "Drop";
            this.DropButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(191, 379);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(130, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // AddDropListBox
            // 
            this.AddDropListBox.FormattingEnabled = true;
            this.AddDropListBox.Location = new System.Drawing.Point(6, 81);
            this.AddDropListBox.Name = "AddDropListBox";
            this.AddDropListBox.Size = new System.Drawing.Size(777, 264);
            this.AddDropListBox.TabIndex = 3;
            // 
            // AddDropCoursesComboBox
            // 
            this.AddDropCoursesComboBox.FormattingEnabled = true;
            this.AddDropCoursesComboBox.Location = new System.Drawing.Point(302, 54);
            this.AddDropCoursesComboBox.Name = "AddDropCoursesComboBox";
            this.AddDropCoursesComboBox.Size = new System.Drawing.Size(315, 21);
            this.AddDropCoursesComboBox.TabIndex = 0;
            // 
            // ProfessorPersonalInfoTab
            // 
            this.ProfessorPersonalInfoTab.Controls.Add(this.LastNamelbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.EmailLbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.PhoneNumberLbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.AddressLbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.IDNumberlbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.FirstNameLbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.UpdateInfoBtn);
            this.ProfessorPersonalInfoTab.Controls.Add(this.UserPhoneNumberLbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.UserEmailLbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.UserAddressLbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.UserIDNumberLbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.UserLastNameLbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.UserInfoDescriptionLbl);
            this.ProfessorPersonalInfoTab.Controls.Add(this.UserFirstNameLbl);
            this.ProfessorPersonalInfoTab.Location = new System.Drawing.Point(23, 4);
            this.ProfessorPersonalInfoTab.Name = "ProfessorPersonalInfoTab";
            this.ProfessorPersonalInfoTab.Size = new System.Drawing.Size(789, 421);
            this.ProfessorPersonalInfoTab.TabIndex = 2;
            this.ProfessorPersonalInfoTab.Text = "Personal Info";
            this.ProfessorPersonalInfoTab.UseVisualStyleBackColor = true;
            // 
            // LastNamelbl
            // 
            this.LastNamelbl.AutoSize = true;
            this.LastNamelbl.Location = new System.Drawing.Point(250, 68);
            this.LastNamelbl.Name = "LastNamelbl";
            this.LastNamelbl.Size = new System.Drawing.Size(61, 13);
            this.LastNamelbl.TabIndex = 12;
            this.LastNamelbl.Text = "Last Name:";
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Location = new System.Drawing.Point(38, 218);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(35, 13);
            this.EmailLbl.TabIndex = 12;
            this.EmailLbl.Text = "Email:";
            // 
            // PhoneNumberLbl
            // 
            this.PhoneNumberLbl.AutoSize = true;
            this.PhoneNumberLbl.Location = new System.Drawing.Point(38, 186);
            this.PhoneNumberLbl.Name = "PhoneNumberLbl";
            this.PhoneNumberLbl.Size = new System.Drawing.Size(81, 13);
            this.PhoneNumberLbl.TabIndex = 12;
            this.PhoneNumberLbl.Text = "Phone Number:";
            // 
            // AddressLbl
            // 
            this.AddressLbl.AutoSize = true;
            this.AddressLbl.Location = new System.Drawing.Point(38, 150);
            this.AddressLbl.Name = "AddressLbl";
            this.AddressLbl.Size = new System.Drawing.Size(48, 13);
            this.AddressLbl.TabIndex = 12;
            this.AddressLbl.Text = "Address:";
            // 
            // IDNumberlbl
            // 
            this.IDNumberlbl.AutoSize = true;
            this.IDNumberlbl.Location = new System.Drawing.Point(38, 111);
            this.IDNumberlbl.Name = "IDNumberlbl";
            this.IDNumberlbl.Size = new System.Drawing.Size(61, 13);
            this.IDNumberlbl.TabIndex = 12;
            this.IDNumberlbl.Text = "ID Number:";
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Location = new System.Drawing.Point(38, 68);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(60, 13);
            this.FirstNameLbl.TabIndex = 12;
            this.FirstNameLbl.Text = "First Name:";
            // 
            // UpdateInfoBtn
            // 
            this.UpdateInfoBtn.Location = new System.Drawing.Point(36, 375);
            this.UpdateInfoBtn.Name = "UpdateInfoBtn";
            this.UpdateInfoBtn.Size = new System.Drawing.Size(116, 23);
            this.UpdateInfoBtn.TabIndex = 11;
            this.UpdateInfoBtn.Text = "Update Info";
            this.UpdateInfoBtn.UseVisualStyleBackColor = true;
            this.UpdateInfoBtn.Click += new System.EventHandler(this.UpdateInfoBtn_Click_1);
            // 
            // UserPhoneNumberLbl
            // 
            this.UserPhoneNumberLbl.AutoSize = true;
            this.UserPhoneNumberLbl.Location = new System.Drawing.Point(134, 186);
            this.UserPhoneNumberLbl.Name = "UserPhoneNumberLbl";
            this.UserPhoneNumberLbl.Size = new System.Drawing.Size(78, 13);
            this.UserPhoneNumberLbl.TabIndex = 6;
            this.UserPhoneNumberLbl.Text = "Phone Number";
            // 
            // UserEmailLbl
            // 
            this.UserEmailLbl.AutoSize = true;
            this.UserEmailLbl.Location = new System.Drawing.Point(134, 218);
            this.UserEmailLbl.Name = "UserEmailLbl";
            this.UserEmailLbl.Size = new System.Drawing.Size(32, 13);
            this.UserEmailLbl.TabIndex = 5;
            this.UserEmailLbl.Text = "Email";
            // 
            // UserAddressLbl
            // 
            this.UserAddressLbl.AutoSize = true;
            this.UserAddressLbl.Location = new System.Drawing.Point(134, 150);
            this.UserAddressLbl.Name = "UserAddressLbl";
            this.UserAddressLbl.Size = new System.Drawing.Size(45, 13);
            this.UserAddressLbl.TabIndex = 4;
            this.UserAddressLbl.Text = "Address";
            // 
            // UserIDNumberLbl
            // 
            this.UserIDNumberLbl.AutoSize = true;
            this.UserIDNumberLbl.Location = new System.Drawing.Point(134, 111);
            this.UserIDNumberLbl.Name = "UserIDNumberLbl";
            this.UserIDNumberLbl.Size = new System.Drawing.Size(58, 13);
            this.UserIDNumberLbl.TabIndex = 3;
            this.UserIDNumberLbl.Text = "ID Number";
            // 
            // UserLastNameLbl
            // 
            this.UserLastNameLbl.AutoSize = true;
            this.UserLastNameLbl.Location = new System.Drawing.Point(331, 68);
            this.UserLastNameLbl.Name = "UserLastNameLbl";
            this.UserLastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.UserLastNameLbl.TabIndex = 2;
            this.UserLastNameLbl.Text = "Last Name";
            // 
            // UserInfoDescriptionLbl
            // 
            this.UserInfoDescriptionLbl.AutoSize = true;
            this.UserInfoDescriptionLbl.Location = new System.Drawing.Point(15, 19);
            this.UserInfoDescriptionLbl.Name = "UserInfoDescriptionLbl";
            this.UserInfoDescriptionLbl.Size = new System.Drawing.Size(87, 13);
            this.UserInfoDescriptionLbl.TabIndex = 1;
            this.UserInfoDescriptionLbl.Text = "User Information:";
            // 
            // UserFirstNameLbl
            // 
            this.UserFirstNameLbl.AutoSize = true;
            this.UserFirstNameLbl.Location = new System.Drawing.Point(134, 68);
            this.UserFirstNameLbl.Name = "UserFirstNameLbl";
            this.UserFirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.UserFirstNameLbl.TabIndex = 0;
            this.UserFirstNameLbl.Text = "First Name";
            // 
            // ProfessorTitle
            // 
            this.ProfessorTitle.AutoSize = true;
            this.ProfessorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfessorTitle.Location = new System.Drawing.Point(187, 6);
            this.ProfessorTitle.Name = "ProfessorTitle";
            this.ProfessorTitle.Size = new System.Drawing.Size(362, 54);
            this.ProfessorTitle.TabIndex = 1;
            this.ProfessorTitle.Text = "Professor Name";
            this.ProfessorTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(690, 498);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(138, 23);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.Logout_Click);
            // 
            // UserViewComboBox
            // 
            this.UserViewComboBox.FormattingEnabled = true;
            this.UserViewComboBox.Location = new System.Drawing.Point(12, 36);
            this.UserViewComboBox.Name = "UserViewComboBox";
            this.UserViewComboBox.Size = new System.Drawing.Size(106, 21);
            this.UserViewComboBox.TabIndex = 3;
            this.UserViewComboBox.Text = "View";
            this.UserViewComboBox.SelectedIndexChanged += new System.EventHandler(this.UserViewComboBox_SelectedIndexChanged);
            // 
            // ProfessorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 533);
            this.ControlBox = false;
            this.Controls.Add(this.UserViewComboBox);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.ProfessorTitle);
            this.Controls.Add(this.ProfessorTabControl);
            this.Name = "ProfessorView";
            this.Text = "Professor";
            this.ProfessorTabControl.ResumeLayout(false);
            this.ProfessorScheduleTab.ResumeLayout(false);
            this.ProfessorScheduleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ProfessorAddDropTab.ResumeLayout(false);
            this.ProfessorAddDropTab.PerformLayout();
            this.ProfessorPersonalInfoTab.ResumeLayout(false);
            this.ProfessorPersonalInfoTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl ProfessorTabControl;
        private System.Windows.Forms.TabPage ProfessorScheduleTab;
        private System.Windows.Forms.TabPage ProfessorAddDropTab;
        private System.Windows.Forms.Label ProfessorTitle;
        private System.Windows.Forms.ComboBox ScheduleSectionsComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox AddDropListBox;
        private System.Windows.Forms.ComboBox AddDropCoursesComboBox;
        private System.Windows.Forms.TabPage ProfessorPersonalInfoTab;
        private System.Windows.Forms.Label UserPhoneNumberLbl;
        private System.Windows.Forms.Label UserEmailLbl;
        private System.Windows.Forms.Label UserAddressLbl;
        private System.Windows.Forms.Label UserIDNumberLbl;
        private System.Windows.Forms.Label UserLastNameLbl;
        private System.Windows.Forms.Label UserInfoDescriptionLbl;
        private System.Windows.Forms.Label UserFirstNameLbl;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DropButton;
        private System.Windows.Forms.ComboBox UserViewComboBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button UpdateStudentButton;
        private System.Windows.Forms.Button UpdateInfoBtn;
        private System.Windows.Forms.Label ScheduleSectionComboBoxlbl;
        private System.Windows.Forms.Label SemesterComboBoxlbl;
        private System.Windows.Forms.ComboBox ScheduleSemesterComboBox;
        private System.Windows.Forms.ComboBox AddDropSemesterComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label LastNamelbl;
        private System.Windows.Forms.Label IDNumberlbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label PhoneNumberLbl;
        private System.Windows.Forms.Label AddressLbl;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
    }
}