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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.addDrop1 = new System.Windows.Forms.TabPage();
            this.persInfo1 = new System.Windows.Forms.TabPage();
            this.finance1 = new System.Windows.Forms.TabPage();
            this.logOut1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.sched1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.sched1);
            this.tabControl1.Controls.Add(this.addDrop1);
            this.tabControl1.Controls.Add(this.persInfo1);
            this.tabControl1.Controls.Add(this.finance1);
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 572);
            this.tabControl1.TabIndex = 0;
            // 
            // sched1
            // 
            this.sched1.Controls.Add(this.monthCalendar1);
            this.sched1.Location = new System.Drawing.Point(23, 4);
            this.sched1.Name = "sched1";
            this.sched1.Padding = new System.Windows.Forms.Padding(3);
            this.sched1.Size = new System.Drawing.Size(668, 564);
            this.sched1.TabIndex = 0;
            this.sched1.Text = "Schedule";
            this.sched1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 3);
            this.monthCalendar1.Location = new System.Drawing.Point(0, 12);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // addDrop1
            // 
            this.addDrop1.Location = new System.Drawing.Point(23, 4);
            this.addDrop1.Name = "addDrop1";
            this.addDrop1.Padding = new System.Windows.Forms.Padding(3);
            this.addDrop1.Size = new System.Drawing.Size(668, 564);
            this.addDrop1.TabIndex = 1;
            this.addDrop1.Text = "Add/Drop";
            this.addDrop1.UseVisualStyleBackColor = true;
            // 
            // persInfo1
            // 
            this.persInfo1.Location = new System.Drawing.Point(23, 4);
            this.persInfo1.Name = "persInfo1";
            this.persInfo1.Size = new System.Drawing.Size(668, 564);
            this.persInfo1.TabIndex = 2;
            this.persInfo1.Text = "Information";
            this.persInfo1.UseVisualStyleBackColor = true;
            // 
            // finance1
            // 
            this.finance1.Location = new System.Drawing.Point(23, 4);
            this.finance1.Name = "finance1";
            this.finance1.Size = new System.Drawing.Size(668, 564);
            this.finance1.TabIndex = 3;
            this.finance1.Text = "Finances";
            this.finance1.UseVisualStyleBackColor = true;
            // 
            // logOut1
            // 
            this.logOut1.Location = new System.Drawing.Point(618, 579);
            this.logOut1.Name = "logOut1";
            this.logOut1.Size = new System.Drawing.Size(75, 23);
            this.logOut1.TabIndex = 1;
            this.logOut1.Text = "Logout";
            this.logOut1.UseVisualStyleBackColor = true;
            this.logOut1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 607);
            this.ControlBox = false;
            this.Controls.Add(this.logOut1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Student View";
            this.tabControl1.ResumeLayout(false);
            this.sched1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage sched1;
        private System.Windows.Forms.TabPage addDrop1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TabPage persInfo1;
        private System.Windows.Forms.Button logOut1;
        private System.Windows.Forms.TabPage finance1;
    }
}