//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To facilitate switching between games
//---------------------------------------------------------------

namespace GainsProject.Domain.Interfaces
{
    //---------------------------------------------------------------
    //Facilitates switching between games
    //---------------------------------------------------------------
    public interface ISelectGame
    {
        //---------------------------------------------------------------
        //Indicates that current game is complete and control can be
        // passed to the next game
        //---------------------------------------------------------------
        void NextGame();
    }
}
