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
        public void ShowForm()
        {
            Show();
        }
        public void HideForm()
        {
            Hide();

        }
        private void LogInButton_Click(object sender, EventArgs e)
        {

            bool login = false;
                  if (UserNameTextBox.Text == "Ian")
                   {
                       //if personID as username this will be fine if not then just search data base for the id linked to the username
                       ID = UserNameTextBox.Text;
                       login = true;
                       Registrar RView = new Registrar(ID);
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
                    studentView SView = new studentView(ID);
                    SView.Show();
                    Hide();
                }
                if (login == false)
                {
                    MessageBox.Show("Invaild Credintials!!");
                }

        }

    }
}
