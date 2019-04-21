using EuroChampionship.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EuroChampionship
{
    public partial class MainForm : Form
    {
        Team[][] teams;
        public MainForm()
        {
            InitializeComponent();
            teams = TeamData.GetTeams();

            for (int i = 0, row = i + 1; i < 4; i++, row++)
            {
                for (int j = 0, column = j; j < 4; j++, column++)
                {
                    var team = teams[j][i];
                    var teamButton = new Button
                    {
                        Text = team.Name,
                        Image = team.Flag,
                        TextImageRelation = TextImageRelation.ImageBeforeText,
                        Padding = new Padding(13),
                        Dock = DockStyle.Fill,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Bold", 13)                        
                    };
                    teamButton.FlatAppearance.BorderSize = 0;

                    teamsTable.Controls.Add(teamButton);
                    teamsTable.SetRow(teamButton, row);
                    teamsTable.SetColumn(teamButton, column);
                }
            }
        }

        private void SelectionButton_Click(object sender, EventArgs e)
        {
            var groupForm = new GroupForm(teams);
            groupForm.ShowDialog();
        }
    }
}
