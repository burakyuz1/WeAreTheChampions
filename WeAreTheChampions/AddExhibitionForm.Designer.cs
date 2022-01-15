namespace WeAreTheChampions
{
    partial class AddExhibitionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpMatchDate = new System.Windows.Forms.DateTimePicker();
            this.cmbHomeTeam = new System.Windows.Forms.ComboBox();
            this.cmbAwayTeam = new System.Windows.Forms.ComboBox();
            this.nmuHomeScore = new System.Windows.Forms.NumericUpDown();
            this.nmuAwayScore = new System.Windows.Forms.NumericUpDown();
            this.pnlScores = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkHasPlayed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmuHomeScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuAwayScore)).BeginInit();
            this.pnlScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpMatchDate
            // 
            this.dtpMatchDate.Location = new System.Drawing.Point(13, 34);
            this.dtpMatchDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpMatchDate.Name = "dtpMatchDate";
            this.dtpMatchDate.Size = new System.Drawing.Size(298, 26);
            this.dtpMatchDate.TabIndex = 0;
            // 
            // cmbHomeTeam
            // 
            this.cmbHomeTeam.DisplayMember = "TeamName";
            this.cmbHomeTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHomeTeam.FormattingEnabled = true;
            this.cmbHomeTeam.Location = new System.Drawing.Point(16, 123);
            this.cmbHomeTeam.Name = "cmbHomeTeam";
            this.cmbHomeTeam.Size = new System.Drawing.Size(128, 28);
            this.cmbHomeTeam.TabIndex = 1;
            // 
            // cmbAwayTeam
            // 
            this.cmbAwayTeam.DisplayMember = "TeamName";
            this.cmbAwayTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAwayTeam.FormattingEnabled = true;
            this.cmbAwayTeam.Location = new System.Drawing.Point(186, 123);
            this.cmbAwayTeam.Name = "cmbAwayTeam";
            this.cmbAwayTeam.Size = new System.Drawing.Size(128, 28);
            this.cmbAwayTeam.TabIndex = 2;
            // 
            // nmuHomeScore
            // 
            this.nmuHomeScore.Location = new System.Drawing.Point(3, 29);
            this.nmuHomeScore.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmuHomeScore.Name = "nmuHomeScore";
            this.nmuHomeScore.Size = new System.Drawing.Size(128, 26);
            this.nmuHomeScore.TabIndex = 3;
            // 
            // nmuAwayScore
            // 
            this.nmuAwayScore.Location = new System.Drawing.Point(170, 29);
            this.nmuAwayScore.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmuAwayScore.Name = "nmuAwayScore";
            this.nmuAwayScore.Size = new System.Drawing.Size(128, 26);
            this.nmuAwayScore.TabIndex = 4;
            // 
            // pnlScores
            // 
            this.pnlScores.Controls.Add(this.label5);
            this.pnlScores.Controls.Add(this.label4);
            this.pnlScores.Controls.Add(this.nmuHomeScore);
            this.pnlScores.Controls.Add(this.nmuAwayScore);
            this.pnlScores.Location = new System.Drawing.Point(16, 167);
            this.pnlScores.Name = "pnlScores";
            this.pnlScores.Size = new System.Drawing.Size(333, 70);
            this.pnlScores.TabIndex = 5;
            this.pnlScores.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Away Score";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Home Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Match Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Home Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Away Team";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(259, 250);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 33);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(163, 250);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkHasPlayed
            // 
            this.chkHasPlayed.AutoSize = true;
            this.chkHasPlayed.Location = new System.Drawing.Point(13, 68);
            this.chkHasPlayed.Name = "chkHasPlayed";
            this.chkHasPlayed.Size = new System.Drawing.Size(165, 24);
            this.chkHasPlayed.TabIndex = 11;
            this.chkHasPlayed.Text = "Has Match Played?";
            this.chkHasPlayed.UseVisualStyleBackColor = true;
            this.chkHasPlayed.CheckedChanged += new System.EventHandler(this.chkHasPlayed_CheckedChanged);
            // 
            // AddExhibitionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 310);
            this.Controls.Add(this.chkHasPlayed);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlScores);
            this.Controls.Add(this.cmbAwayTeam);
            this.Controls.Add(this.cmbHomeTeam);
            this.Controls.Add(this.dtpMatchDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "AddExhibitionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Exhibition";
            ((System.ComponentModel.ISupportInitialize)(this.nmuHomeScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuAwayScore)).EndInit();
            this.pnlScores.ResumeLayout(false);
            this.pnlScores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMatchDate;
        private System.Windows.Forms.ComboBox cmbHomeTeam;
        private System.Windows.Forms.ComboBox cmbAwayTeam;
        private System.Windows.Forms.NumericUpDown nmuHomeScore;
        private System.Windows.Forms.NumericUpDown nmuAwayScore;
        private System.Windows.Forms.Panel pnlScores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkHasPlayed;
    }
}