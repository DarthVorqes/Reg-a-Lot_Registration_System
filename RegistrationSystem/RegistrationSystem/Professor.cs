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
    public partial class ProfessorView : Form
    {
        public ProfessorView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 LogOn = new Form1();
            ProfessorView logout = new ProfessorView();
            Hide();
            LogOn.Show();
        }


    }
}
