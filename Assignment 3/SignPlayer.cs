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
    public partial class SignPlayer : Form
    {
        public SignPlayer()
        {
            InitializeComponent();
        }

        /*
         * Forces user to only enter numbers
         */
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }

        }
        /*
        * Loads in teams available to sign to, when loading the form
        */
        private void SignPlayer_Load(object sender, EventArgs e)
        {
            foreach (var item in Global.iniVar.teamDictionary)
            {
                listTeams.Items.Add(item.Value.GetName());
            }
        }

        /*
        * Signs the player only if?
        *   ID has been filled in
        * Else gets a error message
        */
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textID.Text != "")
            {
                if (Global.iniVar.playersDictionary.ContainsKey(Convert.ToInt32(textID.Text))) {
                    Global.iniVar.playersDictionary[Convert.ToInt32(textID.Text)].SignPlayer(listTeams.Text);
                }
                else
                {
                    MessageBox.Show("The player you have entered has not been added to the program. Add the player first!", "No ID Found");
                }
            }
            else
            {
                MessageBox.Show("Please enter the players ID in order to sign them!", "No ID Filled");
            }
            this.Close();
        }
    }
}
