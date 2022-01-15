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

namespace WeAreTheChampions
{
    public partial class ColorEditForm : Form
    {
        private readonly Models.Color color;
        private readonly WACDbContext db;

        public ColorEditForm(Models.Color color, WACDbContext db)
        {
            InitializeComponent();

            this.color = color;
            this.db = db;
            FillAllControls();
            Text = $"Editing {color.ColorName}";

        }

        private void FillAllControls()
        {
            txtColorName.Text = color.ColorName;
            nmuRed.Value = color.Red;
            nmuBlue.Value = color.Blue;
            nmuGreen.Value = color.Green;
            pcbColor.BackColor = System.Drawing.Color.FromArgb(color.Red, color.Green, color.Blue);
        }

        private void nmuBlue_ValueChanged(object sender, EventArgs e)
        {
            pcbColor.BackColor = System.Drawing.Color.FromArgb((int)nmuRed.Value, (int)nmuGreen.Value, (int)nmuBlue.Value);
        }

        private void btnSaveColor_Click(object sender, EventArgs e)
        {
            color.ColorName = txtColorName.Text.Trim();
            color.Red = (byte)nmuRed.Value;
            color.Green = (byte)nmuGreen.Value;
            color.Blue = (byte)nmuBlue.Value;

            db.SaveChanges();
            Close();
        }
    }
}
