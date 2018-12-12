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
    public partial class StudentView : Form
    {
        private List<string> studentIndex = new List<string>() { "Jim", "gary", "mary" };
        private List<string> sectionIndex = new List<string>() { "section1", "section2", "section3" };
        private List<string> courseIndex = new List<string>() { "course1", "course2", "course3" };
        private List<string> semesterIndex = new List<string>() { "Fall2019", "Spring2019", "Summer2019" };
   
        
        public StudentView()
        {
     
            InitializeComponent();
            UserViewComboBox_Load();
            SetLabels();
            AddDropSemesterComboBox_Load();
        }
//==============================================Labels:
        private void SetLabels()
        {
            StudentTitle.Text = LogIn.user.FirstName + " " + LogIn.user.LastName;
            UserFirstNameLbl.Text = LogIn.user.FirstName;
            UserLastNameLbl.Text = LogIn.user.LastName;
            UserIDNumberLbl.Text = LogIn.user.EnterpriseID.ToString();
            UserAddressLbl.Text = LogIn.user.StreetAddress;
            UserEmailLbl.Text = LogIn.user.Email;
            UserPhoneNumberLbl.Text = LogIn.user.PhoneNumber.ToString();
            HasPaidLbl.Text = LogIn.user.HasPaid.ToString();
        }

//==============================================User view:
        private void UserViewComboBox_Load()
        {
           if (LogIn.user.IsStudent)
            {
                UserViewComboBox.Items.Add("Student");
            }
            if (LogIn.user.IsProfessor)
            {
                UserViewComboBox.Items.Add("Professor");
            }
            if (LogIn.user.IsRegistrar)
            {
                UserViewComboBox.Items.Add("Registar");
            }
        }
        private void UserViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfessorView Professor = new ProfessorView();
            StudentView Student = new StudentView();
            Registrar Registar = new Registrar();
            if ((string) UserViewComboBox.SelectedItem == "Student")
            {
                Student.Show();
                Close();
            }
            if ((string)UserViewComboBox.SelectedItem == "Professor")
            {
                Professor.Show();
                Close();
            }
            if ((string)UserViewComboBox.SelectedItem == "Registar")
            {
                Registar.Show();
                Close();
            }
        }
//=================================================AddDrop tab:
        private void AddDropSemesterComboBox_Load()
        {
            AddDropSemesterComboBox.Items.Clear();
            foreach (string semester in semesterIndex)
            {
                AddDropSemesterComboBox.Items.Add(semester);
            }
        }
        private void AddDropCoursesComboBox_Load()
        {
            AddDropCoursesComboBox.Items.Clear();
            foreach (string course in courseIndex)
            {
                AddDropCoursesComboBox.Items.Add(course);
            }
        }
        private void AddDropSemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDropListBox.Items.Clear();
            if (AddDropSemesterComboBox.SelectedItem.ToString() == "Spring2019")
            {
                AddDropCoursesComboBox_Load();
            }
            if (AddDropSemesterComboBox.SelectedItem.ToString() == "Summer2019")
            {
                AddDropCoursesComboBox.Items.Clear();
            }
            if (AddDropSemesterComboBox.SelectedItem.ToString() == "Fall2019")
            {
                AddDropCoursesComboBox.Items.Clear();
            }
        }
        private void AddDropListBox_Load()
        {
            AddDropListBox.Items.Clear();
            foreach (string section in sectionIndex)
            {
                AddDropListBox.Items.Add(section);
            }
        }
        private void AddDropCoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDropListBox_Load();
        }

 //=============================================================Buttons:
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void DropSectionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = AddDropListBox.SelectedItem.ToString();

                //check database if professor can drop a class
                //ex. if(canDropSection == true)
                if (selectedItem == "section2")
                {
                    MessageBox.Show("You have dropped the section " + selectedItem);
                    //canDropSection = false;
                }
                else
                {
                    MessageBox.Show("You are not approved to drop sections, ask registar for approval!");
                }
            }
            catch
            {
                MessageBox.Show("You do not have a section selected!");
            }
        }

        private void AddSectionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = AddDropListBox.SelectedItem.ToString();

                //check database if professor can registar for a class
                //ex. if(canAddSection == true)
                if (selectedItem == "section2")
                {
                    MessageBox.Show("You have been added to the section " + selectedItem);
                    //canAddSection = false;
                }
                else
                {
                    MessageBox.Show("You are not approved to add sections, ask registar for approval!");
                }
            }
            catch
            {
                MessageBox.Show("You do not have a section selected!");
            }
        }
        private void UpdateInfoBtn_Click(object sender, EventArgs e)
        {
            UserPersonalInformation update = new UserPersonalInformation("Update", LogIn.user.EnterpriseID);
            update.Show();
        }
    }
}
