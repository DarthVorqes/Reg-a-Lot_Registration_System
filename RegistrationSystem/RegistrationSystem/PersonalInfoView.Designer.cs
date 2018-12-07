namespace RegistrationSystem
{
    partial class PersonalInfoView
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
            this.UpdateGradeButton = new System.Windows.Forms.Button();
            this.PVStudentNameLabel = new System.Windows.Forms.Label();
            this.PVFirstNameLabel = new System.Windows.Forms.Label();
            this.PVSectionLabel = new System.Windows.Forms.Label();
            this.PVIDNumberLabel = new System.Windows.Forms.Label();
            this.PVLastNameLabel = new System.Windows.Forms.Label();
            this.PVAddressLabel = new System.Windows.Forms.Label();
            this.PVPhoneLabel = new System.Windows.Forms.Label();
            this.PVEmailLabel = new System.Windows.Forms.Label();
            this.GradeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UpdateGradeButton
            // 
            this.UpdateGradeButton.Location = new System.Drawing.Point(471, 26);
            this.UpdateGradeButton.Name = "UpdateGradeButton";
            this.UpdateGradeButton.Size = new System.Drawing.Size(105, 23);
            this.UpdateGradeButton.TabIndex = 1;
            this.UpdateGradeButton.Text = "Update Grade";
            this.UpdateGradeButton.UseVisualStyleBackColor = true;
            this.UpdateGradeButton.Click += new System.EventHandler(this.UpdateGradeButton_Click);
            // 
            // PVStudentNameLabel
            // 
            this.PVStudentNameLabel.AutoSize = true;
            this.PVStudentNameLabel.Location = new System.Drawing.Point(50, 9);
            this.PVStudentNameLabel.Name = "PVStudentNameLabel";
            this.PVStudentNameLabel.Size = new System.Drawing.Size(75, 13);
            this.PVStudentNameLabel.TabIndex = 2;
            this.PVStudentNameLabel.Text = "Student Name";
            // 
            // PVFirstNameLabel
            // 
            this.PVFirstNameLabel.AutoSize = true;
            this.PVFirstNameLabel.Location = new System.Drawing.Point(72, 101);
            this.PVFirstNameLabel.Name = "PVFirstNameLabel";
            this.PVFirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.PVFirstNameLabel.TabIndex = 2;
            this.PVFirstNameLabel.Text = "First Name";
            // 
            // PVSectionLabel
            // 
            this.PVSectionLabel.AutoSize = true;
            this.PVSectionLabel.Location = new System.Drawing.Point(72, 35);
            this.PVSectionLabel.Name = "PVSectionLabel";
            this.PVSectionLabel.Size = new System.Drawing.Size(74, 13);
            this.PVSectionLabel.TabIndex = 2;
            this.PVSectionLabel.Text = "Section Name";
            // 
            // PVIDNumberLabel
            // 
            this.PVIDNumberLabel.AutoSize = true;
            this.PVIDNumberLabel.Location = new System.Drawing.Point(72, 142);
            this.PVIDNumberLabel.Name = "PVIDNumberLabel";
            this.PVIDNumberLabel.Size = new System.Drawing.Size(58, 13);
            this.PVIDNumberLabel.TabIndex = 2;
            this.PVIDNumberLabel.Text = "ID Number";
            // 
            // PVLastNameLabel
            // 
            this.PVLastNameLabel.AutoSize = true;
            this.PVLastNameLabel.Location = new System.Drawing.Point(229, 101);
            this.PVLastNameLabel.Name = "PVLastNameLabel";
            this.PVLastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.PVLastNameLabel.TabIndex = 2;
            this.PVLastNameLabel.Text = "Last Name";
            // 
            // PVAddressLabel
            // 
            this.PVAddressLabel.AutoSize = true;
            this.PVAddressLabel.Location = new System.Drawing.Point(72, 181);
            this.PVAddressLabel.Name = "PVAddressLabel";
            this.PVAddressLabel.Size = new System.Drawing.Size(45, 13);
            this.PVAddressLabel.TabIndex = 2;
            this.PVAddressLabel.Text = "Address";
            // 
            // PVPhoneLabel
            // 
            this.PVPhoneLabel.AutoSize = true;
            this.PVPhoneLabel.Location = new System.Drawing.Point(72, 219);
            this.PVPhoneLabel.Name = "PVPhoneLabel";
            this.PVPhoneLabel.Size = new System.Drawing.Size(38, 13);
            this.PVPhoneLabel.TabIndex = 2;
            this.PVPhoneLabel.Text = "Phone";
            // 
            // PVEmailLabel
            // 
            this.PVEmailLabel.AutoSize = true;
            this.PVEmailLabel.Location = new System.Drawing.Point(72, 262);
            this.PVEmailLabel.Name = "PVEmailLabel";
            this.PVEmailLabel.Size = new System.Drawing.Size(32, 13);
            this.PVEmailLabel.TabIndex = 2;
            this.PVEmailLabel.Text = "Email";
            // 
            // GradeComboBox
            // 
            this.GradeComboBox.FormattingEnabled = true;
            this.GradeComboBox.Location = new System.Drawing.Point(422, 26);
            this.GradeComboBox.Name = "GradeComboBox";
            this.GradeComboBox.Size = new System.Drawing.Size(43, 21);
            this.GradeComboBox.TabIndex = 3;
            // 
            // PersonalInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 353);
            this.Controls.Add(this.GradeComboBox);
            this.Controls.Add(this.PVSectionLabel);
            this.Controls.Add(this.PVLastNameLabel);
            this.Controls.Add(this.PVEmailLabel);
            this.Controls.Add(this.PVPhoneLabel);
            this.Controls.Add(this.PVAddressLabel);
            this.Controls.Add(this.PVIDNumberLabel);
            this.Controls.Add(this.PVFirstNameLabel);
            this.Controls.Add(this.PVStudentNameLabel);
            this.Controls.Add(this.UpdateGradeButton);
            this.Name = "PersonalInfoView";
            this.Text = "PersonalInfoView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UpdateGradeButton;
        private System.Windows.Forms.Label PVStudentNameLabel;
        private System.Windows.Forms.Label PVFirstNameLabel;
        private System.Windows.Forms.Label PVSectionLabel;
        private System.Windows.Forms.Label PVIDNumberLabel;
        private System.Windows.Forms.Label PVLastNameLabel;
        private System.Windows.Forms.Label PVAddressLabel;
        private System.Windows.Forms.Label PVPhoneLabel;
        private System.Windows.Forms.Label PVEmailLabel;
        private System.Windows.Forms.ComboBox GradeComboBox;
    }
}