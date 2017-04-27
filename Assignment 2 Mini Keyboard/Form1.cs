﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2_Mini_Keyboard
{
    public partial class Form1 : Form
    {
        // Flags changes made and thus file needs saving
        bool booleanRequiresSaving = false;

        // The Path to the 'Dictionary'
        string strPresentFilePathName = "";

        // Timing Functionality
        bool boolFirstVisit = true;
        int intIntervalRequired = 500;

        // Global ListBox can be placed on the Form instead of here.
        ListBox lstGlobalListbox = new ListBox();
        int intMyListIndex = 0;

        // Buttons. Identifies which button is being selected be the user.
        bool[] boolsButtonPresssed = new bool[19];

        // Prediction.
        string Str_KeyStrokes;

        // Is the line from the list that has the highest useage
        int intPredictedIndex;
        int intNumberOfCharacters;
        int pedictedWorddLength;

        public Form1()
        {
            InitializeComponent();
        }

        private void Frm_MainWindow_Load(object sender, EventArgs e)
        {
            // Setup the time Between Presses for Next Character when same button
            withinTimer.Interval = intIntervalRequired;

            for (int intWhichButton = 0; intWhichButton <= 18; intWhichButton++)
            {
                boolsButtonPresssed[intWhichButton] = false;
            }

            // Load the Dictionary
            loadDictionary();
        }




        private void loadDictionary()
        {

        }




        private void btn_Mode_Click(object sender, EventArgs e)
        {
            if (rtxt_Multipress.Text == "Prediction")
            {
                rtxt_Multipress.Text = "Multi-Press";
            }
            else
            {
                rtxt_Multipress.Text = "Prediction";
            }
        }


        private void btn_1_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            if (!withinTimer.Enabled)
            {
                rtxt_WordBuilder.Text += "p";
                Str_KeyStrokes += "1";
                withinTimer.Start();
            }
            else
            {
                string lastChar = "";

                // Gets the last character
                if (rtxt_WordBuilder.Text.Length > 0)
                {
                    lastChar = rtxt_WordBuilder.Text.Substring(rtxt_WordBuilder.Text.Length - 1, 1);
                }


                // Deletes the last character
                rtxt_WordBuilder.Text = rtxt_WordBuilder.Text.Substring(0, rtxt_WordBuilder.Text.Length - 1);

                // reset timer
                withinTimer.Stop();
                withinTimer.Start();
                // depending on last char, pick new one
                switch (lastChar)
                {
                    case "p":
                        rtxt_WordBuilder.Text += "q";
                        break;
                    case "q":
                        rtxt_WordBuilder.Text += "r";
                        break;
                    case "r":
                        rtxt_WordBuilder.Text += "s";
                        break;
                    case "s":
                        rtxt_WordBuilder.Text += "1";
                        break;
                    case "1":
                        rtxt_WordBuilder.Text += "P";
                        break;
                    case "P":
                        rtxt_WordBuilder.Text += "Q";
                        break;
                    case "Q":
                        rtxt_WordBuilder.Text += "R";
                        break;
                    case "R":
                        rtxt_WordBuilder.Text += "S";
                        break;
                    case "S":
                        rtxt_WordBuilder.Text += "p";
                        break;
                }
            }
        }


        private void btn_2_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            if (!withinTimer.Enabled)
            {
                rtxt_WordBuilder.Text += "t";
                Str_KeyStrokes += "2";
                withinTimer.Start();
            }
            else
            {
                string lastChar = "";

                // Gets the last character
                if (rtxt_WordBuilder.Text.Length > 0)
                {
                    lastChar = rtxt_WordBuilder.Text.Substring(rtxt_WordBuilder.Text.Length - 1, 1);
                }


                // Deletes the last character
                rtxt_WordBuilder.Text = rtxt_WordBuilder.Text.Substring(0, rtxt_WordBuilder.Text.Length - 1);

                // reset timer
                withinTimer.Stop();
                withinTimer.Start();
                // depending on last char, pick new one
                switch (lastChar)
                {
                    case "t":
                        rtxt_WordBuilder.Text += "u";
                        break;
                    case "u":
                        rtxt_WordBuilder.Text += "v";
                        break;
                    case "v":
                        rtxt_WordBuilder.Text += "2";
                        break;
                    case "2":
                        rtxt_WordBuilder.Text += "T";
                        break;
                    case "T":
                        rtxt_WordBuilder.Text += "U";
                        break;
                    case "U":
                        rtxt_WordBuilder.Text += "V";
                        break;
                    case "V":
                        rtxt_WordBuilder.Text += "t";
                        break;
    
                }
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            if (!withinTimer.Enabled)
            {
                rtxt_WordBuilder.Text += "w";
                Str_KeyStrokes += "3";
                withinTimer.Start();
            }
            else
            {
                string lastChar = "";

                // Gets the last character
                if (rtxt_WordBuilder.Text.Length > 0)
                {
                    lastChar = rtxt_WordBuilder.Text.Substring(rtxt_WordBuilder.Text.Length - 1, 1);
                }


                // Deletes the last character
                rtxt_WordBuilder.Text = rtxt_WordBuilder.Text.Substring(0, rtxt_WordBuilder.Text.Length - 1);

                // reset timer
                withinTimer.Stop();
                withinTimer.Start();
                // depending on last char, pick new one
                switch (lastChar)
                {
                    case "w":
                        rtxt_WordBuilder.Text += "x";
                        break;
                    case "x":
                        rtxt_WordBuilder.Text += "y";
                        break;
                    case "y":
                        rtxt_WordBuilder.Text += "z";
                        break;
                    case "z":
                        rtxt_WordBuilder.Text += "3";
                        break;
                    case "3":
                        rtxt_WordBuilder.Text += "W";
                        break;
                    case "W":
                        rtxt_WordBuilder.Text += "X";
                        break;
                    case "X":
                        rtxt_WordBuilder.Text += "Y";
                        break;
                    case "Y":
                        rtxt_WordBuilder.Text += "Z";
                        break;
                    case "Z":
                        rtxt_WordBuilder.Text += "w";
                        break;

                }
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            if (!withinTimer.Enabled)
            {
                rtxt_WordBuilder.Text += "g";
                Str_KeyStrokes += "4";
                withinTimer.Start();
            }
            else
            {
                string lastChar = "";

                // Gets the last character
                if (rtxt_WordBuilder.Text.Length > 0)
                {
                    lastChar = rtxt_WordBuilder.Text.Substring(rtxt_WordBuilder.Text.Length - 1, 1);
                }


                // Deletes the last character
                rtxt_WordBuilder.Text = rtxt_WordBuilder.Text.Substring(0, rtxt_WordBuilder.Text.Length - 1);

                // reset timer
                withinTimer.Stop();
                withinTimer.Start();
                // depending on last char, pick new one
                switch (lastChar)
                {
                    case "g":
                        rtxt_WordBuilder.Text += "h";
                        break;
                    case "h":
                        rtxt_WordBuilder.Text += "i";
                        break;
                    case "i":
                        rtxt_WordBuilder.Text += "4";
                        break;
                    case "4":
                        rtxt_WordBuilder.Text += "G";
                        break;
                    case "G":
                        rtxt_WordBuilder.Text += "H";
                        break;
                    case "H":
                        rtxt_WordBuilder.Text += "I";
                        break;
                    case "I":
                        rtxt_WordBuilder.Text += "g";
                        break;

                }
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            if (!withinTimer.Enabled)
            {
                rtxt_WordBuilder.Text += "j";
                Str_KeyStrokes += "5";
                withinTimer.Start();
            }
            else
            {
                string lastChar = "";

                // Gets the last character
                if (rtxt_WordBuilder.Text.Length > 0)
                {
                    lastChar = rtxt_WordBuilder.Text.Substring(rtxt_WordBuilder.Text.Length - 1, 1);
                }


                // Deletes the last character
                rtxt_WordBuilder.Text = rtxt_WordBuilder.Text.Substring(0, rtxt_WordBuilder.Text.Length - 1);

                // reset timer
                withinTimer.Stop();
                withinTimer.Start();
                // depending on last char, pick new one
                switch (lastChar)
                {
                    case "j":
                        rtxt_WordBuilder.Text += "k";
                        break;
                    case "k":
                        rtxt_WordBuilder.Text += "l";
                        break;
                    case "l":
                        rtxt_WordBuilder.Text += "5";
                        break;
                    case "5":
                        rtxt_WordBuilder.Text += "J";
                        break;
                    case "J":
                        rtxt_WordBuilder.Text += "K";
                        break;
                    case "K":
                        rtxt_WordBuilder.Text += "L";
                        break;
                    case "L":
                        rtxt_WordBuilder.Text += "j";
                        break;

                }
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            withinTimer.Start();
            rtxt_WordBuilder.Text += "m";
            Str_KeyStrokes += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            withinTimer.Start();
            rtxt_WordBuilder.Text += ".";
            Str_KeyStrokes += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            withinTimer.Start();
            rtxt_WordBuilder.Text += "a";
            Str_KeyStrokes += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            withinTimer.Start();
            rtxt_WordBuilder.Text += "d";
            Str_KeyStrokes += "9";
        }

        private void btn_BottomLeft_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            withinTimer.Start();
            rtxt_WordBuilder.Text += "*";
        }

        private void btn_BottomRight_Click(object sender, EventArgs e)
        {
            withinTimer.Interval = intIntervalRequired;
            withinTimer.Start();
            rtxt_WordBuilder.Text += "#";
        }

        private void withinTimer_Tick(object sender, EventArgs e)
        {
            withinTimer.Stop();
        }
    }
}
