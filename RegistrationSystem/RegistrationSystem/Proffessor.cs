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
    public partial class ProffessorView : Form
    {
        public ProffessorView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 LogOn = new Form1();
            ProffessorView logout = new ProffessorView();
            Hide();
            LogOn.Show();
        }


    }
}
