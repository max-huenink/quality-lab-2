//---------------------------------------------------------------
// Name:    Ben Hefel and Ian Seidler 
// Project: SE 3330 team:Xx_Bigger_Gains_xX
// Purpose: To give the user some information on how to use the
//          application
//---------------------------------------------------------------
using System;
using System.Windows.Forms;

namespace GainsProject.UI
{
    public partial class TutorialPage : UserControl
    {
        public TutorialPage()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------
        //Hides all tutorial elements for the example game
        //---------------------------------------------------------------
        public void HideElements()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            button1.Hide();
        }
        //---------------------------------------------------------------
        //Passes controll from the tutorial page to the example game
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
        //Hides the elements then launches the example game
        //---------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            HideElements();
            ExampleGame ex = new ExampleGame(null);
            showUserControl(ex);
        }
    }

}
