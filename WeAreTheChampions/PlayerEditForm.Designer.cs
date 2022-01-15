namespace WeAreTheChampions
{
    partial class PlayerEditForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbPlayerChooseTeam = new System.Windows.Forms.ComboBox();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.txtImageLink = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pcbPlayerAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(235, 205);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 37);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 16;
            this.label17.Text = "Team";
            // 
            // cmbPlayerChooseTeam
            // 
            this.cmbPlayerChooseTeam.FormattingEnabled = true;
            this.cmbPlayerChooseTeam.Location = new System.Drawing.Point(16, 160);
            this.cmbPlayerChooseTeam.Name = "cmbPlayerChooseTeam";
            this.cmbPlayerChooseTeam.Size = new System.Drawing.Size(312, 28);
            this.cmbPlayerChooseTeam.TabIndex = 15;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(16, 98);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(312, 26);
            this.txtPlayerName.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Player Name";
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(241, 32);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(87, 26);
            this.btnUploadImage.TabIndex = 12;
            this.btnUploadImage.Text = "Upload";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // txtImageLink
            // 
            this.txtImageLink.Location = new System.Drawing.Point(16, 32);
            this.txtImageLink.Name = "txtImageLink";
            this.txtImageLink.Size = new System.Drawing.Size(219, 26);
            this.txtImageLink.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Image Link";
            // 
            // pcbPlayerAdd
            // 
            this.pcbPlayerAdd.Location = new System.Drawing.Point(348, 26);
            this.pcbPlayerAdd.Name = "pcbPlayerAdd";
            this.pcbPlayerAdd.Size = new System.Drawing.Size(118, 162);
            this.pcbPlayerAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPlayerAdd.TabIndex = 9;
            this.pcbPlayerAdd.TabStop = false;
            // 
            // PlayerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 257);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbPlayerChooseTeam);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.txtImageLink);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pcbPlayerAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "PlayerEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PlayerEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbPlayerChooseTeam;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.TextBox txtImageLink;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pcbPlayerAdd;
    }
}