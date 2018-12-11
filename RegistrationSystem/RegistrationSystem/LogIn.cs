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
        public string ID { get; private set; }

        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

         /*   if (check to see if registar)
            {
                RegistarView RView = new RegistarView(ID);
                RView.Show();
                Hide();
            }*/

            //check to see if professor:
            if (UserNameTextBox.Text == "Max" || UserNameTextBox.Text == "Al")
            {
                //if personID as username this will be fine if not then just search data base for the id linked to the username
                ID = UserNameTextBox.Text;
                ProfessorView PView = new ProfessorView(ID);
                PView.Show();
                Hide();
            }
            //
          if(UserNameTextBox.Text == "Trey")
            {
                ID = UserNameTextBox.Text;
                studentView SView = new studentView();
                SView.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Invaild Credentials!!");
            }


            bool login = false;
                /*   if (check to see if registar)
                   {
                       //if personID as username this will be fine if not then just search data base for the id linked to the username
                       ID = UserNameTextBox.Text;
                       login = true;
                       RegistarView RView = new RegistarView(ID);
                       RView.Show();
                       Hide();
                   }
                //check to see if professor:
                if (UserNameTextBox.Text == "Max")
                {
                    //if personID as username this will be fine if not then just search data base for the id linked to the username
                    ID = UserNameTextBox.Text;
                    login = true;
                    ProfessorView PView = new ProfessorView(ID);
                    PView.Show();
                    Hide();
                }
                if (UserNameTextBox.Text == "Trey")
                {
                    //if personID as username this will be fine if not then just search data base for the id linked to the username
                    ID = UserNameTextBox.Text;
                    login = true;
                    studentView SView = new studentView();
                    SView.Show();
                    Hide();
                }
                if (login == false)
                {
                    MessageBox.Show("Invaild Credintials!!");
                }
                */

        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
