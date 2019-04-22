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

            var group1 = GetTeamsByColumn(Teams, 4, 0).ResetResults().PlayMatches().OrderByDescending(t => t.Points).ThenByDescending(t => t.PlusMinus).ToList();
            var group2 = GetTeamsByColumn(Teams, 4, 1).ResetResults().PlayMatches().OrderByDescending(t => t.Points).ThenByDescending(t => t.PlusMinus).ToList();
            var group3 = GetTeamsByColumn(Teams, 4, 2).ResetResults().PlayMatches().OrderByDescending(t => t.Points).ThenByDescending(t => t.PlusMinus).ToList();
            var group4 = GetTeamsByColumn(Teams, 4, 3).ResetResults().PlayMatches().OrderByDescending(t => t.Points).ThenByDescending(t => t.PlusMinus).ToList();

            FillTable(group1, GroupATable);
            FillTable(group2, GroupBTable);
            FillTable(group3, GroupCTable);
            FillTable(group4, GroupDTable);
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
                table.SetRow(teamButton, i + 1);

                table.GetControlFromPosition(2, i + 1).Text = team.W.ToString();
                table.GetControlFromPosition(3, i + 1).Text = team.D.ToString();
                table.GetControlFromPosition(4, i + 1).Text = team.L.ToString();
                table.GetControlFromPosition(5, i + 1).Text = team.Points.ToString();
                table.GetControlFromPosition(6, i + 1).Text = team.PlusMinus.ToString();
            }
        }

        public Team[][] Teams { get; }

        List<Team> GetTeamsByColumn(Team[][] teams, int rowsCount, int columnIndex)
        {
            List<Team> result = new List<Team>();
            for (int i = 0; i < rowsCount; i++)
                result.Add(teams[i][columnIndex]);

            return result;
        }

     
    }
}
