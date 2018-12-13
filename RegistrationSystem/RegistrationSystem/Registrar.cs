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
     

        private List<string> sectionIndex = new List<string>() { "section1", "section2", "section3" };
        private List<string> courseIndex = new List<string>() { "course1", "course2", "course3" };
        private List <string> people = new List<string> { "jim", "karren", "david"};
   

        
        public Registrar()
        {
  
            InitializeComponent();
            UserViewComboBox_Load();
            LoadPersonalLabels();
        }
 //======================================Labels: 
        private void LoadPersonalLabels()
        {
           
        }
        private void CoursesLabels_Load()
        {
            //andrews method.
            //CourseNameLbl = 
            //SectionNameLbl =
            //ProfessorNameLbl =
            //TimeLbl =
            //DayLbl =
            //DateLbl =
        }
        private void LookupLabels_Load()
        {
            if ("jim" == PersonLookupListBox.SelectedItem.ToString())
            {
                SearchIDNumberLbl.Text = "id";
                SearchFirstNameLbl.Text = "firstname";
                SearchLastNameLbl.Text = "lastname";
                SearchEmailLbl.Text = "age";
                SearchPhoneNumberLbl.Text = "gender";
                SearchAddressLbl.Text = "address";
            }
        }
//=========================================User view:
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


//========================================= Course tab:

        private void CourseListBox_Load()
        {
            CourseListBox.Items.Clear();
            foreach (string course in courseIndex)
            {
                CourseListBox.Items.Add(course);
            }
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
                    CourseNameLbl.Text = "name";
                    SectionNameLbl.Text = "ID";
                    ProfessorNameLbl.Text = "prof";
                    TimeLbl.Text = "time";
                    DayLbl.Text = "day";
                    DateLbl.Text = "date";
                }
            }
            catch
            {
                MessageBox.Show("Item does not exist");
            }
        }
//============================================LookUp tab:
        private void PersonLookupListBox_Load()
        {
            //query database for value in list box
            PersonLookupListBox.Items.Clear();
            foreach (string person in people)
            {

                if (person == UserSearchBox.Text)
                {
                    PersonLookupListBox.Items.Add(person);
                }
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

        private void PersonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SectionLookupListBox_Load();
            LookupLabels_Load();
        }



//==============================================================buttons:
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UserPersonalInformation update = new UserPersonalInformation("Update", LogIn.user.EnterpriseID);
            update.Show();
        }
        private void UpdatePersonalInfoBtn_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string selectedItem = PersonLookupListBox.SelectedItem.ToString();
                                                                                            //but new user::
                    UserPersonalInformation PersonalV = new UserPersonalInformation("Update", LogIn.user.EnterpriseID);
                    PersonalV.Show();
                }
                catch
                {
                    MessageBox.Show("You do not have a person selected!");
                }
            }
        }

        private void UpdateSectionInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedItem = SectionLookupListBox.SelectedItem.ToString();
                //query database for student id using selected item
                //userId = found userid
                UpdateSectionInformation SectionV = new UpdateSectionInformation();
                SectionV.Show();
            }
            catch
            {
                MessageBox.Show("You do not have a section selected!");
            }
        }
        private void CourseSearchBtn_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(UserSearchBox.Text);
            List<SectionStudent> results = LogIn.user.Connection.BuildClassArray<SectionStudent>(new System.Data.SqlClient.SqlParameter[]
            {
                new System.Data.SqlClient.SqlParameter("ID",id)
            },Tables.Person);
            if (CourseSearchBox.Text == "Math")
            {
                CourseListBox_Load();
            }
            //query database

        }
        private void UserSearchBtn_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32("");
            List<SectionStudent> results = LogIn.user.Connection.BuildClassArray<SectionStudent>(new System.Data.SqlClient.SqlParameter[]
            {
                new System.Data.SqlClient.SqlParameter("ID",id)
            }, Tables.Person);
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
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

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
                                                                                 //But new user;;
            UserPersonalInformation addUser = new UserPersonalInformation("Add", LogIn.user.EnterpriseID);
            addUser.Show();
        }


    }
}
