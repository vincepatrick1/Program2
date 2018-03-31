// Program 2
// By: Richard Patrick
// Due Date: 3/8/16
// CIS 199-01
// Description: This program allows the user to enter their number of credit hours earned and their last name to generate
// the earliest date and time they can begin to register for class in the upcoming Fall 2016 semester.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            const double HOURS_SENIOR = 90;   // Hold the hours required for Senior as constant
            const double HOURS_JUNIOR = 60;   // Hold the hours required for Junior as constant
            const double HOURS_SOPHMORE = 30; // Hold the hours required for Sophmore as constant

            const string SENIOR_DAY = "March 30th";      // Create constant for the day seniors can register
            const string JUNIOR_DAY = "March 31st";      // Create constant for the day juniors can register
            const string SOPHMORE_DAY_ONE = "April 1st"; // Create constant for the first day sophmores can register
            const string SOPHMORE_DAY_TWO = "April 4th"; // Create constant for the second day sophmores can register
            const string FRESHMAN_DAY_ONE = "April 5th"; // Create constant for the first day freshman can register
            const string FRESHMAN_DAY_TWO = "April 6th"; // Create constant for the second day freshman can register

            const string FIRST_TIME_SLOT = "8:30 am";   // Create constant for the first time slot option
            const string SECOND_TIME_SLOT = "10:00 am"; // Create constant for the second time slot option
            const string THIRD_TIME_SLOT = "11:30 am";  // Create constant for the third time slot option
            const string FOURTH_TIME_SLOT = "2:00 pm";  // Create constant for the fourth time slot option
            const string FITH_TIME_SLOT = "4:00 pm";    // Create constant for the fith time slot option
            
            double hours; // To hold credit hours
            char letter;  // To hold the first letter of the last name as a char
            string date;  // To hold the date as a string
            string name;  // To hold the name as a string

            name = nameTextBox.Text;        // To get the name from the nameTextBox and apply it to name variable
   
            if (double.TryParse(hoursTextBox.Text, out hours)) // To determine if the hours from the hoursTextBox is a double
            {
                if (hours >= 0) // If the hours entered are non negative
                {
                    if (String.IsNullOrEmpty(name)) // If string is empty 
                    {
                        MessageBox.Show("Please enter your last name"); // Display error message if string name is empty
                    }
                    else // If name is not empty
                    {
                        if (char.IsLetter(name[0])) // If name contains letters instead of digits
                        {
                            letter = char.ToUpper(name[0]); // To get the first letter of the last name and make it an uppercase char

                            if (hours >= HOURS_SENIOR)  // Determine if the hours entered are greater than hours for a senior
                            {
                                date = SENIOR_DAY;  // If meets criteria then register on senior day 
                                dateLabel.Text = SENIOR_DAY; // If meets criteria  then display senior day in the dateLabel
                            }
                            else if (hours >= HOURS_JUNIOR)  // Determine if the hours entered are greater than hours for a junior
                            {
                                date = JUNIOR_DAY;  // If meets criteria then register on junior day
                                dateLabel.Text = JUNIOR_DAY; // If meets criteria  then display junior day in the dateLabel
                            }
                            else if (hours >= HOURS_SOPHMORE && 'E' <= letter && 'Q' >= letter)  // Determine if the hours entered are greater than hours for a sophmore and last name is between e and q
                            {
                                date = SOPHMORE_DAY_ONE;    // If meets criteria then register on the first sophmore day
                                dateLabel.Text = SOPHMORE_DAY_ONE; // If meets criteria  then display sophmore day one in the dateLabel
                            }
                            else if (hours >= HOURS_SOPHMORE)   // Determine if the hours entered are greater than sophmore hours and not between e and q
                            {
                                date = SOPHMORE_DAY_TWO;  // If doesn't meet criteria for sophmore day one then register on second sophmore day
                                dateLabel.Text = SOPHMORE_DAY_TWO; // If meets criteria  then display sophmore day two in the dateLabel
                            }
                            else if (hours < HOURS_SOPHMORE && 'E' <= letter && 'Q' >= letter) // Determine if the hours entered are less than hours for a sophmore and last name is between e and q
                            {
                                date = FRESHMAN_DAY_ONE;  // If meets criteria then register on first freshman day
                                dateLabel.Text = FRESHMAN_DAY_ONE; // If meets criteria  then display freshman day one in the dateLabel
                            }
                            else  // If fits no other criteria 
                            {
                                date = FRESHMAN_DAY_TWO;  // If doesn't meet any oher criteria, then register on second freshman day
                                dateLabel.Text = FRESHMAN_DAY_TWO; // If meets no other criteria, then display freshman day two in the dateLabel
                            }


                            if ((date == SENIOR_DAY || date == JUNIOR_DAY) && 'E' <= letter && 'I' >= letter) // Determine if junior or senior day and if letter is between E and I
                            {
                                timeLabel.Text = FIRST_TIME_SLOT; // Display the first time slot in the timeLabel
                            }
                            else if ((date == SENIOR_DAY || date == JUNIOR_DAY) && 'J' <= letter && 'O' >= letter) // Determine if junior or senior day and if letter is between J and O
                            {
                                timeLabel.Text = SECOND_TIME_SLOT; // Display the second time slot in the timeLabel
                            }
                            else if ((date == SENIOR_DAY || date == JUNIOR_DAY) && 'P' <= letter && 'S' >= letter) // Determine if junior or senior day and if letter is between P and S
                            {
                                timeLabel.Text = THIRD_TIME_SLOT; // Display the third time slot in the timeLabel
                            }
                            else if ((date == SENIOR_DAY || date == JUNIOR_DAY) && 'T' <= letter) // Determine if junior or senior day and if letter is greater than T
                            {
                                timeLabel.Text = FOURTH_TIME_SLOT; // Display the fourth time slot in the timeLabel
                            }

                            else if ((date == SOPHMORE_DAY_ONE || date == FRESHMAN_DAY_ONE) && 'E' <= letter && 'F' >= letter) // Determine if freshman or sophmore day one and if letter is between E and F
                            {
                                timeLabel.Text = FIRST_TIME_SLOT; // Display the first time slot in the timeLabel
                            }
                            else if ((date == SOPHMORE_DAY_ONE || date == FRESHMAN_DAY_ONE) && 'G' <= letter && 'I' >= letter) // Determine if freshman or sophmore day one and if letter is between G and I
                            {
                                timeLabel.Text = SECOND_TIME_SLOT; // Display the second time slot in the timeLabel
                            }
                            else if ((date == SOPHMORE_DAY_ONE || date == FRESHMAN_DAY_ONE) && 'J' <= letter && 'L' >= letter) // Determine if freshman or sophmore day one and if letter is between J and L
                            {
                                timeLabel.Text = THIRD_TIME_SLOT; // Display the third time slot in the timeLabel
                            }
                            else if ((date == SOPHMORE_DAY_ONE || date == FRESHMAN_DAY_ONE) && 'O' >= letter) // Determine if freshman or sophmore day one and if letter is less than O
                            {
                                timeLabel.Text = FOURTH_TIME_SLOT; // Display the fourth time slot in the timeLabel
                            }

                            else if ((date == SOPHMORE_DAY_TWO || date == FRESHMAN_DAY_TWO) && 'R' <= letter && 'S' >= letter) // Determine if freshman or sophmore day two and if letter is between R and S
                            {
                                timeLabel.Text = FIRST_TIME_SLOT; // Display the first time slot in the timeLabel
                            }
                            else if ((date == SOPHMORE_DAY_TWO || date == FRESHMAN_DAY_TWO) && 'T' <= letter && 'V' >= letter) // Determine if freshman or sophmore day two and if letter is between T and V
                            {
                                timeLabel.Text = SECOND_TIME_SLOT; // Display the second time slot in the timeLabel
                            }
                            else if ((date == SOPHMORE_DAY_TWO || date == FRESHMAN_DAY_TWO) && 'W' <= letter) // Determine if freshman or sophmore day two and if letter is greater than W
                            {
                                timeLabel.Text = THIRD_TIME_SLOT; // Display the third time slot in the timeLabel
                            }
                            else if ((date == SOPHMORE_DAY_TWO || date == FRESHMAN_DAY_TWO) && 'B' >= letter) // Determine if freshman or sophmore day two and if letter is less than B
                            {
                                timeLabel.Text = FOURTH_TIME_SLOT; // Display the fourth time slot in the timeLabel
                            }
                            else   // If doesn't fit other time criteria, then is the fith time slot
                            {
                                timeLabel.Text = FITH_TIME_SLOT; // Display the fith time slot in the timeLabel
                            }
                        }
                        else  // If what the user entered in the nameTextBox is not a letter
                        {
                            MessageBox.Show("Please enter a valid last name"); // Display error message if name does not contain letter
                        }
                    }
                }
                else // If not a positive double
                {
                    MessageBox.Show("Please enter a positive double for Hours Earned"); // Display error message box for a negative number entered for hours
                }
            }
            else  // If not a valid double
            {
                MessageBox.Show("Please enter a valid double for Hours Earned"); // Display error message box for invalid double entered for hours
            }
        }
    }
}
