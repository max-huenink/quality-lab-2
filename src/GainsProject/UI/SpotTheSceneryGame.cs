//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To display the spot the scenery game to the user
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GainsProject.Application;
using GainsProject.Domain.Interfaces;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    // This is the UI class to display the spot the scenery game for
    // the user
    //---------------------------------------------------------------
    public partial class SpotTheSceneryGame : UserControl
    {
        private SpotTheSceneryGameManager stsgManager =
            new SpotTheSceneryGameManager();
        private const string GAME_NAME = "SpotTheScenery.txt";
        private const int FIRST_PICTURE = 1;
        private const int SECOND_PICTURE = 2;
        private const int THIRD_PICUTRE = 3;
        private const int FOURTH_PICTURE = 4;
        private ScoreSaveManager scoreSaveManager =
            ScoreSaveManager.getScoreSaveManager();
        private NameClass name = new NameClass();
        private readonly IGameEnd gameEnd;

        //---------------------------------------------------------------
        // parameterized constructor
        //---------------------------------------------------------------
        public SpotTheSceneryGame(IGameEnd gameEnd)
        {
            InitializeComponent();
            this.gameEnd = gameEnd;
        }

        //---------------------------------------------------------------
        // event when the start button is clicked on the tutorial view
        //---------------------------------------------------------------
        private void TutorialStartButton_Click(object sender, EventArgs e)
        {
            TutorialStartButton.Visible = false;
            TutorialText.Visible = false;
            stsgManager.start();
            stsgManager.fillPictureManager();
            intermediaryView();
        }

        //---------------------------------------------------------------
        // the event when the ok button is clicked when the game tells
        // the user wha descriptor to use
        //---------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            gameplayView();
        }

        //---------------------------------------------------------------
        // a picture was clicked on and it will call the method with its
        // number in the picture list
        //---------------------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureClicked(FIRST_PICTURE);
        }

        //---------------------------------------------------------------
        // a picture was clicked on and it will call the method with its
        // number in the picture list
        //---------------------------------------------------------------
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureClicked(FOURTH_PICTURE);
        }

        //---------------------------------------------------------------
        // a picture was clicked on and it will call the method with its
        // number in the picture list
        //---------------------------------------------------------------
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureClicked(THIRD_PICUTRE);
        }

        //---------------------------------------------------------------
        // a picture was clicked on and it will call the method with its
        // number in the picture list
        //---------------------------------------------------------------
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureClicked(SECOND_PICTURE);
        }

        //---------------------------------------------------------------
        // called by pictureBox mouse click events to call logic in
        // manager. It will send the PICNUMBER for what picture to check
        //---------------------------------------------------------------
        private void pictureClicked(int picNumber)
        {
            stsgManager.pictureClicked(picNumber);
            numRight.Text = stsgManager.getNumRight().ToString();
            if (stsgManager.hasNextRound())
                intermediaryView();
            else
                gameOver();
        }

        //---------------------------------------------------------------
        // contains logic for the start of a round and makes the
        // intermediary view visible
        //---------------------------------------------------------------
        private void intermediaryView()
        {
            stsgManager.newRound();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            intermediaryButton.Visible = true;
            intermediaryLabel.Visible = true;
            descriptorHere.Visible = true;
            pictureBox1.Image = stsgManager.getCurrPictures()[0];
            pictureBox2.Image = stsgManager.getCurrPictures()[1];
            pictureBox3.Image = stsgManager.getCurrPictures()[2];
            pictureBox4.Image = stsgManager.getCurrPictures()[3];
            descriptorHere.Text = stsgManager.getCurrDescriptor();
        }

        //---------------------------------------------------------------
        // makes the gameplay view visible
        //---------------------------------------------------------------
        private void gameplayView()
        {
            intermediaryButton.Visible = false;
            intermediaryLabel.Visible = false;
            descriptorHere.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
        }

        //---------------------------------------------------------------
        // calls logic for end of game and to save the score
        //---------------------------------------------------------------
        private void gameOver()
        {
            //TODO
            stsgManager.endGame();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            stsgManager.calculateScore();
            scoreHere.Text = stsgManager.getScore().ToString();
            scoreHere.Visible = true;
            scoreLabel.Visible = true;
            ScoreSave scoreSave = scoreSaveManager.getScoreSave(GAME_NAME);
            scoreSave.addScore((int)stsgManager.getScore(), name.getName());
            gameEnd?.gameFinished(name.getName(), stsgManager.getScore(),
                stsgManager.getGameRunTime());
        }
    }
}
