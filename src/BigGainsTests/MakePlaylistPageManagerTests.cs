﻿//---------------------------------------------------------------
// Name:    Ben Hefel
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the playlist page manager
//---------------------------------------------------------------
using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Windows.Forms;

namespace BigGainsTests
{
    //---------------------------------------------------------------
    // Test the make playlist page manager
    //---------------------------------------------------------------
    [TestClass]
    public class MakePlaylistPageManagerTests
    {
        //---------------------------------------------------------------
        //Checks to see if the manager gets filled.
        //---------------------------------------------------------------
        [TestMethod]
        public void fillManagerWithGames()
        {
            MakePlaylistPageManager playlistManager = new MakePlaylistPageManager();
            Mock<IGameEnd> mock = new Mock<IGameEnd>();
            var manager = GameSelectManager.createAndPopulateManager(mock.Object);
            foreach (var g in manager.getListOfGames())
            {
                playlistManager.add(g);
            }
            Assert.AreNotEqual(true, playlistManager.isEmpty());
        }

        //---------------------------------------------------------------
        //Checks to see if the manager contains a string in the list
        //---------------------------------------------------------------
        [TestMethod]
        public void checkIfAnItemIsPresent()
        {
            MakePlaylistPageManager playlistManager = new MakePlaylistPageManager();
            Mock<IGameEnd> mock = new Mock<IGameEnd>();
            var manager = GameSelectManager.createAndPopulateManager(mock.Object);
            foreach (var g in manager.getListOfGames())
            {
                playlistManager.add(g);
            }
            Assert.AreNotEqual(false, playlistManager.contains("Example Game"));
        }

        //---------------------------------------------------------------
        //Checks to see if the manager contains something not in the list
        //---------------------------------------------------------------
        [TestMethod]
        public void checkIfAnItemIsNotPresent()
        {
            MakePlaylistPageManager playlistManager = new MakePlaylistPageManager();
            Mock<IGameEnd> mock = new Mock<IGameEnd>();
            var manager = GameSelectManager.createAndPopulateManager(mock.Object);
            foreach (var g in manager.getListOfGames())
            {
                playlistManager.add(g);
            }
            Assert.AreEqual(false, playlistManager.contains("Just a game"));
        }

        //---------------------------------------------------------------
        //Checks to see if the First Item is correct
        //---------------------------------------------------------------
        [TestMethod]
        public void checkForCorrectFirstGame()
        {
            MakePlaylistPageManager playlistManager = new MakePlaylistPageManager();
            Mock<IGameEnd> mock = new Mock<IGameEnd>();
            var manager = GameSelectManager.createAndPopulateManager(mock.Object);
            foreach (var g in manager.getListOfGames())
            {
                playlistManager.add(g);
            }
            Assert.AreEqual("Example Game", playlistManager.getFirstGame().Name);
        }

        //---------------------------------------------------------------
        //Checks to see if a different game is first
        //---------------------------------------------------------------
        [TestMethod]
        public void checkForIncorrectFirstGame()
        {
            MakePlaylistPageManager playlistManager = new MakePlaylistPageManager();
            Mock<IGameEnd> mock = new Mock<IGameEnd>();
            var manager = GameSelectManager.createAndPopulateManager(mock.Object);
            foreach (var g in manager.getListOfGames())
            {
                playlistManager.add(g);
            }
            Assert.AreNotEqual("Picture Drawing Game", playlistManager.getFirstGame().Name);
        }

        //---------------------------------------------------------------
        //Checks to see if the remove method works
        //---------------------------------------------------------------
        [TestMethod]
        public void doesRemoveWork()
        {
            MakePlaylistPageManager playlistManager = new MakePlaylistPageManager();
            Mock<IGameEnd> mock = new Mock<IGameEnd>();
            var manager = GameSelectManager.createAndPopulateManager(mock.Object);
            foreach (var g in manager.getListOfGames())
            {
                playlistManager.add(g);
                if (g.Name == "Example Game")
                    playlistManager.remove(g);
            }
            Assert.AreNotEqual("Example Game", playlistManager.getFirstGame().Name);
        }

        //---------------------------------------------------------------
        //Checks to see if the save list feature, and getter works
        //---------------------------------------------------------------
        [TestMethod]
        public void validateAndGetList()
        {
            MakePlaylistPageManager playlistManager = new MakePlaylistPageManager();
            Mock<IGameEnd> mock = new Mock<IGameEnd>();
            var manager = GameSelectManager.createAndPopulateManager(mock.Object);
            playlistManager.validatePlaylist(manager);
            Assert.AreEqual("Example Game", playlistManager.getPlaylist()[0]);
        }
    }
}
