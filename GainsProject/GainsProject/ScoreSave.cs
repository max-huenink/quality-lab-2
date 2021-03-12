using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GainsProject
{
    //--------------------------------------------------------------------
    //This is a class that reads in previous scores from a file, writes
    //scores to the same file once the application is closed or the object 
    //is out of scope, and can add scores to to a list.
    //--------------------------------------------------------------------
    public class ScoreSave
    {
        //placeholder until we have multiple games and their 
        //name will be passed in the constructor
        const string fileName = "GameScore.txt"; 
        private int numGames;
        private int totalScore; //this exists to make avgGamePoints faster to
                                //calculate
        private double avgGamePoints;
        //a list of SaveData nodes
        private List<SaveData> saveDataList;
        //default constructor
        public ScoreSave()
        {
            this.saveDataList = new List<SaveData>();
            readFile();
        }
        ~ScoreSave()
        {
            writeFile();
        }
        //--------------------------------------------------------------------
        //This method reads scores from a txt file into attributes
        //--------------------------------------------------------------------
        private void readFile()
        {
            //if the file exists read it in
            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(fileName);
                this.numGames = Convert.ToInt32(sr.ReadLine());
                this.totalScore = Convert.ToInt32(sr.ReadLine());
                this.avgGamePoints = Convert.ToDouble(sr.ReadLine());
                string line = sr.ReadLine();
                //read in SaveData values and put them in nodes and add
                //them to the list
                while (line != null)
                {
                    string[] sD = line.Split('$');
                    SaveData fileData = new SaveData(Convert.ToInt32(sD[0]),
                        DateTime.Parse(sD[1]), sD[2]);
                    this.saveDataList.Add(fileData);
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            else
            {
                //if the file does not exist initialize values to null/zero
                this.numGames = 0;
                this.totalScore = 0;
                this.avgGamePoints = 0;
                this.saveDataList = new List<SaveData>();
            }
        }
        //---------------------------------------------------------------
        //save all the data stored into a txt file
        //---------------------------------------------------------------
        private void writeFile()
        {
            File.WriteAllText(fileName, getTextString());
        }
        //---------------------------------------------------------------
        //add relevant data into SaveData node and add it tothe list
        //---------------------------------------------------------------
        public void addScore(int newScore, string newPlayerTag)
        {
            SaveData newSave = new SaveData(newScore, DateTime.Now, newPlayerTag);
            this.numGames++;
            this.totalScore += newScore;
            this.avgGamePoints = totalScore / numGames;
            this.saveDataList.Add(newSave);
        }
        //getter for saveDataList
        public List<SaveData> getSaveDataList()
        {
            return saveDataList;
        }
        //getter for SaveDataList nodes
        public SaveData getSaveDataListIndex(int index)
        {
            return saveDataList[index];
        }
        //getter for numGames
        public int getNumGames()
        {
            return numGames;
        }
        //getter for totalScore
        public int getTotalScore()
        {
            return totalScore;
        }
        //getter for avgGamePoints
        public double getAvgGamePoints()
        {
            return avgGamePoints;
        }
        //--------------------------------------------------------------------
        //This method returns a string in the format to save all of the score
        //data.
        //--------------------------------------------------------------------
        public string getTextString()
        {
            string textString = "";
            textString += numGames + "\n";
            textString += totalScore + "\n";
            textString += avgGamePoints + "\n";
            for(int i = 0; i < numGames; i++)
            {
                textString += saveDataList[i].getScore().ToString() + "$" +
                    saveDataList[i].getDt().ToString() + "$" + 
                    saveDataList[i].getPlayerTag().ToString() + "\n";
            }
            return textString;
        }
    }
}
