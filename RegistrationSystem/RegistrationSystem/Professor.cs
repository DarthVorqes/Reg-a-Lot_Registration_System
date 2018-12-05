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

        private void Logout_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void ScheduleComboBox_Load()
        {
            List<string> sectionIndex = new List<string>() { "section1", "section2", "section3" };
            List<string> studentIndex = new List<string>() { "Jim","gary","mary"};
            int sectionIndexCount = 0;
            foreach (string x in sectionIndex)
            {
                sectionIndexCount++;
                ScheduleComboBox.Items.Add(x);
                //Meh
                if (ScheduleComboBox.SelectedIndex == sectionIndexCount)
                {
                    foreach(string student in studentIndex)
                    ScheduleList.Items.Add(student);
                }
            }
    
        }

    }
}
