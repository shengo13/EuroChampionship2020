using EuroChempionship2020.Properties;

namespace EuroChempionship2020
{
    public class TeamData
    {
        public static Team[][] GetTeams()
        {
            Team[][] group = new Team[4][]
            {
            // Pot 1
                new Team[4]
                {
                    new Team { Name = "Spain", Flag = Resources.spain_flag_icon_32 },
                    new Team { Name = "Italy", Flag = Resources.italy_flag_icon_32 },
                    new Team { Name = "Germany", Flag = Resources.germany_flag_icon_32 },
                    new Team { Name = "France", Flag = Resources.france_flag_icon_32 },
                },
            // Pot 2
                new Team[4]
                {
                   new Team { Name = "Croatia", Flag = Resources.croatia_flag_icon_32 },
                   new Team { Name = "Portugal", Flag = Resources.portugal_flag_icon_32},
                   new Team { Name = "Netherlands", Flag = Resources.netherlands_flag_icon_32},
                   new Team { Name = "Belgium", Flag = Resources.belgium_flag_icon_32 }
                },
            // Pot 3
                 new Team[4]
                 {
                    new Team { Name = "Serbia", Flag = Resources.serbia_flag_icon_32 },
                    new Team { Name = "Iceland", Flag = Resources.iceland_flag_icon_32 },
                    new Team { Name = "Sweden", Flag = Resources.sweden_flag_icon_32 },
                    new Team { Name = "Ireland", Flag = Resources.ireland_flag_icon_32__1_ }
                 },
            // Pot 4
                new Team[4]
                {
                   new Team { Name = "Georgia", Flag = Resources.georgia_flag_icon_32 },
                   new Team { Name = "Ukraine", Flag = Resources.ukraine_flag_icon_32 },
                   new Team { Name = "Greece", Flag = Resources.greece_flag_icon_32 },
                   new Team { Name = "Poland", Flag = Resources.poland_flag_icon_32 }
                },
            };

            for (int i = 0; i < 4; i++)
                group[i].Shuffle();

            return group;
        }

    }
}
