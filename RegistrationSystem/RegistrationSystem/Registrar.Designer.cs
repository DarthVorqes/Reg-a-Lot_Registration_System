namespace RegistrationSystem
{
    partial class Registrar
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
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.UserViewComboBox = new System.Windows.Forms.ComboBox();
            this.personalInfoPage = new System.Windows.Forms.TabPage();
            this.updateBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddUserBtn = new System.Windows.Forms.Button();
            this.UpdateSectionInfoBtn = new System.Windows.Forms.Button();
            this.UpdatePersonalInfoBtn = new System.Windows.Forms.Button();
            this.SectionLookupListBox = new System.Windows.Forms.ListBox();
            this.PersonLookupListBox = new System.Windows.Forms.ListBox();
            this.SearchAddressLbl = new System.Windows.Forms.Label();
            this.LookUpEmail = new System.Windows.Forms.Label();
            this.SearchPhoneNumberLbl = new System.Windows.Forms.Label();
            this.SearchEmailLbl = new System.Windows.Forms.Label();
            this.SearchFirstNameLbl = new System.Windows.Forms.Label();
            this.SearchLastNameLbl = new System.Windows.Forms.Label();
            this.SearchIDNumberLbl = new System.Windows.Forms.Label();
            this.SearchResultsListBoxLbl = new System.Windows.Forms.Label();
            this.SectionListBoxLbl = new System.Windows.Forms.Label();
            this.LookUpIDNumberLbl = new System.Windows.Forms.Label();
            this.LookUpPhoneNumberLbl = new System.Windows.Forms.Label();
            this.LookUpAddressLbl = new System.Windows.Forms.Label();
            this.LookUpLastNameLbl = new System.Windows.Forms.Label();
            this.LookUpFirstNameLbl = new System.Windows.Forms.Label();
            this.UserSearchBtn = new System.Windows.Forms.Button();
            this.UserSearchBox = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.ProfessorNameLbl = new System.Windows.Forms.Label();
            this.DayLbl = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.SectionNameLbl = new System.Windows.Forms.Label();
            this.CourseNameLbl = new System.Windows.Forms.Label();
            this.CourseSearchBtn = new System.Windows.Forms.Button();
            this.CourseSearchBox = new System.Windows.Forms.TextBox();
            this.searchCourseLbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.RegistrarTitle = new System.Windows.Forms.Label();
            this.personalInfoPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(690, 498);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(138, 23);
            this.LogoutBtn.TabIndex = 13;
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
            this.UserViewComboBox.TabIndex = 24;
            this.UserViewComboBox.Text = "View";
            this.UserViewComboBox.SelectedIndexChanged += new System.EventHandler(this.UserViewComboBox_SelectedIndexChanged);
            // 
            // personalInfoPage
            // 
            this.personalInfoPage.Controls.Add(this.updateBtn);
            this.personalInfoPage.Location = new System.Drawing.Point(23, 4);
            this.personalInfoPage.Name = "personalInfoPage";
            this.personalInfoPage.Size = new System.Drawing.Size(789, 421);
            this.personalInfoPage.TabIndex = 2;
            this.personalInfoPage.Text = "Personal Info";
            this.personalInfoPage.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(36, 375);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(116, 23);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update Info";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "User Lookup";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.UserSearchBtn);
            this.panel2.Controls.Add(this.UserSearchBox);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 415);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.AddUserBtn);
            this.panel3.Controls.Add(this.UpdateSectionInfoBtn);
            this.panel3.Controls.Add(this.UpdatePersonalInfoBtn);
            this.panel3.Controls.Add(this.SectionLookupListBox);
            this.panel3.Controls.Add(this.PersonLookupListBox);
            this.panel3.Controls.Add(this.SearchAddressLbl);
            this.panel3.Controls.Add(this.LookUpEmail);
            this.panel3.Controls.Add(this.SearchPhoneNumberLbl);
            this.panel3.Controls.Add(this.SearchEmailLbl);
            this.panel3.Controls.Add(this.SearchFirstNameLbl);
            this.panel3.Controls.Add(this.SearchLastNameLbl);
            this.panel3.Controls.Add(this.SearchIDNumberLbl);
            this.panel3.Controls.Add(this.SearchResultsListBoxLbl);
            this.panel3.Controls.Add(this.SectionListBoxLbl);
            this.panel3.Controls.Add(this.LookUpIDNumberLbl);
            this.panel3.Controls.Add(this.LookUpPhoneNumberLbl);
            this.panel3.Controls.Add(this.LookUpAddressLbl);
            this.panel3.Controls.Add(this.LookUpLastNameLbl);
            this.panel3.Controls.Add(this.LookUpFirstNameLbl);
            this.panel3.Location = new System.Drawing.Point(15, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 358);
            this.panel3.TabIndex = 2;
            // 
            // AddUserBtn
            // 
            this.AddUserBtn.Location = new System.Drawing.Point(559, 202);
            this.AddUserBtn.Name = "AddUserBtn";
            this.AddUserBtn.Size = new System.Drawing.Size(146, 23);
            this.AddUserBtn.TabIndex = 18;
            this.AddUserBtn.Text = "Add User";
            this.AddUserBtn.UseVisualStyleBackColor = true;
            this.AddUserBtn.Click += new System.EventHandler(this.AddUserBtn_Click);
            // 
            // UpdateSectionInfoBtn
            // 
            this.UpdateSectionInfoBtn.Location = new System.Drawing.Point(559, 173);
            this.UpdateSectionInfoBtn.Name = "UpdateSectionInfoBtn";
            this.UpdateSectionInfoBtn.Size = new System.Drawing.Size(146, 23);
            this.UpdateSectionInfoBtn.TabIndex = 18;
            this.UpdateSectionInfoBtn.Text = "Update Section Info";
            this.UpdateSectionInfoBtn.UseVisualStyleBackColor = true;
            this.UpdateSectionInfoBtn.Click += new System.EventHandler(this.UpdateSectionInfoBtn_Click);
            // 
            // UpdatePersonalInfoBtn
            // 
            this.UpdatePersonalInfoBtn.Location = new System.Drawing.Point(559, 144);
            this.UpdatePersonalInfoBtn.Name = "UpdatePersonalInfoBtn";
            this.UpdatePersonalInfoBtn.Size = new System.Drawing.Size(146, 23);
            this.UpdatePersonalInfoBtn.TabIndex = 18;
            this.UpdatePersonalInfoBtn.Text = "Update Personal Info";
            this.UpdatePersonalInfoBtn.UseVisualStyleBackColor = true;
            this.UpdatePersonalInfoBtn.Click += new System.EventHandler(this.UpdatePersonalInfoBtn_Click);
            // 
            // SectionLookupListBox
            // 
            this.SectionLookupListBox.FormattingEnabled = true;
            this.SectionLookupListBox.Location = new System.Drawing.Point(282, 144);
            this.SectionLookupListBox.Name = "SectionLookupListBox";
            this.SectionLookupListBox.Size = new System.Drawing.Size(248, 199);
            this.SectionLookupListBox.TabIndex = 17;
            // 
            // PersonLookupListBox
            // 
            this.PersonLookupListBox.FormattingEnabled = true;
            this.PersonLookupListBox.Location = new System.Drawing.Point(21, 144);
            this.PersonLookupListBox.Name = "PersonLookupListBox";
            this.PersonLookupListBox.Size = new System.Drawing.Size(248, 199);
            this.PersonLookupListBox.TabIndex = 17;
            this.PersonLookupListBox.SelectedIndexChanged += new System.EventHandler(this.PersonListBox_SelectedIndexChanged);
            // 
            // SearchAddressLbl
            // 
            this.SearchAddressLbl.AutoSize = true;
            this.SearchAddressLbl.Location = new System.Drawing.Point(556, 56);
            this.SearchAddressLbl.Name = "SearchAddressLbl";
            this.SearchAddressLbl.Size = new System.Drawing.Size(45, 13);
            this.SearchAddressLbl.TabIndex = 16;
            this.SearchAddressLbl.Text = "Address";
            // 
            // LookUpEmail
            // 
            this.LookUpEmail.AutoSize = true;
            this.LookUpEmail.Location = new System.Drawing.Point(452, 82);
            this.LookUpEmail.Name = "LookUpEmail";
            this.LookUpEmail.Size = new System.Drawing.Size(38, 13);
            this.LookUpEmail.TabIndex = 15;
            this.LookUpEmail.Text = "Email: ";
            // 
            // SearchPhoneNumberLbl
            // 
            this.SearchPhoneNumberLbl.AutoSize = true;
            this.SearchPhoneNumberLbl.Location = new System.Drawing.Point(557, 69);
            this.SearchPhoneNumberLbl.Name = "SearchPhoneNumberLbl";
            this.SearchPhoneNumberLbl.Size = new System.Drawing.Size(78, 13);
            this.SearchPhoneNumberLbl.TabIndex = 14;
            this.SearchPhoneNumberLbl.Text = "Phone Number";
            // 
            // SearchEmailLbl
            // 
            this.SearchEmailLbl.AutoSize = true;
            this.SearchEmailLbl.Location = new System.Drawing.Point(557, 82);
            this.SearchEmailLbl.Name = "SearchEmailLbl";
            this.SearchEmailLbl.Size = new System.Drawing.Size(32, 13);
            this.SearchEmailLbl.TabIndex = 13;
            this.SearchEmailLbl.Text = "Email";
            // 
            // SearchFirstNameLbl
            // 
            this.SearchFirstNameLbl.AutoSize = true;
            this.SearchFirstNameLbl.Location = new System.Drawing.Point(557, 16);
            this.SearchFirstNameLbl.Name = "SearchFirstNameLbl";
            this.SearchFirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.SearchFirstNameLbl.TabIndex = 11;
            this.SearchFirstNameLbl.Text = "First Name";
            // 
            // SearchLastNameLbl
            // 
            this.SearchLastNameLbl.AutoSize = true;
            this.SearchLastNameLbl.Location = new System.Drawing.Point(557, 29);
            this.SearchLastNameLbl.Name = "SearchLastNameLbl";
            this.SearchLastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.SearchLastNameLbl.TabIndex = 10;
            this.SearchLastNameLbl.Text = "Last Name";
            // 
            // SearchIDNumberLbl
            // 
            this.SearchIDNumberLbl.AutoSize = true;
            this.SearchIDNumberLbl.Location = new System.Drawing.Point(556, 43);
            this.SearchIDNumberLbl.Name = "SearchIDNumberLbl";
            this.SearchIDNumberLbl.Size = new System.Drawing.Size(58, 13);
            this.SearchIDNumberLbl.TabIndex = 9;
            this.SearchIDNumberLbl.Text = "ID Number";
            // 
            // SearchResultsListBoxLbl
            // 
            this.SearchResultsListBoxLbl.AutoSize = true;
            this.SearchResultsListBoxLbl.Location = new System.Drawing.Point(18, 128);
            this.SearchResultsListBoxLbl.Name = "SearchResultsListBoxLbl";
            this.SearchResultsListBoxLbl.Size = new System.Drawing.Size(79, 13);
            this.SearchResultsListBoxLbl.TabIndex = 7;
            this.SearchResultsListBoxLbl.Text = "Search Results";
            // 
            // SectionListBoxLbl
            // 
            this.SectionListBoxLbl.AutoSize = true;
            this.SectionListBoxLbl.Location = new System.Drawing.Point(279, 128);
            this.SectionListBoxLbl.Name = "SectionListBoxLbl";
            this.SectionListBoxLbl.Size = new System.Drawing.Size(89, 13);
            this.SectionListBoxLbl.TabIndex = 7;
            this.SectionListBoxLbl.Text = "Enrolled Sections";
            // 
            // LookUpIDNumberLbl
            // 
            this.LookUpIDNumberLbl.AutoSize = true;
            this.LookUpIDNumberLbl.Location = new System.Drawing.Point(452, 43);
            this.LookUpIDNumberLbl.Name = "LookUpIDNumberLbl";
            this.LookUpIDNumberLbl.Size = new System.Drawing.Size(61, 13);
            this.LookUpIDNumberLbl.TabIndex = 5;
            this.LookUpIDNumberLbl.Text = "ID Number:";
            // 
            // LookUpPhoneNumberLbl
            // 
            this.LookUpPhoneNumberLbl.AutoSize = true;
            this.LookUpPhoneNumberLbl.Location = new System.Drawing.Point(452, 69);
            this.LookUpPhoneNumberLbl.Name = "LookUpPhoneNumberLbl";
            this.LookUpPhoneNumberLbl.Size = new System.Drawing.Size(81, 13);
            this.LookUpPhoneNumberLbl.TabIndex = 4;
            this.LookUpPhoneNumberLbl.Text = "Phone Number:";
            // 
            // LookUpAddressLbl
            // 
            this.LookUpAddressLbl.AutoSize = true;
            this.LookUpAddressLbl.Location = new System.Drawing.Point(452, 56);
            this.LookUpAddressLbl.Name = "LookUpAddressLbl";
            this.LookUpAddressLbl.Size = new System.Drawing.Size(51, 13);
            this.LookUpAddressLbl.TabIndex = 3;
            this.LookUpAddressLbl.Text = "Address: ";
            // 
            // LookUpLastNameLbl
            // 
            this.LookUpLastNameLbl.AutoSize = true;
            this.LookUpLastNameLbl.Location = new System.Drawing.Point(452, 30);
            this.LookUpLastNameLbl.Name = "LookUpLastNameLbl";
            this.LookUpLastNameLbl.Size = new System.Drawing.Size(61, 13);
            this.LookUpLastNameLbl.TabIndex = 2;
            this.LookUpLastNameLbl.Text = "Last Name:";
            // 
            // LookUpFirstNameLbl
            // 
            this.LookUpFirstNameLbl.AutoSize = true;
            this.LookUpFirstNameLbl.Location = new System.Drawing.Point(453, 16);
            this.LookUpFirstNameLbl.Name = "LookUpFirstNameLbl";
            this.LookUpFirstNameLbl.Size = new System.Drawing.Size(60, 13);
            this.LookUpFirstNameLbl.TabIndex = 0;
            this.LookUpFirstNameLbl.Text = "First Name:";
            // 
            // UserSearchBtn
            // 
            this.UserSearchBtn.Location = new System.Drawing.Point(212, 23);
            this.UserSearchBtn.Name = "UserSearchBtn";
            this.UserSearchBtn.Size = new System.Drawing.Size(72, 20);
            this.UserSearchBtn.TabIndex = 1;
            this.UserSearchBtn.Text = "Search";
            this.UserSearchBtn.UseVisualStyleBackColor = true;
            this.UserSearchBtn.Click += new System.EventHandler(this.UserSearchBtn_Click);
            // 
            // UserSearchBox
            // 
            this.UserSearchBox.Location = new System.Drawing.Point(15, 23);
            this.UserSearchBox.Name = "UserSearchBox";
            this.UserSearchBox.Size = new System.Drawing.Size(170, 20);
            this.UserSearchBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteBtn);
            this.tabPage1.Controls.Add(this.CourseListBox);
            this.tabPage1.Controls.Add(this.DateLbl);
            this.tabPage1.Controls.Add(this.ProfessorNameLbl);
            this.tabPage1.Controls.Add(this.DayLbl);
            this.tabPage1.Controls.Add(this.TimeLbl);
            this.tabPage1.Controls.Add(this.SectionNameLbl);
            this.tabPage1.Controls.Add(this.CourseNameLbl);
            this.tabPage1.Controls.Add(this.CourseSearchBtn);
            this.tabPage1.Controls.Add(this.CourseSearchBox);
            this.tabPage1.Controls.Add(this.searchCourseLbl);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Courses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(583, 234);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CourseListBox
            // 
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.Location = new System.Drawing.Point(21, 126);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(509, 277);
            this.CourseListBox.TabIndex = 9;
            this.CourseListBox.SelectedIndexChanged += new System.EventHandler(this.CourseListBox_SelectedIndexChanged);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(563, 94);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(109, 13);
            this.DateLbl.TabIndex = 8;
            this.DateLbl.Text = "Start Date - End Date";
            // 
            // ProfessorNameLbl
            // 
            this.ProfessorNameLbl.AutoSize = true;
            this.ProfessorNameLbl.Location = new System.Drawing.Point(564, 55);
            this.ProfessorNameLbl.Name = "ProfessorNameLbl";
            this.ProfessorNameLbl.Size = new System.Drawing.Size(51, 13);
            this.ProfessorNameLbl.TabIndex = 7;
            this.ProfessorNameLbl.Text = "Professor";
            // 
            // DayLbl
            // 
            this.DayLbl.AutoSize = true;
            this.DayLbl.Location = new System.Drawing.Point(564, 81);
            this.DayLbl.Name = "DayLbl";
            this.DayLbl.Size = new System.Drawing.Size(108, 13);
            this.DayLbl.TabIndex = 6;
            this.DayLbl.Text = "Monday, Wednesday";
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Location = new System.Drawing.Point(564, 68);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(109, 13);
            this.TimeLbl.TabIndex = 5;
            this.TimeLbl.Text = "Start Time - End Time";
            // 
            // SectionNameLbl
            // 
            this.SectionNameLbl.AutoSize = true;
            this.SectionNameLbl.Location = new System.Drawing.Point(564, 42);
            this.SectionNameLbl.Name = "SectionNameLbl";
            this.SectionNameLbl.Size = new System.Drawing.Size(43, 13);
            this.SectionNameLbl.TabIndex = 4;
            this.SectionNameLbl.Text = "Section";
            // 
            // CourseNameLbl
            // 
            this.CourseNameLbl.AutoSize = true;
            this.CourseNameLbl.Location = new System.Drawing.Point(564, 29);
            this.CourseNameLbl.Name = "CourseNameLbl";
            this.CourseNameLbl.Size = new System.Drawing.Size(40, 13);
            this.CourseNameLbl.TabIndex = 3;
            this.CourseNameLbl.Text = "Course";
            // 
            // CourseSearchBtn
            // 
            this.CourseSearchBtn.Location = new System.Drawing.Point(394, 67);
            this.CourseSearchBtn.Name = "CourseSearchBtn";
            this.CourseSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.CourseSearchBtn.TabIndex = 2;
            this.CourseSearchBtn.Text = "Search";
            this.CourseSearchBtn.UseVisualStyleBackColor = true;
            this.CourseSearchBtn.Click += new System.EventHandler(this.CourseSearchBtn_Click);
            // 
            // CourseSearchBox
            // 
            this.CourseSearchBox.Location = new System.Drawing.Point(20, 69);
            this.CourseSearchBox.Name = "CourseSearchBox";
            this.CourseSearchBox.Size = new System.Drawing.Size(352, 20);
            this.CourseSearchBox.TabIndex = 1;
            // 
            // searchCourseLbl
            // 
            this.searchCourseLbl.AutoSize = true;
            this.searchCourseLbl.Location = new System.Drawing.Point(18, 53);
            this.searchCourseLbl.Name = "searchCourseLbl";
            this.searchCourseLbl.Size = new System.Drawing.Size(97, 13);
            this.searchCourseLbl.TabIndex = 0;
            this.searchCourseLbl.Text = "Search for Courses";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.personalInfoPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 59);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 429);
            this.tabControl1.TabIndex = 17;
            // 
            // RegistrarTitle
            // 
            this.RegistrarTitle.AutoSize = true;
            this.RegistrarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrarTitle.Location = new System.Drawing.Point(187, 6);
            this.RegistrarTitle.Name = "RegistrarTitle";
            this.RegistrarTitle.Size = new System.Drawing.Size(351, 54);
            this.RegistrarTitle.TabIndex = 25;
            this.RegistrarTitle.Text = "Registrar Name";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 533);
            this.ControlBox = false;
            this.Controls.Add(this.RegistrarTitle);
            this.Controls.Add(this.UserViewComboBox);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.tabControl1);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.personalInfoPage.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.ComboBox UserViewComboBox;
        private System.Windows.Forms.TabPage personalInfoPage;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button UpdateSectionInfoBtn;
        private System.Windows.Forms.Button UpdatePersonalInfoBtn;
        private System.Windows.Forms.ListBox SectionLookupListBox;
        private System.Windows.Forms.ListBox PersonLookupListBox;
        private System.Windows.Forms.Label SearchAddressLbl;
        private System.Windows.Forms.Label LookUpEmail;
        private System.Windows.Forms.Label SearchPhoneNumberLbl;
        private System.Windows.Forms.Label SearchEmailLbl;
        private System.Windows.Forms.Label SearchFirstNameLbl;
        private System.Windows.Forms.Label SearchLastNameLbl;
        private System.Windows.Forms.Label SearchIDNumberLbl;
        private System.Windows.Forms.Label SearchResultsListBoxLbl;
        private System.Windows.Forms.Label SectionListBoxLbl;
        private System.Windows.Forms.Label LookUpIDNumberLbl;
        private System.Windows.Forms.Label LookUpPhoneNumberLbl;
        private System.Windows.Forms.Label LookUpAddressLbl;
        private System.Windows.Forms.Label LookUpLastNameLbl;
        private System.Windows.Forms.Label LookUpFirstNameLbl;
        private System.Windows.Forms.Button UserSearchBtn;
        private System.Windows.Forms.TextBox UserSearchBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.ListBox CourseListBox;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label ProfessorNameLbl;
        private System.Windows.Forms.Label DayLbl;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label SectionNameLbl;
        private System.Windows.Forms.Label CourseNameLbl;
        private System.Windows.Forms.Button CourseSearchBtn;
        private System.Windows.Forms.TextBox CourseSearchBox;
        private System.Windows.Forms.Label searchCourseLbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button AddUserBtn;
        private System.Windows.Forms.Label RegistrarTitle;
    }
}