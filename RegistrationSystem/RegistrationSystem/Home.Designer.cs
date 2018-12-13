using System;

namespace RegistrationSystem
{
    partial class Home
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
            this.scheduleTab = new System.Windows.Forms.TabPage();
            this.scheduleSemesterComboBox = new System.Windows.Forms.ComboBox();
            this.scheduleYearComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scheduleDataGrid = new System.Windows.Forms.DataGridView();
            this.scheduleColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleColumnLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleColumnEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleColumnDaysOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scheduleColumnInstructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.registrationDepartmentCombobox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.courseManagerTab = new System.Windows.Forms.TabPage();
            this.sectionManagerTab = new System.Windows.Forms.TabPage();
            this.personnelManagerTab = new System.Windows.Forms.TabPage();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.loginBtnSubmit = new System.Windows.Forms.Button();
            this.loginUserIdTxtBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.activeAs = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.addSection = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.scheduleTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).BeginInit();
            this.registrationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.loginTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.scheduleTab);
            this.tabControl1.Controls.Add(this.registrationTab);
            this.tabControl1.Controls.Add(this.profileTab);
            this.tabControl1.Controls.Add(this.courseManagerTab);
            this.tabControl1.Controls.Add(this.sectionManagerTab);
            this.tabControl1.Controls.Add(this.personnelManagerTab);
            this.tabControl1.Controls.Add(this.loginTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // scheduleTab
            // 
            this.scheduleTab.Controls.Add(this.scheduleSemesterComboBox);
            this.scheduleTab.Controls.Add(this.scheduleYearComboBox);
            this.scheduleTab.Controls.Add(this.label2);
            this.scheduleTab.Controls.Add(this.label1);
            this.scheduleTab.Controls.Add(this.scheduleDataGrid);
            this.scheduleTab.Location = new System.Drawing.Point(42, 4);
            this.scheduleTab.Name = "scheduleTab";
            this.scheduleTab.Size = new System.Drawing.Size(794, 392);
            this.scheduleTab.TabIndex = 0;
            this.scheduleTab.Text = "Schedule";
            this.scheduleTab.UseVisualStyleBackColor = true;
            // 
            // scheduleSemesterComboBox
            // 
            this.scheduleSemesterComboBox.FormattingEnabled = true;
            this.scheduleSemesterComboBox.Location = new System.Drawing.Point(20, 78);
            this.scheduleSemesterComboBox.Name = "scheduleSemesterComboBox";
            this.scheduleSemesterComboBox.Size = new System.Drawing.Size(121, 21);
            this.scheduleSemesterComboBox.TabIndex = 6;
            this.scheduleSemesterComboBox.Text = "All";
            // 
            // scheduleYearComboBox
            // 
            this.scheduleYearComboBox.FormattingEnabled = true;
            this.scheduleYearComboBox.Location = new System.Drawing.Point(20, 38);
            this.scheduleYearComboBox.Name = "scheduleYearComboBox";
            this.scheduleYearComboBox.Size = new System.Drawing.Size(121, 21);
            this.scheduleYearComboBox.TabIndex = 5;
            this.scheduleYearComboBox.Text = "All";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Semester";
            // 
            // scheduleDataGrid
            // 
            this.scheduleDataGrid.AccessibleName = "scheduleDataGrid";
            this.scheduleDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scheduleColumnName,
            this.scheduleColumnLocation,
            this.scheduleStartTime,
            this.scheduleColumnEndTime,
            this.scheduleColumnDaysOfWeek,
            this.scheduleColumnInstructor});
            this.scheduleDataGrid.Location = new System.Drawing.Point(147, 3);
            this.scheduleDataGrid.Name = "scheduleDataGrid";
            this.scheduleDataGrid.ShowCellToolTips = false;
            this.scheduleDataGrid.ShowEditingIcon = false;
            this.scheduleDataGrid.Size = new System.Drawing.Size(644, 386);
            this.scheduleDataGrid.TabIndex = 0;
            this.scheduleDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.scheduleDataGrid_CellContentClick);
            // 
            // scheduleColumnName
            // 
            this.scheduleColumnName.HeaderText = "Section Name";
            this.scheduleColumnName.Name = "scheduleColumnName";
            this.scheduleColumnName.ReadOnly = true;
            // 
            // scheduleColumnLocation
            // 
            this.scheduleColumnLocation.HeaderText = "Location";
            this.scheduleColumnLocation.Name = "scheduleColumnLocation";
            this.scheduleColumnLocation.ReadOnly = true;
            // 
            // scheduleStartTime
            // 
            this.scheduleStartTime.HeaderText = "Start Time";
            this.scheduleStartTime.Name = "scheduleStartTime";
            this.scheduleStartTime.ReadOnly = true;
            // 
            // scheduleColumnEndTime
            // 
            this.scheduleColumnEndTime.HeaderText = "End Time";
            this.scheduleColumnEndTime.Name = "scheduleColumnEndTime";
            this.scheduleColumnEndTime.ReadOnly = true;
            // 
            // scheduleColumnDaysOfWeek
            // 
            this.scheduleColumnDaysOfWeek.HeaderText = "Days Of The Week";
            this.scheduleColumnDaysOfWeek.Name = "scheduleColumnDaysOfWeek";
            this.scheduleColumnDaysOfWeek.ReadOnly = true;
            // 
            // scheduleColumnInstructor
            // 
            this.scheduleColumnInstructor.HeaderText = "Instructor";
            this.scheduleColumnInstructor.Name = "scheduleColumnInstructor";
            this.scheduleColumnInstructor.ReadOnly = true;
            // 
            // registrationTab
            // 
            this.registrationTab.Controls.Add(this.button2);
            this.registrationTab.Controls.Add(this.textBox1);
            this.registrationTab.Controls.Add(this.comboBox3);
            this.registrationTab.Controls.Add(this.comboBox2);
            this.registrationTab.Controls.Add(this.registrationDepartmentCombobox);
            this.registrationTab.Controls.Add(this.label3);
            this.registrationTab.Controls.Add(this.label4);
            this.registrationTab.Controls.Add(this.label5);
            this.registrationTab.Controls.Add(this.label6);
            this.registrationTab.Controls.Add(this.label7);
            this.registrationTab.Controls.Add(this.dataGridView1);
            this.registrationTab.Location = new System.Drawing.Point(42, 4);
            this.registrationTab.Name = "registrationTab";
            this.registrationTab.Size = new System.Drawing.Size(794, 392);
            this.registrationTab.TabIndex = 0;
            this.registrationTab.Text = "Registration";
            this.registrationTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 11;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(16, 31);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 9;
            this.comboBox3.Text = "All Classes";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(17, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // registrationDepartmentCombobox
            // 
            this.registrationDepartmentCombobox.FormattingEnabled = true;
            this.registrationDepartmentCombobox.Location = new System.Drawing.Point(17, 132);
            this.registrationDepartmentCombobox.Name = "registrationDepartmentCombobox";
            this.registrationDepartmentCombobox.Size = new System.Drawing.Size(121, 21);
            this.registrationDepartmentCombobox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Semester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Filters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Currently Viewing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Year";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Value,
            this.Column1,
            this.Column2,
            this.CourseGrade,
            this.addSection});
            this.dataGridView1.Location = new System.Drawing.Point(143, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.HeaderText = "Course Name";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.HeaderText = "Course #";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Section Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Course Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // CourseGrade
            // 
            this.CourseGrade.HeaderText = "Grade";
            this.CourseGrade.Name = "CourseGrade";
            this.CourseGrade.ReadOnly = true;
            // 
            // profileTab
            // 
            this.profileTab.Location = new System.Drawing.Point(42, 4);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(794, 392);
            this.profileTab.TabIndex = 1;
            this.profileTab.Text = "Profile";
            this.profileTab.UseVisualStyleBackColor = true;
            // 
            // courseManagerTab
            // 
            this.courseManagerTab.Location = new System.Drawing.Point(42, 4);
            this.courseManagerTab.Name = "courseManagerTab";
            this.courseManagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.courseManagerTab.Size = new System.Drawing.Size(794, 392);
            this.courseManagerTab.TabIndex = 2;
            this.courseManagerTab.Text = "Course Manager";
            this.courseManagerTab.UseVisualStyleBackColor = true;
            // 
            // sectionManagerTab
            // 
            this.sectionManagerTab.Location = new System.Drawing.Point(42, 4);
            this.sectionManagerTab.Name = "sectionManagerTab";
            this.sectionManagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.sectionManagerTab.Size = new System.Drawing.Size(794, 392);
            this.sectionManagerTab.TabIndex = 3;
            this.sectionManagerTab.Text = "Section Manager";
            this.sectionManagerTab.UseVisualStyleBackColor = true;
            // 
            // personnelManagerTab
            // 
            this.personnelManagerTab.Location = new System.Drawing.Point(42, 4);
            this.personnelManagerTab.Name = "personnelManagerTab";
            this.personnelManagerTab.Padding = new System.Windows.Forms.Padding(3);
            this.personnelManagerTab.Size = new System.Drawing.Size(794, 392);
            this.personnelManagerTab.TabIndex = 4;
            this.personnelManagerTab.Text = "Personnel Manager";
            this.personnelManagerTab.UseVisualStyleBackColor = true;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.loginBtnSubmit);
            this.loginTab.Controls.Add(this.loginUserIdTxtBox);
            this.loginTab.Controls.Add(this.loginPasswordTxtBox);
            this.loginTab.Location = new System.Drawing.Point(42, 4);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(794, 392);
            this.loginTab.TabIndex = 5;
            this.loginTab.Text = "Login";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // loginBtnSubmit
            // 
            this.loginBtnSubmit.Location = new System.Drawing.Point(6, 58);
            this.loginBtnSubmit.Name = "loginBtnSubmit";
            this.loginBtnSubmit.Size = new System.Drawing.Size(181, 23);
            this.loginBtnSubmit.TabIndex = 2;
            this.loginBtnSubmit.Text = "Submit";
            this.loginBtnSubmit.UseVisualStyleBackColor = true;
            // 
            // loginUserIdTxtBox
            // 
            this.loginUserIdTxtBox.Location = new System.Drawing.Point(6, 6);
            this.loginUserIdTxtBox.Name = "loginUserIdTxtBox";
            this.loginUserIdTxtBox.Size = new System.Drawing.Size(181, 20);
            this.loginUserIdTxtBox.TabIndex = 1;
            this.loginUserIdTxtBox.Text = "User ID";
            this.loginUserIdTxtBox.TextChanged += new System.EventHandler(this.usernameTxtBox);
            // 
            // loginPasswordTxtBox
            // 
            this.loginPasswordTxtBox.Location = new System.Drawing.Point(6, 32);
            this.loginPasswordTxtBox.Name = "loginPasswordTxtBox";
            this.loginPasswordTxtBox.Size = new System.Drawing.Size(181, 20);
            this.loginPasswordTxtBox.TabIndex = 0;
            this.loginPasswordTxtBox.Text = "Password";
            this.loginPasswordTxtBox.TextChanged += new System.EventHandler(this.passwordTxtBox);
            // 
            // activeAs
            // 
            this.activeAs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.activeAs.FormattingEnabled = true;
            this.activeAs.Location = new System.Drawing.Point(54, 11);
            this.activeAs.Name = "activeAs";
            this.activeAs.Size = new System.Drawing.Size(121, 21);
            this.activeAs.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Submit Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addSection
            // 
            this.addSection.HeaderText = "AddSection";
            this.addSection.Name = "addSection";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 450);
            this.Controls.Add(this.activeAs);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Text = "Home";
            this.tabControl1.ResumeLayout(false);
            this.scheduleTab.ResumeLayout(false);
            this.scheduleTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGrid)).EndInit();
            this.registrationTab.ResumeLayout(false);
            this.registrationTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage scheduleTab;
        private System.Windows.Forms.TabPage registrationTab;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.ComboBox activeAs;
        private System.Windows.Forms.TabPage courseManagerTab;
        private System.Windows.Forms.TabPage sectionManagerTab;
        private System.Windows.Forms.TabPage personnelManagerTab;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TextBox loginUserIdTxtBox;
        private System.Windows.Forms.TextBox loginPasswordTxtBox;
        private System.Windows.Forms.Button loginBtnSubmit;
        private System.Windows.Forms.DataGridView scheduleDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleColumnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleColumnEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleColumnDaysOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn scheduleColumnInstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox scheduleSemesterComboBox;
        private System.Windows.Forms.ComboBox scheduleYearComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseGrade;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox registrationDepartmentCombobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewButtonColumn addSection;
    }
}