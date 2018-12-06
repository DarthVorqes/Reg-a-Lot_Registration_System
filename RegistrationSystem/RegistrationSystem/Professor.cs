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
        public char grade { get; private set; }
    
        private List<string> studentIndex     = new List<string>() { "Jim", "gary", "mary" };
        private List<string> sectionIndex     = new List<string>() { "section1", "section2", "section3" };
        private List<string> courseIndex      = new List<string>() { "course1", "course2", "course3" };
        private string userID;
        /// <summary>
        /// Opens Professor View form
        /// </summary>
        /// <param name="ID">the ID used to log in, this will be used to populate lists/comboboxs etc.</param>
        public ProfessorView(string ID)
        {
            userID = ID;
            InitializeComponent();
            UserViewComboBox_Load(ID);
            ScheduleComboBox_Load(ID);
            AddDropCoursesComboBox_Load(ID);
           

        }
        /// <summary>
        /// loads values into the UserView combo box
        /// </summary>
        private void UserViewComboBox_Load(string ID)
        {
            UserViewComboBox.Items.Add("Student");
            //check login id to see if they have professor rights
            if (ID == "Max")
            {
                UserViewComboBox.Items.Add("Professor");
            }
            //check login id to see if they have registar rights
            if (ID == "Al")
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
            ProfessorView Professor = new ProfessorView(userID);
            //StudentView Student = new StudentView();
            //RegistarView Registar = new RegistarView();
            if ((string)UserViewComboBox.SelectedItem == "Student")
            {
                //Student.show();
                //Close();
            }
            if ((string)UserViewComboBox.SelectedItem == "Professor")
            {
                Professor.Show();
                Close();
            }
            if ((string)UserViewComboBox.SelectedItem == "Registar")
            {
                //Registar.Show();
                //Close();
            }
        }
        /// <summary>
        /// Logout button, exits application for now.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logout_Click(object sender, EventArgs e)
        {
            LogIn logout = new LogIn();
            logout.Show();
            Close();
        }
        /// <summary>
        /// sets the values for the Schedule tab's combo box with sections.
        /// </summary>
        private void ScheduleComboBox_Load(string ID)
        {
            foreach (string section in sectionIndex)
            {
                ScheduleComboBox.Items.Add(section);
            }
        }

        /// <summary>
        /// sets valuse for the Add/Drop tab's combo box with courses
        /// </summary>
        private void AddDropCoursesComboBox_Load(string ID)
        {
            foreach (string course in courseIndex)
            {
                AddDropCoursesComboBox.Items.Add(course);
            }
        }
        /// <summary>
        /// sets the values for the Schedule tab's list box with students.
        /// </summary>
        private void ScheduleListBox_Load()
        {
            ScheduleListBox.Items.Clear();
            foreach (string student in studentIndex)
            {
                ScheduleListBox.Items.Add(student);
            }
        }
        private void AddDropCoursesListBox_Load()
        {
            AddDropListBox.Items.Clear();
            foreach (string section in sectionIndex)
            {
                AddDropListBox.Items.Add(section);
            }
        }
        /// <summary>
        /// Loads in the list box values to the Schedule tab's Schedule List box, depending on what section you choose.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {         
            ScheduleListBox_Load();
        }

        /// <summary>
        /// Loads in the list box values in Add/Drop tab depeding on the course selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDropCoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDropCoursesListBox_Load();
        }
        /// <summary>
        /// Request to add a section to professors schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Request to drop a section from professors schedule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DropButton_Click(object sender, EventArgs e)
        {

        }
    }
}
