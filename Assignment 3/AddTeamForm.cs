using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class AddTeamForm : Form
    {
        public AddTeamForm()
        {
            InitializeComponent();
        }
        /*
        * Forces user to only enter numbers
        */
        private void textYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }

        /*
       * Adds a team only IF
       *   All values are entered
       *   The team has not already been added
       * Else gets a error message
       */
        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            if (!((textName.Text == "") || (textGround.Text == "") || (textCoach.Text == "") || (textLocation.Text == "")))
            {
                if (!(Global.iniVar.teamDictionary.ContainsKey(textName.Text)))
                {
                    Global.iniVar.teamDictionary.Add((textName.Text), new Team(
            textName.Text, textGround.Text, textCoach.Text, "Founded: " + textYear.Text + ", " + textLocation.Text));
                }
                else
                {
                    MessageBox.Show("A team with this name has already been added. Please try again.", "Duplicates Skipped");
                }
            }
            else
            {
                MessageBox.Show("Not all data was entered, please fill out the fill application!", "Uncompleted Application");
            }
            this.Close();
        }
    }
    
}
