using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GainsProject
{
    //--------------------------------------------------------------------
    //This is a class that will hold all of the data logic for displaying
    //scores on the PreviousScoresPage
    //--------------------------------------------------------------------
    class ScoreDisplay
    {
        const int TIME_DISPLAY = 0;
        const int TAG_DISPLAY = 1;
        const int SCORE_DISPLAY = 2;
        const string SOMETHING_BROKE = "SOMETHING BROKE";   //this is fine because it 
                                                            //will never get used
        private int numGames;
        private int currDisplay; //0-time, 1-tag, 2-score
        bool reverseScore; //if the score is in reverse order or not
        private int totalScore;
        private double avgGamePoints;
        //save a list for each right away so it does not have to be 
        //recalculated at each button press
        private List<SaveData> timeSorted;
        private List<SaveData> tagSorted;
        private List<SaveData> scoreSorted;
        //this is a parameterized constructor
        public ScoreDisplay(ScoreSave scoreSave)
        {
            this.currDisplay = 0;
            this.reverseScore = false;
            this.numGames = scoreSave.getNumGames();
            this.totalScore = scoreSave.getTotalScore();
            this.avgGamePoints = scoreSave.getAvgGamePoints();
            this.timeSorted = scoreSave.getSaveDataList();
            tagSort();
            scoreSort();
        }
        //---------------------------------------------------------------
        //sort a list in order of the tags using insert sort
        //---------------------------------------------------------------
        private void tagSort()
        {
            tagSorted = this.timeSorted.ToList();
            int i, j;
            SaveData key;
            for(i = 1; i < this.numGames; i++)
            {
                key = tagSorted[i];
                j = i - 1;
                while(j >= 0 && String.Compare(tagSorted[j].getPlayerTag()
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
            scoreSorted = this.timeSorted.ToList();
            int i, j;
            SaveData key;
            for (i = 1; i < this.numGames; i++)
            {
                key = scoreSorted[i];
                j = i - 1;
                while (j >= 0 && String.Compare(
                    scoreSorted[j].getPlayerTag(), key.getPlayerTag()) > 0)
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
            if(currDisplay == TIME_DISPLAY)
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
            if(reverseScore == false)
            {
                switch(currDisplay)
                {
                    case TIME_DISPLAY: 
                        return getTimeSortedTimestamp();
                    case TAG_DISPLAY:
                        return getTagSortedTimestamp();
                    case SCORE_DISPLAY:
                        return getScoreSortedTimestamp();
                    default:
                        return SOMETHING_BROKE;
                }
            }
            else
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        return getReverseTimeSortedTimestamp();
                    case TAG_DISPLAY:
                        return getReverseTagSortedTimestamp();
                    case SCORE_DISPLAY:
                        return getReverseScoreSortedTimestamp();
                    default:
                        return SOMETHING_BROKE;
                }
            }
        }
        //---------------------------------------------------------------
        //get the correct string for tag
        //---------------------------------------------------------------
        public string getTag()
        {
            if (reverseScore == false)
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        return getTimeSortedTag();
                    case TAG_DISPLAY:
                        return getTagSortedTag();
                    case SCORE_DISPLAY:
                        return getScoreSortedTag();
                    default:
                        return SOMETHING_BROKE;
                }
            }
            else
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        return getReverseTimeSortedTag();
                    case TAG_DISPLAY:
                        return getReverseTagSortedTag();
                    case SCORE_DISPLAY:
                        return getReverseScoreSortedTag();
                    default:
                        return SOMETHING_BROKE;
                }
            }
        }
        //---------------------------------------------------------------
        //get the correct string for score
        //---------------------------------------------------------------
        public string getScore()
        {
            if (reverseScore == false)
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        return getTimeSortedScore();
                    case TAG_DISPLAY:
                        return getTagSortedScore();
                    case SCORE_DISPLAY:
                        return getScoreSortedScore();
                    default:
                        return SOMETHING_BROKE;
                }
            }
            else
            {
                switch (currDisplay)
                {
                    case TIME_DISPLAY:
                        return getReverseTimeSortedScore();
                    case TAG_DISPLAY:
                        return getReverseTagSortedScore();
                    case SCORE_DISPLAY:
                        return getReverseScoreSortedScore();
                    default:
                        return SOMETHING_BROKE;
                }
            }
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
            for(int i = 0; i < this.numGames; i++)
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
            for (int i = this.numGames - 1; i >= 0; i--)
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
            for (int i = 0; i < this.numGames; i++)
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
            for (int i = this.numGames - 1; i >= 0; i--)
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
            for (int i = 0; i < this.numGames; i++)
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
            for (int i = this.numGames - 1; i >= 0; i--)
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
            for (int i = 0; i < this.numGames; i++)
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
            for (int i = this.numGames - 1; i >= 0; i--)
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
            for (int i = 0; i < this.numGames; i++)
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
            for (int i = this.numGames - 1; i >= 0; i--)
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
            for (int i = 0; i < this.numGames; i++)
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
            for (int i = this.numGames - 1; i >= 0; i--)
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
            for (int i = 0; i < this.numGames; i++)
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
            for (int i = this.numGames - 1; i >= 0; i--)
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
            for (int i = 0; i < this.numGames; i++)
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
            for (int i = this.numGames - 1; i >= 0; i--)
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
            for (int i = 0; i < this.numGames; i++)
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
            for (int i = this.numGames - 1; i >= 0; i--)
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
    }
}
