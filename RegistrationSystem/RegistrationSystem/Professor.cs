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
        public char grade { get; private set; }
        private List<string> studentIndex     = new List<string>() { "Jim", "gary", "mary" };
        private List<string> sectionIndex     = new List<string>() { "section1", "section2", "section3" }; 
        private int sectionIndexCount = 0;

        public ProfessorView()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Logout button, exits application for now.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logout_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        /// <summary>
        /// sets the values for the Schedule tab's combo box with sections.
        /// </summary>
        private void ScheduleComboBox_Load()
        {
            foreach (string x in sectionIndex)
            {
                sectionIndexCount++;
                ScheduleComboBox.Items.Add(x);
            }
        }
        /// <summary>
        /// sets the values for the Schedule tab's list box with students.
        /// </summary>
        private void ScheduleListBox_Load()
        {
            foreach (string student in studentIndex)
            {
                ScheduleList.Items.Add(student);

            }
        }
        /// <summary>
        /// Loads in the combo box values to the gui
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScheduleComboBox_Enter(object sender, EventArgs e)
        {
            ScheduleComboBox_Load();
        }
        /// <summary>
        /// Loads in the list box values to the gui, depending on what section you choose.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < sectionIndexCount; i++)
            {
                ScheduleList.Items.Clear();
                if (ScheduleComboBox.SelectedIndex == i)
                {
                    ScheduleListBox_Load();
                }
                
            }

        }

    }
}
