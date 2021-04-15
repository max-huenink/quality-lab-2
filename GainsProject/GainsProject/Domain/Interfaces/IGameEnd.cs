//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To indicate when the current game is over
//---------------------------------------------------------------

using System;

namespace GainsProject.Domain.Interfaces
{
    //---------------------------------------------------------------
    //Indicates when the game is over
    //---------------------------------------------------------------
    public interface IGameEnd
    {
        //---------------------------------------------------------------
        //Indicates the game played by name is over with a score of
        // score and a time of timeSpan
        //---------------------------------------------------------------
        void GameFinished(string name, long score, TimeSpan timeSpan);
    }
}
