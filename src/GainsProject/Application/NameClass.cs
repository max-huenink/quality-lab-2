//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To store the name and keep it seperate from the UI
//---------------------------------------------------------------
using GainsProject.Domain;
using GainsProject.Application;
namespace GainsProject.Application
{
    //---------------------------------------------------------------
    //Allows the GUI to acess the name
    //---------------------------------------------------------------
    public class NameClass : BaseName
    {
        //Static name var to be shared among all objects
        static private string name;

        //Getter and setter for name
        public override void setName(string newName)
        {
            name = newName;
        }

        public override string getName()
        {
            return name;
        }
    }
}
