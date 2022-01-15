namespace WeAreTheChampions
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteMatch = new System.Windows.Forms.Button();
            this.btnUpdateMatch = new System.Windows.Forms.Button();
            this.lblHomeTeamName = new System.Windows.Forms.Label();
            this.btnNewExhibition = new System.Windows.Forms.Button();
            this.dgvExhibitions = new System.Windows.Forms.DataGridView();
            this.lblAwayTeamName = new System.Windows.Forms.Label();
            this.pcbAway = new System.Windows.Forms.PictureBox();
            this.pcbHome = new System.Windows.Forms.PictureBox();
            this.lblAwayScore = new System.Windows.Forms.Label();
            this.lblHomeScore = new System.Windows.Forms.Label();
            this.lblMatchDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.lsvColors = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pcbColor = new System.Windows.Forms.PictureBox();
            this.nmuBlue = new System.Windows.Forms.NumericUpDown();
            this.nmuGreen = new System.Windows.Forms.NumericUpDown();
            this.nmuRed = new System.Windows.Forms.NumericUpDown();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPlayerTransfer = new System.Windows.Forms.Button();
            this.btnPlayerDelete = new System.Windows.Forms.Button();
            this.btnPlayerUpdate = new System.Windows.Forms.Button();
            this.lblPlayerTeam = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pcbPlayerInfo = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPlayerAdd = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbPlayerChooseTeam = new System.Windows.Forms.ComboBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtImageLink = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pcbPlayerAdd = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTeamSort = new System.Windows.Forms.ComboBox();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbPlayersOfTeam = new System.Windows.Forms.GroupBox();
            this.lsvPlayersOfTeam = new System.Windows.Forms.ListView();
            this.imgPlayers = new System.Windows.Forms.ImageList(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.btnTeamDelete = new System.Windows.Forms.Button();
            this.btnTeamUpdate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddColorToTeam = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lsvColorOfTeam = new System.Windows.Forms.ListView();
            this.txtTeamAddName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExhibitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuRed)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerInfo)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerAdd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbPlayersOfTeam.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 494);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteMatch);
            this.tabPage1.Controls.Add(this.btnUpdateMatch);
            this.tabPage1.Controls.Add(this.lblHomeTeamName);
            this.tabPage1.Controls.Add(this.btnNewExhibition);
            this.tabPage1.Controls.Add(this.dgvExhibitions);
            this.tabPage1.Controls.Add(this.lblAwayTeamName);
            this.tabPage1.Controls.Add(this.pcbAway);
            this.tabPage1.Controls.Add(this.pcbHome);
            this.tabPage1.Controls.Add(this.lblAwayScore);
            this.tabPage1.Controls.Add(this.lblHomeScore);
            this.tabPage1.Controls.Add(this.lblMatchDate);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(618, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Exhibitions";
            // 
            // btnDeleteMatch
            // 
            this.btnDeleteMatch.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteMatch.Location = new System.Drawing.Point(403, 425);
            this.btnDeleteMatch.Name = "btnDeleteMatch";
            this.btnDeleteMatch.Size = new System.Drawing.Size(88, 30);
            this.btnDeleteMatch.TabIndex = 21;
            this.btnDeleteMatch.Text = "Delete";
            this.btnDeleteMatch.UseVisualStyleBackColor = false;
            this.btnDeleteMatch.Click += new System.EventHandler(this.btnDeleteMatch_Click);
            // 
            // btnUpdateMatch
            // 
            this.btnUpdateMatch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateMatch.Location = new System.Drawing.Point(497, 425);
            this.btnUpdateMatch.Name = "btnUpdateMatch";
            this.btnUpdateMatch.Size = new System.Drawing.Size(88, 30);
            this.btnUpdateMatch.TabIndex = 20;
            this.btnUpdateMatch.Text = "Update";
            this.btnUpdateMatch.UseVisualStyleBackColor = false;
            this.btnUpdateMatch.Click += new System.EventHandler(this.btnUpdateMatch_Click);
            // 
            // lblHomeTeamName
            // 
            this.lblHomeTeamName.AutoSize = true;
            this.lblHomeTeamName.Location = new System.Drawing.Point(150, 125);
            this.lblHomeTeamName.Name = "lblHomeTeamName";
            this.lblHomeTeamName.Size = new System.Drawing.Size(0, 20);
            this.lblHomeTeamName.TabIndex = 16;
            this.lblHomeTeamName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewExhibition
            // 
            this.btnNewExhibition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewExhibition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewExhibition.Location = new System.Drawing.Point(445, 6);
            this.btnNewExhibition.Name = "btnNewExhibition";
            this.btnNewExhibition.Size = new System.Drawing.Size(140, 30);
            this.btnNewExhibition.TabIndex = 19;
            this.btnNewExhibition.Text = "+ Add New Exhibition";
            this.btnNewExhibition.UseVisualStyleBackColor = false;
            this.btnNewExhibition.Click += new System.EventHandler(this.btnNewExhibition_Click);
            // 
            // dgvExhibitions
            // 
            this.dgvExhibitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExhibitions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExhibitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExhibitions.Location = new System.Drawing.Point(18, 163);
            this.dgvExhibitions.Name = "dgvExhibitions";
            this.dgvExhibitions.RowHeadersVisible = false;
            this.dgvExhibitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExhibitions.Size = new System.Drawing.Size(567, 259);
            this.dgvExhibitions.TabIndex = 18;
            this.dgvExhibitions.SelectionChanged += new System.EventHandler(this.dgvExhibitions_SelectionChanged);
            // 
            // lblAwayTeamName
            // 
            this.lblAwayTeamName.AutoSize = true;
            this.lblAwayTeamName.Location = new System.Drawing.Point(293, 125);
            this.lblAwayTeamName.Name = "lblAwayTeamName";
            this.lblAwayTeamName.Size = new System.Drawing.Size(0, 20);
            this.lblAwayTeamName.TabIndex = 17;
            // 
            // pcbAway
            // 
            this.pcbAway.Location = new System.Drawing.Point(295, 72);
            this.pcbAway.Name = "pcbAway";
            this.pcbAway.Size = new System.Drawing.Size(100, 50);
            this.pcbAway.TabIndex = 15;
            this.pcbAway.TabStop = false;
            // 
            // pcbHome
            // 
            this.pcbHome.Location = new System.Drawing.Point(154, 72);
            this.pcbHome.Name = "pcbHome";
            this.pcbHome.Size = new System.Drawing.Size(100, 50);
            this.pcbHome.TabIndex = 14;
            this.pcbHome.TabStop = false;
            // 
            // lblAwayScore
            // 
            this.lblAwayScore.AutoSize = true;
            this.lblAwayScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAwayScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAwayScore.Location = new System.Drawing.Point(315, 37);
            this.lblAwayScore.Name = "lblAwayScore";
            this.lblAwayScore.Size = new System.Drawing.Size(86, 37);
            this.lblAwayScore.TabIndex = 12;
            this.lblAwayScore.Text = "NaN";
            // 
            // lblHomeScore
            // 
            this.lblHomeScore.AutoSize = true;
            this.lblHomeScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHomeScore.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblHomeScore.Location = new System.Drawing.Point(172, 37);
            this.lblHomeScore.Name = "lblHomeScore";
            this.lblHomeScore.Size = new System.Drawing.Size(86, 37);
            this.lblHomeScore.TabIndex = 11;
            this.lblHomeScore.Text = "NaN";
            // 
            // lblMatchDate
            // 
            this.lblMatchDate.AutoSize = true;
            this.lblMatchDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMatchDate.Location = new System.Drawing.Point(236, 11);
            this.lblMatchDate.Name = "lblMatchDate";
            this.lblMatchDate.Size = new System.Drawing.Size(207, 20);
            this.lblMatchDate.TabIndex = 10;
            this.lblMatchDate.Text = "Add an Exhibition to See";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(246, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 51);
            this.label4.TabIndex = 13;
            this.label4.Text = " -";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnAddColor);
            this.tabPage2.Controls.Add(this.lsvColors);
            this.tabPage2.Controls.Add(this.pcbColor);
            this.tabPage2.Controls.Add(this.nmuBlue);
            this.tabPage2.Controls.Add(this.nmuGreen);
            this.tabPage2.Controls.Add(this.nmuRed);
            this.tabPage2.Controls.Add(this.txtColorName);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Colors";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(12, 431);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 26);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Double Click to Edit Color";
            // 
            // btnAddColor
            // 
            this.btnAddColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddColor.Location = new System.Drawing.Point(480, 198);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(113, 38);
            this.btnAddColor.TabIndex = 10;
            this.btnAddColor.Text = "+ Add Color";
            this.btnAddColor.UseVisualStyleBackColor = false;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // lsvColors
            // 
            this.lsvColors.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lsvColors.HideSelection = false;
            this.lsvColors.LargeImageList = this.imgList;
            this.lsvColors.Location = new System.Drawing.Point(12, 242);
            this.lsvColors.Name = "lsvColors";
            this.lsvColors.Size = new System.Drawing.Size(581, 186);
            this.lsvColors.TabIndex = 9;
            this.lsvColors.UseCompatibleStateImageBehavior = false;
            this.lsvColors.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvColors_MouseDoubleClick);
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(50, 50);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pcbColor
            // 
            this.pcbColor.Location = new System.Drawing.Point(261, 74);
            this.pcbColor.Name = "pcbColor";
            this.pcbColor.Size = new System.Drawing.Size(332, 118);
            this.pcbColor.TabIndex = 8;
            this.pcbColor.TabStop = false;
            // 
            // nmuBlue
            // 
            this.nmuBlue.Location = new System.Drawing.Point(110, 166);
            this.nmuBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmuBlue.Name = "nmuBlue";
            this.nmuBlue.Size = new System.Drawing.Size(120, 26);
            this.nmuBlue.TabIndex = 7;
            this.nmuBlue.ValueChanged += new System.EventHandler(this.nmuRed_ValueChanged);
            // 
            // nmuGreen
            // 
            this.nmuGreen.Location = new System.Drawing.Point(110, 120);
            this.nmuGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmuGreen.Name = "nmuGreen";
            this.nmuGreen.Size = new System.Drawing.Size(120, 26);
            this.nmuGreen.TabIndex = 6;
            this.nmuGreen.ValueChanged += new System.EventHandler(this.nmuRed_ValueChanged);
            // 
            // nmuRed
            // 
            this.nmuRed.Location = new System.Drawing.Point(110, 74);
            this.nmuRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmuRed.Name = "nmuRed";
            this.nmuRed.Size = new System.Drawing.Size(120, 26);
            this.nmuRed.TabIndex = 5;
            this.nmuRed.ValueChanged += new System.EventHandler(this.nmuRed_ValueChanged);
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(110, 24);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(483, 26);
            this.txtColorName.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Blue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Green";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Red";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Color Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(618, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Players";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPlayerTransfer);
            this.groupBox2.Controls.Add(this.btnPlayerDelete);
            this.groupBox2.Controls.Add(this.btnPlayerUpdate);
            this.groupBox2.Controls.Add(this.lblPlayerTeam);
            this.groupBox2.Controls.Add(this.lblPlayerName);
            this.groupBox2.Controls.Add(this.pcbPlayerInfo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(306, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 216);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Details";
            // 
            // btnPlayerTransfer
            // 
            this.btnPlayerTransfer.Location = new System.Drawing.Point(6, 164);
            this.btnPlayerTransfer.Name = "btnPlayerTransfer";
            this.btnPlayerTransfer.Size = new System.Drawing.Size(152, 23);
            this.btnPlayerTransfer.TabIndex = 6;
            this.btnPlayerTransfer.Text = "Transfer";
            this.btnPlayerTransfer.UseVisualStyleBackColor = true;
            this.btnPlayerTransfer.Click += new System.EventHandler(this.btnPlayerTransfer_Click);
            // 
            // btnPlayerDelete
            // 
            this.btnPlayerDelete.Location = new System.Drawing.Point(85, 134);
            this.btnPlayerDelete.Name = "btnPlayerDelete";
            this.btnPlayerDelete.Size = new System.Drawing.Size(73, 23);
            this.btnPlayerDelete.TabIndex = 5;
            this.btnPlayerDelete.Text = "Delete";
            this.btnPlayerDelete.UseVisualStyleBackColor = true;
            this.btnPlayerDelete.Click += new System.EventHandler(this.btnPlayerDelete_Click);
            // 
            // btnPlayerUpdate
            // 
            this.btnPlayerUpdate.Location = new System.Drawing.Point(6, 134);
            this.btnPlayerUpdate.Name = "btnPlayerUpdate";
            this.btnPlayerUpdate.Size = new System.Drawing.Size(73, 23);
            this.btnPlayerUpdate.TabIndex = 4;
            this.btnPlayerUpdate.Text = "Update";
            this.btnPlayerUpdate.UseVisualStyleBackColor = true;
            this.btnPlayerUpdate.Click += new System.EventHandler(this.btnPlayerUpdate_Click);
            // 
            // lblPlayerTeam
            // 
            this.lblPlayerTeam.AutoSize = true;
            this.lblPlayerTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayerTeam.Location = new System.Drawing.Point(36, 74);
            this.lblPlayerTeam.Name = "lblPlayerTeam";
            this.lblPlayerTeam.Size = new System.Drawing.Size(0, 20);
            this.lblPlayerTeam.TabIndex = 2;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlayerName.Location = new System.Drawing.Point(6, 20);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(0, 26);
            this.lblPlayerName.TabIndex = 1;
            // 
            // pcbPlayerInfo
            // 
            this.pcbPlayerInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPlayerInfo.Location = new System.Drawing.Point(172, 20);
            this.pcbPlayerInfo.Name = "pcbPlayerInfo";
            this.pcbPlayerInfo.Size = new System.Drawing.Size(118, 167);
            this.pcbPlayerInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPlayerInfo.TabIndex = 0;
            this.pcbPlayerInfo.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPlayerAdd);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.cmbPlayerChooseTeam);
            this.groupBox3.Controls.Add(this.txtPlayerName);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btnUploadImage);
            this.groupBox3.Controls.Add(this.txtImageLink);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.pcbPlayerAdd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(306, 225);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 216);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Player";
            // 
            // btnPlayerAdd
            // 
            this.btnPlayerAdd.Location = new System.Drawing.Point(219, 187);
            this.btnPlayerAdd.Name = "btnPlayerAdd";
            this.btnPlayerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPlayerAdd.TabIndex = 8;
            this.btnPlayerAdd.Text = "Add";
            this.btnPlayerAdd.UseVisualStyleBackColor = true;
            this.btnPlayerAdd.Click += new System.EventHandler(this.btnPlayerAdd_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(131, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 15);
            this.label17.TabIndex = 7;
            this.label17.Text = "Team";
            // 
            // cmbPlayerChooseTeam
            // 
            this.cmbPlayerChooseTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlayerChooseTeam.FormattingEnabled = true;
            this.cmbPlayerChooseTeam.Location = new System.Drawing.Point(134, 152);
            this.cmbPlayerChooseTeam.Name = "cmbPlayerChooseTeam";
            this.cmbPlayerChooseTeam.Size = new System.Drawing.Size(160, 23);
            this.cmbPlayerChooseTeam.TabIndex = 6;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(134, 104);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(160, 21);
            this.txtPlayerName.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(131, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Player Name";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(237, 53);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(57, 23);
            this.btnUploadImage.TabIndex = 3;
            this.btnUploadImage.Text = "Upload";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // txtImageLink
            // 
            this.txtImageLink.Location = new System.Drawing.Point(134, 53);
            this.txtImageLink.Name = "txtImageLink";
            this.txtImageLink.Size = new System.Drawing.Size(103, 21);
            this.txtImageLink.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Image Link";
            // 
            // pcbPlayerAdd
            // 
            this.pcbPlayerAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbPlayerAdd.Location = new System.Drawing.Point(6, 34);
            this.pcbPlayerAdd.Name = "pcbPlayerAdd";
            this.pcbPlayerAdd.Size = new System.Drawing.Size(118, 176);
            this.pcbPlayerAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPlayerAdd.TabIndex = 0;
            this.pcbPlayerAdd.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTeamSort);
            this.groupBox1.Controls.Add(this.lstPlayers);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 435);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Players";
            // 
            // cmbTeamSort
            // 
            this.cmbTeamSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeamSort.FormattingEnabled = true;
            this.cmbTeamSort.Location = new System.Drawing.Point(185, 15);
            this.cmbTeamSort.Name = "cmbTeamSort";
            this.cmbTeamSort.Size = new System.Drawing.Size(106, 28);
            this.cmbTeamSort.TabIndex = 7;
            this.cmbTeamSort.SelectedIndexChanged += new System.EventHandler(this.cmbTeamSort_SelectedIndexChanged);
            // 
            // lstPlayers
            // 
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.ItemHeight = 20;
            this.lstPlayers.Location = new System.Drawing.Point(3, 45);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(288, 384);
            this.lstPlayers.TabIndex = 0;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbPlayersOfTeam);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(618, 461);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Teams";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbPlayersOfTeam
            // 
            this.gbPlayersOfTeam.Controls.Add(this.lsvPlayersOfTeam);
            this.gbPlayersOfTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbPlayersOfTeam.Location = new System.Drawing.Point(251, 20);
            this.gbPlayersOfTeam.Name = "gbPlayersOfTeam";
            this.gbPlayersOfTeam.Size = new System.Drawing.Size(357, 216);
            this.gbPlayersOfTeam.TabIndex = 9;
            this.gbPlayersOfTeam.TabStop = false;
            // 
            // lsvPlayersOfTeam
            // 
            this.lsvPlayersOfTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvPlayersOfTeam.HideSelection = false;
            this.lsvPlayersOfTeam.LargeImageList = this.imgPlayers;
            this.lsvPlayersOfTeam.Location = new System.Drawing.Point(3, 17);
            this.lsvPlayersOfTeam.Name = "lsvPlayersOfTeam";
            this.lsvPlayersOfTeam.Size = new System.Drawing.Size(351, 196);
            this.lsvPlayersOfTeam.SmallImageList = this.imgPlayers;
            this.lsvPlayersOfTeam.TabIndex = 3;
            this.lsvPlayersOfTeam.UseCompatibleStateImageBehavior = false;
            this.lsvPlayersOfTeam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsvPlayersOfTeam_KeyDown);
            // 
            // imgPlayers
            // 
            this.imgPlayers.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgPlayers.ImageSize = new System.Drawing.Size(60, 80);
            this.imgPlayers.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstTeams);
            this.groupBox5.Controls.Add(this.btnTeamDelete);
            this.groupBox5.Controls.Add(this.btnTeamUpdate);
            this.groupBox5.Location = new System.Drawing.Point(9, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(236, 435);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Teams";
            // 
            // lstTeams
            // 
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 20;
            this.lstTeams.Location = new System.Drawing.Point(6, 25);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(224, 364);
            this.lstTeams.TabIndex = 12;
            this.lstTeams.SelectedIndexChanged += new System.EventHandler(this.lstTeams_SelectedIndexChanged);
            // 
            // btnTeamDelete
            // 
            this.btnTeamDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnTeamDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeamDelete.Location = new System.Drawing.Point(74, 403);
            this.btnTeamDelete.Name = "btnTeamDelete";
            this.btnTeamDelete.Size = new System.Drawing.Size(75, 26);
            this.btnTeamDelete.TabIndex = 11;
            this.btnTeamDelete.Text = "Delete";
            this.btnTeamDelete.UseVisualStyleBackColor = false;
            this.btnTeamDelete.Click += new System.EventHandler(this.btnTeamDelete_Click);
            // 
            // btnTeamUpdate
            // 
            this.btnTeamUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTeamUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeamUpdate.Location = new System.Drawing.Point(155, 403);
            this.btnTeamUpdate.Name = "btnTeamUpdate";
            this.btnTeamUpdate.Size = new System.Drawing.Size(75, 26);
            this.btnTeamUpdate.TabIndex = 10;
            this.btnTeamUpdate.Text = "Update";
            this.btnTeamUpdate.UseVisualStyleBackColor = false;
            this.btnTeamUpdate.Click += new System.EventHandler(this.btnTeamUpdate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddColorToTeam);
            this.groupBox4.Controls.Add(this.btnAddTeam);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.lsvColorOfTeam);
            this.groupBox4.Controls.Add(this.txtTeamAddName);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(251, 242);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(357, 216);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add New Team";
            // 
            // btnAddColorToTeam
            // 
            this.btnAddColorToTeam.Location = new System.Drawing.Point(195, 185);
            this.btnAddColorToTeam.Name = "btnAddColorToTeam";
            this.btnAddColorToTeam.Size = new System.Drawing.Size(75, 23);
            this.btnAddColorToTeam.TabIndex = 10;
            this.btnAddColorToTeam.Text = "Add";
            this.btnAddColorToTeam.UseVisualStyleBackColor = true;
            this.btnAddColorToTeam.Click += new System.EventHandler(this.btnAddColorToTeam_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(276, 185);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeam.TabIndex = 9;
            this.btnAddTeam.Text = "Save";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "Color";
            // 
            // lsvColorOfTeam
            // 
            this.lsvColorOfTeam.HideSelection = false;
            this.lsvColorOfTeam.LargeImageList = this.imgList;
            this.lsvColorOfTeam.Location = new System.Drawing.Point(20, 82);
            this.lsvColorOfTeam.Name = "lsvColorOfTeam";
            this.lsvColorOfTeam.Size = new System.Drawing.Size(331, 97);
            this.lsvColorOfTeam.TabIndex = 2;
            this.lsvColorOfTeam.UseCompatibleStateImageBehavior = false;
            // 
            // txtTeamAddName
            // 
            this.txtTeamAddName.Location = new System.Drawing.Point(71, 33);
            this.txtTeamAddName.Name = "txtTeamAddName";
            this.txtTeamAddName.Size = new System.Drawing.Size(280, 21);
            this.txtTeamAddName.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 494);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WE ARE THE CHAMPIONS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExhibitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbHome)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuRed)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerInfo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerAdd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.gbPlayersOfTeam.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnNewExhibition;
        private System.Windows.Forms.DataGridView dgvExhibitions;
        private System.Windows.Forms.Label lblAwayTeamName;
        private System.Windows.Forms.Label lblHomeTeamName;
        private System.Windows.Forms.PictureBox pcbAway;
        private System.Windows.Forms.PictureBox pcbHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAwayScore;
        private System.Windows.Forms.Label lblHomeScore;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.ListView lsvColors;
        private System.Windows.Forms.PictureBox pcbColor;
        private System.Windows.Forms.NumericUpDown nmuBlue;
        private System.Windows.Forms.NumericUpDown nmuGreen;
        private System.Windows.Forms.NumericUpDown nmuRed;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPlayerDelete;
        private System.Windows.Forms.Button btnPlayerUpdate;
        private System.Windows.Forms.Label lblPlayerTeam;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.PictureBox pcbPlayerInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.TextBox txtImageLink;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pcbPlayerAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnPlayerAdd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbPlayerChooseTeam;
        private System.Windows.Forms.ComboBox cmbTeamSort;
        private System.Windows.Forms.GroupBox gbPlayersOfTeam;
        private System.Windows.Forms.ListView lsvPlayersOfTeam;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnTeamDelete;
        private System.Windows.Forms.Button btnTeamUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListView lsvColorOfTeam;
        private System.Windows.Forms.TextBox txtTeamAddName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPlayerTransfer;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddColorToTeam;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList imgPlayers;
        private System.Windows.Forms.Label lblMatchDate;
        private System.Windows.Forms.Button btnDeleteMatch;
        private System.Windows.Forms.Button btnUpdateMatch;
    }
}