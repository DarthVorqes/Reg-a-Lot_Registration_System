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
        private string userID;
        
        public Registrar(string ID)
        {
            userID = ID;
            InitializeComponent();
            UserViewComboBox_Load(ID);
        }
        
        /// <summary>
        /// A combo box to change user views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        /// loads values into the UserView combo box
        /// </summary>
        private void UserViewComboBox_Load(string ID)
        {
            UserViewComboBox.Items.Add("Student");
            //check login id to see if they have professor rights
            if (ID == "Max" || ID == "Ian")
            {
                UserViewComboBox.Items.Add("Professor");
            }
            //check login id to see if they have registar rights
            if (ID == "Ian")
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
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdatePersonalInformation update = new UpdatePersonalInformation(userID);
            update.Show();
        }

        private void CourseListBox_Load()
        {
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

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            
            MessageBoxButtons confirm = MessageBoxButtons.YesNo;
           
            DialogResult result;
            result = MessageBox.Show("are you sure you want to delete", "Delete", confirm);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                //delete shit
            }

        }
    }
}
