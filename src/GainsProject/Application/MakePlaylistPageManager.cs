//---------------------------------------------------------------
// Name:    Ben Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: Creates the game playlist page 
//---------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using GainsProject.Domain;


namespace GainsProject.Application
{
    //--------------------------------------------------------------------
    //Makes the new playlist
    //--------------------------------------------------------------------
    public class MakePlaylistPageManager
    {
        //Lists to hold the games
        private List<(string Name, Func<Control> GameControlCreator)> 
            playlist;
        List<string> startPlaylist;

        //--------------------------------------------------------------------
        //Default constructor
        //--------------------------------------------------------------------
        public MakePlaylistPageManager()
        {
            playlist = new List<(string Name
                , Func<Control> GameControlCreator)>();
            startPlaylist = new List<string>();
        }
        //--------------------------------------------------------------------
        //Checks if the playlist contains a string
        //params:
        //g of type string
        //--------------------------------------------------------------------
        public bool contains(string g) 
        { 
            foreach(var game in playlist)
            {
                if (game.Name == g)
                    return true;
            }
            return false; 
        }
        //--------------------------------------------------------------------
        //Checks if the playlist is empty
        //--------------------------------------------------------------------
        public bool isEmpty()
        {
            return playlist.Count == 0;
        }
        //--------------------------------------------------------------------
        //Adds a game to the playlist
        //params:
        // GAME of type (string Name, Func<Control> GameControlCreator)
        //--------------------------------------------------------------------
        public void add((string Name, Func<Control> GameControlCreator) game)
        {
            playlist.Add(game);
        }
        //--------------------------------------------------------------------
        //Removes a game from the playlist
        //params:
        // GAME of type (string Name, Func<Control> GameControlCreator)
        //--------------------------------------------------------------------
        public void remove((string Name
            , Func<Control> GameControlCreator) game)
        {
            playlist.Remove(game);
        }
        //--------------------------------------------------------------------
        //Get the first game
        //--------------------------------------------------------------------
        public (string Name, Func<Control> GameControlCreator) getFirstGame()
        {
            return playlist[0];
        }
        //--------------------------------------------------------------------
        //saves the list after the start button was pressed
        // params:
        // GAMELIST of type GameSelectManager
        //--------------------------------------------------------------------
        public void validatePlaylist(GameSelectManager gamelist)
        {
            foreach(var g in gamelist.GetListOfGames())
            {
                startPlaylist.Add(g.Name);
            }
        }
        //--------------------------------------------------------------------
        //returns a list of names that were in the playlist
        //--------------------------------------------------------------------
        public List<string> getPlaylist()
        {
            return startPlaylist;
        }

    }
}
