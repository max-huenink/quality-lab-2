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
        List<string> startPlaylist;

        public MakePlaylistPageManager()
        {
            playlist = new List<(string Name, Func<Control> GameControlCreator)>();
            startPlaylist = new List<string>();
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
            //foreach (var g in playlist)
            //{
             //   if (g.Name == game.Name)
            //        playlist.Remove(g);
            //}
            playlist.Remove(game);
        }

        public (string Name, Func<Control> GameControlCreator) getFirstGame()
        {
            return playlist[0];
        }

        /*public void validatePlaylist()
        {
            foreach(var game in playlist)
            {
                startPlaylist.Add(game);
            }
        } */

        public void validatePlaylist(GameSelectManager gamelist)
        {
            foreach(var g in gamelist.GetListOfGames())
            {
                startPlaylist.Add(g.Name);
            }
        }

        public List<string> getPlaylist()
        {
            return startPlaylist;
        }

    }
}
