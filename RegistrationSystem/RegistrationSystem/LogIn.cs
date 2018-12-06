﻿using System;
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
          /*if(check to see if student)
            {
                StudentView SView = new StudentView();
                SView.Show();
                Hide();
            }*/
            else
            {
                MessageBox.Show("Invaild Credentials!!");
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}