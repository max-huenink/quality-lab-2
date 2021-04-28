//---------------------------------------------------------------
// Name:    Nick Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To hold descriptors for pictures and their names
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace GainsProject.Domain
{
    //---------------------------------------------------------------
    // This class holds a list of picture names and holds their
    // descriptors
    //---------------------------------------------------------------
    public class SpotTheSceneryPictureDescriptor
    {
        private Dictionary<string, List<string>> descriptors = new Dictionary<string, List<string>>();
        private List<Image> pictureList = new List<Image>();
        private List<string> pictureNameList = new List<string>();
        //---------------------------------------------------------------
        // this method fills the descriptor dictionary with all of the
        // pictures' descriptors with the picture name as the key
        //---------------------------------------------------------------
        public void fillDescriptors()
        {
            string diName = "STSPictureDescriptors";
            //string diName = "PictureDrawingFolder";
            string directory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            directory += "/" + diName;
            DirectoryInfo di = new DirectoryInfo(directory);
            FileInfo[] dirFiles = di.GetFiles();
            for(int i = 0; i < dirFiles.Length; i++)
            {
                StreamReader streamReader = new StreamReader(directory + "/" + dirFiles[i].Name);
                string line;
                List<string> descriptorList = new List<string>();
                string[] temp = dirFiles[i].Name.Split('.');
                descriptors.Add(temp[0], descriptorList);
                while ((line = streamReader.ReadLine()) != null)
                {
                    descriptorList.Add(line);
                }
                streamReader.Close();
            }
        }
        //---------------------------------------------------------------
        // This method fills a list wih Image objects from the folder
        // that contains all of the scenes for the Spot the Scenery game
        //---------------------------------------------------------------
        public void fillPictureList()
        {
            string diName = "SpotTheSceneryFolder";
            string directory = System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
            directory += "/" + diName;
            DirectoryInfo di = new DirectoryInfo(directory);
            FileInfo[] dirFiles = di.GetFiles();
            for(int i = 0; i < dirFiles.Length; i++)
            {
                pictureList.Add(Image.FromFile(directory + "/" + dirFiles[i].Name));
                string[] temp = dirFiles[i].Name.Split('.');
                //pictureList[pictureList.Count - 1].Tag = temp[0];
                pictureNameList.Add(temp[0]);
            }
        }
        //---------------------------------------------------------------
        // getter for pictureList
        //---------------------------------------------------------------
        public List<Image> getPictureList()
        {
            return pictureList;
        }
        //---------------------------------------------------------------
        // getter for descriptors
        //---------------------------------------------------------------
        public Dictionary<string, List<string>> getDescriptors()
        {
            return descriptors;
        }
        //---------------------------------------------------------------
        // getter for picture name list
        //---------------------------------------------------------------
        public List<string> getPictureNamesList()
        {
            return pictureNameList;
        }
    }
}
