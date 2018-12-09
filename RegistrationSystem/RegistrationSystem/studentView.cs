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
        string userID;
        public studentView(string ID)
        {
            userID = ID;
            InitializeComponent();
            comboBox1_Load(ID);
        }
        /// <summary>
        /// loads values into the UserView combo box
        /// </summary>
        private void comboBox1_Load(string ID)
        {
            comboBox1.Items.Add("Student");
            //check login id to see if they have professor rights
            if (ID == "Max" || ID == "Ian")
            {
                comboBox1.Items.Add("Professor");
            }
            //check login id to see if they have registar rights
            if (ID == "Ian")
            {
                comboBox1.Items.Add("Registar");
            }

        }
        /// <summary>
        /// A combo box to change user views
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProfessorView Professor = new ProfessorView(userID);
            studentView Student = new studentView(userID);
            Registrar Registar = new Registrar(userID);
            if ((string) comboBox1.SelectedItem == "Student")
            {
                Student.Show();
                Close();
            }
            if ((string)comboBox1.SelectedItem == "Professor")
            {
                Professor.Show();
                Close();
            }
            if ((string)comboBox1.SelectedItem == "Registar")
            {
                Registar.Show();
                Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
