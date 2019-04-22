using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroChempionship2020
{
    class GameClass
    {
        static void PlayMatches(List<Team> teams)
        {
            for (int i = 0; i < teams.Count-1; i++)
            {
                for (int j = i+1; j < teams.Count; j++)
                {
                    teams[i].PlayWith(teams[j]);
                }
            }
        }

    }
}
