//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To store the name so that games may use it.
//---------------------------------------------------------------

namespace GainsProject.Domain
{
    //---------------------------------------------------------------
    //Allows the application layer to acess the name
    //---------------------------------------------------------------
    public abstract class BaseName
    {
        //Getter and setter for name
        public abstract void setName(string newName);
        public abstract string getName();
    }
}
