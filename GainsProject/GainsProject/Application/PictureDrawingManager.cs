//---------------------------------------------------------------
// Name:    Ben Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To run the picture drawing game and manage the data
//---------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using GainsProject.Domain;

namespace GainsProject.Application
{
    public class PictureDrawingManager : BaseGame
    {
        public const int UPPER_PICTURE_LIMIT = 8;
        //Seeded random
        Random random = new Random();
        DateTime startTime = new DateTime();
        int[,] pictureArray = new int[8, 8];
        int[,] drawingArray = new int[8, 8];
        int color = 0;
        int xCoord = 0;
        int yCoord = 0;
        int boxSize = 0;
        int incorrectPictures = 0;

        public override void runGame()
        {
            incorrectPictures = 0;
            startTime = DateTime.Now;
            start();
        }

        public override void calculateScore()
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            long scoreSubtracter = Convert.ToInt64(elapsedTime.TotalSeconds) * 2;
            setScore(1000 - scoreSubtracter - (incorrectPictures * 100));
        }

        public override int randomTime()
        {
            return -1;
        }

        public string getElapsedTime()
        {
            string timeString = "";
            TimeSpan elapsedTime = DateTime.Now - startTime;
            timeString += elapsedTime.Hours.ToString("00") + ": " +
                elapsedTime.Minutes.ToString("00") + ": " +
                elapsedTime.Seconds.ToString("00");
            return timeString;
        }

        public void incorrectAnswer()
        {
            ++incorrectPictures;
        }

        public string getIncorrectPictures()
        {
            return "" + incorrectPictures;
        }

        public bool checkPainting()
        {
            bool isMatch = true;
            for(int i = 0; i < UPPER_PICTURE_LIMIT; i ++)
            {
                for(int j = 0; j < UPPER_PICTURE_LIMIT; j++)
                {
                    if(pictureArray[i,j] != drawingArray[i,j])
                    {
                        isMatch = false;
                        return isMatch;
                    }
                }
            }
            calculateScore();
            endGame();
            return isMatch;
        }

        public void colorSquare(object sender, PaintEventArgs e)
        {
            int xPos = xCoord / boxSize;
            int yPos = yCoord / boxSize;
            drawingArray[xPos, yPos] = color;
            for(int i = 0; i < UPPER_PICTURE_LIMIT; i++)
            {
                for(int j = 0; j < UPPER_PICTURE_LIMIT; j++)
                {
                    Rectangle rect = new Rectangle(i * boxSize, j * boxSize, boxSize, boxSize);
                    e.Graphics.FillRectangle(coloredBrush(drawingArray[i,j]), rect);
                }
            }
        }

        private SolidBrush coloredBrush(int color)
        {
            
            SolidBrush brush = new SolidBrush(Color.White);
            if(color == 0)
            {
                brush = new SolidBrush(Color.White);
            }
            else if (color == 1)
            {
                brush = new SolidBrush(Color.Yellow);
            }
            else if (color == 2)
            {
                brush = new SolidBrush(Color.Orange);
            }
            else if (color == 3)
            {
                brush = new SolidBrush(Color.Red);
            }
            else if (color == 4)
            {
                brush = new SolidBrush(Color.Purple);
            }
            else if (color == 5)
            {
                brush = new SolidBrush(Color.Blue);
            }
            else if (color == 6)
            {
                brush = new SolidBrush(Color.Green);
            }
            else if (color == 7)
            {
                brush = new SolidBrush(Color.SaddleBrown);
            }
            else if (color == 8)
            {
                brush = new SolidBrush(Color.Black);
            }
            return brush;
        }

        public void setColor(int color)
        {
            this.color = color;
        }

        public int getColor()
        {
            return color;
        }

        public void setPanelInfo(int x, int y, int boxSize)
        {
            xCoord = x;
            yCoord = y;
            this.boxSize = boxSize;
        }

        public void fillPicturePanel(object sender, PaintEventArgs e)
        {
            boxSize = 30;
            int xPos = xCoord / boxSize;
            int yPos = yCoord / boxSize;
            drawingArray[xPos, yPos] = color;
            for (int i = 0; i < UPPER_PICTURE_LIMIT; i++)
            {
                for (int j = 0; j < UPPER_PICTURE_LIMIT; j++)
                {
                    Rectangle rect = new Rectangle(i * boxSize, j * boxSize, boxSize, boxSize);
                    e.Graphics.FillRectangle(coloredBrush(pictureArray[i, j]), rect);
                }
            }
        }
        public void loadPicturePanel()
        {
            //Stream
        }
    }
}
