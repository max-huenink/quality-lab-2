using GainsProject.Application;
using GainsProject.Domain.Interfaces;
using System;
using System.Windows.Forms;
namespace GainsProject.UI
{
    public partial class PictureDrawing : UserControl
    {
        static PictureDrawing pd = new PictureDrawing();
        private DateTime temp = DateTime.Now;
        public PictureDrawing()
        {
            InitializeComponent();
        }
        private bool nextGame;
        //---------------------------------------------------------------
        //Constructor that initializes the next game button, which calls
        // the NextGame method of ISelectGame when clicked
        //---------------------------------------------------------------
        public PictureDrawing(IGamePlaylist selectGame)
        {
            InitializeComponent();
            nextGameBtn.Click += (sender, e) => selectGame.NextGame();
            exitGameBtn.Click += (sender, e) => selectGame.Exit();
            nextGame = true;
        }
        public string getElapsedTime(DateTime startTime)
        {
            string timeString = "";
            TimeSpan elapsedTime = DateTime.Now - startTime;
            timeString += elapsedTime.Hours.ToString("00") + ": " +
                elapsedTime.Minutes.ToString("00") + ": " +
                elapsedTime.Seconds.ToString("00");
            return timeString;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = pd.getElapsedTime(temp);
        }
    }
}
