using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            SetLabels1();
            AddDropSemesterComboBox_Load();
        }
        private void SetLabels1()
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
                "Connection"
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
            
        }
//==============================================Labels:



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
            
            //push datagrid to database
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // pull users where the user is in them
            
            List<string> myCourseSection = new List<string>();
            List<string> myCourseHours = new List<string>();
            List<string> myCourseDays = new List<string>();
            try
            {


                object[] firstCourseNameHTMLEdit = { "document.getElementById(\"firstCourseName\").innerHTML = $firstCourseName" };
                object[] firstCourseSectionHTMLEdit = { "document.getElementById(\"firstCourseSection\").innerHTML = $firstCourseSection" };
                object[] firstCourseHoursHTMLEdit = { "document.getElementById(\"firstCourseHours\").innerHTML = $firstCourseHours" };
                object[] firstCourseDaysHTMLEdit = { "document.getElementById(\"firstCourseDays\").innerHTML = $firstCourseDays" };

                object[] firstCourseNameJScript = { "$firstCourseName = \"" + LogIn.user.Registrations[0] + "\"" };
                webBrowser1.Document.InvokeScript("eval", firstCourseNameJScript);
                webBrowser1.Document.InvokeScript("eval", firstCourseNameHTMLEdit);
                object[] firstCourseSectionJScript = { "var $firstCourseSection = \"" + LogIn.user.Registrations[0].ToString() + "\"" };
                webBrowser1.Document.InvokeScript("eval", firstCourseSectionJScript);
                webBrowser1.Document.InvokeScript("eval", firstCourseSectionHTMLEdit);
                object[] firstCourseHoursJScript = { "var $firstCourseHours = \"" + LogIn.user.Registrations[0].ToString() + "\"" };
                webBrowser1.Document.InvokeScript("eval", firstCourseHoursJScript);
                webBrowser1.Document.InvokeScript("eval", firstCourseHoursHTMLEdit);
                object[] firstCourseDaysJScript = { "var $firstCourseDays = \"" + LogIn.user.Registrations[0].ToString() + "\"" };
                webBrowser1.Document.InvokeScript("eval", firstCourseDaysJScript);
                webBrowser1.Document.InvokeScript("eval", firstCourseDaysHTMLEdit);
            }
            catch
            {
                MessageBox.Show("It Broken printing the first time");
            }
            bool scheduleLooping = true;
            //keeps the thing looping when it grabs and puts in the data
            int timesScheduleLooped = 0;
            //

            //The stuff that will need to be done every time for part of the loop
            object[] courseNameHTMLCreationPtOne = { "var para = document.createElement(\"li\");" };
            object[] courseNameHTMLCreationPtThree = { "para.appendChild(node);" };
            object[] courseNameHTMLCreationPtFour = { "var element = document.getElementById(\"additionalCourses\");" };
            object[] courseNameHTMLCreationPtFive = { "element.appendChild(para);" };

            //ditto
            object[] courseSectionHTMLCreationPtOne = { "var para = document.createElement(\"p\");" };
            object[] courseSectionHTMLCreationPtThree = { "para.appendChild(node);" };
            object[] courseSectionHTMLCreationPtFour = { "var element = document.getElementById(\"additionalCourses\");" };
            object[] courseSectionHTMLCreationPtFive = { "element.appendChild(para);" };

            //ditto
            object[] courseHoursHTMLCreationPtOne = { "var para = document.createElement(\"p\");" };
            object[] courseHoursHTMLCreationPtThree = { "para.appendChild(node);" };
            object[] courseHoursHTMLCreationPtFour = { "var element = document.getElementById(\"additionalCourses\");" };
            object[] courseHoursHTMLCreationPtFive = { "element.appendChild(para);" };

            object[] courseDaysHTMLCreationPtOne = { "var para = document.createElement(\"p\");" };
            object[] courseDaysHTMLCreationPtThree = { "para.appendChild(node);" };
            object[] courseDaysHTMLCreationPtFour = { "var element = document.getElementById(\"additionalCourses\");" };
            object[] courseDaysHTMLCreationPtFive = { "element.appendChild(para);" };

            while (scheduleLooping == true)

                try 
                {
                    webBrowser1.Document.InvokeScript("eval", courseNameHTMLCreationPtOne);
                    object[] courseNameHTMLCreationPtTwo = { "var node = document.createTextNode(\"" + LogIn.user.Registrations[timesScheduleLooped+1].ToString()+ "\")" };
                    //make the node on the fly
                    webBrowser1.Document.InvokeScript("eval", courseNameHTMLCreationPtTwo);
                    webBrowser1.Document.InvokeScript("eval", courseNameHTMLCreationPtThree);
                    webBrowser1.Document.InvokeScript("eval", courseNameHTMLCreationPtFour);
                    webBrowser1.Document.InvokeScript("eval", courseNameHTMLCreationPtFive);

                    webBrowser1.Document.InvokeScript("eval", courseSectionHTMLCreationPtOne);
                    //make the node on the fly
                    object[] courseSectionHTMLCreationPtTwo = { "var node = document.createTextNode(\"" + LogIn.user.Registrations[timesScheduleLooped+1].ToString() + "\")" };
                    webBrowser1.Document.InvokeScript("eval", courseSectionHTMLCreationPtTwo);
                    webBrowser1.Document.InvokeScript("eval", courseSectionHTMLCreationPtThree);
                    webBrowser1.Document.InvokeScript("eval", courseSectionHTMLCreationPtFour);
                    webBrowser1.Document.InvokeScript("eval", courseSectionHTMLCreationPtFive);

                    webBrowser1.Document.InvokeScript("eval", courseHoursHTMLCreationPtOne);
                    //make the node on the fly
                    object[] courseHoursHTMLCreationPtTwo = { "var node = document.createTextNode(\"" + LogIn.user.Registrations[timesScheduleLooped+1].ToString() + "\")" };
                    webBrowser1.Document.InvokeScript("eval", courseHoursHTMLCreationPtTwo);
                    webBrowser1.Document.InvokeScript("eval", courseHoursHTMLCreationPtThree);
                    webBrowser1.Document.InvokeScript("eval", courseHoursHTMLCreationPtFour);
                    webBrowser1.Document.InvokeScript("eval", courseHoursHTMLCreationPtFive);

                    webBrowser1.Document.InvokeScript("eval", courseDaysHTMLCreationPtOne);
                    //make the node on the fly
                    object[] courseDaysHTMLCreationPtTwo = { "var node = document.createTextNode(\"" + LogIn.user.Registrations[timesScheduleLooped+1].ToString() + "\")" };
                    webBrowser1.Document.InvokeScript("eval", courseDaysHTMLCreationPtTwo);
                    webBrowser1.Document.InvokeScript("eval", courseDaysHTMLCreationPtThree);
                    webBrowser1.Document.InvokeScript("eval", courseDaysHTMLCreationPtFour);
                    webBrowser1.Document.InvokeScript("eval", courseDaysHTMLCreationPtFive);
                    timesScheduleLooped++;
                    MessageBox.Show("It worked");
                }

                catch
                {
                    MessageBox.Show("It Broken, printing the second time.");
                    scheduleLooping = false;
                }

            
            //close connection to database.
        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(String.Format("file:///{0}/schedule.html", curDir));
        }
    }
}
