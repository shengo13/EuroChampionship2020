using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroChempionship2020.Forms
{
    public partial class GroupForm : Form
    {
        public GroupForm(Team[][] teams)
        {
            InitializeComponent();
            Teams = teams;

            FillTable(GetTeamsByColumn(Teams, 4, 0), GroupATable);
            FillTable(GetTeamsByColumn(Teams, 4, 1), GroupBTable);
            FillTable(GetTeamsByColumn(Teams, 4, 2), GroupCTable);
            FillTable(GetTeamsByColumn(Teams, 4, 3), GroupDTable);


        }

        private void FillTable(List<Team> teams, TableLayoutPanel table)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                var team = teams[i];
                var teamButton = new Button
                {
                    Text = team.Name,
                    Image = team.Flag,
                    TextImageRelation = TextImageRelation.ImageBeforeText,
                    Padding = new Padding(13),
                    Dock = DockStyle.Fill,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Bold", 13),

                };
                teamButton.FlatAppearance.BorderSize = 0;

                table.Controls.Add(teamButton);
                table.SetColumn(teamButton, 1);
                table.SetRow(teamButton, i+1);

            }
        }

        public Team[][] Teams { get; }

        List<Team> GetTeamsByColumn(Team[][] teams, int rowsCount , int columnIndex )
        {
            List<Team> result = new List<Team>();
            for (int i = 0; i < rowsCount; i++)
            {
                result.Add(teams[i][columnIndex]);
            }
            return result;

            

        }

    }
}
