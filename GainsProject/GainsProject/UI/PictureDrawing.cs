//---------------------------------------------------------------
// Name:    Ben Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To run the picture drawing game UI
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;
namespace GainsProject.UI
{
    public partial class PictureDrawing : UserControl
    {
        private static PictureDrawingManager pd = new PictureDrawingManager();
        public const int COLOR_WHITE = 0;
        public const int COLOR_YELLOW = 1;
        public const int COLOR_ORANGE = 2;
        public const int COLOR_RED = 3;
        public const int COLOR_PURPLE = 4;
        public const int COLOR_BLUE = 5;
        public const int COLOR_GREEN = 6;
        public const int COLOR_BROWN = 7;
        public const int COLOR_BLACK = 8;
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
        //---------------------------------------------------------------
        //updates the timer
        //---------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = pd.getElapsedTime();
        }
        //---------------------------------------------------------------
        //changes the color of the button when a cursor is hovering over
        //---------------------------------------------------------------
        private void checkScoreButton_MouseEnter(object sender, EventArgs e)
        {
            checkScoreButton.BackColor = System.Drawing.Color.LimeGreen;
        }
        //---------------------------------------------------------------
        //changes the color of the button when the cursor leaves button
        //---------------------------------------------------------------
        private void checkScoreButton_MouseLeave(object sender, EventArgs e)
        {
            checkScoreButton.BackColor = System.Drawing.Color.Tomato;
        }
        //---------------------------------------------------------------
        //checks whether the pictures are the same, updates UI 
        // if they are the same. It is also the button for starting the
        // game and playing more than one game.
        //---------------------------------------------------------------
        private void checkScoreButton_MouseClick(object sender, MouseEventArgs e)
        {
            if(!pd.isGameLive()) //starts a game
            {
                pd.setPanelInfo(0, 0, 360);
                drawingPanel.Paint += new PaintEventHandler(pd.clearPanel);
                drawingPanel.Refresh();
                dashedTimerLabel.Visible = true;
                timerLabel.Visible = true;
                dashedLineLabel.Visible = true;
                endTimeLabel.Visible = false;
                incorrectPictureLabel.Visible = false;
                scoreLabel.Visible = false;
                checkScoreButton.Text = "Check Picture";
                checkScoreButton.BackColor = System.Drawing.Color.LimeGreen;
                pd.runGame();
                picturePanel.Paint += new PaintEventHandler(pd.fillPicturePanel);
                picturePanel.Refresh();
                timer1.Enabled = true;
                label1.Visible = false;
                label3.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                
            }
            else //ends a game
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
                else //subtracts points for wrong picture
                    pd.incorrectAnswer();
            }
        }
        //---------------------------------------------------------------
        //colors one square in the picture.
        //---------------------------------------------------------------
        private void drawingPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (pd.isGameLive())
            {
                pd.setPanelInfo(e.X, e.Y, drawingPanel.Width / 8);
                drawingPanel.Paint += new PaintEventHandler(pd.colorSquare);
                drawingPanel.Refresh();
            }
        }
        //---------------------------------------------------------------
        //changes the color to white
        //---------------------------------------------------------------
        private void paintWhite_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(COLOR_WHITE);
        }
        //---------------------------------------------------------------
        //changes the color to yellow
        //---------------------------------------------------------------
        private void paintYellow_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(COLOR_YELLOW);
        }
        //---------------------------------------------------------------
        //changes the color to orange
        //---------------------------------------------------------------
        private void paintOrange_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(COLOR_ORANGE);
        }
        //---------------------------------------------------------------
        //changes the color to red
        //---------------------------------------------------------------
        private void paintRed_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(COLOR_RED);
        }
        //---------------------------------------------------------------
        //changes the color to purple
        //---------------------------------------------------------------
        private void paintPurple_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(COLOR_PURPLE);
        }
        //---------------------------------------------------------------
        //changes the color to blue
        //---------------------------------------------------------------
        private void paintBlue_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(COLOR_BLUE);
        }
        //---------------------------------------------------------------
        //changes the color to green
        //---------------------------------------------------------------
        private void paintGreen_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(COLOR_GREEN);
        }
        //---------------------------------------------------------------
        //changes the color to brown
        //---------------------------------------------------------------
        private void paintBrown_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(COLOR_BROWN);
        }
        //---------------------------------------------------------------
        //changes the color to black
        //---------------------------------------------------------------
        private void paintBlack_MouseClick(object sender, MouseEventArgs e)
        {
            pd.setColor(COLOR_BLACK);
        }
        //---------------------------------------------------------------
        //resets the game when the exit button is pressed
        // and resets all of the UI
        //---------------------------------------------------------------
        private void exitGameBtn_Click(object sender, EventArgs e)
        {
            pd.endGame();
            timer1.Enabled = false;
            checkScoreButton.Text = "START";
            checkScoreButton.BackColor = System.Drawing.Color.Tomato;

            dashedTimerLabel.Visible = true;
            timerLabel.Visible = true;
            dashedLineLabel.Visible = true;
            endTimeLabel.Visible = false;
            incorrectPictureLabel.Visible = false;
            scoreLabel.Visible = false;
        }
        //---------------------------------------------------------------
        //changes the color based on the key input pressed.
        //---------------------------------------------------------------
        private void checkScoreButton_KeyDown(object sender, KeyEventArgs e)
        {
            pd.setColorWithKey(e.KeyCode);
        }

    }
}
