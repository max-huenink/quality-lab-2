
namespace GainsProject.UI
{
    partial class DizzyButtonsGame
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreHere = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.finalScoreLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(503, 212);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(922, 4);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(38, 13);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "Score:";
            // 
            // scoreHere
            // 
            this.scoreHere.AutoSize = true;
            this.scoreHere.Location = new System.Drawing.Point(965, 4);
            this.scoreHere.Name = "scoreHere";
            this.scoreHere.Size = new System.Drawing.Size(13, 13);
            this.scoreHere.TabIndex = 4;
            this.scoreHere.Text = "0";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(319, 169);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(429, 73);
            this.gameOverLabel.TabIndex = 5;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.Visible = false;
            // 
            // finalScoreLabel
            // 
            this.finalScoreLabel.AutoSize = true;
            this.finalScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScoreLabel.Location = new System.Drawing.Point(496, 271);
            this.finalScoreLabel.Name = "finalScoreLabel";
            this.finalScoreLabel.Size = new System.Drawing.Size(37, 39);
            this.finalScoreLabel.TabIndex = 6;
            this.finalScoreLabel.Text = "0";
            this.finalScoreLabel.Visible = false;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(234, 149);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(623, 20);
            this.instructionsLabel.TabIndex = 10;
            this.instructionsLabel.Text = "There will be a green button that you want to click on but if you miss you will l" +
    "oose points";
            // 
            // DizzyButtonsGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.finalScoreLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.scoreHere);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.startButton);
            this.Name = "DizzyButtonsGame";
            this.Size = new System.Drawing.Size(1060, 686);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DizzyButtonsGame_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreHere;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label finalScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label instructionsLabel;
    }
}
