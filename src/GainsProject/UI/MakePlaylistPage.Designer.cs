
namespace GainsProject.UI
{
    partial class MakePlaylistPage
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
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GamePlaylist = new System.Windows.Forms.TableLayoutPanel();
            this.GameSelector = new System.Windows.Forms.TableLayoutPanel();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Controls.Add(this.startButton);
            this.Content.Controls.Add(this.label2);
            this.Content.Controls.Add(this.label1);
            this.Content.Controls.Add(this.GamePlaylist);
            this.Content.Controls.Add(this.GameSelector);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1063, 681);
            this.Content.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Rockwell", 27.75F);
            this.startButton.Location = new System.Drawing.Point(421, 294);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(239, 154);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start Playlist";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 27.75F);
            this.label2.Location = new System.Drawing.Point(777, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Playlist: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 27.75F);
            this.label1.Location = new System.Drawing.Point(3, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 84);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pick the games you \nwish to play: ";
            // 
            // GamePlaylist
            // 
            this.GamePlaylist.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GamePlaylist.AutoSize = true;
            this.GamePlaylist.ColumnCount = 1;
            this.GamePlaylist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GamePlaylist.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.GamePlaylist.Location = new System.Drawing.Point(818, 294);
            this.GamePlaylist.Name = "GamePlaylist";
            this.GamePlaylist.RowCount = 1;
            this.GamePlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GamePlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.GamePlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.GamePlaylist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.GamePlaylist.Size = new System.Drawing.Size(81, 44);
            this.GamePlaylist.TabIndex = 1;
            // 
            // GameSelector
            // 
            this.GameSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameSelector.AutoSize = true;
            this.GameSelector.ColumnCount = 1;
            this.GameSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GameSelector.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.GameSelector.Location = new System.Drawing.Point(138, 294);
            this.GameSelector.Name = "GameSelector";
            this.GameSelector.RowCount = 1;
            this.GameSelector.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.GameSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.GameSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.GameSelector.Size = new System.Drawing.Size(81, 44);
            this.GameSelector.TabIndex = 0;
            // 
            // MakePlaylistPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Content);
            this.Name = "MakePlaylistPage";
            this.Size = new System.Drawing.Size(1063, 681);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.TableLayoutPanel GamePlaylist;
        private System.Windows.Forms.TableLayoutPanel GameSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
    }
}
