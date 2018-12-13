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
        List<SectionStudent> updateGrade = new List<SectionStudent>();
        string[] semesterIndex = LogIn.user.GetSemesters();

        public ProfessorView()
        {

            InitializeComponent();
            SetLabels();
            UserViewComboBox_Load();
            SemesterComboBox_Load();
            AddDropSemesterComboBox_Load();
            AddDropCoursesComboBox_Load();
            ProfessorTitle.Text = LogIn.user.FirstName + " " + LogIn.user.LastName;
            StudentGridView.CellEndEdit += StudentGridView_CellEndEdit;
            InfoGrid.CellEndEdit += InfoGrid_CellEndEdit;

        }

        private void InfoGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = InfoGrid.Rows[e.RowIndex];

            var password = row.Cells[1].Value;

            if (password == null)
                return;
            row.Cells[1].Value = password;
            LogIn.user.Password = password.ToString();
            LogIn.user.PushChanges(LogIn.user);

        }

        private void StudentGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = StudentGridView.Rows[e.RowIndex];
            var id = Convert.ToInt32(row.Cells[0].Value);
            var grade = row.Cells[3].Value as string;
            if (grade == null)
                grade = "";
            if (grade.Length < 10)
                grade = grade.Substring(0, 1).ToUpper();
            row.Cells[3].Value = grade;
            LogIn.user.SetGrade(id, grade,selectedSection.ID);
        }

        //=========================Set user specific labels:
        private void SetLabels()
        {
            DataGrid grid = new DataGrid();
            string[] excludeFromDataGrid = new string[]
            {
                "Bill",
                "HasPaid",
                "IsProfessor",
                "IsStudent",
                "IsRegistrar",
                "Password",
                "UserSchedule",
                "Connection",
                "Registrations"
            };
            foreach (var property in typeof(User).GetProperties())
            {
                if (property.PropertyType.Namespace == "RegistrationSystem")
                    continue;
                bool exclude = false;
                foreach (var name in excludeFromDataGrid)
                {
                    if (name == property.Name)
                    {
                        exclude = true;
                        break;
                    }
                }
                if (exclude)
                {
                    continue;
                }
                var row = new DataGridViewRow();
                row.CreateCells(InfoGrid, new string[]
                {
                        property.Name,
                        property.GetValue(LogIn.user).ToString()
                });
                InfoGrid.Rows.Add(row);
            }
            InfoGrid.Rows[10].Cells[1].Value = "";
            InfoGrid.Rows.Add("Password");
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
        List<Section> loadedSections = new List<Section>();
        Section selectedSection;
        private void ScheduleSemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] selectedItem = ScheduleSemesterComboBox.SelectedItem.ToString().Split();
            loadedSections = LogIn.user.GetSections(selectedItem[0], selectedItem[1], true);
            ScheduleSectionsComboBox.Items.Clear();
            foreach (Section section in loadedSections)
            {
                ScheduleSectionsComboBox.Items.Add(section.GetCourseName(LogIn.user) + '-' + section.SectionNumber);
            }

        }

        private void ScheduleSectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] selectedItem = ScheduleSectionsComboBox.SelectedItem.ToString().Split('-');
            selectedSection = loadedSections.Find((Section s) => { return s.SectionNumber.ToString() == selectedItem[1] && s.GetCourseName(LogIn.user) == selectedItem[0]; });
            List<SectionStudent> students = LogIn.user.GetStudents(new System.Data.SqlClient.SqlParameter[] {
                new System.Data.SqlClient.SqlParameter("SectionID", selectedSection.ID) });
            updateGrade = students;
           
    
            foreach (var student in students)
            {
                var row = new DataGridViewRow();
          

                row.CreateCells(StudentGridView,new string[] {
                    student.PersonID.ToString(),
                    student.GetFirstName(LogIn.user),
                    student.GetLastName(LogIn.user),
                    student.Grade,
                });
                StudentGridView.Rows.Add(row);
            }
        }
           
            
    
             
          

//====================================================Add Drop Tab:
        private void AddDropSemesterComboBox_Load()
        {
            AddDropSemesterComboBox.Items.Clear();
            foreach (string semester in semesterIndex)
            {
                AddDropSemesterComboBox.Items.Add(semester.ToString());
            }
        }
        private void AddDropCoursesComboBox_Load()
        {
            AddDropDepartmentComboBox.Items.Clear();
            foreach (string department in LogIn.user.GetDepartments())
            {
                AddDropDepartmentComboBox.Items.Add(department);
            }

        }


//===========================================================Buttons:
        private void Logout_Click(object sender, EventArgs e)
        {

            Environment.Exit(1);
        }

        private void UpdateInfoBtn_Click_1(object sender, EventArgs e)
        {
            UserPersonalInformation update = new UserPersonalInformation("Update", LogIn.user.EnterpriseID);
           update.Show();
        }


    }
}
