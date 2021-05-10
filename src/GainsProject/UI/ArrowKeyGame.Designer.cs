
namespace GainsProject.UI
{
    partial class ArrowKeyGame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrowKeyGame));
            this.InstructionsLbl = new System.Windows.Forms.RichTextBox();
            this.EasyDifficultyBtn = new System.Windows.Forms.Button();
            this.MediumDifficultyBtn = new System.Windows.Forms.Button();
            this.HardDifficultBtn = new System.Windows.Forms.Button();
            this.LeftArrowLbl = new System.Windows.Forms.Label();
            this.UpArrowLbl = new System.Windows.Forms.Label();
            this.RightArrowLbl = new System.Windows.Forms.Label();
            this.DownArrowLbl = new System.Windows.Forms.Label();
            this.ScoreLbl = new System.Windows.Forms.Label();
            this.TotalScoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstructionsLbl
            // 
            this.InstructionsLbl.BackColor = System.Drawing.Color.Salmon;
            this.InstructionsLbl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructionsLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLbl.Location = new System.Drawing.Point(59, 93);
            this.InstructionsLbl.Name = "InstructionsLbl";
            this.InstructionsLbl.ReadOnly = true;
            this.InstructionsLbl.Size = new System.Drawing.Size(844, 154);
            this.InstructionsLbl.TabIndex = 8;
            this.InstructionsLbl.Text = resources.GetString("InstructionsLbl.Text");
            // 
            // EasyDifficultyBtn
            // 
            this.EasyDifficultyBtn.BackColor = System.Drawing.Color.IndianRed;
            this.EasyDifficultyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EasyDifficultyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyDifficultyBtn.Location = new System.Drawing.Point(356, 300);
            this.EasyDifficultyBtn.Name = "EasyDifficultyBtn";
            this.EasyDifficultyBtn.Size = new System.Drawing.Size(346, 52);
            this.EasyDifficultyBtn.TabIndex = 7;
            this.EasyDifficultyBtn.Text = "Easy";
            this.EasyDifficultyBtn.UseVisualStyleBackColor = false;
            this.EasyDifficultyBtn.Click += new System.EventHandler(this.easyDifficultyBtn_Click);
            // 
            // MediumDifficultyBtn
            // 
            this.MediumDifficultyBtn.BackColor = System.Drawing.Color.IndianRed;
            this.MediumDifficultyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MediumDifficultyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediumDifficultyBtn.Location = new System.Drawing.Point(356, 370);
            this.MediumDifficultyBtn.Name = "MediumDifficultyBtn";
            this.MediumDifficultyBtn.Size = new System.Drawing.Size(346, 52);
            this.MediumDifficultyBtn.TabIndex = 11;
            this.MediumDifficultyBtn.Text = "Medium";
            this.MediumDifficultyBtn.UseVisualStyleBackColor = false;
            this.MediumDifficultyBtn.Click += new System.EventHandler(this.mediumDifficultyBtn_Click);
            // 
            // HardDifficultBtn
            // 
            this.HardDifficultBtn.BackColor = System.Drawing.Color.IndianRed;
            this.HardDifficultBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HardDifficultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardDifficultBtn.Location = new System.Drawing.Point(356, 441);
            this.HardDifficultBtn.Name = "HardDifficultBtn";
            this.HardDifficultBtn.Size = new System.Drawing.Size(346, 52);
            this.HardDifficultBtn.TabIndex = 12;
            this.HardDifficultBtn.Text = "Hard";
            this.HardDifficultBtn.UseVisualStyleBackColor = false;
            this.HardDifficultBtn.Click += new System.EventHandler(this.hardDifficultBtn_Click);
            // 
            // LeftArrowLbl
            // 
            this.LeftArrowLbl.AutoSize = true;
            this.LeftArrowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftArrowLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LeftArrowLbl.Location = new System.Drawing.Point(270, 43);
            this.LeftArrowLbl.Name = "LeftArrowLbl";
            this.LeftArrowLbl.Size = new System.Drawing.Size(116, 108);
            this.LeftArrowLbl.TabIndex = 13;
            this.LeftArrowLbl.Text = "🡄";
            this.LeftArrowLbl.Visible = false;
            // 
            // UpArrowLbl
            // 
            this.UpArrowLbl.AutoSize = true;
            this.UpArrowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpArrowLbl.Location = new System.Drawing.Point(392, 43);
            this.UpArrowLbl.Name = "UpArrowLbl";
            this.UpArrowLbl.Size = new System.Drawing.Size(116, 108);
            this.UpArrowLbl.TabIndex = 14;
            this.UpArrowLbl.Text = "🡅";
            this.UpArrowLbl.Visible = false;
            // 
            // RightArrowLbl
            // 
            this.RightArrowLbl.AutoSize = true;
            this.RightArrowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightArrowLbl.Location = new System.Drawing.Point(636, 43);
            this.RightArrowLbl.Name = "RightArrowLbl";
            this.RightArrowLbl.Size = new System.Drawing.Size(116, 108);
            this.RightArrowLbl.TabIndex = 15;
            this.RightArrowLbl.Text = "🡆";
            this.RightArrowLbl.Visible = false;
            // 
            // DownArrowLbl
            // 
            this.DownArrowLbl.AutoSize = true;
            this.DownArrowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownArrowLbl.Location = new System.Drawing.Point(514, 43);
            this.DownArrowLbl.Name = "DownArrowLbl";
            this.DownArrowLbl.Size = new System.Drawing.Size(116, 108);
            this.DownArrowLbl.TabIndex = 16;
            this.DownArrowLbl.Text = "🡇";
            this.DownArrowLbl.Visible = false;
            // 
            // ScoreLbl
            // 
            this.ScoreLbl.AutoSize = true;
            this.ScoreLbl.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.ScoreLbl.Location = new System.Drawing.Point(482, 22);
            this.ScoreLbl.Name = "ScoreLbl";
            this.ScoreLbl.Size = new System.Drawing.Size(53, 21);
            this.ScoreLbl.TabIndex = 17;
            this.ScoreLbl.Text = "+000";
            this.ScoreLbl.Visible = false;
            // 
            // TotalScoreLbl
            // 
            this.TotalScoreLbl.AutoSize = true;
            this.TotalScoreLbl.Font = new System.Drawing.Font("Rockwell", 14.25F);
            this.TotalScoreLbl.Location = new System.Drawing.Point(930, 22);
            this.TotalScoreLbl.Name = "TotalScoreLbl";
            this.TotalScoreLbl.Size = new System.Drawing.Size(100, 21);
            this.TotalScoreLbl.TabIndex = 18;
            this.TotalScoreLbl.Text = "000000000";
            this.TotalScoreLbl.Visible = false;
            // 
            // ArrowKeyGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.TotalScoreLbl);
            this.Controls.Add(this.ScoreLbl);
            this.Controls.Add(this.DownArrowLbl);
            this.Controls.Add(this.RightArrowLbl);
            this.Controls.Add(this.UpArrowLbl);
            this.Controls.Add(this.LeftArrowLbl);
            this.Controls.Add(this.HardDifficultBtn);
            this.Controls.Add(this.MediumDifficultyBtn);
            this.Controls.Add(this.InstructionsLbl);
            this.Controls.Add(this.EasyDifficultyBtn);
            this.Name = "ArrowKeyGame";
            this.Size = new System.Drawing.Size(1060, 686);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ArrowKeyGame_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox InstructionsLbl;
        private System.Windows.Forms.Button EasyDifficultyBtn;
        private System.Windows.Forms.Button MediumDifficultyBtn;
        private System.Windows.Forms.Button HardDifficultBtn;
        private System.Windows.Forms.Label LeftArrowLbl;
        private System.Windows.Forms.Label UpArrowLbl;
        private System.Windows.Forms.Label RightArrowLbl;
        private System.Windows.Forms.Label DownArrowLbl;
        private System.Windows.Forms.Label ScoreLbl;
        private System.Windows.Forms.Label TotalScoreLbl;
    }
}
