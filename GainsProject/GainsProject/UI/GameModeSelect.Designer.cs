namespace GainsProject.UI
{
    partial class GameModeSelect
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
            this.SingleGame = new System.Windows.Forms.Button();
            this.RandomGames = new System.Windows.Forms.Button();
            this.Playlist = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SingleGame
            // 
            this.SingleGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SingleGame.Location = new System.Drawing.Point(219, 412);
            this.SingleGame.Name = "SingleGame";
            this.SingleGame.Size = new System.Drawing.Size(165, 67);
            this.SingleGame.TabIndex = 0;
            this.SingleGame.Text = "Single game";
            this.SingleGame.UseVisualStyleBackColor = true;
            this.SingleGame.Click += new System.EventHandler(this.SingleGame_Click);
            // 
            // RandomGames
            // 
            this.RandomGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomGames.Location = new System.Drawing.Point(445, 412);
            this.RandomGames.Name = "RandomGames";
            this.RandomGames.Size = new System.Drawing.Size(167, 67);
            this.RandomGames.TabIndex = 1;
            this.RandomGames.Text = "Random Games";
            this.RandomGames.UseVisualStyleBackColor = true;
            // 
            // Playlist
            // 
            this.Playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playlist.Location = new System.Drawing.Point(654, 412);
            this.Playlist.Name = "Playlist";
            this.Playlist.Size = new System.Drawing.Size(179, 67);
            this.Playlist.TabIndex = 2;
            this.Playlist.Text = "Playlist";
            this.Playlist.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Salmon;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(327, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 44);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Select your game mode!";
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1063, 678);
            this.Content.TabIndex = 4;
            // 
            // GameModeSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Playlist);
            this.Controls.Add(this.RandomGames);
            this.Controls.Add(this.SingleGame);
            this.Controls.Add(this.Content);
            this.Name = "GameModeSelect";
            this.Size = new System.Drawing.Size(1063, 681);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SingleGame;
        private System.Windows.Forms.Button RandomGames;
        private System.Windows.Forms.Button Playlist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel Content;
    }
}
