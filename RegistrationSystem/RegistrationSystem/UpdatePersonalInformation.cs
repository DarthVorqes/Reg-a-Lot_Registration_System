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
    public partial class UpdatePersonalInformation : Form
    {
        int userID;
        public UpdatePersonalInformation(int ID)
        {
            userID = ID;
            InitializeComponent();
            CanComboBoxs_Load(ID);
        }
        private void CanComboBoxs_Load(int ID)
        {
            if (true)
            {
                canRegComboBox.Items.Add("Yes");
                canRegComboBox.Items.Add("No");
                CanDropComboBox.Items.Add("Yes");
                CanDropComboBox.Items.Add("No");
                CanAddComboBox.Items.Add("Yes");
                CanAddComboBox.Items.Add("No");
            }
            else
            {
                canRegComboBox.IsAccessible = false;
                CanDropComboBox.IsAccessible = false;
                CanAddComboBox.IsAccessible = false;
                canRegComboBox.Hide();
                CanDropComboBox.Hide();
                CanAddComboBox.Hide();
                CanReglbl.Hide();
                CanDroplbl.Hide();
                CanAddlbl.Hide();
            }
        }
        private void updateInfoBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string[] whatever = new string[7];

                whatever[0] = FirstNameComboBox.Text;

                whatever[1] = LastNameComboBox.Text;

                whatever[2] = addressComboBox.Text;

                whatever[3] = PhoneComboBox.Text;

                whatever[4] = FaxComboBox.Text;

                whatever[5] = IDComboBox.Text;

                whatever[6] = emailComboBox.Text;
              
                
                    if (ChangePass.Text.Length < 6)
                    {
                        MessageBox.Show("Your password is too short!");
                    }
                    if (ChangePass.Text.Equals(ChangePassCheck.Text))
                    {
                        if (ChangePass.Text.Length > 5)
                        {
                            MessageBox.Show("Your password has been changed!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords DO NOT match!");
                    }
                
                if (whatever != null)
                {
                    //update database
                    MessageBox.Show("You updated your info");
                }
            }
            catch
            {
                MessageBox.Show("you didnt put any info in");
            }
        
        }


    }
}
