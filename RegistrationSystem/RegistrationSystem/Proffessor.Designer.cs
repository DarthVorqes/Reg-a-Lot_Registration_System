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
            this.ScheduleList = new System.Windows.Forms.ListBox();
            this.ScheduleComboBox = new System.Windows.Forms.ComboBox();
            this.ScheduleCalander = new System.Windows.Forms.MonthCalendar();
            this.ProfessorAddDropTab = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AddDropCoursesSearchBox = new System.Windows.Forms.TextBox();
            this.DropButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.AddDropFilterButton = new System.Windows.Forms.Button();
            this.AddDropCoursesComboBox = new System.Windows.Forms.ComboBox();
            this.ProfessorPersonalInfoTab = new System.Windows.Forms.TabPage();
            this.UpdatePersonalInfoButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.IDNumberLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PersonalInforDescriptionLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ProfessorTitle = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
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
            this.ProfessorTabControl.Location = new System.Drawing.Point(12, 59);
            this.ProfessorTabControl.Multiline = true;
            this.ProfessorTabControl.Name = "ProfessorTabControl";
            this.ProfessorTabControl.SelectedIndex = 0;
            this.ProfessorTabControl.Size = new System.Drawing.Size(758, 465);
            this.ProfessorTabControl.TabIndex = 0;
            // 
            // ProfessorScheduleTab
            // 
            this.ProfessorScheduleTab.Controls.Add(this.ScheduleList);
            this.ProfessorScheduleTab.Controls.Add(this.ScheduleComboBox);
            this.ProfessorScheduleTab.Controls.Add(this.ScheduleCalander);
            this.ProfessorScheduleTab.Location = new System.Drawing.Point(23, 4);
            this.ProfessorScheduleTab.Name = "ProfessorScheduleTab";
            this.ProfessorScheduleTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfessorScheduleTab.Size = new System.Drawing.Size(731, 457);
            this.ProfessorScheduleTab.TabIndex = 0;
            this.ProfessorScheduleTab.Text = "Schedule";
            this.ProfessorScheduleTab.UseVisualStyleBackColor = true;
            // 
            // ScheduleList
            // 
            this.ScheduleList.FormattingEnabled = true;
            this.ScheduleList.Location = new System.Drawing.Point(27, 210);
            this.ScheduleList.Name = "ScheduleList";
            this.ScheduleList.Size = new System.Drawing.Size(666, 225);
            this.ScheduleList.TabIndex = 2;
            // 
            // ScheduleComboBox
            // 
            this.ScheduleComboBox.FormattingEnabled = true;
            this.ScheduleComboBox.Items.AddRange(new object[] {
            "Sections"});
            this.ScheduleComboBox.Location = new System.Drawing.Point(27, 183);
            this.ScheduleComboBox.Name = "ScheduleComboBox";
            this.ScheduleComboBox.Size = new System.Drawing.Size(347, 21);
            this.ScheduleComboBox.TabIndex = 1;
            // 
            // ScheduleCalander
            // 
            this.ScheduleCalander.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.ScheduleCalander.Location = new System.Drawing.Point(17, 9);
            this.ScheduleCalander.Name = "ScheduleCalander";
            this.ScheduleCalander.TabIndex = 0;
            // 
            // ProfessorAddDropTab
            // 
            this.ProfessorAddDropTab.Controls.Add(this.label11);
            this.ProfessorAddDropTab.Controls.Add(this.label10);
            this.ProfessorAddDropTab.Controls.Add(this.AddDropCoursesSearchBox);
            this.ProfessorAddDropTab.Controls.Add(this.DropButton);
            this.ProfessorAddDropTab.Controls.Add(this.AddButton);
            this.ProfessorAddDropTab.Controls.Add(this.listBox2);
            this.ProfessorAddDropTab.Controls.Add(this.AddDropFilterButton);
            this.ProfessorAddDropTab.Controls.Add(this.AddDropCoursesComboBox);
            this.ProfessorAddDropTab.Location = new System.Drawing.Point(23, 4);
            this.ProfessorAddDropTab.Name = "ProfessorAddDropTab";
            this.ProfessorAddDropTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProfessorAddDropTab.Size = new System.Drawing.Size(731, 457);
            this.ProfessorAddDropTab.TabIndex = 1;
            this.ProfessorAddDropTab.Text = "Add/Drop";
            this.ProfessorAddDropTab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Search for Courses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Courses";
            // 
            // AddDropCoursesSearchBox
            // 
            this.AddDropCoursesSearchBox.Location = new System.Drawing.Point(366, 54);
            this.AddDropCoursesSearchBox.Name = "AddDropCoursesSearchBox";
            this.AddDropCoursesSearchBox.Size = new System.Drawing.Size(278, 20);
            this.AddDropCoursesSearchBox.TabIndex = 6;
            // 
            // DropButton
            // 
            this.DropButton.Location = new System.Drawing.Point(431, 402);
            this.DropButton.Name = "DropButton";
            this.DropButton.Size = new System.Drawing.Size(130, 23);
            this.DropButton.TabIndex = 4;
            this.DropButton.Text = "Drop";
            this.DropButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(169, 402);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(130, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 81);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(719, 303);
            this.listBox2.TabIndex = 3;
            // 
            // AddDropFilterButton
            // 
            this.AddDropFilterButton.Location = new System.Drawing.Point(650, 51);
            this.AddDropFilterButton.Name = "AddDropFilterButton";
            this.AddDropFilterButton.Size = new System.Drawing.Size(75, 23);
            this.AddDropFilterButton.TabIndex = 2;
            this.AddDropFilterButton.Text = "Filter";
            this.AddDropFilterButton.UseVisualStyleBackColor = true;
            // 
            // AddDropCoursesComboBox
            // 
            this.AddDropCoursesComboBox.FormattingEnabled = true;
            this.AddDropCoursesComboBox.Items.AddRange(new object[] {
            "Courses"});
            this.AddDropCoursesComboBox.Location = new System.Drawing.Point(6, 54);
            this.AddDropCoursesComboBox.Name = "AddDropCoursesComboBox";
            this.AddDropCoursesComboBox.Size = new System.Drawing.Size(315, 21);
            this.AddDropCoursesComboBox.TabIndex = 0;
            // 
            // ProfessorPersonalInfoTab
            // 
            this.ProfessorPersonalInfoTab.Controls.Add(this.UpdatePersonalInfoButton);
            this.ProfessorPersonalInfoTab.Controls.Add(this.PasswordLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.PhoneNumberLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.EmailLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.AddressLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.IDNumberLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.LastNameLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.PersonalInforDescriptionLabel);
            this.ProfessorPersonalInfoTab.Controls.Add(this.FirstNameLabel);
            this.ProfessorPersonalInfoTab.Location = new System.Drawing.Point(23, 4);
            this.ProfessorPersonalInfoTab.Name = "ProfessorPersonalInfoTab";
            this.ProfessorPersonalInfoTab.Size = new System.Drawing.Size(731, 457);
            this.ProfessorPersonalInfoTab.TabIndex = 2;
            this.ProfessorPersonalInfoTab.Text = "Personal Info";
            this.ProfessorPersonalInfoTab.UseVisualStyleBackColor = true;
            // 
            // UpdatePersonalInfoButton
            // 
            this.UpdatePersonalInfoButton.Location = new System.Drawing.Point(181, 319);
            this.UpdatePersonalInfoButton.Name = "UpdatePersonalInfoButton";
            this.UpdatePersonalInfoButton.Size = new System.Drawing.Size(75, 23);
            this.UpdatePersonalInfoButton.TabIndex = 8;
            this.UpdatePersonalInfoButton.Text = "Change";
            this.UpdatePersonalInfoButton.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(58, 324);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(99, 13);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password Change?";
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
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(628, 530);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(138, 23);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // ProfessorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 565);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ProfessorTitle);
            this.Controls.Add(this.ProfessorTabControl);
            this.Name = "ProfessorView";
            this.Text = "Professor";
            this.ProfessorTabControl.ResumeLayout(false);
            this.ProfessorScheduleTab.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox ScheduleList;
        private System.Windows.Forms.ComboBox ScheduleComboBox;
        private System.Windows.Forms.MonthCalendar ScheduleCalander;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button AddDropFilterButton;
        private System.Windows.Forms.ComboBox AddDropCoursesComboBox;
        private System.Windows.Forms.TabPage ProfessorPersonalInfoTab;
        private System.Windows.Forms.Button UpdatePersonalInfoButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label IDNumberLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PersonalInforDescriptionLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.TextBox AddDropCoursesSearchBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DropButton;
    }
}