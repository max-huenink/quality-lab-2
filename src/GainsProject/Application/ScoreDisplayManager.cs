//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To hold all of the data and logic for displaying
// scores
//---------------------------------------------------------------
using GainsProject.Domain;
using System.Collections.Generic;
using System.Linq;

namespace GainsProject.Application
{
    //--------------------------------------------------------------------
    //This is a class that will hold all of the data logic for displaying
    //scores on the PreviousScoresPage
    //--------------------------------------------------------------------
    public class ScoreDisplayManager
    {
        private const int TIME_DISPLAY = 0;
        private const int TAG_DISPLAY = 1;
        private const int SCORE_DISPLAY = 2;
        //this is fine because it                                         
        //will never get used
        private int numGames;
        private int currDisplay = TIME_DISPLAY;     //0-time, 1-tag, 2-score
        private bool reverseScore;                   //if the score is in
                                                     //reverse order or not
        private double avgGamePoints;
        private List<SaveData> timeSorted;           //save a list for each right
                                                     //away so it does not
                                                     //have to be 
        private List<SaveData> tagSorted;            //recalculated at each
                                                     //button press
        private List<SaveData> scoreSorted;

        //---------------------------------------------------------------
        //this is a parameterized constructor that takes a SCORESAVE
        //object for displaying the information for a game
        //---------------------------------------------------------------
        public ScoreDisplayManager(ScoreSave scoreSave)
        {
            currDisplay = 0;
            reverseScore = false;
            numGames = scoreSave.getNumGames();
            avgGamePoints = scoreSave.getAvgGamePoints();
            timeSorted = scoreSave.getSaveDataList();
            tagSort();
            scoreSort();
        }

        //---------------------------------------------------------------
        //sort a list in order of the tags using insert sort
        //---------------------------------------------------------------
        private void tagSort()
        {
            tagSorted = timeSorted.ToList();
            int i, j;
            SaveData key;
            for (i = 1; i < numGames; i++)
            {
                key = tagSorted[i];
                j = i - 1;
                while (j >= 0 && string.Compare(tagSorted[j].getPlayerTag()
                    , key.getPlayerTag()) > 0)
                {
                    tagSorted[j + 1] = tagSorted[j];
                    j--;
                }
                tagSorted[j + 1] = key;
            }
        }

        //---------------------------------------------------------------
        //sort a list in order of the score using insert sort
        //---------------------------------------------------------------
        private void scoreSort()
        {
            scoreSorted = timeSorted.ToList();
            int i, j;
            SaveData key;
            for (i = 1; i < numGames; i++)
            {
                key = scoreSorted[i];
                j = i - 1;
                while (j >= 0 && scoreSorted[j].getScore() < key.getScore())
                {
                    scoreSorted[j + 1] = scoreSorted[j];
                    j--;
                }
                scoreSorted[j + 1] = key;
            }
        }

        //---------------------------------------------------------------
        //sort a list in order of the timestamps using insert sort
        //---------------------------------------------------------------
        public void setTimeSorted()
        {
            if (currDisplay == TIME_DISPLAY)
            {
                changeReverseScore();
            }
            else
            {
                currDisplay = TIME_DISPLAY;
                reverseScore = false;
            }
        }

        //---------------------------------------------------------------
        //set the currDisplay and/or change reverseScore
        //---------------------------------------------------------------
        public void setTagSorted()
        {
            if (currDisplay == TAG_DISPLAY)
            {
                changeReverseScore();
            }
            else
            {
                currDisplay = TAG_DISPLAY;
                reverseScore = false;
            }
        }

        //---------------------------------------------------------------
        //set the currDisplay and/or change reverseScore
        //---------------------------------------------------------------
        public void setScoreSorted()
        {
            if (currDisplay == SCORE_DISPLAY)
            {
                changeReverseScore();
            }
            else
            {
                currDisplay = SCORE_DISPLAY;
                reverseScore = false;
            }
        }

        //---------------------------------------------------------------
        //get the correct string for time
        //---------------------------------------------------------------
        public string getTime()
        {
            string rs = "";
            if (reverseScore == false)
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        rs = getTimeSortedTimestamp();
                        break;
                    case TAG_DISPLAY:
                        rs = getTagSortedTimestamp();
                        break;
                    case SCORE_DISPLAY:
                        rs = getScoreSortedTimestamp();
                        break;
                }
            }
            else
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        rs = getReverseTimeSortedTimestamp();
                        break;
                    case TAG_DISPLAY:
                        rs = getReverseTagSortedTimestamp();
                        break;
                    case SCORE_DISPLAY:
                        rs = getReverseScoreSortedTimestamp();
                        break;
                }
            }
            return rs;
        }

        //---------------------------------------------------------------
        //get the correct string for tag
        //---------------------------------------------------------------
        public string getTag()
        {
            string rs = "";
            if (reverseScore == false)
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        rs = getTimeSortedTag();
                        break;
                    case TAG_DISPLAY:
                        rs = getTagSortedTag();
                        break;
                    case SCORE_DISPLAY:
                        rs = getScoreSortedTag();
                        break;
                }
            }
            else
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        rs = getReverseTimeSortedTag();
                        break;
                    case TAG_DISPLAY:
                        rs = getReverseTagSortedTag();
                        break;
                    case SCORE_DISPLAY:
                        rs = getReverseScoreSortedTag();
                        break;
                }
            }
            return rs;
        }

        //---------------------------------------------------------------
        //get the correct string for score
        //---------------------------------------------------------------
        public string getScore()
        {
            string rs = "";
            if (reverseScore == false)
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        rs = getTimeSortedScore();
                        break;
                    case TAG_DISPLAY:
                        rs = getTagSortedScore();
                        break;
                    case SCORE_DISPLAY:
                        rs = getScoreSortedScore();
                        break;
                }
            }
            else
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        rs = getReverseTimeSortedScore();
                        break;
                    case TAG_DISPLAY:
                        rs = getReverseTagSortedScore();
                        break;
                    case SCORE_DISPLAY:
                        rs = getReverseScoreSortedScore();
                        break;
                }
            }
            return rs;
        }

        //---------------------------------------------------------------
        //make the reverseScore the opposite of what it is
        //---------------------------------------------------------------
        private void changeReverseScore()
        {
            if (reverseScore == false)
            {
                reverseScore = true;
            }
            else
            {
                reverseScore = false;
            }
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getTimeSortedTimestamp()
        {
            string returnString = "";
            for (int i = 0; i < numGames; i++)
            {
                returnString += timeSorted[i].getDt().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getReverseTimeSortedTimestamp()
        {
            string returnString = "";
            for (int i = numGames - 1; i >= 0; i--)
            {
                returnString += timeSorted[i].getDt().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getTagSortedTimestamp()
        {
            string returnString = "";
            for (int i = 0; i < numGames; i++)
            {
                returnString += tagSorted[i].getDt().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getReverseTagSortedTimestamp()
        {
            string returnString = "";
            for (int i = numGames - 1; i >= 0; i--)
            {
                returnString += tagSorted[i].getDt().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getScoreSortedTimestamp()
        {
            string returnString = "";
            for (int i = 0; i < numGames; i++)
            {
                returnString += scoreSorted[i].getDt().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getReverseScoreSortedTimestamp()
        {
            string returnString = "";
            for (int i = numGames - 1; i >= 0; i--)
            {
                returnString += scoreSorted[i].getDt().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getTimeSortedTag()
        {
            string returnString = "";
            for (int i = 0; i < numGames; i++)
            {
                returnString += timeSorted[i].getPlayerTag().ToString()
                    + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getReverseTimeSortedTag()
        {
            string returnString = "";
            for (int i = numGames - 1; i >= 0; i--)
            {
                returnString += timeSorted[i].getPlayerTag().ToString()
                    + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getTagSortedTag()
        {
            string returnString = "";
            for (int i = 0; i < numGames; i++)
            {
                returnString += tagSorted[i].getPlayerTag().ToString()
                    + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getReverseTagSortedTag()
        {
            string returnString = "";
            for (int i = numGames - 1; i >= 0; i--)
            {
                returnString += tagSorted[i].getPlayerTag().ToString()
                    + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getScoreSortedTag()
        {
            string returnString = "";
            for (int i = 0; i < numGames; i++)
            {
                returnString += scoreSorted[i].getPlayerTag().ToString()
                    + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getReverseScoreSortedTag()
        {
            string returnString = "";
            for (int i = numGames - 1; i >= 0; i--)
            {
                returnString += scoreSorted[i].getPlayerTag().ToString()
                    + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getTimeSortedScore()
        {
            string returnString = "";
            for (int i = 0; i < numGames; i++)
            {
                returnString += timeSorted[i].getScore().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getReverseTimeSortedScore()
        {
            string returnString = "";
            for (int i = numGames - 1; i >= 0; i--)
            {
                returnString += timeSorted[i].getScore().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getTagSortedScore()
        {
            string returnString = "";
            for (int i = 0; i < numGames; i++)
            {
                returnString += tagSorted[i].getScore().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getReverseTagSortedScore()
        {
            string returnString = "";
            for (int i = numGames - 1; i >= 0; i--)
            {
                returnString += tagSorted[i].getScore().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getScoreSortedScore()
        {
            string returnString = "";
            for (int i = 0; i < numGames; i++)
            {
                returnString += scoreSorted[i].getScore().ToString() + "\n";
            }
            return returnString;
        }

        //---------------------------------------------------------------
        //return the correct sorted and reversed string
        //---------------------------------------------------------------
        private string getReverseScoreSortedScore()
        {
            string returnString = "";
            for (int i = numGames - 1; i >= 0; i--)
            {
                returnString += scoreSorted[i].getScore().ToString()
                    + "\n";
            }
            return returnString;
        }

        //getter for numGames
        public int getNumGames()
        {
            return numGames;
        }

        //getter for avgGamePoints
        public double getAvgGamePoints()
        {
            return avgGamePoints;
        }

        //gettter for timeSorted
        public List<SaveData> getTimeSortedList()
        {
            return timeSorted;
        }

        //getter for tagSorted
        public List<SaveData> getTagSortedList()
        {
            return tagSorted;
        }

        //getter for scoreSorted
        public List<SaveData> getScoreSortedList()
        {
            return scoreSorted;
        }

        //getter for reverseScore
        public bool getReverseScore()
        {
            return reverseScore;
        }
    }
}
