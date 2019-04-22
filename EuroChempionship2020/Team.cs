using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroChempionship2020
{
    public class Team
    {
        public string Name { get; set; }
        public Image Flag { get; set; }

        public int W { get; set; }
        public int D { get; set; }
        public int L { get; set; }
        public int Points { get; set; }

        internal void PlayWith(Team team)
        {
            Random random = new Random();
            GoalsScored = random.Next(0, 5);
            team.GoalsScored = random.Next(0, 5);

            if (GoalsScored < team.GoalsScored)
            {
                L++;
                PlusMinus += GoalsScored - team.GoalsScored;
            }
            else if (GoalsScored == team.GoalsScored)
            {
                D++;
                Points++;
            }
            else
            {
                W++;
                Points += 3;
                PlusMinus += GoalsScored - team.GoalsScored;
            }

        }

        public int PlusMinus { get; set; }
        public int GoalsScored { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}