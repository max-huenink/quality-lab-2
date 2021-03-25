using GainsProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GainsProject.UI
{
    public partial class ArrowKeyGame : UserControl
    {
        private readonly bool InPlaylist;

        public ArrowKeyGame()
        {
            InitializeComponent();
        }

        public ArrowKeyGame(IGamePlaylist gamePlaylist)
        {
            if (gamePlaylist != null)
            {
                InPlaylist = true;
                exitGameBtn.Click += (sender, e) => gamePlaylist.Exit();
                nextGameBtn.Click += (sender, e) => gamePlaylist.NextGame();
            }
        }

        private void HideInstructions()
        {
            InstructionsLbl.Hide();
            EasyDifficultyBtn.Hide();
            MediumDifficultyBtn.Hide();
            HardDifficultBtn.Hide();
        }

        private void ShowInstructions()
        {
            InstructionsLbl.Show();
            EasyDifficultyBtn.Show();
            MediumDifficultyBtn.Show();
            HardDifficultBtn.Show();
        }

        private void HideGame()
        {
            LeftArrowLbl.Hide();
            UpArrowLbl.Hide();
            RightArrowLbl.Hide();
            DownArrowLbl.Hide();
        }

        private void ShowGame()
        {
            LeftArrowLbl.Show();
            UpArrowLbl.Show();
            RightArrowLbl.Show();
            DownArrowLbl.Show();
        }

        private void HidePlaylistBtns()
        {
            exitGameBtn.Hide();
            nextGameBtn.Hide();
        }

        private void ShowPlaylistBtns()
        {
            exitGameBtn.Show();
            nextGameBtn.Show();
        }
    }
}
