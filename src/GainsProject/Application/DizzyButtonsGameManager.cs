﻿//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: This class handles most of the logic for the dizzy
// buttons game
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using GainsProject.Domain;

namespace GainsProject.Application
{
    //---------------------------------------------------------------
    // this class handles the logic for the dizzy buttons game
    //---------------------------------------------------------------
    public class DizzyButtonsGameManager : BaseGame
    {
        private const string GAME_NAME = "DizzyButtons.txt";
        private const int GAME_LENGTH = 1000;
        public const int NUM_BUTTONS = 20;
        private const int SPEED_RANGE = 15;
        private const int PAGE_HEIGHT = 686;
        private const int PAGE_WIDTH = 1060;
        private const int BUTTON_WIDTH = 88;
        private const int BUTTON_HEIGHT = 40;
        public const int SCORE = 75;
        public const int MINUS_SCORE = 25;
        private const string DEFAULT_TEXT = "Don't Click Me";
        private const string IS_IT_TEXT = "CLICK ME!";
        private const int REVERSE_DIRECTION = -1;
        private const int SHIFT_SPEED_RANGE = 2;
        private const int BUTTON_OUT_OF_BOUNDS = -1;
        private bool isFinished;
        private readonly Color DEFAULT_BACK_COLOR = Color.FromName("White");
        private readonly Color IS_IT_BACK_COLOR = Color.FromName("Lime");
        private int tickCounter;
        private List<Button> buttonList;
        private List<int> xMove;
        private List<int> yMove;
        private Stack<Button> toAdd;
        private Stack<Button> toDelete;
        private Random random;
        private int score;

        //---------------------------------------------------------------
        // default constructor
        //---------------------------------------------------------------
        public DizzyButtonsGameManager()
        {
            toAdd = new Stack<Button>();
            toDelete = new Stack<Button>();
            isFinished = false;
            tickCounter = 0;
            score = 0;
            buttonList = new List<Button>();
            xMove = new List<int>();
            yMove = new List<int>();
            random = new Random();
            for (int i = 0; i < NUM_BUTTONS; i++)
            {
                addNewButton();
            }
            setIsIt(buttonList[random.Next(NUM_BUTTONS)]);
        }

        //---------------------------------------------------------------
        // this method is to satisfy the abstract base class
        //---------------------------------------------------------------
        public override void runGame()
        {
            start();
        }

        //---------------------------------------------------------------
        // this method is to satisfy the abstract base class
        //---------------------------------------------------------------
        public override void calculateScore()
        {

        }

        //---------------------------------------------------------------
        // this method is to satisfy the abstract base class
        //---------------------------------------------------------------
        public override int randomTime()
        {
            return 0;
        }

        //---------------------------------------------------------------
        // this method creates a button, formats it, and makes accompaning
        // movement lists
        //---------------------------------------------------------------
        private void addNewButton()
        {
            Button button = new Button();
            xMove.Add(random.Next(REVERSE_DIRECTION * (SPEED_RANGE /
                SHIFT_SPEED_RANGE), SPEED_RANGE / SHIFT_SPEED_RANGE));
            yMove.Add(random.Next(REVERSE_DIRECTION * (SPEED_RANGE /
                SHIFT_SPEED_RANGE), SPEED_RANGE / SHIFT_SPEED_RANGE));
            setButtonDefaults(button);
            button.Location = new Point(random.Next(PAGE_WIDTH - BUTTON_WIDTH),
                random.Next(PAGE_HEIGHT - BUTTON_HEIGHT));
            //this adds the onButtonClick method below as an event in a button
            button.MouseDown += new MouseEventHandler(onButtonClick);
            button.Width = BUTTON_WIDTH;
            button.Height = BUTTON_HEIGHT;
            buttonList.Add(button);
            toAdd.Push(button);
        }

        //---------------------------------------------------------------
        // set the default color and text message on a button
        //---------------------------------------------------------------
        public void setButtonDefaults(Button button)
        {
            button.Text = DEFAULT_TEXT;
            button.BackColor = DEFAULT_BACK_COLOR;
        }

        //---------------------------------------------------------------
        // Set the color to green and ask the user to click it. It also
        // makes the button on top so it can be seen over other buttons
        //---------------------------------------------------------------
        public void setIsIt(Button button)
        {
            button.Text = IS_IT_TEXT;
            button.BackColor = IS_IT_BACK_COLOR;
            button.BringToFront();
        }

        //---------------------------------------------------------------
        // If a button was clicked on and it was the green one it will 
        // award points and delete it, otherwise it will minus points
        //---------------------------------------------------------------
        public void onButtonClick(object sender, System.EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton.BackColor == IS_IT_BACK_COLOR)
            {
                score += SCORE;
                if (score > GAME_LENGTH)
                    score = GAME_LENGTH;
                int index = getButtonIndex(clickedButton);
                if (index != BUTTON_OUT_OF_BOUNDS)
                {
                    toDelete.Push(clickedButton);
                    buttonList.Remove(clickedButton);
                    xMove.Remove(xMove[index]);
                    yMove.Remove(yMove[index]);
                    addNewButton();
                    setIsIt(buttonList[random.Next(NUM_BUTTONS)]);
                }
            }
            else
            {
                score -= MINUS_SCORE;
            }
        }

        //---------------------------------------------------------------
        // this method is called by the timer in the ui page every tick
        // it moves the buttons and counts until the end of the game
        //---------------------------------------------------------------
        public void tick()
        {
            if (tickCounter == GAME_LENGTH)
            {
                isFinished = true;
            }
            for (int i = 0; i < NUM_BUTTONS; i++)
            {
                Point temp = new Point(buttonList[i].Location.X,
                   buttonList[i].Location.Y);
                if (temp.X < 0 || temp.X > PAGE_WIDTH - buttonList[i].Width)
                {
                    xMove[i] *= -1;
                }
                if (temp.Y < 0 || temp.Y > PAGE_HEIGHT - buttonList[i].Height)
                {
                    yMove[i] *= -1;
                }
                temp.X += xMove[i];
                temp.Y += yMove[i];
                buttonList[i].Location = temp;
            }
            tickCounter++;
        }

        //---------------------------------------------------------------
        // gets the index for a BUTTON in the list for deleting it after
        // getting sent through the sender object in the event handler
        //---------------------------------------------------------------
        private int getButtonIndex(Button button)
        {
            int count = -1;
            for (int i = 0; i < buttonList.Count; i++)
            {
                if (buttonList[i].Equals(button))
                {
                    count = i;
                    break;
                }
            }
            return count;
        }

        //getter for buttonList
        public List<Button> getButtonList()
        {
            return buttonList;
        }

        //---------------------------------------------------------------
        // decrement the score by the set amount
        //---------------------------------------------------------------
        public void minusScore()
        {
            score -= MINUS_SCORE;
        }

        //getter for score
        public int getScore()
        {
            return score;
        }

        //setter for score
        public void setScore(int score)
        {
            this.score = score;
        }

        //getter for isFinished
        public bool getIsFinished()
        {
            return isFinished;
        }

        //getter for toAdd
        public Stack<Button> getToAdd()
        {
            return toAdd;
        }

        //getter for toDelete
        public Stack<Button> getToDelete()
        {
            return toDelete;
        }
    }
}
