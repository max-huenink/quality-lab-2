//---------------------------------------------------------------
// Name:    Ian Seidler
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To allow the user to select game modes
//---------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GainsProject
{
    //---------------------------------------------------------------
    //UI for the GameModeSelect screen
    //---------------------------------------------------------------
    public partial class GameModeSelect : UserControl
    {
        //---------------------------------------------------------------
        //Hides compnents on the current page
        //---------------------------------------------------------------
        public void HidePage()
        {
            SingleGame.Hide();
            Playlist.Hide();
            RandomGames.Hide();
            textBox1.Hide();
            this.BackColor = System.Drawing.Color.White;
        }
        public GameModeSelect()
        {
            InitializeComponent();
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
        //Allows the user to go to the game select page for signle games
        //---------------------------------------------------------------
        private void SingleGame_Click(object sender, EventArgs e)
        {
            //Hides the current elements
            HidePage();
            GameSelectPage gameSelect = new GameSelectPage();
            showUserControl(gameSelect);
        }
    }
}
