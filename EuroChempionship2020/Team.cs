using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroChampionship
{
    public class Team
    {
        static Random random = new Random();
        public string Name { get; set; }
        public Image Flag { get; set; }

        public int W { get; set; }
        public int D { get; set; }
        public int L { get; set; }
        public int Points { get; set; }
        public int PlusMinus { get; set; }
        public int GoalsScored { get; set; }

        public void Reset()
        {
            W = 0;
            D = 0;
            L = 0;
            Points = 0;
            PlusMinus = 0;
            GoalsScored = 0;
        }

        internal void PlayWith(Team team)
        {
            GoalsScored = random.Next(0, 5);
            team.GoalsScored = random.Next(0, 5);

            if (GoalsScored < team.GoalsScored)
            {
                L++;
                team.W++;
                team.Points += 3;
                team.PlusMinus += team.GoalsScored - GoalsScored;
                PlusMinus += GoalsScored - team.GoalsScored;
            }
            else if (GoalsScored == team.GoalsScored)
            {
                D++;
                Points++;
                team.D++;
                team.Points++;
            }
            else
            {
                W++;
                Points += 3;
                PlusMinus += GoalsScored - team.GoalsScored;

                team.L++;
                team.PlusMinus += team.GoalsScored - GoalsScored;
            }

        }



        public override string ToString()
        {
            return Name;
        }
    }
}