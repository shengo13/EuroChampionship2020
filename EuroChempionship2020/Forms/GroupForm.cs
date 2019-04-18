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


        }

        public Team[][] Teams { get; }

        List<Team> GetTeamsByColumn(Team[][] teams, int rowsCount, int columnIndex)
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
