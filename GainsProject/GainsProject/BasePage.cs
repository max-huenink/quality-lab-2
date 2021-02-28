using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GainsProject
{
    public partial class BasePage : Form
    {
        public BasePage()
        {
            InitializeComponent();
        }

        private void tutorialButton_MouseClick(object sender, MouseEventArgs e)
        {
            TutorialPage tp = new TutorialPage();
            showUserControl(tp);
        }

        public void showUserControl(Control control)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }

        private void playButton_MouseClick(object sender, MouseEventArgs e)
        {
            GameSelectPage gsp = new GameSelectPage();
            showUserControl(gsp);
        }

        private void previousResultsButton_MouseClick(object sender, MouseEventArgs e)
        {
            PreviousScoresPage psp = new PreviousScoresPage();
            showUserControl(psp);
        }

        private void leaderboardButton_MouseClick(object sender, MouseEventArgs e)
        {
            LeaderboardPage lp = new LeaderboardPage();
            showUserControl(lp);
        }
    }
}
