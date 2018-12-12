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
    partial class LogIn : Form
    {

         public static  User user = new User();

        public LogIn()
        {
            InitializeComponent();
        }
        public void LogInButton_Click(object sender, EventArgs e)
        {
            int.TryParse(UserNameTextBox.Text, out int UserID);
            int ID = UserID;
            if (user.Authenticate(UserID, PasswordTextBox.Text))
            {
                if (user.IsRegistrar)
                {
                    Registrar RView = new Registrar();
                    RView.Show();
                    Hide();
                }
                else if (user.IsProfessor)
                { 
                    ProfessorView PView = new ProfessorView();
                    PView.Show();
                    Hide();
                }
                else if (user.IsStudent)
                {
                    StudentView SView = new StudentView();
                    SView.Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Invaild credentials!!");
            }


        }

    }
}
