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
    public partial class studentView : Form
    {
        public studentView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void studentView_Load(object sender, EventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            //this populates the first course that someone is in during the semester a schedule is looked at.

            //should go into database, keep it open set these variables to the first 
            string firstCourseName = "C# Programming"; //the course name of the first section it pulls out of the database.
            string firstCourseSection = "COSC 1320 001"; //the course section of the first section it pulls out of the database.
            string firstCourseHours = "12:30 - 3:15"; //the time (such time  of the first section it pulls out of the database.

            if (firstCourseName != "" && firstCourseSection != "" && firstCourseHours != "")
            { 
            object[] firstCourseNameHTMLEdit = { "document.getElementById(\"firstCourseName\").innerHTML = $firstCourseName" };
            object[] firstCourseSectionHTMLEdit = { "document.getElementById(\"firstCourseSection\").innerHTML = $firstCourseSection" };
            object[] firstCourseHoursHTMLEdit = { "document.getElementById(\"firstCourseHours\").innerHTML = $firstCourseHours" };

            object[] firstCourseNameJScript = { "$firstCourseName = \"" + firstCourseName + "\"" };
            webBrowser1.Document.InvokeScript("eval", firstCourseNameJScript);
            webBrowser1.Document.InvokeScript("eval", firstCourseNameHTMLEdit);
            object[] firstCourseSectionJScript = { "var $firstCourseSection = \"" + firstCourseSection + "\"" };
            webBrowser1.Document.InvokeScript("eval", firstCourseSectionJScript);
            webBrowser1.Document.InvokeScript("eval", firstCourseSectionHTMLEdit);
            object[] firstCourseHoursJScript = { "var $firstCourseHours = \"" + firstCourseHours + "\"" };
            webBrowser1.Document.InvokeScript("eval", firstCourseHoursJScript);
            webBrowser1.Document.InvokeScript("eval", firstCourseHoursHTMLEdit);
            }
            bool scheduleLooping = true;
            //keeps the thing looping when it grabs and puts in the data
            int timesScheduleLooped = 0;
            //
            List<string> myCourseName = new List<string>();
            List<string> myCourseSection = new List<string>();
            List<string> myCourseHours = new List<string>();

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

            while (scheduleLooping == true)
            {
                string pullCourseName = "Pull Course Name"; //Pull the course name from the table.
                string pullCourseSection = "Pull Course Section"; //pull the course section from the table.
                string pullCourseHours = "Pull Course Hours"; //pull the course hours from the table


                myCourseName.Add(pullCourseName); 
                myCourseSection.Add(pullCourseSection);
                myCourseHours.Add(pullCourseHours);
                if (myCourseName[timesScheduleLooped] != null && myCourseSection[timesScheduleLooped] != null && myCourseHours[timesScheduleLooped] != null)
                {
                    webBrowser1.Document.InvokeScript("eval", courseNameHTMLCreationPtOne);
                    object[] courseNameHTMLCreationPtTwo = { "var node = document.createTextNode(\"" + myCourseName[timesScheduleLooped] + "\")" };
                    //make the node on the fly
                    webBrowser1.Document.InvokeScript("eval", courseNameHTMLCreationPtTwo);
                    webBrowser1.Document.InvokeScript("eval", courseNameHTMLCreationPtThree);
                    webBrowser1.Document.InvokeScript("eval", courseNameHTMLCreationPtFour);
                    webBrowser1.Document.InvokeScript("eval", courseNameHTMLCreationPtFive);

                    webBrowser1.Document.InvokeScript("eval", courseSectionHTMLCreationPtOne);
                    //make the node on the fly
                    object[] courseSectionHTMLCreationPtTwo = { "var node = document.createTextNode(\"" + myCourseSection[timesScheduleLooped] + "\")" };
                    webBrowser1.Document.InvokeScript("eval", courseSectionHTMLCreationPtTwo);
                    webBrowser1.Document.InvokeScript("eval", courseSectionHTMLCreationPtThree);
                    webBrowser1.Document.InvokeScript("eval", courseSectionHTMLCreationPtFour);
                    webBrowser1.Document.InvokeScript("eval", courseSectionHTMLCreationPtFive);

                    webBrowser1.Document.InvokeScript("eval", courseHoursHTMLCreationPtOne);
                    //make the node on the fly
                    object[] courseHoursHTMLCreationPtTwo = { "var node = document.createTextNode(\"" + myCourseHours[timesScheduleLooped] + "\")" };
                    webBrowser1.Document.InvokeScript("eval", courseHoursHTMLCreationPtTwo);
                    webBrowser1.Document.InvokeScript("eval", courseHoursHTMLCreationPtThree);
                    webBrowser1.Document.InvokeScript("eval", courseHoursHTMLCreationPtFour);
                    webBrowser1.Document.InvokeScript("eval", courseHoursHTMLCreationPtFive);
                    timesScheduleLooped++;
                }
                else
                {
                    scheduleLooping = false;
                    
                }

                if (timesScheduleLooped == 5)
                {

                    scheduleLooping = false;
                }
            }
            //close connection to database.
        }
    }
}
