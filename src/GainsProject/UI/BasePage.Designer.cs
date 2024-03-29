﻿
namespace GainsProject.UI
{
    partial class BasePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leaderboardButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.previousResultsButton = new System.Windows.Forms.Button();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.Panel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.leaderboardButton);
            this.panel1.Controls.Add(this.quitButton);
            this.panel1.Controls.Add(this.previousResultsButton);
            this.panel1.Controls.Add(this.tutorialButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 689);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // leaderboardButton
            // 
            this.leaderboardButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leaderboardButton.FlatAppearance.BorderSize = 0;
            this.leaderboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderboardButton.Font = new System.Drawing.Font("Rockwell", 18F);
            this.leaderboardButton.Location = new System.Drawing.Point(3, 466);
            this.leaderboardButton.Name = "leaderboardButton";
            this.leaderboardButton.Size = new System.Drawing.Size(201, 114);
            this.leaderboardButton.TabIndex = 4;
            this.leaderboardButton.Text = "About Us";
            this.leaderboardButton.UseVisualStyleBackColor = true;
            this.leaderboardButton.Visible = false;
            this.leaderboardButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.aboutUsButton_MouseClick);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Rockwell", 18F);
            this.quitButton.Location = new System.Drawing.Point(3, 586);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(201, 100);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // previousResultsButton
            // 
            this.previousResultsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.previousResultsButton.FlatAppearance.BorderSize = 0;
            this.previousResultsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousResultsButton.Font = new System.Drawing.Font("Rockwell", 18F);
            this.previousResultsButton.Location = new System.Drawing.Point(3, 346);
            this.previousResultsButton.Name = "previousResultsButton";
            this.previousResultsButton.Size = new System.Drawing.Size(201, 114);
            this.previousResultsButton.TabIndex = 2;
            this.previousResultsButton.Text = "Previous Results";
            this.previousResultsButton.UseVisualStyleBackColor = true;
            this.previousResultsButton.Visible = false;
            this.previousResultsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.previousResultsButton_MouseClick);
            // 
            // tutorialButton
            // 
            this.tutorialButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tutorialButton.FlatAppearance.BorderSize = 0;
            this.tutorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutorialButton.Font = new System.Drawing.Font("Rockwell", 18F);
            this.tutorialButton.Location = new System.Drawing.Point(3, 226);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(201, 114);
            this.tutorialButton.TabIndex = 0;
            this.tutorialButton.Text = "Tutorial";
            this.tutorialButton.UseVisualStyleBackColor = true;
            this.tutorialButton.Visible = false;
            this.tutorialButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tutorialButton_MouseClick);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.playButton.BackColor = System.Drawing.Color.Tomato;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(3, 106);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(201, 114);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Visible = false;
            this.playButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.playButton_MouseClick);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.Beige;
            this.Content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Content.Controls.Add(this.EnterButton);
            this.Content.Controls.Add(this.NameBox);
            this.Content.Controls.Add(this.WelcomeLabel);
            this.Content.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Content.Location = new System.Drawing.Point(201, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1063, 681);
            this.Content.TabIndex = 5;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.EnterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Location = new System.Drawing.Point(399, 474);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(328, 103);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(399, 363);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(328, 62);
            this.NameBox.TabIndex = 1;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(182, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(746, 288);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to the \r\nXxBigger_GainsxX \r\nReaction game!\r\nPlease enter your name.";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "BasePage";
            this.Text = "Reaction Games";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button previousResultsButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button tutorialButton;
        private System.Windows.Forms.Button leaderboardButton;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

