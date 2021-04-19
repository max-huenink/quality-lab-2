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

        public MakePlaylistPageManager()
        {
            playlist = new List<(string Name, Func<Control> GameControlCreator)>();
        }

        public bool contains((string Name, Func<Control> GameControlCreator) game) 
        { 
            return playlist.Contains(game); 
        }

        public bool isEmpty()
        {
            return playlist.Count < 1;
        }

        public void add((string Name, Func<Control> GameControlCreator) game) 
        {
            playlist.Add(game); 
        }

        public void remove(Func<Control> GameControlCreator game)
        {
            playlist.Remove(game);
        }

        public (string Name, Func<Control> GameControlCreator) getFirstGame()
        {
            return playlist[0];
        }
    }
}
