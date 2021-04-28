
namespace GainsProject.UI
{
    partial class GameEndPage
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
            this.Content = new System.Windows.Forms.Panel();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.nextGameBtn = new System.Windows.Forms.Button();
            this.playAgainLbl = new System.Windows.Forms.Label();
            this.gameTimeLbl = new System.Windows.Forms.Label();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.Salmon;
            this.Content.Controls.Add(this.gameTimeLbl);
            this.Content.Controls.Add(this.scoreLbl);
            this.Content.Controls.Add(this.nameLbl);
            this.Content.Controls.Add(this.exitBtn);
            this.Content.Controls.Add(this.nextGameBtn);
            this.Content.Controls.Add(this.playAgainLbl);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1063, 681);
            this.Content.TabIndex = 0;
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.scoreLbl.Location = new System.Drawing.Point(3, 160);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(492, 63);
            this.scoreLbl.TabIndex = 4;
            this.scoreLbl.Text = "Your score was {0}.";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.nameLbl.Location = new System.Drawing.Point(3, 69);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(385, 63);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Great work {0}!";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.exitBtn.Location = new System.Drawing.Point(590, 439);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(213, 96);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // nextGameBtn
            // 
            this.nextGameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.nextGameBtn.Location = new System.Drawing.Point(233, 439);
            this.nextGameBtn.Name = "nextGameBtn";
            this.nextGameBtn.Size = new System.Drawing.Size(213, 96);
            this.nextGameBtn.TabIndex = 1;
            this.nextGameBtn.Text = "Next Game";
            this.nextGameBtn.UseVisualStyleBackColor = true;
            // 
            // playAgainLbl
            // 
            this.playAgainLbl.AutoSize = true;
            this.playAgainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.playAgainLbl.Location = new System.Drawing.Point(3, 334);
            this.playAgainLbl.Name = "playAgainLbl";
            this.playAgainLbl.Size = new System.Drawing.Size(936, 63);
            this.playAgainLbl.TabIndex = 0;
            this.playAgainLbl.Text = "Would you like to play the next game?";
            // 
            // gameTimeLbl
            // 
            this.gameTimeLbl.AutoSize = true;
            this.gameTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.25F);
            this.gameTimeLbl.Location = new System.Drawing.Point(3, 247);
            this.gameTimeLbl.Name = "gameTimeLbl";
            this.gameTimeLbl.Size = new System.Drawing.Size(819, 63);
            this.gameTimeLbl.TabIndex = 5;
            this.gameTimeLbl.Text = "The game lasted {0} (mm:ss.ms).";
            // 
            // GameEndPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Content);
            this.Name = "GameEndPage";
            this.Size = new System.Drawing.Size(1063, 681);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button nextGameBtn;
        private System.Windows.Forms.Label playAgainLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label gameTimeLbl;
    }
}
