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
    class MakePlaylistPageManager
    {
        //Lists to hold the games
        private List<(string Name, Func<Control> GameControlCreator)> playlist;
        private List<(string Name, Func<Control> GameControlCreator)> startPlaylist;
        //--------------------------------------------------------------------
        //Default constructor
        //--------------------------------------------------------------------
        public MakePlaylistPageManager()
        {
            playlist = new List<(string Name, Func<Control> GameControlCreator)>();
            startPlaylist = new List<(string Name, Func<Control> GameControlCreator)>();
        }
        //--------------------------------------------------------------------
        //Checks if the playlist contains a string
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
        //--------------------------------------------------------------------
        public void add((string Name, Func<Control> GameControlCreator) game) 
        {
            playlist.Add(game); 
        }
        //--------------------------------------------------------------------
        //Removes a game from the playlist
        //--------------------------------------------------------------------
        public void remove((string Name, Func<Control> GameControlCreator) game)
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
        //Start the platlist
        //--------------------------------------------------------------------
        public void validatePlaylist()
        {
            foreach(var game in playlist)
            {
                startPlaylist.Add(game);
            }
        }
        //--------------------------------------------------------------------
        //Get the playlist.
        //--------------------------------------------------------------------
        public List<(string Name, Func<Control> GameControlCreator)> getPlaylist()
        {
            return startPlaylist;
        }

    }
}
