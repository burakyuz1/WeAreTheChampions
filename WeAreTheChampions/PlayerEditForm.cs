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
    public partial class PlayerEditForm : Form
    {
        private readonly Player player;
        private readonly WACDbContext db;

        public PlayerEditForm(Player player, WACDbContext db)
        {
            InitializeComponent();
            this.player = player;
            this.db = db;
            Text = $"Editing: {player.PlayerName}";
            FillAllControls();
        }

        private void FillAllControls()
        {
        List<Team> teamList = db.Teams.ToList();
            txtImageLink.Text = player.ImageLink;
            txtPlayerName.Text = player.PlayerName;
            pcbPlayerAdd.ImageLocation = player.ImageLink;
            teamList.Insert(0, new Team() { TeamName = "No Team" });
            cmbPlayerChooseTeam.DisplayMember = "TeamName";
            cmbPlayerChooseTeam.DataSource = teamList;

            cmbPlayerChooseTeam.SelectedItem = player.Team == null ? teamList[0] : player.Team;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Team> teamList = db.Teams.ToList();

            player.PlayerName = txtPlayerName.Text.Trim();
            player.ImageLink = txtImageLink.Text.Trim();

            if (cmbPlayerChooseTeam.SelectedItem == null)
                player.Team = teamList[0];
            else
                player.Team = (Team)cmbPlayerChooseTeam.SelectedItem;


            db.SaveChanges();
            Close();

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            pcbPlayerAdd.ImageLocation = txtImageLink.Text.Trim();
        }
    }
}
