using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Team
    {
        //Team object constructor
        public Team(string name, string ground, string coach, string founded) {
            Mname = name;
            Mfounded = founded;
            Mcoach = coach;
            Mground = ground;
        }

        public string GetName()
        {
            return Mname;
        }
        public string GetFounded()
        {
            return Mfounded;
        }
        public string GetCoach()
        {
            return Mcoach;
        }
        public string GetGround()
        {
            return Mground;
        }

    /*  Members */
    private string Mname {get; set;}
        private string Mfounded { get; set; }
        private string Mcoach { get; set; }
        private string Mregion { get; set; }
        private string Mground { get; set; }
    }
}
