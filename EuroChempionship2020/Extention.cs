using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroChempionship2020
{
    public static class Extention
    {
        
        public static void Shuffle<T>(this IList<T> source)
        {
            int count = source.Count;
            var random = new Random();
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
