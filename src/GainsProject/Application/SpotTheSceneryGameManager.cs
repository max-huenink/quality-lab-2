//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To contain logic for the spot the scenery game
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GainsProject.Domain;
using System.Diagnostics;

namespace GainsProject.Application
{
    //---------------------------------------------------------------
    // This class contains logic for the spot the scenery game
    //---------------------------------------------------------------
    public class SpotTheSceneryGameManager : BaseGame
    {
        private Random random = new Random();
        private const int RANDOM_TIME = 5;
        public const int NUM_ROUNDS = 5;        //public for testing
        private const int NUM_PICTURES = 4;
        public const int PERFECT_TIME = 5000;   //public for testing
        public const int PERFECT_SCORE = 1000;  //public for testing
        public const int SCORE_DECAY = 50;      //public for testing
        private int currRound = 0;
        private string currDescriptor;
        private int numRight = 0;
        private int numWrong = 0;
        private List<Image> currPictures = new List<Image>();
        private List<string> currPicturesNames = new List<string>();
        private SpotTheSceneryPictureDescriptor stspd = new SpotTheSceneryPictureDescriptor();
        //---------------------------------------------------------------
        // this method calcualtes the score for the performance taking
        // into account how long it took and how many were correct
        //---------------------------------------------------------------
        public override void calculateScore()
        {
            double score;
            if (totalRunTime.ElapsedMilliseconds <= PERFECT_TIME)
                score = PERFECT_SCORE;
            else
                score = PERFECT_SCORE - ((totalRunTime.ElapsedMilliseconds - PERFECT_TIME) / SCORE_DECAY);
            score *= ((double)numRight - (double)numWrong) / (double)numRight;
            if (score <= 0)
            {
                score = 0;
            }
            setScore((long)score);
        }
        //---------------------------------------------------------------
        // this method starts the timer for the game
        //---------------------------------------------------------------
        public override void runGame()
        {
            setTime(stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
        }
        //---------------------------------------------------------------
        // this method returns a random time
        //---------------------------------------------------------------
        public override int randomTime()
        {
            return random.Next(RANDOM_TIME);
        }
        //---------------------------------------------------------------
        // this method gets 4 random pictures to be displayed and a
        // descriptor from one of them
        //---------------------------------------------------------------
        public void newRound()
        {
            currRound++;
            currPictures.Clear();
            currPicturesNames.Clear();
            int numPictures = 0;
            List<Image> tempList = stspd.getPictureList();
            while (numPictures < 4)
            {
                //get a random number
                int rand = random.Next(tempList.Count - 1);
                Image tempImage = tempList[rand];
                string tempImageName = stspd.getPictureNamesList()[rand];
                //check if the image is in the currPictures
                if (!currPictures.Contains(tempImage))
                {
                    //check if currPictures is big enough for the first go through
                    if (numPictures >= currPictures.Count)
                    {
                        //add new element
                        currPictures.Add(tempImage);
                        currPicturesNames.Add(tempImageName);
                    }
                    numPictures++;
                }
            }
            List<string> tempDescriptors = stspd.getDescriptors()[currPicturesNames[random.Next(NUM_PICTURES - 1)]];
            currDescriptor = tempDescriptors[random.Next(tempDescriptors.Count - 1)];
        }
        //---------------------------------------------------------------
        // checks if there are more rounds to be played
        //---------------------------------------------------------------
        public bool hasNextRound()
        {
            if (currRound < NUM_ROUNDS)
                return true;
            else
                return false;
        }
        //---------------------------------------------------------------
        // checks if the picture in the list at index of PICTURENUMBER
        // has the same descriptor as the desired one
        //---------------------------------------------------------------
        public void pictureClicked(int pictureNumber)
        {
            string key = currPicturesNames[pictureNumber - 1];
            List<string> tempDescriptors = stspd.getDescriptors()[key];
            if (tempDescriptors.Contains(currDescriptor))
            {
                numRight++;
            }
            else
            {
                numWrong++;
            }
        }
        //---------------------------------------------------------------
        // getter for current pictures
        //---------------------------------------------------------------
        public List<Image> getCurrPictures()
        {
            return currPictures;
        }
        //---------------------------------------------------------------
        // getter for current descriptor
        //---------------------------------------------------------------
        public string getCurrDescriptor()
        {
            return currDescriptor;
        }
        //---------------------------------------------------------------
        // calls the fillDescirptors and fillPictureList from the picture
        // manager so they can be used later
        //---------------------------------------------------------------
        public void fillPictureManager()
        {
            stspd.fillDescriptors();
            stspd.fillPictureList();
        }
        //---------------------------------------------------------------
        // getter for numRight, used for testing
        //---------------------------------------------------------------
        public int getNumRight()
        {
            return numRight;
        }
        //---------------------------------------------------------------
        // getter for numWrong, used for testing
        //---------------------------------------------------------------
        public int getNumWrong()
        {
            return numWrong;
        }
        //---------------------------------------------------------------
        // setter for numRight, used for testing
        //---------------------------------------------------------------
        public void setNumRight(int numRight)
        {
            this.numRight = numRight;
        }
        //---------------------------------------------------------------
        // setter for numWrong, used for testing
        //---------------------------------------------------------------
        public void setNumWrong(int numWrong)
        {
            this.numWrong = numWrong;
        }
        //---------------------------------------------------------------
        // getter for current round
        //---------------------------------------------------------------
        public int getCurrRound()
        {
            return currRound;
        }
    }
}
