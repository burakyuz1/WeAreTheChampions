namespace WeAreTheChampions
{
    partial class TeamEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvColorsOfTeam = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lsvAllColors = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveAndExit = new System.Windows.Forms.Button();
            this.btnAddColorToTeam = new System.Windows.Forms.Button();
            this.btnDeleteColorOfTeam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team Name";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(123, 26);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(309, 26);
            this.txtTeamName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Colors Of Team";
            // 
            // lsvColorsOfTeam
            // 
            this.lsvColorsOfTeam.HideSelection = false;
            this.lsvColorsOfTeam.LargeImageList = this.imgList;
            this.lsvColorsOfTeam.Location = new System.Drawing.Point(123, 110);
            this.lsvColorsOfTeam.Name = "lsvColorsOfTeam";
            this.lsvColorsOfTeam.Size = new System.Drawing.Size(309, 158);
            this.lsvColorsOfTeam.TabIndex = 3;
            this.lsvColorsOfTeam.UseCompatibleStateImageBehavior = false;
            // 
            // imgList
            // 
            this.imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgList.ImageSize = new System.Drawing.Size(50, 50);
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lsvAllColors
            // 
            this.lsvAllColors.HideSelection = false;
            this.lsvAllColors.LargeImageList = this.imgList;
            this.lsvAllColors.Location = new System.Drawing.Point(123, 319);
            this.lsvAllColors.Name = "lsvAllColors";
            this.lsvAllColors.Size = new System.Drawing.Size(309, 158);
            this.lsvAllColors.TabIndex = 5;
            this.lsvAllColors.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add New Color";
            // 
            // btnSaveAndExit
            // 
            this.btnSaveAndExit.Location = new System.Drawing.Point(293, 483);
            this.btnSaveAndExit.Name = "btnSaveAndExit";
            this.btnSaveAndExit.Size = new System.Drawing.Size(139, 29);
            this.btnSaveAndExit.TabIndex = 6;
            this.btnSaveAndExit.Text = "Save and Exit";
            this.btnSaveAndExit.UseVisualStyleBackColor = true;
            this.btnSaveAndExit.Click += new System.EventHandler(this.btnSaveAndExit_Click);
            // 
            // btnAddColorToTeam
            // 
            this.btnAddColorToTeam.Location = new System.Drawing.Point(208, 483);
            this.btnAddColorToTeam.Name = "btnAddColorToTeam";
            this.btnAddColorToTeam.Size = new System.Drawing.Size(79, 29);
            this.btnAddColorToTeam.TabIndex = 7;
            this.btnAddColorToTeam.Text = "Add";
            this.btnAddColorToTeam.UseVisualStyleBackColor = true;
            this.btnAddColorToTeam.Click += new System.EventHandler(this.btnAddColorToTeam_Click);
            // 
            // btnDeleteColorOfTeam
            // 
            this.btnDeleteColorOfTeam.Location = new System.Drawing.Point(353, 274);
            this.btnDeleteColorOfTeam.Name = "btnDeleteColorOfTeam";
            this.btnDeleteColorOfTeam.Size = new System.Drawing.Size(79, 29);
            this.btnDeleteColorOfTeam.TabIndex = 8;
            this.btnDeleteColorOfTeam.Text = "Delete";
            this.btnDeleteColorOfTeam.UseVisualStyleBackColor = true;
            this.btnDeleteColorOfTeam.Click += new System.EventHandler(this.btnDeleteColorOfTeam_Click);
            // 
            // TeamEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 547);
            this.Controls.Add(this.btnDeleteColorOfTeam);
            this.Controls.Add(this.btnAddColorToTeam);
            this.Controls.Add(this.btnSaveAndExit);
            this.Controls.Add(this.lsvAllColors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvColorsOfTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "TeamEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TeamEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvColorsOfTeam;
        private System.Windows.Forms.ListView lsvAllColors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveAndExit;
        private System.Windows.Forms.Button btnAddColorToTeam;
        private System.Windows.Forms.Button btnDeleteColorOfTeam;
        private System.Windows.Forms.ImageList imgList;
    }
}