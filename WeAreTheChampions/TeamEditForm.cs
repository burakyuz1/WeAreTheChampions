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
    public partial class TeamEditForm : Form
    {
        private readonly Team team;
        private readonly WACDbContext db;

        public TeamEditForm(Team team, WACDbContext db)
        {
            InitializeComponent();
            this.team = team;
            this.db = db;
            txtTeamName.Text = team.TeamName;
            Text = $"Editing: {team.TeamName}";
            GetTeamColors();

            GetAllColors();
        }

        private void GetAllColors()
        {
            foreach (var color in db.Colors)
            {
                ListViewItem lvi = new ListViewItem();
                Bitmap newbmp = new Bitmap(200, 200);
                for (int x = 0; x < newbmp.Height; x++)
                {
                    for (int y = 0; y < newbmp.Width; y++)
                    {
                        newbmp.SetPixel(x, y, System.Drawing.Color.FromArgb(color.Red, color.Green, color.Blue));
                    }
                }
                imgList.Images.Add(color.ColorName, newbmp);
                lvi.Tag = color.Id;
                lvi.ImageKey = color.ColorName;
                lvi.Text = color.ColorName;
                lsvAllColors.Items.Add(lvi);
            }
        }

        private void GetTeamColors()
        {
            lsvColorsOfTeam.Clear();
            foreach (var color in team.Colors)
            {
                ListViewItem lvi = new ListViewItem();
                Bitmap newbmp = new Bitmap(200, 200);
                for (int x = 0; x < newbmp.Height; x++)
                {
                    for (int y = 0; y < newbmp.Width; y++)
                    {
                        newbmp.SetPixel(x, y, System.Drawing.Color.FromArgb(color.Red, color.Green, color.Blue));
                    }
                }
                imgList.Images.Add(color.ColorName, newbmp);
                lvi.Tag = color.Id;
                lvi.ImageKey = color.ColorName;
                lvi.Text = color.ColorName;
                lsvColorsOfTeam.Items.Add(lvi);
            }
        }

        private void btnDeleteColorOfTeam_Click(object sender, EventArgs e)
        {
            if (lsvColorsOfTeam.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a color to delete!");
                return;
            }

            int deleteColorId = (int)lsvColorsOfTeam.SelectedItems[0].Tag;
            Models.Color deleteColor = team.Colors.FirstOrDefault(x => x.Id == deleteColorId);
            DialogResult dr = MessageBox.Show($"Are you sure about to delete {deleteColor.ColorName} from the team: {team.TeamName}?", "Warning", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                team.Colors.Remove(deleteColor);
                db.SaveChanges();

            }
            GetTeamColors();
        }

        private void btnAddColorToTeam_Click(object sender, EventArgs e)
        {
            if (lsvAllColors.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please choose a color to add.");
                return;
            }

            int selectedColorId = (int)lsvAllColors.SelectedItems[0].Tag;

            team.Colors.Add(db.Colors.FirstOrDefault(x => x.Id == selectedColorId));
            db.SaveChanges();
            GetTeamColors();

        }

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTeamName.Text))
            {
                MessageBox.Show("Team name is mandatory!");
                return;
            }
            team.TeamName = txtTeamName.Text.Trim();
            db.SaveChanges();
            Close();
        }
    }
}
