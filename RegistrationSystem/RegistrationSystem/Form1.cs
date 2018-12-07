using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//alright
namespace RegistrationSystem
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Trey" && radioButton1.Checked)
            {
                studentView Sview = new studentView();
                Sview.Show();
                Hide();
            }

            if (textBox1.Text == "Max" && radioButton2.Checked)
            {
                ProfessorView PView = new ProfessorView();
                PView.Show();
                Hide();
            }

            if (textBox1.Text == "Max" && radioButton3.Checked)
            {
                string message = "You are not a registrar.";
                string caption = "Authentification Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);
            }
        }

    }
}
