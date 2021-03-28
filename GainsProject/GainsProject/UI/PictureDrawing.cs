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
                dashedTimerLabel.Visible = true;
                timerLabel.Visible = true;
                dashedLineLabel.Visible = true;
                endTimeLabel.Visible = false;
                incorrectPictureLabel.Visible = false;
                scoreLabel.Visible = false;
                checkScoreButton.Text = "Check Picture";
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

                    endTimeLabel.Text = "Time: " + pd.getElapsedTime();
                    incorrectPictureLabel.Text = "Bad Pictures: " + pd.getIncorrectPictures();
                    scoreLabel.Text = "Score: " + pd.getScore();

                    dashedTimerLabel.Visible = false;
                    timerLabel.Visible = false;
                    dashedLineLabel.Visible = false;
                    endTimeLabel.Visible = true;
                    incorrectPictureLabel.Visible = true;
                    scoreLabel.Visible = true;
                }
                else
                    pd.incorrectAnswer();
            }
        }

        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (pd.isGameLive())
            {
                pd.setPanelInfo(e.X, e.Y, drawingPanel.Width / 8);
                drawingPanel.Paint += new PaintEventHandler(pd.colorSquare);
                drawingPanel.Refresh();
            }
        }

        private void paintWhite_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(0);
        }

        private void paintYellow_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(1);
        }

        private void paintOrange_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(2);
        }

        private void paintRed_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(3);
        }

        private void paintPurple_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(4);
        }

        private void paintBlue_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(5);
        }

        private void paintGreen_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(6);
        }

        private void paintBrown_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(7);
        }

        private void paintBlack_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(8);
        }
    }
}
