using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroChempionship2020
{
    public static class Extention
    {
        static Random random = new Random();

        public static List<Team> PlayMatches(this List<Team> teams)
        {
            for (int i = 0; i < teams.Count - 1; i++)
            {
                for (int j = i + 1; j < teams.Count; j++)
                {                  
                    teams[i].PlayWith(teams[j]);
                }
            }
            return teams;
        }

        public static List<Team> ResetResults(this List<Team> teams)
        {
            foreach (var team in teams)
            {
                team.Reset();
            }
            return teams;
        }

        public static void Shuffle<T>(this IList<T> source)
        {
            int count = source.Count;
            for (int i = 0; i < count/2; i++)
            {
                int first = random.Next(0, count);
                int second;

                while (first == (second = random.Next(0, count))) ;

                T temp = source[first];
                source[first] = source[second];
                source[second] = temp; 
              
            }
        }
    }
}
