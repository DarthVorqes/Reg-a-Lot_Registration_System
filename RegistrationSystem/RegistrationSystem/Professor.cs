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
    public partial class ProfessorView : Form
    {
        public char Grade { get; private set; }
    
        List<Course> courseIndex = LogIn.user.Connection.BuildClassArray<Course>(new System.Data.SqlClient.SqlParameter[0], Tables.Course);
        List<Section> sectionIndex = LogIn.user.Connection.BuildClassArray<Section>(new System.Data.SqlClient.SqlParameter[0], Tables.Section);
        string[] semesterIndex = LogIn.user.GetSemesters();
  
        public ProfessorView()
        {
         
            InitializeComponent();
            SetLabels();
            UserViewComboBox_Load();
            SemesterComboBox_Load();
            AddDropSemesterComboBox_Load();
            AddDropCoursesComboBox_Load();
           

        }
//=========================Set user specific labels:
        private void SetLabels()
        {
            ProfessorTitle.Text = LogIn.user.FirstName + " " +LogIn.user.LastName; 
            UserFirstNameLbl.Text = LogIn.user.FirstName;
            UserLastNameLbl.Text = LogIn.user.LastName; 
            UserIDNumberLbl.Text = LogIn.user.EnterpriseID.ToString(); 
            UserAddressLbl.Text = LogIn.user.StreetAddress; 
            UserEmailLbl.Text = LogIn.user.Email;
            UserPhoneNumberLbl.Text = LogIn.user.PhoneNumber.ToString();
        }
//======================================================User View:
        public void UserViewComboBox_Load()
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
            if (UserViewComboBox.SelectedItem.ToString() == "Student")
            {
                Student.Show();
                Close();
            }
            if (UserViewComboBox.SelectedItem.ToString() == "Professor")
            {
                Professor.Show();
                Close();
            }
            if (UserViewComboBox.SelectedItem.ToString() == "Registar")
            {
                Registar.Show();
                Close();
            }
        }
//=====================================================Schedule tab:
        private void SemesterComboBox_Load()
        {
            ScheduleSemesterComboBox.Items.Clear();
            foreach (string semester in semesterIndex)
            {
                ScheduleSemesterComboBox.Items.Add(semester.ToString());
            }
      
        }
        private void ScheduleSemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScheduleStudentListBox.Items.Clear();
            string[] selectedItem = ScheduleSemesterComboBox.SelectedItem.ToString().Split();
            
  
        }
        private void ScheduleSectionComboBox_Load()
        {
            ScheduleSectionsComboBox.Items.Clear();
            foreach (Section section in sectionIndex)
            {
                ScheduleSectionsComboBox.Items.Add(section.ToString());
            }
        }
        private void ScheduleSectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScheduleStudentListBox_Load();
        }
        private void ScheduleStudentListBox_Load()
        {
            ScheduleStudentListBox.Items.Clear();
            //foreach (string student in studentIndex)
            //{
            //  ScheduleStudentListBox.Items.Add(student);
            //}
        }

//====================================================Add Drop Tab:
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
            foreach (Course course in courseIndex)
            {
                AddDropCoursesComboBox.Items.Add(course);
            }
        }

        private void AddDropListBox_Load()
        {
            AddDropListBox.Items.Clear();
            foreach (Section section in sectionIndex)
            {
                AddDropListBox.Items.Add(section);
            }
        }
        private void AddDropCoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDropListBox_Load();
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
//===========================================================Buttons:
        private void Logout_Click(object sender, EventArgs e)
        {

            Environment.Exit(1);
        }
        private void ViewStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = ScheduleStudentListBox.SelectedItem.ToString();
                //query database for student id using selected item
                PersonalInfoView PersonalV = new PersonalInfoView(1);
                PersonalV.Show();
            }
            catch
            {
                MessageBox.Show("You do not have a section selected!");
            }
        }
        private void DropButton_Click(object sender, EventArgs e)
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
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = AddDropListBox.SelectedItem.ToString();

                //check database if professor can registar for a class
                //ex. if(canAddSection == true)
                if (selectedItem == "section2")
                {
                    MessageBox.Show("You have been added as the instructor for the section " + selectedItem);
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

        private void UpdateInfoBtn_Click_1(object sender, EventArgs e)
        {
            UserPersonalInformation update = new UserPersonalInformation("Update", LogIn.user.EnterpriseID);
            update.Show();
        }
    }
}
