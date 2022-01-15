using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.Context;
using WeAreTheChampions.Models;

namespace WeAreTheChampions
{
    public partial class MainForm : Form
    {
        WACDbContext db = new WACDbContext();
        List<Models.Color> teamColorList = new List<Models.Color>();
        List<string> teamColorNames = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            LoadColors();
            LoadTeams();
            LoadPlayers();
            LoadExhibitions();
            pcbHome.Paint += PcbHome_Paint;
            pcbAway.Paint += PcbAway_Paint;
            pcbAway.Image = null;
            pcbHome.Image = null;
        }

        private void PcbAway_Paint(object sender, PaintEventArgs e)
        {
            if (dgvExhibitions.SelectedRows.Count == 0) return;
            int matchId = (int)dgvExhibitions.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.FirstOrDefault(x => x.Id == matchId);
            Team team2 = match.Team2;
            int team2ColorQuantity = team2.Colors.Count();
            float team2PerColor = pcbAway.Width / team2ColorQuantity;
            float sayacT2 = 0;



            foreach (var item in team2.Colors)
            {
                var pcHome = sender as PictureBox;
                var g = e.Graphics;
                g.FillRectangle(new SolidBrush(System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue)), sayacT2, 0, team2PerColor, 50);
                sayacT2 += team2PerColor;
            }

        }

        private void LoadExhibitions()
        {
            dgvExhibitions.DataSource = db.Matches.AsEnumerable().Select(x => new
            {
                Id = x.Id,
                Date = x.MatchTime.ToShortDateString(),
                HomeTeam = x.Team1.TeamName,
                AwayTeam = x.Team2.TeamName,
                Score = x.Score1 + " - " + x.Score2,
                Result = x.Result

            }).ToList();
            dgvExhibitions.Columns[0].Visible = false;
        }

        private void LoadPlayers()
        {
            lstPlayers.DataSource = db.Players.ToList();
            lstPlayers.DisplayMember = "PlayerName";
        }

        private void LoadTeams()
        {
            lstTeams.DisplayMember = "TeamName";
            List<Team> teamsForSort = db.Teams.ToList();
            List<Team> teamsForAdd = db.Teams.ToList();
            cmbPlayerChooseTeam.DisplayMember = "TeamName";
            teamsForAdd.Insert(0, new Team() { TeamName = "No Team" });
            teamsForSort.Insert(0, new Team() { TeamName = "No Team" });
            teamsForSort.Insert(0, new Team() { TeamName = "All Teams" });
            lstTeams.DataSource = teamsForAdd;
            cmbPlayerChooseTeam.DataSource = teamsForAdd;
            cmbTeamSort.DisplayMember = "TeamName";
            cmbTeamSort.DataSource = teamsForSort;
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtColorName.Text))
            {
                MessageBox.Show("Please fill the Color Name area!");
                return;
            }

            Models.Color color = new Models.Color()
            {
                ColorName = txtColorName.Text.Trim(),
                Red = (byte)nmuRed.Value,
                Green = (byte)nmuGreen.Value,
                Blue = (byte)nmuBlue.Value
            };
            db.Colors.Add(color);
            db.SaveChanges();
            MessageBox.Show($"{color.ColorName} added succesfully!");
            LoadColors();
            ClearColorArea();
        }

        private void ClearColorArea()
        {
            txtColorName.Text = "";
            nmuRed.Value = 0;
            nmuGreen.Value = 0;
            nmuBlue.Value = 0;
            pcbColor.Image = null;
        }

        private void LoadColors()
        {
            lsvColors.Clear();
            lsvColorOfTeam.Clear();
            if (db.Colors.Count() == 0)
            {
                return;
            }
            foreach (var color in db.Colors)
            {
                ListViewItem lvi = new ListViewItem();
                Bitmap newbmp = new Bitmap(200, 200);
                for (int x = 0; x < newbmp.Height; x++)
                    for (int y = 0; y < newbmp.Width; y++)
                        newbmp.SetPixel(x, y, System.Drawing.Color.FromArgb(color.Red, color.Green, color.Blue));
                imgList.Images.Add(color.ColorName, newbmp);
                lvi.Tag = color.Id;
                lvi.ImageKey = color.ColorName;
                lvi.Text = color.ColorName;
                lsvColors.Items.Add(lvi);
                lsvColorOfTeam.Items.Add((ListViewItem)lvi.Clone());
            }

        }

        private void nmuRed_ValueChanged(object sender, EventArgs e)
        {
            int red = (int)nmuRed.Value;
            int green = (int)nmuGreen.Value;
            int blue = (int)nmuBlue.Value;
            pcbColor.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void lsvColors_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int colorId = (int)lsvColors.SelectedItems[0].Tag;

            Models.Color color = db.Colors.FirstOrDefault(x => x.Id == colorId);

            ColorEditForm cef = new ColorEditForm(color, db);
            cef.ShowDialog();
            LoadColors();
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeamAddName.Text))
            {
                MessageBox.Show("You should fill the Team Name area!");
                return;
            }
            Team team = new Team()
            {
                TeamName = txtTeamAddName.Text.Trim(),
                Colors = teamColorList
            };
            db.Teams.Add(team);
            foreach (var item in team.Colors)
            {
                teamColorNames.Add(item.ColorName);
            }
            string fullListOfTeamColors = string.Join(", ", teamColorNames);
            MessageBox.Show($"{team.TeamName} created succesfully with colors of : {fullListOfTeamColors}");
            db.SaveChanges();
            teamColorList.Clear();
            LoadTeams();
            txtTeamAddName.Text = "";
            teamColorNames.Clear();
        }

        private void btnAddColorToTeam_Click(object sender, EventArgs e)
        {
            if (lsvColorOfTeam.SelectedItems.Count == 0 || txtTeamAddName.Text == "")
            {
                MessageBox.Show("Color and Team Name is mandatory!");
                return;
            }
            int colorId = (int)lsvColorOfTeam.SelectedItems[0].Tag;
            Models.Color selectedColor = db.Colors.FirstOrDefault(x => x.Id == colorId);

            teamColorList.Add(selectedColor);
            MessageBox.Show($"{selectedColor.ColorName} is added succesfully to team {txtTeamAddName.Text}");
        }

        private void btnTeamUpdate_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex == 0) return;
            Team selectedTeam = (Team)lstTeams.SelectedItem;

            TeamEditForm tef = new TeamEditForm(selectedTeam, db);
            tef.ShowDialog();
            LoadTeams();
        }

        private void btnTeamDelete_Click(object sender, EventArgs e)
        {
            if (lstTeams.SelectedIndex == 0) return;
            if (lstTeams.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a team to delete");
                return;
            }
            Team deleteTeam = (Team)lstTeams.SelectedItem;

            if (deleteTeam.Players != null && deleteTeam.Players.Count > 0)
            {
                DialogResult dr1 = MessageBox.Show($"This team has {deleteTeam.Players.Count} players.\nAfter you delete all players will be teamless. Would you like to continue?", "Warning", MessageBoxButtons.YesNo);
                if (dr1 == DialogResult.Yes)
                {
                    db.Teams.Remove(deleteTeam);
                    db.SaveChanges();
                }
            }
            else
            {
                DialogResult dr = MessageBox.Show($"Are you sure about to delete {deleteTeam.TeamName}", "Warning", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    db.Teams.Remove(deleteTeam);
                    db.SaveChanges();
                }
            }


            LoadTeams();

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtImageLink.Text))
            {
                MessageBox.Show("Please enter a image link!");
                return;
            }

            string imageLink = txtImageLink.Text.Trim();
            try
            {
                pcbPlayerAdd.Load(imageLink);
            }
            catch (Exception)
            {
                pcbPlayerAdd.Load("https://lh4.googleusercontent.com/Npzt0f37WqQKKgbNKCTzo52qLMvJygsyTPS-JuJhWQKvrm--NoVEAhxJQJaumXCINZjTyQS7H2FZYfXTSi8qau1_9HpQi_OIJH93xqUwMlD0bNj4w67l1WzfV66Rc8R2jlvlujBuqm4");
            }
            cmbPlayerChooseTeam.SelectedIndex = 0;
        }

        private void btnPlayerAdd_Click(object sender, EventArgs e)
        {
            string imageLink = txtImageLink.Text.Trim();
            string playerName = txtPlayerName.Text.Trim();
            Team selectedTeam = (Team)cmbPlayerChooseTeam.SelectedItem;
            if (imageLink == "" || playerName == "" || selectedTeam == null)
            {
                MessageBox.Show("Please fill all controls");
                return;
            }

            if (cmbPlayerChooseTeam.SelectedIndex == 0)
            {
                selectedTeam = null;
            }

            Player player = new Player()
            {
                ImageLink = imageLink,
                PlayerName = playerName,
                Team = selectedTeam
            };

            db.Players.Add(player);
            db.SaveChanges();
            string messageTeam = selectedTeam == null ? "No Team" : selectedTeam.TeamName;
            MessageBox.Show($"{player.PlayerName} added succesfully to team of {messageTeam}");
            ClearAddPlayerArea();
            LoadPlayers();
        }

        private void ClearAddPlayerArea()
        {
            pcbPlayerAdd.Image = null;
            txtPlayerName.Text = "";
            txtImageLink.Text = "";
            cmbPlayerChooseTeam.SelectedIndex = 0;
        }

        private void cmbTeamSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team sortTeam = (Team)cmbTeamSort.SelectedItem;
            if (cmbTeamSort.SelectedIndex == 0) //all teams
                lstPlayers.DataSource = db.Players.ToList();
            else if (cmbTeamSort.SelectedIndex == 1) //no team
                lstPlayers.DataSource = db.Players.Where(x => x.Team == null).ToList();
            else // specific id
                lstPlayers.DataSource = db.Players.Where(x => x.Team.Id == sortTeam.Id).ToList();
        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player selectedPlayer = (Player)lstPlayers.SelectedItem;

            lblPlayerName.Text = selectedPlayer.PlayerName;
            lblPlayerTeam.Text = selectedPlayer.Team == null ? "NO TEAM" : selectedPlayer.Team.TeamName;
            try
            {
                pcbPlayerInfo.Load(selectedPlayer.ImageLink);
            }
            catch (Exception)
            {
                pcbPlayerInfo.Load("https://lh4.googleusercontent.com/Npzt0f37WqQKKgbNKCTzo52qLMvJygsyTPS-JuJhWQKvrm--NoVEAhxJQJaumXCINZjTyQS7H2FZYfXTSi8qau1_9HpQi_OIJH93xqUwMlD0bNj4w67l1WzfV66Rc8R2jlvlujBuqm4");
            }

        }

        private void btnPlayerUpdate_Click(object sender, EventArgs e)
        {
            Player selectedPlayer = (Player)lstPlayers.SelectedItem;
            PlayerEditForm pef = new PlayerEditForm(selectedPlayer, db);
            pef.ShowDialog();
            LoadPlayers();
            lstPlayers.SelectedItem = selectedPlayer;
        }

        private void btnPlayerDelete_Click(object sender, EventArgs e)
        {
            Player deletePlayer = (Player)lstPlayers.SelectedItem;
            DialogResult dr = MessageBox.Show($"Are you sure to delete {deletePlayer.PlayerName}?", "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                db.Players.Remove(deletePlayer);
            db.SaveChanges();
            LoadPlayers();
            lstPlayers.SelectedItem = deletePlayer;
        }

        private void btnPlayerTransfer_Click(object sender, EventArgs e)
        {
            Player selectedPlayer = (Player)lstPlayers.SelectedItem;
            TransferForm tf = new TransferForm(selectedPlayer, db);
            tf.ShowDialog();
            LoadPlayers();
            LoadTeams();
            lstPlayers.SelectedItem = selectedPlayer;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deletedColorId = (int)lsvColors.SelectedItems[0].Tag;
            Models.Color color = db.Colors.FirstOrDefault(x => x.Id == deletedColorId);
            DialogResult dr = MessageBox.Show($"{color.ColorName} will delete! Are you sure?", "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                db.Colors.Remove(color);
                db.SaveChanges();
            }
            LoadColors();
        }

        private void lstTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsvPlayersOfTeam.Items.Clear();
            Team selectedTeam = lstTeams.SelectedItem as Team;
            gbPlayersOfTeam.Text = $"Players of {selectedTeam.TeamName}. Press 'DEL' to FIRE a player!";
            List<Player> teamPlayers = new List<Player>();
            if (selectedTeam.Id == 0) //takımsız biri geliyor demektir
                teamPlayers = db.Players.Where(x => x.Team == null).ToList();
            else
            {
                if (selectedTeam.Players != null)
                {
                    teamPlayers = selectedTeam.Players.ToList();

                }
            }


            foreach (Player player in teamPlayers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = player.PlayerName;
                lvi.Tag = player;

                PictureBox pb = new PictureBox();
                try
                {
                    pb.Load(player.ImageLink);
                }
                catch (Exception)
                {
                    pb.Load("https://lh4.googleusercontent.com/Npzt0f37WqQKKgbNKCTzo52qLMvJygsyTPS-JuJhWQKvrm--NoVEAhxJQJaumXCINZjTyQS7H2FZYfXTSi8qau1_9HpQi_OIJH93xqUwMlD0bNj4w67l1WzfV66Rc8R2jlvlujBuqm4");
                }

                Image img = pb.Image;
                Bitmap btm = new Bitmap(img, new Size(100, 100));
                imgPlayers.Images.Add(player.PlayerName, btm);
                lvi.ImageKey = player.PlayerName;
                lsvPlayersOfTeam.Items.Add(lvi);

            }
        }

        private void lsvPlayersOfTeam_KeyDown(object sender, KeyEventArgs e)
        {

            Player selectedPlayerOfTeam = (Player)lsvPlayersOfTeam.SelectedItems[0].Tag;


            if (e.KeyCode == Keys.Delete)
            {

                if (selectedPlayerOfTeam.Team == null)
                {
                    MessageBox.Show($"The player {selectedPlayerOfTeam.PlayerName} has not got a team already.\nIf you want to delete, go player tab.");
                }
                else
                {
                    DialogResult dr = MessageBox.Show($"Are you sure to fire {selectedPlayerOfTeam.PlayerName}?", "Warning", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        selectedPlayerOfTeam.Team = null;
                        db.SaveChanges();
                    }
                }
            }

            LoadTeams();
        }

        private void btnNewExhibition_Click(object sender, EventArgs e)
        {
            AddExhibitionForm aef = new AddExhibitionForm(db);
            aef.ShowDialog();
            LoadExhibitions();
        }


   

        private void PcbHome_Paint(object sender, PaintEventArgs e)
        {
            if (dgvExhibitions.SelectedRows.Count == 0) return;
            int matchId = (int)dgvExhibitions.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.FirstOrDefault(x => x.Id == matchId);
            Team team2 = match.Team2;

            Team team1 = match.Team1;
            int team1ColorQuantity = team1.Colors.Count();


            float team1PerColor = pcbHome.Width / team1ColorQuantity;

            float sayacT1 = 0;




            foreach (var item in team1.Colors)
            {
                var pcHome = sender as PictureBox;
                var g = e.Graphics;
                g.FillRectangle(new SolidBrush(System.Drawing.Color.FromArgb(item.Red, item.Green, item.Blue)), sayacT1, 0, team1PerColor, 50);
                sayacT1 += team1PerColor;
            }


        }

        private void PaintPcbWithTeamColors(Team team1, Team team2)
        {
            int team1ColorQuantity = team1.Colors.Count();
            int team2ColorQuantity = team2.Colors.Count();


            decimal team1PerColor = pcbHome.Width / team1ColorQuantity;
            decimal team2PerColor = pcbAway.Width / team2ColorQuantity;


        }

        private void btnDeleteMatch_Click(object sender, EventArgs e)
        {
            int matchId = (int)dgvExhibitions.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.FirstOrDefault(x => x.Id == matchId);

            DialogResult dr = MessageBox.Show("Are you sure about the delete selected exhibition?", "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                db.Matches.Remove(match);
                db.SaveChanges();

            }
            LoadExhibitions();
            ClearExhibitionArea();

        }

        private void ClearExhibitionArea()
        {
            lblMatchDate.Text = "";
            lblAwayScore.Text = "";
            lblHomeScore.Text = "";
            lblHomeTeamName.Text = "";
            lblAwayTeamName.Text = "";
            pcbAway.Image = null;
            pcbHome.Image = null;

        }

        private void btnUpdateMatch_Click(object sender, EventArgs e)
        {
            int matchId = (int)dgvExhibitions.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.FirstOrDefault(x => x.Id == matchId);
            AddExhibitionForm aef = new AddExhibitionForm(match, db);
            aef.ShowDialog();
            LoadExhibitions();
        }



        private void dgvExhibitions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExhibitions.SelectedRows.Count == 0)
            {
                return;
            }
            int matchId = (int)dgvExhibitions.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.FirstOrDefault(x => x.Id == matchId);

            lblHomeTeamName.Text = match.Team1.TeamName;
            lblAwayTeamName.Text = match.Team2.TeamName;
            lblHomeScore.Text = match.Score1.ToString();
            lblAwayScore.Text = match.Score2.ToString();
            lblMatchDate.Text = match.MatchTime.ToShortDateString();
            pcbHome.Refresh();
            pcbAway.Refresh();
        }

    
    }
}
