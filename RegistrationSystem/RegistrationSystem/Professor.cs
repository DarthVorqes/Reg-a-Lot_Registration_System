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
    
        List<string> semesterIndex    = new List<string>() { "Fall2019", "Spring2019", "Summer2019" };
      
      
      
        public ProfessorView()
        {
         
            InitializeComponent();
            SetLabels();
            UserViewComboBox_Load();
            SemesterComboBox_Load();
           //AddDropSemesterComboBox_Load(ID);
          //AddDropCoursesComboBox_Load(ID);
           

        }
        private void SetLabels()
        {
            ProfessorTitle.Text = LogIn.user.FirstName + " " +LogIn.user.LastName; 
            FirstNameLabel.Text = LogIn.user.FirstName;
            LastNameLabel.Text = LogIn.user.LastName; 
            IDNumberLabel.Text = LogIn.user.EnterpriseID.ToString(); 
            AddressLabel.Text = LogIn.user.StreetAddress; 
            EmailLabel.Text = LogIn.user.Email;
            PhoneNumberLabel.Text = LogIn.user.PhoneNumber.ToString();
        }
        /// <summary>
        /// loads values into the UserView combo box
        /// </summary>
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
        /// <summary>
        /// A combo box to change user views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfessorView Professor = new ProfessorView();
            studentView Student = new studentView(1);
            Registrar Registar = new Registrar(1);
            if (UserViewComboBox.SelectedText == "Student")
            {
                Student.Show();
                Close();
            }
            if (UserViewComboBox.SelectedText == "Professor")
            {
                Professor.Show();
                Close();
            }
            if (UserViewComboBox.SelectedText == "Registar")
            {
                Registar.Show();
                Close();
            }
        }
        /// <summary>
        /// Logout button, exits application for now.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logout_Click(object sender, EventArgs e)
        {
           
            Environment.Exit(1);
        }
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
            if (ScheduleSemesterComboBox.SelectedItem.ToString() == "Spring2019")
            {
                ScheduleSectionComboBox_Load();
            }
            if (ScheduleSemesterComboBox.SelectedItem.ToString() == "Summer2019")
            {
                ScheduleSectionsComboBox.Items.Clear();
            }
            if (ScheduleSemesterComboBox.SelectedItem.ToString() == "Fall2019")
            {
                ScheduleSectionsComboBox.Items.Clear();
            }
        }
        /// <summary>
        /// sets the values for the Schedule tab's combo box with sections.
        /// </summary>
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





/*
        private void AddDropSemesterComboBox_Load()
        {
            AddDropSemesterComboBox.Items.Clear();
            foreach (string semester in semesterIndex)
            {
                AddDropSemesterComboBox.Items.Add(semester);
            }
        }
        /// <summary>
        /// sets valuse for the Add/Drop tab's combo box with courses
        /// </summary>
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



 

        /// <summary>
        /// Loads in the list box values in Add/Drop tab depeding on the course selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDropCoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDropListBox_Load();
        }
        
        /// <summary>
        /// Request to add a section to professors schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Request to drop a section from professors schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void updateInfoBtn_Click(object sender, EventArgs e)
        {
            UpdatePersonalInformation update = new UpdatePersonalInformation(1);
            update.Show();
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
        }*/
    }
}
