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
    public partial class Registrar : Form
    {
        public char grade { get; private set; }

        private List<string> sectionIndex = new List<string>() { "section1", "section2", "section3" };
        private List<string> courseIndex = new List<string>() { "course1", "course2", "course3" };
        private List <string> people = new List<string> { "jim", "karren", "david"};
        private int userID;
        
        public Registrar(int ID)
        {
            userID = ID;
            InitializeComponent();
            UserViewComboBox_Load(ID);
            LoadPersonalLabels(ID);
        }
        private void LoadPersonalLabels(int ID)
        {
            personalidlbl.Text = ID.ToString();
            personalFirstNamelbl.Text = "firstName";
            personalLastNamelbl.Text = "lastname";
            personalAgelbl.Text = "age";
            personalAddresslbl.Text = "address";
            personalSexlbl.Text = "gender";
        }
        /// <summary>
        /// A combo box to change user views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        /// loads values into the UserView combo box
        /// </summary>
        private void UserViewComboBox_Load(int ID)
        {
            UserViewComboBox.Items.Add("Student");
            //check login id to see if they have professor rights
            if (true)
            {
                UserViewComboBox.Items.Add("Professor");
            }
            //check login id to see if they have registar rights
            if (true)
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
            studentView Student = new studentView(userID);
            Registrar Registar = new Registrar(userID);
            if ((string)UserViewComboBox.SelectedItem == "Student")
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
        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfessorView Professor = new ProfessorView(userID);
            studentView Student = new studentView(userID);
            Registrar Registar = new Registrar(userID);
            if ((string)UserViewComboBox.SelectedItem == "Student")
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdatePersonalInformation update = new UpdatePersonalInformation(userID);
            update.Show();
        }

        private void CourseListBox_Load()
        {
            CourseListBox.Items.Clear();
            foreach (string course in courseIndex)
            {
                CourseListBox.Items.Add(course);
            }
        }
        private void courseSearchBtn_Click(object sender, EventArgs e)
        {

            if (courseSearchBox.Text == "Math")
            {
                CourseListBox_Load();
            }
            //query database
            
        }

    
        private void CourseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //query the name from courseSearchBox.text
            //query for the ID and other shit
            //
            try
            {
                if ("course1" == CourseListBox.SelectedItem.ToString())
                {
                    course1.Text = "name";
                    section1.Text = "ID";
                    professor1.Text = "prof";
                    time1.Text = "time";
                    day1.Text = "day";
                    date1.Text = "date";
                }
            }
            catch
            {
                MessageBox.Show("Item does not exist");
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons confirm = MessageBoxButtons.YesNo;
           
            DialogResult result;
            result = MessageBox.Show("are you sure you want to delete", "Delete", confirm);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //delete shit from database
                string selectedItem = CourseListBox.SelectedItem.ToString();
                CourseListBox.Items.Remove(selectedItem);
            }

        }
        private void PersonLookupListBox_Load()
        {
            //query database for value in list box
            PersonLookupListBox.Items.Clear();
            foreach (string person in people)
            {

                if (person == userSearchBox.Text)
                {
                    PersonLookupListBox.Items.Add(person);
                }
            }
          
        }
        private void userSearchBtn_Click(object sender, EventArgs e)
        {
            if (userSearchBox.Text == "jim")
            {
                PersonLookupListBox_Load();
            }
        }
        private void SectionLookupListBox_Load()
        {
            SectionLookupListBox.Items.Clear();
            foreach (string section in sectionIndex)
            {
                SectionLookupListBox.Items.Add(section);
            }
        }
        private void LookupLabels_Load()
        {
            if ("jim" == PersonLookupListBox.SelectedItem.ToString())
            {
                IdLookuplbl.Text = "id";
                firstNameLookuplbl.Text = "firstname";
                lastNameLookuplbl.Text = "lastname";
                ageLookuplbl.Text = "age";
                sexLookuplbl.Text = "gender";
                addressLookuplbl.Text = "address";
                emailLookuplbl.Text = "email";
            }
        }
        private void PersonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionLookupListBox_Load();
            LookupLabels_Load();
        }

        private void updatePersonalInfobtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string selectedItem = PersonLookupListBox.SelectedItem.ToString();
                    //query database for student id using selected item
                    //userId = found userid
                    UpdatePersonalInformation PersonalV = new UpdatePersonalInformation(userID);
                    PersonalV.Show();
                }
                catch
                {
                    MessageBox.Show("You do not have a person selected!");
                }
            }
        }

        private void updateCourseInfobtn_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = SectionLookupListBox.SelectedItem.ToString();
                //query database for student id using selected item
                //userId = found userid
                UpdateSectionInformation SectionV = new UpdateSectionInformation(userID);
                SectionV.Show();
            }
            catch
            {
                MessageBox.Show("You do not have a section selected!");
            }
        }
    }
}
