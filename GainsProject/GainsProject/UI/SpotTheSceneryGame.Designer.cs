
namespace GainsProject.UI
{
    partial class SpotTheSceneryGame
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TutorialText = new System.Windows.Forms.Label();
            this.TutorialStartButton = new System.Windows.Forms.Button();
            this.intermediaryLabel = new System.Windows.Forms.Label();
            this.descriptorHere = new System.Windows.Forms.Label();
            this.intermediaryButton = new System.Windows.Forms.Button();
            this.numRight = new System.Windows.Forms.Label();
            this.scenesCorrect = new System.Windows.Forms.Label();
            this.scoreHere = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(518, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(368, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(144, 341);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(368, 244);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(518, 91);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(368, 244);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // TutorialText
            // 
            this.TutorialText.AutoSize = true;
            this.TutorialText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TutorialText.Location = new System.Drawing.Point(211, 186);
            this.TutorialText.Name = "TutorialText";
            this.TutorialText.Size = new System.Drawing.Size(627, 66);
            this.TutorialText.TabIndex = 4;
            this.TutorialText.Text = "You will be prompted to choose a scene based \r\non a discription of it out of 4 ch" +
    "oices";
            this.TutorialText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TutorialStartButton
            // 
            this.TutorialStartButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TutorialStartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TutorialStartButton.Location = new System.Drawing.Point(486, 272);
            this.TutorialStartButton.Name = "TutorialStartButton";
            this.TutorialStartButton.Size = new System.Drawing.Size(75, 38);
            this.TutorialStartButton.TabIndex = 5;
            this.TutorialStartButton.Text = "Start";
            this.TutorialStartButton.UseVisualStyleBackColor = true;
            this.TutorialStartButton.Click += new System.EventHandler(this.TutorialStartButton_Click);
            // 
            // intermediaryLabel
            // 
            this.intermediaryLabel.AutoSize = true;
            this.intermediaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediaryLabel.Location = new System.Drawing.Point(227, 199);
            this.intermediaryLabel.Name = "intermediaryLabel";
            this.intermediaryLabel.Size = new System.Drawing.Size(398, 37);
            this.intermediaryLabel.TabIndex = 6;
            this.intermediaryLabel.Text = "Click a scene that contains";
            this.intermediaryLabel.Visible = false;
            // 
            // descriptorHere
            // 
            this.descriptorHere.AutoSize = true;
            this.descriptorHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptorHere.Location = new System.Drawing.Point(621, 199);
            this.descriptorHere.Name = "descriptorHere";
            this.descriptorHere.Size = new System.Drawing.Size(226, 37);
            this.descriptorHere.TabIndex = 7;
            this.descriptorHere.Text = "STUFF_HERE";
            this.descriptorHere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.descriptorHere.Visible = false;
            // 
            // intermediaryButton
            // 
            this.intermediaryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediaryButton.Location = new System.Drawing.Point(428, 255);
            this.intermediaryButton.Name = "intermediaryButton";
            this.intermediaryButton.Size = new System.Drawing.Size(179, 89);
            this.intermediaryButton.TabIndex = 8;
            this.intermediaryButton.Text = "okay";
            this.intermediaryButton.UseVisualStyleBackColor = true;
            this.intermediaryButton.Visible = false;
            this.intermediaryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // numRight
            // 
            this.numRight.AutoSize = true;
            this.numRight.Location = new System.Drawing.Point(1005, 11);
            this.numRight.Name = "numRight";
            this.numRight.Size = new System.Drawing.Size(13, 13);
            this.numRight.TabIndex = 9;
            this.numRight.Text = "0";
            // 
            // scenesCorrect
            // 
            this.scenesCorrect.AutoSize = true;
            this.scenesCorrect.Location = new System.Drawing.Point(876, 11);
            this.scenesCorrect.Name = "scenesCorrect";
            this.scenesCorrect.Size = new System.Drawing.Size(132, 13);
            this.scenesCorrect.TabIndex = 10;
            this.scenesCorrect.Text = "Number of scenes correct:";
            // 
            // scoreHere
            // 
            this.scoreHere.AutoSize = true;
            this.scoreHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreHere.Location = new System.Drawing.Point(442, 326);
            this.scoreHere.Name = "scoreHere";
            this.scoreHere.Size = new System.Drawing.Size(152, 55);
            this.scoreHere.TabIndex = 11;
            this.scoreHere.Text = "label1";
            this.scoreHere.Visible = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(461, 278);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(109, 37);
            this.scoreLabel.TabIndex = 12;
            this.scoreLabel.Text = "Score:";
            this.scoreLabel.Visible = false;
            // 
            // SpotTheSceneryGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.scoreHere);
            this.Controls.Add(this.scenesCorrect);
            this.Controls.Add(this.numRight);
            this.Controls.Add(this.intermediaryButton);
            this.Controls.Add(this.descriptorHere);
            this.Controls.Add(this.intermediaryLabel);
            this.Controls.Add(this.TutorialStartButton);
            this.Controls.Add(this.TutorialText);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SpotTheSceneryGame";
            this.Size = new System.Drawing.Size(1060, 686);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label TutorialText;
        private System.Windows.Forms.Button TutorialStartButton;
        private System.Windows.Forms.Label intermediaryLabel;
        private System.Windows.Forms.Label descriptorHere;
        private System.Windows.Forms.Button intermediaryButton;
        private System.Windows.Forms.Label numRight;
        private System.Windows.Forms.Label scenesCorrect;
        private System.Windows.Forms.Label scoreHere;
        private System.Windows.Forms.Label scoreLabel;
    }
}
