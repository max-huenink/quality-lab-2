namespace GainsProject.UI
{
    partial class MentalMathGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MentalMathGame));
            this.Content = new System.Windows.Forms.Panel();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.exitGameBtn = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nextGameBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.ansBox = new System.Windows.Forms.TextBox();
            this.NameEnter = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Controls.Add(this.SaveButton);
            this.Content.Controls.Add(this.NameEnter);
            this.Content.Controls.Add(this.ScoreLabel);
            this.Content.Controls.Add(this.exitGameBtn);
            this.Content.Controls.Add(this.SubmitButton);
            this.Content.Controls.Add(this.label1);
            this.Content.Controls.Add(this.nextGameBtn);
            this.Content.Controls.Add(this.richTextBox1);
            this.Content.Controls.Add(this.StartButton);
            this.Content.Controls.Add(this.ansBox);
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1063, 686);
            this.Content.TabIndex = 0;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(423, 128);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(0, 23);
            this.ScoreLabel.TabIndex = 7;
            // 
            // exitGameBtn
            // 
            this.exitGameBtn.Location = new System.Drawing.Point(982, 643);
            this.exitGameBtn.Name = "exitGameBtn";
            this.exitGameBtn.Size = new System.Drawing.Size(75, 23);
            this.exitGameBtn.TabIndex = 6;
            this.exitGameBtn.Text = "Exit";
            this.exitGameBtn.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(498, 525);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Visible = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 54);
            this.label1.TabIndex = 3;
            // 
            // nextGameBtn
            // 
            this.nextGameBtn.Location = new System.Drawing.Point(901, 643);
            this.nextGameBtn.Name = "nextGameBtn";
            this.nextGameBtn.Size = new System.Drawing.Size(75, 23);
            this.nextGameBtn.TabIndex = 2;
            this.nextGameBtn.Text = "NextGame";
            this.nextGameBtn.UseVisualStyleBackColor = true;
            this.nextGameBtn.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Salmon;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(103, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(844, 154);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.IndianRed;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Location = new System.Drawing.Point(365, 345);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(346, 109);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ansBox
            // 
            this.ansBox.Location = new System.Drawing.Point(514, 499);
            this.ansBox.Name = "ansBox";
            this.ansBox.Size = new System.Drawing.Size(42, 20);
            this.ansBox.TabIndex = 4;
            this.ansBox.Visible = false;
            // 
            // NameEnter
            // 
            this.NameEnter.Location = new System.Drawing.Point(396, 333);
            this.NameEnter.Name = "NameEnter";
            this.NameEnter.Size = new System.Drawing.Size(270, 20);
            this.NameEnter.TabIndex = 14;
            this.NameEnter.Text = "Enter your name here!";
            this.NameEnter.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(498, 370);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save score";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            // 
            // MentalMathGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.Controls.Add(this.Content);
            this.Name = "MentalMathGame";
            this.Size = new System.Drawing.Size(1060, 686);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button nextGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ansBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button exitGameBtn;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TextBox NameEnter;
        private System.Windows.Forms.Button SaveButton;
    }
}
