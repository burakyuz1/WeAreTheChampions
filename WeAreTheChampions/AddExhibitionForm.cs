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
    public partial class AddExhibitionForm : Form
    {
        private readonly WACDbContext db;
        private readonly Match match;

        public AddExhibitionForm(WACDbContext db)
        {
            InitializeComponent();
            this.db = db;
            LoadTeams();

        }

        public AddExhibitionForm(Match match, WACDbContext db)
        {
            InitializeComponent();
            this.match = match;
            this.db = db;
            LoadUpdateForm();
            Text = $"Editing {match.Team1.TeamName} & {match.Team2.TeamName}";
            
        }

        private void LoadUpdateForm()
        {
            dtpMatchDate.Value = match.MatchTime;
            chkHasPlayed.Checked = match.Result == null ? false : true;
            LoadTeams();
            cmbHomeTeam.SelectedItem = match.Team1;
            cmbAwayTeam.SelectedItem = match.Team2;
            if (match.Result != null)
            {
                nmuHomeScore.Value = (int)match.Score1;
                nmuAwayScore.Value = (int)match.Score2;
            }

        }

        private void LoadTeams()
        {
            cmbAwayTeam.DataSource = db.Teams.ToList();
            cmbHomeTeam.DataSource = db.Teams.ToList();
        }

        private void chkHasPlayed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHasPlayed.Checked)
                pnlScores.Show();
            else
                pnlScores.Hide();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DateTime matchTime = dtpMatchDate.Value;
            Team homeTeam = (Team)cmbHomeTeam.SelectedItem;
            Team awayTeam = (Team)cmbAwayTeam.SelectedItem;
            if (homeTeam == awayTeam)
            {
                MessageBox.Show("Can not play same teams!");
                return;
            }
            if (this.match == null)
            {
                Match match = new Match();
                match.MatchTime = matchTime;
                match.Team1 = homeTeam;
                match.Team2 = awayTeam;

                if (chkHasPlayed.Checked) //mac oynanmıştır
                {
                    int homeScore = (int)nmuHomeScore.Value, awayScore = (int)nmuAwayScore.Value;
                    match.Score1 = homeScore;
                    match.Score2 = awayScore;
                    if (homeScore > awayScore)
                        match.Result = Enums.Result.Team1Wins;
                    else if (awayScore > homeScore)
                        match.Result = Enums.Result.Team2Wins;
                    else
                        match.Result = Enums.Result.Draw;
                }
                else
                {
                    match.Result = null;
                    match.Score1 = null;
                    match.Score2 = null;
                }
                db.Matches.Add(match);

            }
            else
            {
                match.MatchTime = matchTime;
                match.Team1 = homeTeam;
                match.Team2 = awayTeam;
                if (chkHasPlayed.Checked) 
                {
                    int homeScore = (int)nmuHomeScore.Value, awayScore = (int)nmuAwayScore.Value;
                    match.Score1 = homeScore;
                    match.Score2 = awayScore;
                    if (homeScore > awayScore)
                        match.Result = Enums.Result.Team1Wins;
                    else if (awayScore > homeScore)
                        match.Result = Enums.Result.Team2Wins;
                    else
                        match.Result = Enums.Result.Draw;
                }
                else
                {
                    match.Result = null;
                    match.Score1 = null;
                    match.Score2 = null;
                }

            }

            db.SaveChanges();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
