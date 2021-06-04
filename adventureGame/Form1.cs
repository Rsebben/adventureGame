using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace LostAdventure
{
    public partial class Form1 : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;

        public Form1()
        {
            InitializeComponent();

            // Display initial message and options
            questionBox.Text = "Choose your path.";
            option1.Text = "River";
            option2.Text = "Bush";

        }

        private void option1_Click(object sender, EventArgs e)
        {
            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1

            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 1; }
            else if (page == 4) { page = 1; }
            else if (page == 5) { page = 6; }
            else if (page == 6) { page = 1; }
            else if (page == 7) { page = 1; }


            /// Display text and game options to screen based on the 
            /// current page

            switch (page)
            {
                case 1:
                    questionBox.Text = "Choose your path.";
                    option1.Text = "River";
                    option2.Text = "Bush";
                    break;
                case 2:
                    questionBox.Text = "Swim across the river or look for a bridge.";
                    option1.Text = "Swim across";
                    option2.Text = "Lookk for bridge";
                    break;
                case 3:
                    questionBox.Text = "You get lost and starve. Play again?";
                    option1.Text = "yes";
                    option2.Text = "no";
                    break;
                case 4:
                    questionBox.Text = "Theres a crocodile in the water it eats you. Play again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    break;
                case 5:
                    questionBox.Text = "you find a bridge and cross it. Theres a house on the other side do you enter? ";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    break;
                case 6:
                    questionBox.Text = "You enter the house to find a distress signal you get rescued and taken to safety. Play again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    break;
                case 7:
                    questionBox.Text = "You never get rescued you starve and die. Play again";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    break;
                case 99:
                    questionBox.Text = "Thank you for playing!";
                    option1.Text = "";
                    option2.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void option2_Click_1(object sender, EventArgs e)
        {
            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 99; }
            else if (page == 4) { page = 99; }
            else if (page == 5) { page = 7; }
            else if (page == 6) { page = 99; }
            else if (page == 7) { page = 99; }


            switch (page)
            {
                case 1:
                    questionBox.Text = "Choose your path.";
                    option1.Text = "River";
                    option2.Text = "Bush";
                    break;
                case 2:
                    questionBox.Text = "Swim across the river or look for a bridge.";
                    option1.Text = "Swim across";
                    option2.Text = "Lookk for bridge";
                    break;
                case 3:
                    questionBox.Text = "You get lost and starve. Play again?";
                    option1.Text = "yes";
                    option2.Text = "no";
                    break;
                case 4:
                    questionBox.Text = "Theres a crocodile in the water it eats you. Play again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    break;
                case 5:
                    questionBox.Text = "you find a bridge and cross it. Theres a house on the other side do you enter? ";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    break;
                case 6:
                    questionBox.Text = "You enter the house to find a distress signal you get rescued and taken to safety. Play again?";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    break;
                case 7:
                    questionBox.Text = "You never get rescued you starve and die. Play again";
                    option1.Text = "Yes";
                    option2.Text = "No";
                    break;
                case 99:
                    questionBox.Text = "Thank you for playing!";
                    option1.Text = "";
                    option2.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }


        }

    }

}




