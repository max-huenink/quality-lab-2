using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;

namespace GainsProject.UI
{
    public partial class MentalMathGame : UserControl
    {
        static MentalMathGameManager mmgame = new MentalMathGameManager();
        int questionNumber = 0;
        int random1 = mmgame.randomTime();
        int random2 = mmgame.randomTime();
        int ans = 0;
        int guess = 0;
        public MentalMathGame()
        {
            InitializeComponent();
            NextGame.Hide();
        }
        private bool nextGame;
        public MentalMathGame(ISelectGame selectGame)
        {
            InitializeComponent();
            NextGame.Click += (sender, e) => selectGame.NextGame();
            nextGame = true;
        }

        public void HideStartComponents()
        {
            StartButton.Hide();
            richTextBox1.Hide();
            mmgame.start();
            label1.Text = (random1 + " + " + random2);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            HideStartComponents();

        }
    }
}
