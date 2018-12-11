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
            
            
            try
            {
                int.TryParse(UserNameTextBox.Text, out int UserID);
                int ID = UserID;
                if (user.Authenticate(UserID, PasswordTextBox.Text))
                {
                    MessageBox.Show("Authenticated!");
                    if (user.IsRegistrar)
                    {
                        Registrar RView = new Registrar(ID);
                        RView.Show();
                        Hide();
                    }
                    else if (user.IsProfessor)
                    {
                        MessageBox.Show("here in prof");
                        ProfessorView PView = new ProfessorView();                      
                        PView.Show();                      
                        Hide();
                    }
                    else if (user.IsStudent)
                    {
                        studentView SView = new studentView(ID);
                        SView.Show();
                        Hide();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Not a vaild Username or Password!");
            }
        }

    }
}
