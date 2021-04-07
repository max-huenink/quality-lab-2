//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To prompt the user to replay available games in a
//          different random order
//---------------------------------------------------------------
using System;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //Prompts the user to replay games in a new order
    //---------------------------------------------------------------
    public partial class PlayAgainPage : UserControl
    {
        //---------------------------------------------------------------
        //Default constructor that initializes the buttons
        //---------------------------------------------------------------
        public PlayAgainPage()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------
        //Passes control from the game select page to the selected game
        // Params: Control control - the control to show
        //---------------------------------------------------------------
        private void showUserControl(Control control)
        {
            Content.Controls.Clear();

            if (control != null)
            {
                control.Dock = DockStyle.Fill;
                control.BringToFront();
                control.Focus();

                Content.Controls.Add(control);
            }
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            showUserControl(new RandomGamesPage());
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            showUserControl(null);
        }
    }
}
