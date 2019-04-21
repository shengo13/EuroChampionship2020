using System.Drawing;

namespace EuroChampionship
{
   public class Team
    {
        public string Name { get; set; } = "Team X";
        public Image Flag { get; set; }
        public int W { get; set; } = 0;
        public int D { get; set; } = 0;
        public int L { get; set; } = 0;
        public int Points { get; set; } = 0;
        public int PlusMinus { get; set; } = 0;
        public int Goals { get; set; } = 0;

        public override string ToString()
        {
            return Name;
        }
    }

}
