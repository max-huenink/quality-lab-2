//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To store the name and keep it seperate from the UI
//---------------------------------------------------------------
namespace GainsProject.Application
{
    public class NameClass
    {
        //Static name var to be shared among all objects
        static private string name;
        //Getter and setter for name
        public void setName(string newName)
        {
            name = newName;
        }
        public string getName()
        {
            return name;
        }
    }
}
