using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using GainsProject.Domain;

namespace GainsProject.Application
{
    class MakePlaylistPageManager
    {

        private List<(string Name, Func<Control> GameControlCreator)> playlist;
        private List<(string Name, Func<Control> GameControlCreator)> startPlaylist;

        public MakePlaylistPageManager()
        {
            playlist = new List<(string Name, Func<Control> GameControlCreator)>();
            startPlaylist = new List<(string Name, Func<Control> GameControlCreator)>();
        }

        public bool contains(string g) 
        { 
            foreach(var game in playlist)
            {
                if (game.Name == g)
                    return true;
            }
            return false; 
        }

        public bool isEmpty()
        {
            return playlist.Count == 0;
        }

        public void add((string Name, Func<Control> GameControlCreator) game) 
        {
            playlist.Add(game); 
        }

        public void remove((string Name, Func<Control> GameControlCreator) game)
        {
            playlist.Remove(game);
        }

        public (string Name, Func<Control> GameControlCreator) getFirstGame()
        {
            return playlist[0];
        }

        public void validatePlaylist()
        {
            foreach(var game in playlist)
            {
                startPlaylist.Add(game);
            }
        }

        public List<(string Name, Func<Control> GameControlCreator)> getPlaylist()
        {
            return startPlaylist;
        }

    }
}
