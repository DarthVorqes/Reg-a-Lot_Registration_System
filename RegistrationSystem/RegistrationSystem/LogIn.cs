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
    public partial class LogIn : Form
    {
        public int ID { get; private set; }

        public LogIn()
        {
            InitializeComponent();
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            User LogIn = new User();
            try
            {
                int.TryParse(UserNameTextBox.Text, out int UserID);
                ID = UserID;
                if (LogIn.Authenticate(UserID, PasswordTextBox.Text))
                {
                    if (LogIn.IsRegistrar)
                    {
                        Registrar RView = new Registrar(ID);
                        RView.Show();
                        Hide();
                    }
                    else if (LogIn.IsProfessor)
                    {
                        ProfessorView PView = new ProfessorView(ID);
                        PView.Show();
                        Hide();
                    }
                    else if (LogIn.IsStudent)
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
