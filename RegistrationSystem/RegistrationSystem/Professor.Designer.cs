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
            this.CoursesComboBoxlbl = new System.Windows.Forms.Label();
            this.SemesterComboBoxlbl = new System.Windows.Forms.Label();
            this.ViewStudentButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.ScheduleStudentListBox = new System.Windows.Forms.ListBox();
            this.ScheduleSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.ScheduleCoursesComboBox = new System.Windows.Forms.ComboBox();
            this.ProfessorAddDropTab = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.DropButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddDropListBox = new System.Windows.Forms.ListBox();
            this.AddDropCoursesComboBox = new System.Windows.Forms.ComboBox();
            this.ProfessorPersonalInfoTab = new System.Windows.Forms.TabPage();
            this.updateInfoBtn = new System.Windows.Forms.Button();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.IDNumberLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PersonalInforDescriptionLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ProfessorTitle = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.UserViewComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDropSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.ProfessorTabControl.SuspendLayout();
            this.ProfessorScheduleTab.SuspendLayout();
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
            this.ProfessorScheduleTab.Controls.Add(this.CoursesComboBoxlbl);
            this.ProfessorScheduleTab.Controls.Add(this.SemesterComboBoxlbl);
            this.ProfessorScheduleTab.Controls.Add(this.ViewStudentButton);
            this.ProfessorScheduleTab.Controls.Add(this.webBrowser1);
            this.ProfessorScheduleTab.Controls.Add(this.ScheduleStudentListBox);
            this.ProfessorScheduleTab.Controls.Add(this.ScheduleSemesterComboBox);
            this.ProfessorScheduleTab.Controls.Add(this.ScheduleCoursesComboBox);
            this.ProfessorScheduleTab.Location = new System.Drawing.Point(23, 4);
            this.ProfessorScheduleTab.Name = "ProfessorScheduleTab";
            this.ProfessorScheduleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfessorScheduleTab.Size = new System.Drawing.Size(789, 421);
            this.ProfessorScheduleTab.TabIndex = 0;
            this.ProfessorScheduleTab.Text = "Schedule";
            this.ProfessorScheduleTab.UseVisualStyleBackColor = true;
            // 
            // CoursesComboBoxlbl
            // 
            this.CoursesComboBoxlbl.AutoSize = true;
            this.CoursesComboBoxlbl.Location = new System.Drawing.Point(282, 160);
            this.CoursesComboBoxlbl.Name = "CoursesComboBoxlbl";
            this.CoursesComboBoxlbl.Size = new System.Drawing.Size(48, 13);
            this.CoursesComboBoxlbl.TabIndex = 5;
            this.CoursesComboBoxlbl.Text = "Courses:";
            // 
            // SemesterComboBoxlbl
            // 
            this.SemesterComboBoxlbl.AutoSize = true;
            this.SemesterComboBoxlbl.Location = new System.Drawing.Point(27, 157);
            this.SemesterComboBoxlbl.Name = "SemesterComboBoxlbl";
            this.SemesterComboBoxlbl.Size = new System.Drawing.Size(54, 13);
            this.SemesterComboBoxlbl.TabIndex = 5;
            this.SemesterComboBoxlbl.Text = "Semester:";
            // 
            // ViewStudentButton
            // 
            this.ViewStudentButton.Location = new System.Drawing.Point(664, 174);
            this.ViewStudentButton.Name = "ViewStudentButton";
            this.ViewStudentButton.Size = new System.Drawing.Size(109, 23);
            this.ViewStudentButton.TabIndex = 4;
            this.ViewStudentButton.Text = "View Student";
            this.ViewStudentButton.UseVisualStyleBackColor = true;
            this.ViewStudentButton.Click += new System.EventHandler(this.ViewStudentButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(15, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(768, 145);
            this.webBrowser1.TabIndex = 3;
            // 
            // ScheduleStudentListBox
            // 
            this.ScheduleStudentListBox.FormattingEnabled = true;
            this.ScheduleStudentListBox.Location = new System.Drawing.Point(27, 203);
            this.ScheduleStudentListBox.Name = "ScheduleStudentListBox";
            this.ScheduleStudentListBox.Size = new System.Drawing.Size(746, 212);
            this.ScheduleStudentListBox.TabIndex = 2;
            // 
            // ScheduleSemesterComboBox
            // 
            this.ScheduleSemesterComboBox.FormattingEnabled = true;
            this.ScheduleSemesterComboBox.Location = new System.Drawing.Point(27, 176);
            this.ScheduleSemesterComboBox.Name = "ScheduleSemesterComboBox";
            this.ScheduleSemesterComboBox.Size = new System.Drawing.Size(220, 21);
            this.ScheduleSemesterComboBox.TabIndex = 1;
            this.ScheduleSemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.ScheduleSemesterComboBox_SelectedIndexChanged);
            // 
            // ScheduleCoursesComboBox
            // 
            this.ScheduleCoursesComboBox.FormattingEnabled = true;
            this.ScheduleCoursesComboBox.Location = new System.Drawing.Point(285, 176);
            this.ScheduleCoursesComboBox.Name = "ScheduleCoursesComboBox";
            this.ScheduleCoursesComboBox.Size = new System.Drawing.Size(220, 21);
            this.ScheduleCoursesComboBox.TabIndex = 1;
            this.ScheduleCoursesComboBox.SelectedIndexChanged += new System.EventHandler(this.ScheduleCoursesComboBox_SelectedIndexChanged);
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
            this.DropButton.Click += new System.EventHandler(this.DropButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(191, 379);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(130, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
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
            this.AddDropCoursesComboBox.SelectedIndexChanged += new System.EventHandler(this.AddDropCoursesComboBox_SelectedIndexChanged);
            // 
            // ProfessorPersonalInfoTab
            // 
            this.ProfessorPersonalInfoTab.Controls.Add(this.updateInfoBtn);
            this.ProfessorPersonalInfoTab.Controls.Add(this.PhoneNumberLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.EmailLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.AddressLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.IDNumberLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.LastNameLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.PersonalInforDescriptionLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.FirstNameLabel);
            this.ProfessorPersonalInfoTab.Location = new System.Drawing.Point(23, 4);
            this.ProfessorPersonalInfoTab.Name = "ProfessorPersonalInfoTab";
            this.ProfessorPersonalInfoTab.Size = new System.Drawing.Size(789, 421);
            this.ProfessorPersonalInfoTab.TabIndex = 2;
            this.ProfessorPersonalInfoTab.Text = "Personal Info";
            this.ProfessorPersonalInfoTab.UseVisualStyleBackColor = true;
            // 
            // updateInfoBtn
            // 
            this.updateInfoBtn.Location = new System.Drawing.Point(61, 297);
            this.updateInfoBtn.Name = "updateInfoBtn";
            this.updateInfoBtn.Size = new System.Drawing.Size(116, 23);
            this.updateInfoBtn.TabIndex = 11;
            this.updateInfoBtn.Text = "Update Info";
            this.updateInfoBtn.UseVisualStyleBackColor = true;
            this.updateInfoBtn.Click += new System.EventHandler(this.updateInfoBtn_Click);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(58, 186);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(78, 13);
            this.PhoneNumberLabel.TabIndex = 6;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(58, 222);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "Email";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(58, 150);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address";
            // 
            // IDNumberLabel
            // 
            this.IDNumberLabel.AutoSize = true;
            this.IDNumberLabel.Location = new System.Drawing.Point(58, 110);
            this.IDNumberLabel.Name = "IDNumberLabel";
            this.IDNumberLabel.Size = new System.Drawing.Size(54, 13);
            this.IDNumberLabel.TabIndex = 3;
            this.IDNumberLabel.Text = "Id number";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(217, 68);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // PersonalInforDescriptionLabel
            // 
            this.PersonalInforDescriptionLabel.AutoSize = true;
            this.PersonalInforDescriptionLabel.Location = new System.Drawing.Point(15, 19);
            this.PersonalInforDescriptionLabel.Name = "PersonalInforDescriptionLabel";
            this.PersonalInforDescriptionLabel.Size = new System.Drawing.Size(84, 13);
            this.PersonalInforDescriptionLabel.TabIndex = 1;
            this.PersonalInforDescriptionLabel.Text = "User Information";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(58, 68);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // ProfessorTitle
            // 
            this.ProfessorTitle.AutoSize = true;
            this.ProfessorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfessorTitle.Location = new System.Drawing.Point(187, 6);
            this.ProfessorTitle.Name = "ProfessorTitle";
            this.ProfessorTitle.Size = new System.Drawing.Size(395, 54);
            this.ProfessorTitle.TabIndex = 1;
            this.ProfessorTitle.Text = "Professor\'s Name";
            this.ProfessorTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(690, 498);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(138, 23);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // UserViewComboBox
            // 
            this.UserViewComboBox.FormattingEnabled = true;
            this.UserViewComboBox.Location = new System.Drawing.Point(12, 36);
            this.UserViewComboBox.Name = "UserViewComboBox";
            this.UserViewComboBox.Size = new System.Drawing.Size(106, 21);
            this.UserViewComboBox.TabIndex = 3;
            this.UserViewComboBox.SelectedIndexChanged += new System.EventHandler(this.UserViewComboBox_SelectedIndexChanged);
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
            // AddDropSemesterComboBox
            // 
            this.AddDropSemesterComboBox.FormattingEnabled = true;
            this.AddDropSemesterComboBox.Location = new System.Drawing.Point(6, 54);
            this.AddDropSemesterComboBox.Name = "AddDropSemesterComboBox";
            this.AddDropSemesterComboBox.Size = new System.Drawing.Size(208, 21);
            this.AddDropSemesterComboBox.TabIndex = 9;
            this.AddDropSemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.AddDropSemesterComboBox_SelectedIndexChanged);
            // 
            // ProfessorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 533);
            this.ControlBox = false;
            this.Controls.Add(this.UserViewComboBox);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ProfessorTitle);
            this.Controls.Add(this.ProfessorTabControl);
            this.Name = "ProfessorView";
            this.Text = "Professor";
            this.ProfessorTabControl.ResumeLayout(false);
            this.ProfessorScheduleTab.ResumeLayout(false);
            this.ProfessorScheduleTab.PerformLayout();
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
        private System.Windows.Forms.ListBox ScheduleStudentListBox;
        private System.Windows.Forms.ComboBox ScheduleCoursesComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox AddDropListBox;
        private System.Windows.Forms.ComboBox AddDropCoursesComboBox;
        private System.Windows.Forms.TabPage ProfessorPersonalInfoTab;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label IDNumberLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PersonalInforDescriptionLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DropButton;
        private System.Windows.Forms.ComboBox UserViewComboBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button ViewStudentButton;
        private System.Windows.Forms.Button updateInfoBtn;
        private System.Windows.Forms.Label CoursesComboBoxlbl;
        private System.Windows.Forms.Label SemesterComboBoxlbl;
        private System.Windows.Forms.ComboBox ScheduleSemesterComboBox;
        private System.Windows.Forms.ComboBox AddDropSemesterComboBox;
        private System.Windows.Forms.Label label1;
    }
}