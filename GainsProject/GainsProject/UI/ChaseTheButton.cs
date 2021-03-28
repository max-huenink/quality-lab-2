﻿//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To display a chase the button game 
//          for the user to play
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //GUI side of the chase the button game
    //---------------------------------------------------------------
    public partial class ChaseTheButton : UserControl
    {
        //Constants
        public const int Y_CORD_DIVISOR = 3;
        public const int Y_CORD_MULTIPLIER = 2;
        public const int NUMBER_OF_BUTTONS = 5;
        public const int MAX_BACKGROUND_CLICKS = 100;
        private int buttonNumber = 0;
        private int backgroundClicks = 0;
        //Chase the button game manager object -> Application layer connection
        private ChaseTheButtonGameManager game = new ChaseTheButtonGameManager();
        public ChaseTheButton()
        {
            InitializeComponent();
        }
        private bool nextGame;
        //---------------------------------------------------------------
        //Constructor that initializes the next game button, which calls
        // the NextGame method of ISelectGame when clicked
        //---------------------------------------------------------------
        public ChaseTheButton(IGamePlaylist selectGame)
        {
            InitializeComponent();
            nextGameBtn.Click += (sender, e) => selectGame.NextGame();
            exitGameBtn.Click += (sender, e) => selectGame.Exit();
            nextGame = true;
        }
        //---------------------------------------------------------------
        //GUI element logic when the start button is clicked
        //---------------------------------------------------------------
        public void SwitchToGameState()
        {
            //Hide and show GUI elements
            StartButton.Hide();
            richTextBox1.Hide();
            nextGameBtn.Hide();
        }

        //---------------------------------------------------------------
        //GUI logic when the start button is clicked. Also shows and
        //places the ChseButton in a random spot
        //---------------------------------------------------------------
        private void StartButton_Click(object sender, EventArgs e)
        {
            //Hide GUI elements
            SwitchToGameState();
            //start the game!
            game.start();
            //Show the button in a new position.
            moveButton();
            //start the stopwatch
            game.stopwatch.Start();
        }
        //---------------------------------------------------------------
        //Hides the ChaseButton, sets its cords to random cords, then
        //shows the button
        //---------------------------------------------------------------
        private void moveButton()
        {
            //Hide the button
            ChaseButton.Hide();
            //Calculate random cords
            int xCord = game.randomTime();
            int yCord = game.randomY();
            //Move and show the button
            ChaseButton.Location = new System.Drawing.Point(xCord, yCord);
            ChaseButton.Show();
        }
        //---------------------------------------------------------------
        //If the background is clicked while the game is live, add
        //a penalty.
        //---------------------------------------------------------------
        private void Content_Click(object sender, EventArgs e)
        {
            if(game.isGameLive() && backgroundClicks <= MAX_BACKGROUND_CLICKS)
            {
                backgroundClicks++;
            }
        }
        //---------------------------------------------------------------
        //When the chase button is clicked, add a button click, and
        //see if the 5th button has been clicked. If it has, then
        //wrap up the game.
        //---------------------------------------------------------------
        private void ChaseButton_Click(object sender, EventArgs e)
        {
            buttonNumber++;
            //Is this the 5th button?
            if (buttonNumber != NUMBER_OF_BUTTONS)
            {
                moveButton();
                return;
            }
            //Stop time, add penalties, calculate score then display the score
            game.stopwatch.Stop();
            game.setTime(game.stopwatch.ElapsedMilliseconds + backgroundClicks * MAX_BACKGROUND_CLICKS);
            game.calculateScore();
            //End the game.
            game.endGame();
            ChaseButton.Hide();
            nextGameBtn.Show();
            ScoreShow.Text = ("Score: " + game.getScore());
            ScoreShow.Show();
        }
    }
}