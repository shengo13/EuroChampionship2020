using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroChampionship.Forms
{
    public partial class PlayoffsForm : Form
    {
        public PlayoffsForm(List<Team> qualified)
        {
            InitializeComponent();
            Qualified = qualified;
            var quarters = new List<TableLayoutPanel>
            {
                Quarters1,
                Quarters2,
                Quarters3,
                Quarters4
            };

            FillTable(Qualified, Quarters1);
            FillTable(Qualified, Quarters2);
            FillTable(Qualified, Quarters3);
            FillTable(Qualified, Quarters4);
        }
        List<Team> Qualified { get; }

        private void FillTable(List<Team> teams, TableLayoutPanel table)
        {
            for (int i = 0; i < 2; i++)
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
                table.SetColumn(teamButton, 0);
                table.SetRow(teamButton, i);
            }
        }

        #region TLP List
        //private void FillTable(List<Team> teams, List<TableLayoutPanel> table)
        //{
        //    for (int i = 0; i < teams.Count; i++)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            var team = teams[i];
        //            var teamButton = new Button
        //            {
        //                Text = team.Name,
        //                Image = team.Flag,
        //                TextImageRelation = TextImageRelation.ImageBeforeText,
        //                Padding = new Padding(13),
        //                Dock = DockStyle.Fill,
        //                FlatStyle = FlatStyle.Flat,
        //                Font = new Font("Bold", 13),
        //            };
        //            teamButton.FlatAppearance.BorderSize = 0;

        //            table[j].Controls.Add(teamButton);
        //            table[j].SetColumn(teamButton, 0);
        //            table[j].SetRow(teamButton, 1);
        //        }
        //    }
        //}
        #endregion
    }
}