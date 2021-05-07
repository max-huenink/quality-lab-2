//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To allow the user to select game modes
//---------------------------------------------------------------
using System;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //UI for the GameModeSelect screen
    //---------------------------------------------------------------
    public partial class GameModeSelect : UserControl
    {
        public GameModeSelect()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------
        //Hides compnents on the current page
        //---------------------------------------------------------------
        public void hidePage()
        {
            SingleGame.Hide();
            Playlist.Hide();
            RandomGames.Hide();
            textBox1.Hide();
            this.BackColor = System.Drawing.Color.White;
        }

        //---------------------------------------------------------------
        //Hides opened userControl and puts the one clicked on at the top.
        //---------------------------------------------------------------
        public void showUserControl(Control control)
        {
            Content.Controls.Clear();

            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            Content.Controls.Add(control);
        }

        //---------------------------------------------------------------
        //Allows the user to go to the game select page for single games
        //---------------------------------------------------------------
        private void SingleGame_Click(object sender, EventArgs e)
        {
            //Hides the current elements
            hidePage();
            SingleGamePage gameSelect = new SingleGamePage();
            showUserControl(gameSelect);
        }

        //---------------------------------------------------------------
        //Allows the user to play games in a random order
        //---------------------------------------------------------------
        private void RandomGame_Click(object sender, EventArgs e)
        {
            //Hides the current elements
            hidePage();
            var gameSelect = new RandomGamesPage();
            showUserControl(gameSelect);
        }

        //---------------------------------------------------------------
        //Allows the user to create a playlist of games that they want to
        // play in a certain order
        //---------------------------------------------------------------
        private void Playlist_Click(object sender, EventArgs e)
        {
            //Hides the current elements
            hidePage();
            var makePlaylist = new MakePlaylistPage();
            showUserControl(makePlaylist);
        }
    }
}
