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
    public interface IGamePlaylist
    {
        //---------------------------------------------------------------
        //Indicates that current game is complete, the user wants to
        // play another game, and control can be passed to the next game
        //---------------------------------------------------------------
        void NextGame();

        //---------------------------------------------------------------
        //Indicates that current game is complete, the user does not want
        // to play another game, and control can be passed to the parent
        //---------------------------------------------------------------
        void Exit();
    }
}
