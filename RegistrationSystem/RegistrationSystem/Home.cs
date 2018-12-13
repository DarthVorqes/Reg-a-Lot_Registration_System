using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationSystem
{
    enum Tabs
    {
        Schedule = 0,
        Registration,
        Profile,
        CourseManager,
        SectionManager,
        PersonelManager,
        Login,
    }
    enum SystemActors
    {
        Registrar = 0,
        Professor,
        Student,
        LoggedOut,
    }
    public partial class Home : Form
    {
        User user = new User();
        SystemActors activeActor = SystemActors.LoggedOut;
        public Home()
        {
            InitializeComponent();
            //
            activeAs.Visible = false;
            ChangeTabVisibility(SystemActors.LoggedOut);
            loginBtnSubmit.Click += loginBtnOnSubmit_OnClick;
            activeAs.SelectedIndexChanged += ActiveAs_SelectedIndexChanged;
            scheduleYearComboBox.SelectedIndexChanged += scheduleQueryChanged;
            scheduleSemesterComboBox.SelectedIndexChanged += scheduleQueryChanged;
            scheduleQueryChanged(null, null);
        }

        private void ActiveAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTabVisibility(GetActor(activeAs.SelectedItem.ToString()));
        }

        private void loginBtnOnSubmit_OnClick(object sender, EventArgs e)
        {
            user.IsStudent = true;
            user.IsRegistrar = true;
            user.IsProfessor = true;
            int.TryParse(loginUserIdTxtBox.Text, out int userID);
            if (true || user.Authenticate(userID, loginUserIdTxtBox.Text))
            {
                if (user.IsProfessor)
                    activeAs.Items.Add(SystemActors.Professor.ToString());
                if (user.IsRegistrar)
                    activeAs.Items.Add(SystemActors.Registrar.ToString());
                if (user.IsStudent)
                    activeAs.Items.Add(SystemActors.Student.ToString());
                if (user.IsProfessor)
                    ChangeTabVisibility(SystemActors.Professor);
                else if (user.IsRegistrar)
                    ChangeTabVisibility(SystemActors.Registrar);
                else
                    ChangeTabVisibility(SystemActors.Student);

                if (activeAs.Items.Count > 1)
                    activeAs.Visible = true;
            }
        }

        //helper methods
        private void ChangeTabVisibility(SystemActors actor)
        {
            activeActor = actor;
            tabControl1.TabPages.Clear();
            switch (actor)
            {
                case SystemActors.Registrar:
                    tabControl1.TabPages.Add(scheduleTab);
                    tabControl1.TabPages.Add(registrationTab);
                    tabControl1.TabPages.Add(profileTab);
                    tabControl1.TabPages.Add(personnelManagerTab);
                    tabControl1.TabPages.Add(courseManagerTab);
                    tabControl1.TabPages.Add(sectionManagerTab);
                    break;
                case SystemActors.Professor:
                    tabControl1.TabPages.Add(scheduleTab);
                    //this is for signing up to teach classes
                    tabControl1.TabPages.Add(registrationTab);
                    tabControl1.TabPages.Add(profileTab);
                    tabControl1.TabPages.Add(personnelManagerTab);//this will be limited access
                    break;
                case SystemActors.Student:
                    tabControl1.TabPages.Add(scheduleTab);
                    tabControl1.TabPages.Add(registrationTab);
                    tabControl1.TabPages.Add(profileTab);
                    break;
                case SystemActors.LoggedOut:
                    tabControl1.TabPages.Add(loginTab);
                    break;
            }
        }
        void AddSpaces(string txt)
        {
            string allCaps = txt.ToUpper();
            for (int i = 0; i < txt.Length; i++)
                if (txt[i] == allCaps[i])
                    txt = txt.Insert(i++ - 1, " ");
        }
        SystemActors GetActor(string str)
        {
            string[] names = Enum.GetNames(typeof(SystemActors));
            for (int i = 0; i < names.Length; i++)
                if (names[i] == str)
                    return (SystemActors)i;
            return SystemActors.LoggedOut;
        }
        //login page
        private void usernameTxtBox(object sender, EventArgs e)
        {
            while (loginUserIdTxtBox.Text.Length > 0 && !int.TryParse(loginUserIdTxtBox.Text, out int n))
                loginUserIdTxtBox.Text = loginUserIdTxtBox.Text.Substring(0, loginUserIdTxtBox.Text.Length - 1);
        }

        private void passwordTxtBox(object sender, EventArgs e)
        {

        }
        //Schedule page
        private void scheduleDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        List<Section> fullSectionList;
        List<Registration> registrations;
        private void scheduleQueryChanged(object sender, EventArgs e)
        {
            if(fullSectionList == null)
            {
                if(activeActor == SystemActors.Professor)
                {
                    fullSectionList = user.Connection.BuildClassArray<Section>(new SqlParameter[]
                        {
                            new System.Data.SqlClient.SqlParameter("InstructorID",user.EnterpriseID)
                        }, Tables.Section);
                }
                else if(activeActor == SystemActors.Student)
                {
                    if(registrations == null)
                    {

                        RefreshRegistrations();
                    }
                    fullSectionList = new List<Section>();
                    foreach(var registration in registrations)
                    {
                        fullSectionList.Add(user.Connection.BuildClass<Section>(new SqlParameter[]
                        {
                            new SqlParameter("ID",registration.SectionID)
                        }, Tables.Section));
                    }
                    string filter = scheduleYearComboBox.SelectedValue.ToString();
                    if (filter != "All")
                        fullSectionList.RemoveAll((Section s) => {
                            return s.StartDate.Year.ToString() != filter; });
                    filter = scheduleSemesterComboBox.SelectedValue.ToString();
                    filter = user.Connection.GetValue("ID", new SqlParameter[]
                    {
                        new SqlParameter("SemesterName",filter)
                    },Tables.Semester).ToString();
                    if (filter != "All")
                        fullSectionList.RemoveAll((Section s) => {
                            return s.SemesterID.ToString() != filter;
                        });
                }
            }
            List<Section> query = //to remove object references
                new List<Section>(fullSectionList.ToArray());

            
        }
        //registration page
        private void RefreshRegistrations()
        {
            registrations = user.Connection.BuildClassArray<Registration>(new SqlParameter[]
            {
                new SqlParameter("PersonID",user.EnterpriseID)
            }, Tables.Registration);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
