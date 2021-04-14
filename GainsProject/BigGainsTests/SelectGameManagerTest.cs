//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To test the game manager class
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
    //Test the game select manager class
    //---------------------------------------------------------------
    [TestClass]
    public class SelectGameManagerTest
    {
        //---------------------------------------------------------------
        //Tests that the static create and populate method, with a mocked
        // IGameEnd, creates a not empty list of games
        //---------------------------------------------------------------
        [TestMethod]
        public void CreateAndPopulateGameManager()
        {
            Mock<IGameEnd> mock = new Mock<IGameEnd>();
            var manager = GameSelectManager.CreateAndPopulateManager(mock.Object);
            var gameList = manager.GetListOfGames();
            Assert.IsNotNull(gameList);
            // List should not be empty because it was populated
            //  with list of games
            Assert.AreNotEqual(0, gameList.Count);
        }

        //---------------------------------------------------------------
        //Tests that the list of games is not null and is empty
        // when the class is created
        //---------------------------------------------------------------
        [TestMethod]
        public void GetEmptyListOfGamesTest()
        {
            var manager = new GameSelectManager();
            var gameList = manager.GetListOfGames();
            Assert.IsNotNull(gameList);
            Assert.AreEqual(0, gameList.Count);
        }

        //---------------------------------------------------------------
        //Tests that the AddGameToList adds each item to the list
        //---------------------------------------------------------------
        [TestMethod]
        public void AddToListOfGamesTest()
        {
            var manager = new GameSelectManager();
            // Items to add
            (string, Func<Control>) test0 = ("TestGame0", () => new Control());
            (string, Func<Control>) test1 = ("TestGame1", () => new Control());
            (string, Func<Control>) test2 = ("TestGame2", () => new Control());
            // Add items
            manager.AddGameToList(test0.Item1, test0.Item2);
            manager.AddGameToList(test1.Item1, test1.Item2);
            manager.AddGameToList(test2.Item1, test2.Item2);

            // List isn't null, contains 3 elements
            var gameList = manager.GetListOfGames();
            Assert.IsNotNull(gameList);
            Assert.AreEqual(3, gameList.Count);
            // List contains each item
            Assert.IsTrue(gameList.Contains(test0));
            Assert.IsTrue(gameList.Contains(test1));
            Assert.IsTrue(gameList.Contains(test2));
        }

        //---------------------------------------------------------------
        //Tests that the unplayed game from an empty games list is null
        //---------------------------------------------------------------
        [TestMethod]
        public void GetUnplayedGameFromEmptyListTest()
        {
            var manager = new GameSelectManager();
            var game = manager.GetRandomUnplayedGame();
            Assert.AreEqual(null, game);
        }

        //---------------------------------------------------------------
        //Tests that the random unplayed control, when there are two
        // games with one played, returns the only other unplayed game
        //---------------------------------------------------------------
        [TestMethod]
        public void RandomUnplayedGameTest()
        {
            var manager = new GameSelectManager();
            // Controls to add to game list
            Func<Control> test0 = () => new Control()
            {
                Name = "test0"
            };
            Func<Control> test1 = () => new Control()
            {
                Name = "test1"
            };
            // Add controls to game list
            manager.AddGameToList("TestGame0", test0);
            manager.AddGameToList("TestGame1", test1);
            // Play test1
            manager.PlayedGame(test1);
            // The random unplayed game should not be test1
            // should be test0
            var unplayed = manager.GetRandomUnplayedGame();
            Assert.AreNotEqual(test1, unplayed);
            Assert.AreEqual(test0, unplayed);
        }

        //---------------------------------------------------------------
        //Tests that the random unplayed game returns null when all games
        // have been played
        //---------------------------------------------------------------
        [TestMethod]
        public void AllGamesPlayedTest()
        {
            var manager = new GameSelectManager();
            // Controls to add
            Func<Control> test0 = () => new Control();
            Func<Control> test1 = () => new Control();
            Func<Control> test2 = () => new Control();
            // Adds controls
            manager.AddGameToList("TestGame0", test0);
            manager.AddGameToList("TestGame1", test1);
            manager.AddGameToList("TestGame2", test2);
            // Plays all controls
            manager.PlayedGame(test0);
            manager.PlayedGame(test1);
            manager.PlayedGame(test2);
            // The random unplayed game should be null, all games have been
            // played
            var unplayed = manager.GetRandomUnplayedGame();
            Assert.AreEqual(null, unplayed);
        }
    }
}
