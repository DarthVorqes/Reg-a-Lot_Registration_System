using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    public partial class PersonalInfoView : Form
    {
        public PersonalInfoView(int ID)
        {
            InitializeComponent();
            SetLabels(ID);
        }

        private void SetLabels(int ID)
        {
            PVStudentNameLabel.Text = "name"; // or query database to find name
            PVSectionLabel.Text = "section"; //query for section
            PVFirstNameLabel.Text = "max"; //query for firstname in database
            PVLastNameLabel.Text = "clem"; //query for lastname in database
            PVIDNumberLabel.Text = ID.ToString(); //should have the ID
            PVAddressLabel.Text = "55 wastingon st"; //query for address in database
            PVPhoneLabel.Text = "555-555-5555";//query for phone number
            PVEmailLabel.Text = "bleh@gmail.com"; //queery for email
            GradeComboBox.Items.Add("A");
            GradeComboBox.Items.Add("B");
            GradeComboBox.Items.Add("C");
            GradeComboBox.Items.Add("D");
            GradeComboBox.Items.Add("F");

        }
        private void UpdateGradeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string grade = GradeComboBox.SelectedItem.ToString();
                MessageBox.Show("The grade you chose was " + grade);
                //Update database with value in combo box
            }
            catch
            {
                MessageBox.Show("You have no grade selected!");
            }
        }
    }
}
