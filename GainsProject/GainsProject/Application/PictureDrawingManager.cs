//---------------------------------------------------------------
// Name:    Ben Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To run the picture drawing game and manage the data
//---------------------------------------------------------------
using System;
using System.Drawing;
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public override void runGame()
        {
            startTime = DateTime.Now;
            start();
        }

        public override void calculateScore()
        {
            throw new NotImplementedException();
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
            long score = getScore();
            setScore(score - 100);
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
            endGame();
            return isMatch;
        }

        public void colorSquare(object sender, PaintEventArgs e)
        {
            int xPos = xCoord / boxSize;
            int yPos = yCoord / boxSize;
            drawingArray[xPos, yPos] = color;
            Rectangle rect = new Rectangle(xPos * boxSize, yPos * boxSize, boxSize, boxSize);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            e.Graphics.FillRectangle(blueBrush, rect);
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
    }
}
