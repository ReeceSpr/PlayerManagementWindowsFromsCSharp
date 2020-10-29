using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Player
    {
        //Player object constructor
        public Player(int id, string fname,string sname ,string birthdate, int height, int weight, string birthplace, string team="No Team Assigned")
        {
            Mid = id;
            Mfname = fname;
            Msname = sname;
            Mheight = height;
            Mweight = weight;
            Mbirthdate = birthdate;
            Mbirthplace = birthplace;
            Mteam = team;
        }
        public int GetId() {
            return Mid;
        }
        public string GetFName()
        {
            return Mfname;
        }
        public string GetSName()
        {
            return Msname;
        }
        public int GetHeight()
        {
            return Mheight;
        }
        public int GetWeight()
        {
            return Mweight;
        }
        public string GetBirthDate()
        {
            return Mbirthdate;
        }
        public string GetBirthPlace()
        {
            return Mbirthplace;
        }

        public string GetTeam()
        {
            return Mteam;
        }
        public void SignPlayer(string team)
        {
            Mteam = team;
        }

        /*  Members */
        private int Mid { get; set; }
        private string Mfname { get; set; }
        private string Msname { get; set; }
        private int Mheight { get; set; }
        private int Mweight { get; set; }
        private string Mbirthdate { get; set; }
        private string Mbirthplace { get; set; }
        private string Mteam { get; set; }
    }
}
