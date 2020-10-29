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

    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
        }
        /*
         * Converts all the objects of player and team type, stored in their dictionaries, into ListViewItems
         * Adds the The Items to the ListViewBoxs
       */
        private void ListViewLoader()
        {
            listViewPlayers.Items.Clear();
            listViewTeam.Items.Clear();
            Dictionary<int, ListViewItem> playerslistDictionary = new Dictionary<int, ListViewItem>();
            playerslistDictionary.Clear();
            int i = 0;
            foreach (var item in Global.iniVar.playersDictionary)
            {
                playerslistDictionary.Add(i, new ListViewItem(Convert.ToString(item.Value.GetId())));
                playerslistDictionary[i].SubItems.Add(item.Value.GetFName());
                playerslistDictionary[i].SubItems.Add(item.Value.GetSName());
                playerslistDictionary[i].SubItems.Add(item.Value.GetBirthDate());
                playerslistDictionary[i].SubItems.Add((Convert.ToString(item.Value.GetHeight())));
                playerslistDictionary[i].SubItems.Add(Convert.ToString(item.Value.GetWeight()));
                playerslistDictionary[i].SubItems.Add(item.Value.GetBirthPlace());
                playerslistDictionary[i].SubItems.Add(item.Value.GetTeam());
                i++;
            }
            for (i = 0; i < playerslistDictionary.Count; i++)
            {
                listViewPlayers.Items.Add(playerslistDictionary[i]);
            }

            Dictionary<int, ListViewItem> teamlistDictionary = new Dictionary<int, ListViewItem>();
            teamlistDictionary.Clear();
            i = 0;
            foreach (var item in Global.iniVar.teamDictionary)
            {
                teamlistDictionary.Add(i, new ListViewItem(item.Value.GetName()));
                teamlistDictionary[i].SubItems.Add(item.Value.GetGround());
                teamlistDictionary[i].SubItems.Add(item.Value.GetCoach());
                teamlistDictionary[i].SubItems.Add(Convert.ToString(item.Value.GetFounded ()));
                i++;
            }
            for (i = 0; i < Global.iniVar.teamDictionary.Count; i++)
            {
                listViewTeam.Items.Add(teamlistDictionary[i]);
            }
        }


        /*
          * Opens the file and extracts data into player objects
          * Error message if duplicates are found
          * Calls for ListViewLoad(); above
        */
        private void playersFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int counter = 0;
                string input;
                System.IO.StreamReader file = new System.IO.StreamReader(openFile.FileName);
                bool containsDups = false;
                while ((input = file.ReadLine()) != null)
                {
                    string[] inputSplit = input.Split(';');
                    int ID = Convert.ToInt32(inputSplit[0].Trim());
                    string fname = inputSplit[1].Trim();
                    string sname = inputSplit[2].Trim();
                    string bdate = inputSplit[3].Trim();
                    int height = Convert.ToInt32(inputSplit[4].Trim());
                    int weight = Convert.ToInt32(inputSplit[5].Trim());
                    string bplace = inputSplit[6].Trim();
                    if (!(Global.iniVar.playersDictionary.ContainsKey(ID)))
                    {
                        if (inputSplit.Length > 7)
                        {
                            string team = inputSplit[7].Trim();
                            Global.iniVar.playersDictionary.Add(ID, new Player(ID, fname, sname, bdate, height, weight, bplace, team));
                        }
                        else
                        {
                            Global.iniVar.playersDictionary.Add(ID, new Player(ID, fname, sname, bdate, height, weight, bplace));
                        }
                    }
                    else
                    {
                        containsDups = true;
                    }
                    counter++;
                }
                if (containsDups)
                {
                    MessageBox.Show("The file contains duplicates. Some duplicate teams have been skipped", "Duplicates Skipped");
                }
                file.Close();
                ListViewLoader();
            }
        }

        /*
          * Opens the file and extracts data into team objects
          * Error message if duplicates are found
          * Calls for ListViewLoad(); above
        */
        private void teamFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bool containsDups = false;
                int counter = 0;
                string input;
                System.IO.StreamReader file = new System.IO.StreamReader(openFile.FileName);
                while ((input = file.ReadLine()) != null)
                {
                    string[] inputSplit = input.Split(';');
                    string name = inputSplit[0];
                    string ground = inputSplit[1];
                    string coach = inputSplit[2];
                    string founded = inputSplit[3];
                    if (!(Global.iniVar.teamDictionary.ContainsKey(name)))
                    {
                        Global.iniVar.teamDictionary.Add(name, new Team(name, ground, coach, founded));
                    } else
                    {
                        containsDups = true;
                    }
                    counter++;            
                }
                if (containsDups)
                {
                    MessageBox.Show("The file contains duplicates. Some duplicate teams have been skipped", "Duplicates Skipped");
                }
                file.Close();
                ListViewLoader();
            }
        }

        /*
          * Opens Add Player Form
          * Loads ListViewLoad(); above
        */
        private void addNewPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPlayerForm addPlayer = new AddPlayerForm();
            addPlayer.ShowDialog();
            ListViewLoader();
        }

        /*
           * Opens Add Team Form
           * Loads ListViewLoad(); above
        */
        private void addNewTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeamForm addTeam = new AddTeamForm();
            addTeam.ShowDialog();
            ListViewLoader();
        }

        /*
          * Opens Sign Player Form
          * Loads ListViewLoad(); above
       */
        private void signAPlayerToATeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignPlayer Sign = new SignPlayer();
            Sign.ShowDialog();
            ListViewLoader();
        }

        /*
          * If a user double clicks a team.
          * Displays Players in that team in the PlayerListViewBox
       */
        private void listViewTeam_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewTeam.HitTest(e.X, e.Y);
            ListViewItem item = info.Item;
            textSearch.Text = item.Text;
            radioTeamName.Checked = true;
            buttonSearch_Click(sender, e);
        }

        /*
          * Uses data in textSearch and from the radio buttons to carry out a search
          * Age is for years players is old (Rounded Down), in textSearch
          * Birth Place shows players with birthplaces containing the text in textSearch
          * Team shows players in the team, exactly given in textSearch
       */
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            if (radioAge.Checked == true)
            {
                foreach (ListViewItem item in listViewPlayers.Items)
                {
                    DateTime now = DateTime.Today;
                    string[] DateSplit = item.SubItems[3].Text.Split('/');
                    int day = Convert.ToInt32(DateSplit[0]);
                    int month = Convert.ToInt32(DateSplit[1]);
                    int year = Convert.ToInt32(DateSplit[2]);
                    DateTime birthday = new DateTime(year, month, day);
                    int age = now.Year - birthday.Year;
                    if (now < birthday.AddYears(age)) age--;
                    if(!(Convert.ToString(age) == textSearch.Text))
                    {
                        item.Remove();
                    }
                }
            }
            if (radioBPlace.Checked == true)
            {
                foreach (ListViewItem item in listViewPlayers.Items)
                {
                    if (!(item.SubItems[6].Text.Contains(textSearch.Text)))
                    {
                        item.Remove();
                    }
                }
            }
            if (radioTeamName.Checked == true)
            {
                foreach (ListViewItem item in listViewPlayers.Items)
                {
                    if(!(item.SubItems[7].Text == textSearch.Text))
                    {
                        item.Remove();
                    }  
                }

            }
        }


        /*
          * Resets the listviews, searchText and radio buttons after a search
       */
        private void buttonShow_Click(object sender, EventArgs e)
        {
            textSearch.Text = "";
            radioAge.Checked = false;
            radioBPlace.Checked = false;
            radioTeamName.Checked = false;
            ListViewLoader();
        }

       /*
        * Saves players to a file, including team data
        */
        private void playersFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (folderSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(folderSave.SelectedPath + "\\Players.txt");
                foreach (var item in Global.iniVar.playersDictionary)
                {
                    file.WriteLine(item.Value.GetId() + "; " + item.Value.GetFName() + "; " + item.Value.GetSName() + "; " +
                        item.Value.GetBirthDate() + "; " + item.Value.GetHeight() + "; " + item.Value.GetWeight() + "; " +
                        item.Value.GetBirthPlace()+ "; "+item.Value.GetTeam());
                }
                file.Close();
            }

        }

        /*
         * Saves team to a file
         */
        private void teamFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (folderSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter(folderSave.SelectedPath + "\\Team.txt");
                foreach (var item in Global.iniVar.teamDictionary)
                {
                    file.WriteLine(item.Value.GetName() + "; " + item.Value.GetGround() + "; " + item.Value.GetCoach() + "; " +
                        item.Value.GetFounded());
                }
                file.Close();
            }
        }
    }
}
