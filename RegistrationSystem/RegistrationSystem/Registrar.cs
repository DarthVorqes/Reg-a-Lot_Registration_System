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
            if (ID == "Max")
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
            LogIn logout = new LogIn();
            logout.Show();
            Close();
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
    }
}
