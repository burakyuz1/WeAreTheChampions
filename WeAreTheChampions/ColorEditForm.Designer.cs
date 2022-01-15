namespace WeAreTheChampions
{
    partial class ColorEditForm
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
            this.btnSaveColor = new System.Windows.Forms.Button();
            this.pcbColor = new System.Windows.Forms.PictureBox();
            this.nmuBlue = new System.Windows.Forms.NumericUpDown();
            this.nmuGreen = new System.Windows.Forms.NumericUpDown();
            this.nmuRed = new System.Windows.Forms.NumericUpDown();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuRed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveColor
            // 
            this.btnSaveColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveColor.Location = new System.Drawing.Point(332, 242);
            this.btnSaveColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveColor.Name = "btnSaveColor";
            this.btnSaveColor.Size = new System.Drawing.Size(108, 31);
            this.btnSaveColor.TabIndex = 20;
            this.btnSaveColor.Text = "Save Color";
            this.btnSaveColor.UseVisualStyleBackColor = false;
            this.btnSaveColor.Click += new System.EventHandler(this.btnSaveColor_Click);
            // 
            // pcbColor
            // 
            this.pcbColor.Location = new System.Drawing.Point(215, 75);
            this.pcbColor.Margin = new System.Windows.Forms.Padding(4);
            this.pcbColor.Name = "pcbColor";
            this.pcbColor.Size = new System.Drawing.Size(225, 136);
            this.pcbColor.TabIndex = 19;
            this.pcbColor.TabStop = false;
            // 
            // nmuBlue
            // 
            this.nmuBlue.Location = new System.Drawing.Point(106, 188);
            this.nmuBlue.Margin = new System.Windows.Forms.Padding(4);
            this.nmuBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmuBlue.Name = "nmuBlue";
            this.nmuBlue.Size = new System.Drawing.Size(90, 23);
            this.nmuBlue.TabIndex = 18;
            this.nmuBlue.ValueChanged += new System.EventHandler(this.nmuBlue_ValueChanged);
            // 
            // nmuGreen
            // 
            this.nmuGreen.Location = new System.Drawing.Point(106, 130);
            this.nmuGreen.Margin = new System.Windows.Forms.Padding(4);
            this.nmuGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmuGreen.Name = "nmuGreen";
            this.nmuGreen.Size = new System.Drawing.Size(90, 23);
            this.nmuGreen.TabIndex = 17;
            this.nmuGreen.ValueChanged += new System.EventHandler(this.nmuBlue_ValueChanged);
            // 
            // nmuRed
            // 
            this.nmuRed.Location = new System.Drawing.Point(106, 75);
            this.nmuRed.Margin = new System.Windows.Forms.Padding(4);
            this.nmuRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nmuRed.Name = "nmuRed";
            this.nmuRed.Size = new System.Drawing.Size(90, 23);
            this.nmuRed.TabIndex = 16;
            this.nmuRed.ValueChanged += new System.EventHandler(this.nmuBlue_ValueChanged);
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(106, 18);
            this.txtColorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(334, 23);
            this.txtColorName.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 190);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Blue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Green";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Red";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Color Name";
            // 
            // ColorEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 297);
            this.Controls.Add(this.btnSaveColor);
            this.Controls.Add(this.pcbColor);
            this.Controls.Add(this.nmuBlue);
            this.Controls.Add(this.nmuGreen);
            this.Controls.Add(this.nmuRed);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ColorEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ColorEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.pcbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmuRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveColor;
        private System.Windows.Forms.PictureBox pcbColor;
        private System.Windows.Forms.NumericUpDown nmuBlue;
        private System.Windows.Forms.NumericUpDown nmuGreen;
        private System.Windows.Forms.NumericUpDown nmuRed;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}