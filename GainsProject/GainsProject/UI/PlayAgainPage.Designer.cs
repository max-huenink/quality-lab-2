
namespace GainsProject.UI
{
    partial class PlayAgainPage
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
            this.noBtn = new System.Windows.Forms.Button();
            this.yesBtn = new System.Windows.Forms.Button();
            this.playAgainLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.Salmon;
            this.Content.Controls.Add(this.label1);
            this.Content.Controls.Add(this.noBtn);
            this.Content.Controls.Add(this.yesBtn);
            this.Content.Controls.Add(this.playAgainLbl);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1063, 681);
            this.Content.TabIndex = 0;
            // 
            // noBtn
            // 
            this.noBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.noBtn.Location = new System.Drawing.Point(600, 375);
            this.noBtn.Name = "noBtn";
            this.noBtn.Size = new System.Drawing.Size(213, 96);
            this.noBtn.TabIndex = 2;
            this.noBtn.Text = "No";
            this.noBtn.UseVisualStyleBackColor = true;
            this.noBtn.Click += new System.EventHandler(this.noBtn_Click);
            // 
            // yesBtn
            // 
            this.yesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.yesBtn.Location = new System.Drawing.Point(230, 375);
            this.yesBtn.Name = "yesBtn";
            this.yesBtn.Size = new System.Drawing.Size(213, 96);
            this.yesBtn.TabIndex = 1;
            this.yesBtn.Text = "Yes";
            this.yesBtn.UseVisualStyleBackColor = true;
            this.yesBtn.Click += new System.EventHandler(this.yesBtn_Click);
            // 
            // playAgainLbl
            // 
            this.playAgainLbl.AutoSize = true;
            this.playAgainLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.playAgainLbl.Location = new System.Drawing.Point(70, 219);
            this.playAgainLbl.Name = "playAgainLbl";
            this.playAgainLbl.Size = new System.Drawing.Size(895, 76);
            this.playAgainLbl.TabIndex = 0;
            this.playAgainLbl.Text = "Would you like to play again?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.Location = new System.Drawing.Point(322, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "Playlist over.";
            // 
            // PlayAgainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Content);
            this.Name = "PlayAgainPage";
            this.Size = new System.Drawing.Size(1063, 681);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button noBtn;
        private System.Windows.Forms.Button yesBtn;
        private System.Windows.Forms.Label playAgainLbl;
        private System.Windows.Forms.Label label1;
    }
}
