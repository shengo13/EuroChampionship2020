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

        public override string ToString()
        {
            return Name;
        }
    }

}
