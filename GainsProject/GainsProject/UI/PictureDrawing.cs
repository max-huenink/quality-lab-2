using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;
namespace GainsProject.UI
{
    public partial class PictureDrawing : UserControl
    {
        static PictureDrawingManager pd = new PictureDrawingManager();
        public PictureDrawing()
        {
            InitializeComponent();
        }
        private bool nextGame;
        //---------------------------------------------------------------
        //Constructor that initializes the next game button, which calls
        // the NextGame method of ISelectGame when clicked
        //---------------------------------------------------------------
        public PictureDrawing(IGamePlaylist selectGame)
        {
            InitializeComponent();
            nextGameBtn.Click += (sender, e) => selectGame.NextGame();
            exitGameBtn.Click += (sender, e) => selectGame.Exit();
            nextGame = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = pd.getElapsedTime();
        }
        private void checkScoreButton_MouseEnter(object sender, EventArgs e)
        {
            checkScoreButton.BackColor = System.Drawing.Color.LimeGreen;
        }

        private void checkScoreButton_MouseLeave(object sender, EventArgs e)
        {
            checkScoreButton.BackColor = System.Drawing.Color.Tomato;
        }

        private void checkScoreButton_MouseClick(object sender, MouseEventArgs e)
        {
            if(!pd.isGameLive())
            {
                checkScoreButton.Text = "Check Score";
                checkScoreButton.BackColor = System.Drawing.Color.LimeGreen;
                pd.runGame();
                timer1.Enabled = true;
            }
            else
            {
                if(pd.checkPainting())
                {
                    timer1.Enabled = false;
                    checkScoreButton.Text = "PLAY AGAIN";
                    checkScoreButton.BackColor = System.Drawing.Color.Tomato;
                }
            }
        }

        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setPanelInfo(e.X, e.Y, drawingPanel.Width / 8);
            drawingPanel.Paint += new PaintEventHandler(pd.colorSquare);
            drawingPanel.Refresh();
        }

        private void paintWhite_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void paintYellow_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void paintOrange_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void paintRed_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void paintPurple_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void paintBlue_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void paintGreen_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void paintBrown_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void paintBlack_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
