
namespace GainsProject.UI
{
    partial class PictureDrawing
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
            this.nextGameBtn = new System.Windows.Forms.Button();
            this.exitGameBtn = new System.Windows.Forms.Button();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.paintBlack = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.paintBrown = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.paintGreen = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.paintBlue = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.paintPurple = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.paintRed = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.paintOrange = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.paintYellow = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.paintWhite = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dashedTimerLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.dashedLineLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkScoreButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.incorrectPictureLabel = new System.Windows.Forms.Label();
            this.endTimeLabel = new System.Windows.Forms.Label();
            this.paintBlack.SuspendLayout();
            this.paintBrown.SuspendLayout();
            this.paintGreen.SuspendLayout();
            this.paintBlue.SuspendLayout();
            this.paintPurple.SuspendLayout();
            this.paintRed.SuspendLayout();
            this.paintOrange.SuspendLayout();
            this.paintYellow.SuspendLayout();
            this.paintWhite.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextGameBtn
            // 
            this.nextGameBtn.Location = new System.Drawing.Point(971, 631);
            this.nextGameBtn.Name = "nextGameBtn";
            this.nextGameBtn.Size = new System.Drawing.Size(75, 23);
            this.nextGameBtn.TabIndex = 3;
            this.nextGameBtn.Text = "NextGame";
            this.nextGameBtn.UseVisualStyleBackColor = true;
            this.nextGameBtn.Visible = false;
            // 
            // exitGameBtn
            // 
            this.exitGameBtn.Location = new System.Drawing.Point(890, 631);
            this.exitGameBtn.Name = "exitGameBtn";
            this.exitGameBtn.Size = new System.Drawing.Size(75, 23);
            this.exitGameBtn.TabIndex = 7;
            this.exitGameBtn.Text = "Exit";
            this.exitGameBtn.UseVisualStyleBackColor = true;
            this.exitGameBtn.Click += new System.EventHandler(this.exitGameBtn_Click);
            // 
            // picturePanel
            // 
            this.picturePanel.BackColor = System.Drawing.Color.White;
            this.picturePanel.Location = new System.Drawing.Point(33, 157);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(240, 240);
            this.picturePanel.TabIndex = 8;
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.Location = new System.Drawing.Point(350, 100);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(360, 360);
            this.drawingPanel.TabIndex = 9;
            this.drawingPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseClick);
            // 
            // paintBlack
            // 
            this.paintBlack.BackColor = System.Drawing.Color.Black;
            this.paintBlack.Controls.Add(this.label11);
            this.paintBlack.Location = new System.Drawing.Point(834, 508);
            this.paintBlack.Name = "paintBlack";
            this.paintBlack.Size = new System.Drawing.Size(80, 80);
            this.paintBlack.TabIndex = 0;
            this.paintBlack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintBlack_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(64, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "9";
            // 
            // paintBrown
            // 
            this.paintBrown.BackColor = System.Drawing.Color.SaddleBrown;
            this.paintBrown.Controls.Add(this.label10);
            this.paintBrown.Location = new System.Drawing.Point(748, 508);
            this.paintBrown.Name = "paintBrown";
            this.paintBrown.Size = new System.Drawing.Size(80, 80);
            this.paintBrown.TabIndex = 10;
            this.paintBrown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintBrown_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "8";
            // 
            // paintGreen
            // 
            this.paintGreen.BackColor = System.Drawing.Color.Green;
            this.paintGreen.Controls.Add(this.label9);
            this.paintGreen.Location = new System.Drawing.Point(662, 508);
            this.paintGreen.Name = "paintGreen";
            this.paintGreen.Size = new System.Drawing.Size(80, 80);
            this.paintGreen.TabIndex = 11;
            this.paintGreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintGreen_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "7";
            // 
            // paintBlue
            // 
            this.paintBlue.BackColor = System.Drawing.Color.Blue;
            this.paintBlue.Controls.Add(this.label8);
            this.paintBlue.Location = new System.Drawing.Point(576, 508);
            this.paintBlue.Name = "paintBlue";
            this.paintBlue.Size = new System.Drawing.Size(80, 80);
            this.paintBlue.TabIndex = 12;
            this.paintBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintBlue_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "6";
            // 
            // paintPurple
            // 
            this.paintPurple.BackColor = System.Drawing.Color.Purple;
            this.paintPurple.Controls.Add(this.label7);
            this.paintPurple.Location = new System.Drawing.Point(490, 508);
            this.paintPurple.Name = "paintPurple";
            this.paintPurple.Size = new System.Drawing.Size(80, 80);
            this.paintPurple.TabIndex = 13;
            this.paintPurple.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintPurple_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "5";
            // 
            // paintRed
            // 
            this.paintRed.BackColor = System.Drawing.Color.Red;
            this.paintRed.Controls.Add(this.label6);
            this.paintRed.Location = new System.Drawing.Point(404, 508);
            this.paintRed.Name = "paintRed";
            this.paintRed.Size = new System.Drawing.Size(80, 80);
            this.paintRed.TabIndex = 14;
            this.paintRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintRed_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "4";
            // 
            // paintOrange
            // 
            this.paintOrange.BackColor = System.Drawing.Color.Orange;
            this.paintOrange.Controls.Add(this.label5);
            this.paintOrange.Location = new System.Drawing.Point(318, 508);
            this.paintOrange.Name = "paintOrange";
            this.paintOrange.Size = new System.Drawing.Size(80, 80);
            this.paintOrange.TabIndex = 15;
            this.paintOrange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintOrange_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "3";
            // 
            // paintYellow
            // 
            this.paintYellow.BackColor = System.Drawing.Color.Yellow;
            this.paintYellow.Controls.Add(this.label4);
            this.paintYellow.Location = new System.Drawing.Point(232, 508);
            this.paintYellow.Name = "paintYellow";
            this.paintYellow.Size = new System.Drawing.Size(80, 80);
            this.paintYellow.TabIndex = 16;
            this.paintYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintYellow_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "2";
            // 
            // paintWhite
            // 
            this.paintWhite.BackColor = System.Drawing.Color.White;
            this.paintWhite.Controls.Add(this.label2);
            this.paintWhite.Location = new System.Drawing.Point(146, 508);
            this.paintWhite.Name = "paintWhite";
            this.paintWhite.Size = new System.Drawing.Size(80, 80);
            this.paintWhite.TabIndex = 17;
            this.paintWhite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paintWhite_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "1";
            // 
            // dashedTimerLabel
            // 
            this.dashedTimerLabel.AutoSize = true;
            this.dashedTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashedTimerLabel.Location = new System.Drawing.Point(857, 38);
            this.dashedTimerLabel.Name = "dashedTimerLabel";
            this.dashedTimerLabel.Size = new System.Drawing.Size(108, 25);
            this.dashedTimerLabel.TabIndex = 18;
            this.dashedTimerLabel.Text = "---Timer---";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(857, 63);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(108, 25);
            this.timerLabel.TabIndex = 19;
            this.timerLabel.Text = "00: 00: 00";
            // 
            // dashedLineLabel
            // 
            this.dashedLineLabel.AutoSize = true;
            this.dashedLineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashedLineLabel.Location = new System.Drawing.Point(855, 75);
            this.dashedLineLabel.Name = "dashedLineLabel";
            this.dashedLineLabel.Size = new System.Drawing.Size(110, 25);
            this.dashedLineLabel.TabIndex = 20;
            this.dashedLineLabel.Text = "--------------";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkScoreButton
            // 
            this.checkScoreButton.BackColor = System.Drawing.Color.Tomato;
            this.checkScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkScoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkScoreButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkScoreButton.Location = new System.Drawing.Point(818, 221);
            this.checkScoreButton.Name = "checkScoreButton";
            this.checkScoreButton.Size = new System.Drawing.Size(186, 122);
            this.checkScoreButton.TabIndex = 21;
            this.checkScoreButton.Text = "START";
            this.checkScoreButton.UseVisualStyleBackColor = false;
            this.checkScoreButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkScoreButton_KeyDown);
            this.checkScoreButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkScoreButton_MouseClick);
            this.checkScoreButton.MouseEnter += new System.EventHandler(this.checkScoreButton_MouseEnter);
            this.checkScoreButton.MouseLeave += new System.EventHandler(this.checkScoreButton_MouseLeave);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(813, 157);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(80, 25);
            this.scoreLabel.TabIndex = 22;
            this.scoreLabel.Text = "Score: ";
            this.scoreLabel.Visible = false;
            // 
            // incorrectPictureLabel
            // 
            this.incorrectPictureLabel.AutoSize = true;
            this.incorrectPictureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectPictureLabel.Location = new System.Drawing.Point(813, 132);
            this.incorrectPictureLabel.Name = "incorrectPictureLabel";
            this.incorrectPictureLabel.Size = new System.Drawing.Size(146, 25);
            this.incorrectPictureLabel.TabIndex = 23;
            this.incorrectPictureLabel.Text = "Bad Pictures: ";
            this.incorrectPictureLabel.Visible = false;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeLabel.Location = new System.Drawing.Point(813, 107);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(71, 25);
            this.endTimeLabel.TabIndex = 24;
            this.endTimeLabel.Text = "Time: ";
            this.endTimeLabel.Visible = false;
            // 
            // PictureDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.endTimeLabel);
            this.Controls.Add(this.incorrectPictureLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.checkScoreButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.dashedTimerLabel);
            this.Controls.Add(this.paintWhite);
            this.Controls.Add(this.paintYellow);
            this.Controls.Add(this.paintOrange);
            this.Controls.Add(this.paintRed);
            this.Controls.Add(this.paintPurple);
            this.Controls.Add(this.paintBlue);
            this.Controls.Add(this.paintGreen);
            this.Controls.Add(this.paintBrown);
            this.Controls.Add(this.paintBlack);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.exitGameBtn);
            this.Controls.Add(this.nextGameBtn);
            this.Controls.Add(this.dashedLineLabel);
            this.Name = "PictureDrawing";
            this.Size = new System.Drawing.Size(1060, 686);
            this.paintBlack.ResumeLayout(false);
            this.paintBlack.PerformLayout();
            this.paintBrown.ResumeLayout(false);
            this.paintBrown.PerformLayout();
            this.paintGreen.ResumeLayout(false);
            this.paintGreen.PerformLayout();
            this.paintBlue.ResumeLayout(false);
            this.paintBlue.PerformLayout();
            this.paintPurple.ResumeLayout(false);
            this.paintPurple.PerformLayout();
            this.paintRed.ResumeLayout(false);
            this.paintRed.PerformLayout();
            this.paintOrange.ResumeLayout(false);
            this.paintOrange.PerformLayout();
            this.paintYellow.ResumeLayout(false);
            this.paintYellow.PerformLayout();
            this.paintWhite.ResumeLayout(false);
            this.paintWhite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextGameBtn;
        private System.Windows.Forms.Button exitGameBtn;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.Panel paintBlack;
        private System.Windows.Forms.Panel paintBrown;
        private System.Windows.Forms.Panel paintGreen;
        private System.Windows.Forms.Panel paintBlue;
        private System.Windows.Forms.Panel paintPurple;
        private System.Windows.Forms.Panel paintRed;
        private System.Windows.Forms.Panel paintOrange;
        private System.Windows.Forms.Panel paintYellow;
        private System.Windows.Forms.Panel paintWhite;
        private System.Windows.Forms.Label dashedTimerLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label dashedLineLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button checkScoreButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label incorrectPictureLabel;
        private System.Windows.Forms.Label endTimeLabel;
    }
}
