//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To provide methods for the base game
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GainsProject.Domain.Interfaces
{
    //---------------------------------------------------------------
    //Methods for the base game class
    //---------------------------------------------------------------
    public interface IGame
    {
        //---------------------------------------------------------------
        //Gives a random number of milliseconds based on the game
        //---------------------------------------------------------------
        int randomTime();
        //---------------------------------------------------------------
        //Method for game-spesific features to be run in
        //---------------------------------------------------------------
        void runGame();
        //---------------------------------------------------------------
        //Calculates the score based on the time 
        //---------------------------------------------------------------
        void calculateScore();
    }
}
