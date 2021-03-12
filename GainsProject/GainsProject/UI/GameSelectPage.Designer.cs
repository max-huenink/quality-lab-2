
namespace GainsProject.UI
{
    partial class GameSelectPage
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
            this.GameSelector = new System.Windows.Forms.TableLayoutPanel();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Controls.Add(this.GameSelector);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1063, 681);
            this.Content.TabIndex = 0;
            // 
            // GameSelector
            // 
            this.GameSelector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameSelector.AutoSize = true;
            this.GameSelector.ColumnCount = 1;
            this.GameSelector.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.GameSelector.Location = new System.Drawing.Point(483, 327);
            this.GameSelector.Name = "GameSelector";
            this.GameSelector.RowCount = 1;
            this.GameSelector.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.GameSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GameSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GameSelector.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.GameSelector.Size = new System.Drawing.Size(64, 44);
            this.GameSelector.TabIndex = 0;
            // 
            // GameSelectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Content);
            this.Name = "GameSelectPage";
            this.Size = new System.Drawing.Size(1063, 681);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.TableLayoutPanel GameSelector;
    }
}
