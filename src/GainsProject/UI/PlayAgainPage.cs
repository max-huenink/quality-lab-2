﻿//---------------------------------------------------------------
// Name:    Maxwell Huenink
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To prompt the user to replay available games in a
//          different random order
//---------------------------------------------------------------
using GainsProject.Application;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GainsProject.UI
{
    //---------------------------------------------------------------
    //Prompts the user to replay games in a new order
    //---------------------------------------------------------------
    public partial class PlayAgainPage : UserControl
    {
        private bool isPlaylist;
        private int counter;
        private List<string> playlist;

        //---------------------------------------------------------------
        //Default constructor that initializes the buttons
        //---------------------------------------------------------------
        public PlayAgainPage()
        {
            InitializeComponent();
            isPlaylist = false;
        }

        //---------------------------------------------------------------
        //Parameterized constructor is used to save all the games in the
        // playlist for the playlist page, so the playlist page is the
        // same when it is recreated
        //---------------------------------------------------------------
        public PlayAgainPage(List<string> list, int count)
        {
            InitializeComponent();
            playlist = list;
            isPlaylist = true;
            counter = count;
        }

        //---------------------------------------------------------------
        //Passes control from the play again page to the selected game
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

        //---------------------------------------------------------------
        //Shows the user control for the playlist/random to replay it
        //---------------------------------------------------------------
        private void yesBtn_Click(object sender, EventArgs e)
        {
            if (isPlaylist == false)
                showUserControl(new RandomGamesPage());
            else
                showUserControl(new MakePlaylistPage(playlist, counter));
        }

        //---------------------------------------------------------------
        //Shows a blank screen
        //---------------------------------------------------------------
        private void noBtn_Click(object sender, EventArgs e)
        {
            showUserControl(null);
        }
    }
}
