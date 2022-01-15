using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Context;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class TransferForm : Form
    {
        private readonly Player player;
        private readonly WACDbContext db;

        public TransferForm(Player player, WACDbContext db)
        {
            InitializeComponent();
            this.player = player;
            this.db = db;
            Text = $"Transfer of {player.PlayerName}";
            string teamName = player.Team == null ? "No Team" : player.Team.TeamName;
            lblCurrentTeam.Text = $"Current Team of {player.PlayerName}: {teamName}";

            LoadAllTeams();
        }

        private void LoadAllTeams()
        {
            List<Team> teams = db.Teams.ToList();
            if (player.Team != null)
                teams.Insert(0, new Team() { TeamName = "No Team" });

            teams.Remove(player.Team);
            lstTeams.DisplayMember = "TeamName";
            lstTeams.DataSource = teams;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int idSelected = (lstTeams.SelectedItem as Team).Id;
            if (idSelected == 0)
                player.Team = null;
            else
                player.Team = (Team)lstTeams.SelectedItem;
            db.SaveChanges();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
