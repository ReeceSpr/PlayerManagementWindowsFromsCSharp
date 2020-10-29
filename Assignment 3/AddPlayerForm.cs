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
    public partial class AddPlayerForm : Form
    {
        public AddPlayerForm()
        {
            InitializeComponent();
        }

            /*
      * Adds a player only IF
      *   All values are entered
      *   The player has not already been added
      * Else gets a error message
      */
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!((textID.Text == "") || (textFName.Text == "") || (textSName.Text == "") || (textBPlace.Text == "")))
            {
                if (!(Global.iniVar.playersDictionary.ContainsKey(Convert.ToInt32(textID.Text))))
                {
                    Global.iniVar.playersDictionary.Add(Convert.ToInt32(textID.Text), new Player(
                Convert.ToInt32(textID.Text), textFName.Text, textSName.Text, Convert.ToString(dateBDate.Value), Convert.ToInt32(numericHeight.Value), Convert.ToInt32(numericWeight.Value), textBPlace.Text));
                }
                else
                {
                    MessageBox.Show("A player with this ID has already been added. Please try again.", "Duplicates Skipped");
                }
            }
            else
            {
                MessageBox.Show("Not all data was entered, please fill out the fill application!", "Uncompleted Application");
            }
            this.Close();
        }
        /*
        * Forces user to only enter numbers
        */
        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch!=8 && ch != 46)
            {
                e.Handled = true;
            }

        }
    }
}
