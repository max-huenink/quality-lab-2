using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace GainsProject
{
    public class ScoreSave
    {
        const string fileName = "GameScore.txt";
        protected int numGames;
        protected int totalScore;
        protected double avgGamePoints;
        protected List<SaveData> saveDataList;

        public struct SaveData
        {
            int score;
            DateTime dt;
            string playerTag;
            public SaveData(int newScore, DateTime newDt, string newPlayerTag) : this()
            {
                this.score = newScore;
                this.dt = newDt;
                this.playerTag = newPlayerTag;
            }
            public int getScore()
            {
                return score;
            }
            public DateTime getDt()
            {
                return dt;
            }
            public string getPlayerTag()
            {
                return playerTag;
            }
        }

        public ScoreSave()
        {
            this.saveDataList = new List<SaveData>();
            readFile();
        }
        private void readFile()
        {
            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(fileName);
                this.numGames = Convert.ToInt32(sr.ReadLine());
                this.totalScore = Convert.ToInt32(sr.ReadLine());
                this.avgGamePoints = Convert.ToDouble(sr.ReadLine());
                string line = sr.ReadLine();
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
                this.numGames = 0;
                this.totalScore = 0;
                this.avgGamePoints = 0;
                this.saveDataList = new List<SaveData>();
            }
        }
        public void writeFile()
        {
            File.WriteAllText(fileName, getTextString());
        }
        public void addScore(int newScore, string newPlayerTag)
        {
            SaveData newSave = new SaveData(newScore, DateTime.Now, newPlayerTag);
            this.numGames++;
            this.totalScore += newScore;
            this.avgGamePoints = totalScore / numGames;
            this.saveDataList.Add(newSave);
        }
        public List<SaveData> getSaveDataList()
        {
            return saveDataList;
        }
        public SaveData getSaveDataListIndex(int index)
        {
            return saveDataList[index];
        }
        public int getNumGames()
        {
            return numGames;
        }
        public int getTotalScore()
        {
            return totalScore;
        }
        public double getAvgGamePoints()
        {
            return avgGamePoints;
        }
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
