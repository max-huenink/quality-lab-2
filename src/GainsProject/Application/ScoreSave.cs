//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To hold score data for a game, save it, and add more 
// scores
//---------------------------------------------------------------
using GainsProject.Domain;
using System;
using System.Collections.Generic;
using System.IO;

namespace GainsProject.Application
{
    //--------------------------------------------------------------------
    //This is a class that reads in previous scores from a file, writes
    //scores to the same file once the application is closed or the object 
    //is out of scope, and can add scores to to a list.
    //--------------------------------------------------------------------
    public class ScoreSave
    {
        string fileName;
        private int numGames;
        private int totalScore;                   //this exists to make avgGamePoints faster to
                                                  //calculate
        private double avgGamePoints;
        private List<SaveData> saveDataList;      //a list of SaveData nodes
        //--------------------------------------------------------------------
        //parameterized constructor that takes the FILENAME that will be read
        //in
        //--------------------------------------------------------------------
        public ScoreSave(string fileName)
        {
            this.fileName = fileName;
            saveDataList = new List<SaveData>();
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
            numGames = 0;
            totalScore = 0;
            avgGamePoints = 0;
            saveDataList = new List<SaveData>();
            //if the file exists read it in
            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(fileName);
                numGames = Convert.ToInt32(sr.ReadLine());
                totalScore = Convert.ToInt32(sr.ReadLine());
                avgGamePoints = Convert.ToDouble(sr.ReadLine());
                string line = sr.ReadLine();
                //read in SaveData values and put them in nodes and add
                //them to the list
                while (line != null)
                {
                    string[] sD = line.Split('$');
                    SaveData fileData = new SaveData(Convert.ToInt32(sD[0]),
                        DateTime.Parse(sD[1]), sD[2]);
                    saveDataList.Add(fileData);
                    line = sr.ReadLine();
                }
                sr.Close();
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
        //add NEWSCORE and NEWPLAYERTAG into SaveData node and add it to
        //the list
        //---------------------------------------------------------------
        public void addScore(int newScore, string newPlayerTag)
        {
            SaveData newSave = new SaveData(newScore, DateTime.Now, newPlayerTag);
            numGames++;
            totalScore += newScore;
            avgGamePoints = totalScore / numGames;
            saveDataList.Add(newSave);
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
            for (int i = 0; i < numGames; i++)
            {
                textString += saveDataList[i].getScore().ToString() + "$" +
                    saveDataList[i].getDt().ToString() + "$" +
                    saveDataList[i].getPlayerTag().ToString() + "\n";
            }
            return textString;
        }
    }
}
