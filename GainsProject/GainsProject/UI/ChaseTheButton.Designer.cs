namespace GainsProject.UI
{
    partial class ChaseTheButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChaseTheButton));
            this.Content = new System.Windows.Forms.Panel();
            this.ScoreShow = new System.Windows.Forms.Label();
            this.ChaseButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.nextGameBtn = new System.Windows.Forms.Button();
            this.exitGameBtn = new System.Windows.Forms.Button();
            this.NameEnter = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.Moccasin;
            this.Content.Controls.Add(this.SaveButton);
            this.Content.Controls.Add(this.NameEnter);
            this.Content.Controls.Add(this.ScoreShow);
            this.Content.Controls.Add(this.ChaseButton);
            this.Content.Controls.Add(this.richTextBox1);
            this.Content.Controls.Add(this.StartButton);
            this.Content.Controls.Add(this.nextGameBtn);
            this.Content.Controls.Add(this.exitGameBtn);
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1060, 686);
            this.Content.TabIndex = 0;
            this.Content.Click += new System.EventHandler(this.Content_Click);
            // 
            // ScoreShow
            // 
            this.ScoreShow.AutoSize = true;
            this.ScoreShow.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreShow.Location = new System.Drawing.Point(386, 59);
            this.ScoreShow.Name = "ScoreShow";
            this.ScoreShow.Size = new System.Drawing.Size(161, 54);
            this.ScoreShow.TabIndex = 12;
            this.ScoreShow.Text = "label1";
            this.ScoreShow.Visible = false;
            // 
            // ChaseButton
            // 
            this.ChaseButton.BackColor = System.Drawing.Color.LightPink;
            this.ChaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChaseButton.Location = new System.Drawing.Point(47, 477);
            this.ChaseButton.Name = "ChaseButton";
            this.ChaseButton.Size = new System.Drawing.Size(158, 56);
            this.ChaseButton.TabIndex = 11;
            this.ChaseButton.Text = "Click me!";
            this.ChaseButton.UseVisualStyleBackColor = false;
            this.ChaseButton.Visible = false;
            this.ChaseButton.Click += new System.EventHandler(this.ChaseButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Bisque;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(96, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(844, 154);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.NavajoWhite;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(372, 404);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(319, 115);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // nextGameBtn
            // 
            this.nextGameBtn.Location = new System.Drawing.Point(891, 651);
            this.nextGameBtn.Name = "nextGameBtn";
            this.nextGameBtn.Size = new System.Drawing.Size(75, 23);
            this.nextGameBtn.TabIndex = 8;
            this.nextGameBtn.Text = "NextGame";
            this.nextGameBtn.UseVisualStyleBackColor = true;
            this.nextGameBtn.Visible = false;
            // 
            // exitGameBtn
            // 
            this.exitGameBtn.Location = new System.Drawing.Point(972, 651);
            this.exitGameBtn.Name = "exitGameBtn";
            this.exitGameBtn.Size = new System.Drawing.Size(75, 23);
            this.exitGameBtn.TabIndex = 7;
            this.exitGameBtn.Text = "Exit";
            this.exitGameBtn.UseVisualStyleBackColor = true;
            // 
            // NameEnter
            // 
            this.NameEnter.Location = new System.Drawing.Point(395, 289);
            this.NameEnter.Name = "NameEnter";
            this.NameEnter.Size = new System.Drawing.Size(270, 20);
            this.NameEnter.TabIndex = 13;
            this.NameEnter.Text = "Enter your name here!";
            this.NameEnter.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(486, 315);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Save score";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ChaseTheButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Content);
            this.Name = "ChaseTheButton";
            this.Size = new System.Drawing.Size(1060, 686);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Button exitGameBtn;
        private System.Windows.Forms.Button nextGameBtn;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ChaseButton;
        private System.Windows.Forms.Label ScoreShow;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox NameEnter;
    }
}
