/*Hobart High School Performing Arts Center Reserve Ticking Application
Copyright (C) 2009  Jeff Wozniak

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace seating
{
    public partial class frmReserveTickets : Form
    {
        private frmSeatingChart SeatingChart;
        private ArrayList numbers;
        private ArrayList comboBoxes;
        private bool Handi = false;
        private int adultTotal;
        private int studentTotal;
        private int seniorTotal;
        private int compTotal;
        private int cmbosActive;

        //default constructor
        public frmReserveTickets()
        {
            InitializeComponent();
        }//end default constructor

        //non-default constructor
        public frmReserveTickets(frmSeatingChart seatingChart)
        {
            InitializeComponent();

            this.SeatingChart = seatingChart;
        }//end non-default constructor

        private void frmReserveTickets_Load(object sender, EventArgs e)
        {
            //put the show's name in the title
            this.Text += " - " + SeatingChart.currentShow.showName;

            //initialize the array lists
            numbers = new ArrayList(100);
            comboBoxes = new ArrayList();// (4);

            //fill the array with the numbers
            populateCollection();

            //fill the array with combos
            populateCombos();

            //populate the combo collect
            enableCombos();
        }//end form load

        private void frmReserveTickets_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.SeatingChart.buttonsEnabled = true;
        }//end form closing

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //disable this form so it can't be tampered while the user is prompted
            this.Enabled = false;

            //tally tickets from combos
            
            //make sure selected index isn't 0 or you'll get negative values
            if (tallyCheck(cmboAdults))
            {
                adultTotal = cmboAdults.SelectedIndex;
            }

            if (tallyCheck(cmboStudents))
            {
                studentTotal = cmboStudents.SelectedIndex;
            }

            if (tallyCheck(cmboSeniors))
            {
                seniorTotal = cmboSeniors.SelectedIndex;
            }

            if (tallyCheck(cmboComps))
            {
                compTotal = cmboComps.SelectedIndex;
            }

            //determine whether searching for handicapped
            if (chkHandi.Checked == false)
            {
                //perform search
                search();
            }//end if

            else if (chkHandi.Checked == true)
            {
                search(true);
            }//end else if
        }//end btnSearch click

        private void chkHandi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHandi.Checked)
            {
                handiCombos();
                this.Handi = true;
            }//end if

            else if (!chkHandi.Checked)
            {
                enableCombos();
                this.Handi = false;
            }//end else if
        }//end change check

        private void cmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //convert sender to combo
            ComboBox thisCombo = (ComboBox)sender;

            //disable searching until something is selected
            if (thisCombo.SelectedIndex > 0)
            {
                //used to determine if other combos still have non 0 values
                this.cmbosActive++;
            }//end if

            else if (thisCombo.SelectedIndex < 0)
            {
                this.cmbosActive--;
                btnSearch.Enabled = false;
            }//end else

            if (cmbosActive > 0)
            {
                btnSearch.Enabled = true;
            }//end if

            else
            {
                btnSearch.Enabled = false;
            }//end else

            //if this is selected a number, disable the others
            if (this.Handi && thisCombo.SelectedIndex > 0 )
            {
                //disable the other combos
                disableCombos((ComboBox)sender);

                //enable the search button
                btnSearch.Enabled = true;

                //set active combos
                this.cmbosActive = 1;
            }//end if

            //if this is deselecting a number, enable the others
            else if (this.Handi && thisCombo.SelectedIndex <= 0)
            {
                //reset the other combos
                handiCombos();

                //clear active combos
                this.cmbosActive = 0;
            }//end else if
        }//end selected index changed event

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end btnCancel

        //?///////////////////////////CUSTOM METHODS///////////////////
        #region

        private void handiCombos()
        {
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                //store combo locally from array list
                ComboBox thisCombo = (ComboBox)comboBoxes[i];

                //clear combo
                thisCombo.Items.Clear();

                //add 1 & 0 to collection
                thisCombo.Items.Add("0");
                thisCombo.Items.Add("1");

                //enable the combos
                thisCombo.Enabled = true;

                //disable the search button since all the combos just got reset
                btnSearch.Enabled = false;

                this.cmbosActive = 0;
            }//end for
        }//end disable combobs

        private void disableCombos(ComboBox combo)
        {
            //disable all combos except for the one passed
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                //store combo locally from array list
                ComboBox thisCombo = (ComboBox)comboBoxes[i];
                if (thisCombo != combo)
                {
                    //clear combo
                    thisCombo.Items.Clear();

                    //enable the combo
                    thisCombo.Enabled = false;
                }//end if
            }//end for
        }//end disable combobs

        private void enableCombos()
        {
            for (int i = 0; i < comboBoxes.Count; i++)
            {
                //store combo locally from array list
                ComboBox thisCombo = (ComboBox)comboBoxes[i];

                //clear combo
                thisCombo.Items.Clear();

                //add numbers to collection
                populateCombo(thisCombo);

                //enable the combo
                thisCombo.Enabled = true;
            }//end for

            //uncheck handicapped
            chkHandi.Checked = false;

            //disable button since nothing is selected
            btnSearch.Enabled = false;
        }//end enableCombos

        private void populateCombo(ComboBox combo)
        {
            //clear the combo to prevent pile on
            combo.Items.Clear();

            //add from the array list
            for(int i = 0; i <= 99; i++)
            {
                combo.Items.Add(Convert.ToString(numbers[i]));
            }//end for
        }//end populate combo

        private void populateCollection()
        {
            for (int i = 0; i <= 99; i++)
            {
                this.numbers.Add(i);
            }//end for
        }//end populateCollection

        private void populateCombos()
        {
            this.comboBoxes.Add(cmboAdults);
            this.comboBoxes.Add(cmboStudents);
            this.comboBoxes.Add(cmboSeniors);
            this.comboBoxes.Add(cmboComps);
        }//end populateCombos

        private void search()
        {
            ArrayList foundSeats;
            string type = "";
            int total = adultTotal + studentTotal + seniorTotal + compTotal;
            double costTotal = (adultTotal * Ticket.adultCost) + (studentTotal * Ticket.studentCost) + (seniorTotal * Ticket.seniorCost);

            //search for the seats
            foundSeats = SeatingChart.currentNight.findSeats(total);

            if (foundSeats.Count > 0)
            {
                //display found seats in seating chart
                indicateSeats(foundSeats, true);

                //confirmation save
                DialogResult accept = MessageBox.Show("The total cost for these tickets is: $" + String.Format("{0:0.00}", Convert.ToString(costTotal)) + "\n Do you wish to reserve these seats?", "Reserve Seats?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (accept == System.Windows.Forms.DialogResult.Yes)
                {
                    //indicate that changes have been made
                    SeatingChart.changed = true;

                    //go through array list
                    for (int i = 0; i < foundSeats.Count; i++)
                    {
                        //grab the seat
                        Seat thisSeat = (Seat)foundSeats[i];

                        //reserve the seat
                        thisSeat.reserved = true;

                        //check for existing ticket types and assign to type var
                        if (adultTotal > 0)
                        {
                            type = "Adult";
                            adultTotal--;
                        }//end if

                        else if (studentTotal > 0)
                        {
                            type = "Student";
                            studentTotal--;
                        }//end else if

                        else if (seniorTotal > 0)
                        {
                            type = "Senior";
                            seniorTotal--;
                        }//end else if

                        else if (compTotal > 0)
                        {
                            type = "Comp";
                            compTotal--;
                        }//end else if

                        //reserve the seat
                        if (!SeatingChart.currentNight.reserveSeat(thisSeat.seatNum, true))
                        {
                            //if there is an error saving seats, break and throw error
                            MessageBox.Show("Error reserving seats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //deselect seats
                            indicateSeats(foundSeats, false);

                            //renable this form
                            this.Enabled = true;

                            break;
                        }//end if

                        else
                        {
                            //otherwise, assign it a ticket and move on to the next seat

                            //create a ticket for the seat
                            Ticket thisTicket = new Ticket(type);

                            //assign the ticket to the seat
                            thisSeat.ticket = thisTicket;
                        }//end else
                    }//end for

                    //confirm that reservation has been made

                    //create new reservation confirmation form
                    frmReservedSeats reserved = new frmReservedSeats(this, foundSeats, costTotal);

                    //disable this form
                    this.Enabled = true;

                    //display the form
                    reserved.Show();
                }//end if
            }//end if

            else
            {
                MessageBox.Show("Empty seats could not be found. Try searching for a smaller number.", "Seats not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //re-enable form
                this.Enabled = true;
            }//end else

            //deselect seats
            indicateSeats(foundSeats, false);

            //reset combos
            this.enableCombos();

            //clear running totals
            resetTotals();

            //re-enable the form
            this.Enabled = true;
        }//end search

        private void search(bool handi)
        {
            ArrayList foundSeats;
            string type = "";
            int total = adultTotal + studentTotal + seniorTotal + compTotal;
            double costTotal = (adultTotal * Ticket.adultCost) + (studentTotal * Ticket.studentCost) + (seniorTotal * Ticket.seniorCost);

            //search for the seats
            foundSeats = SeatingChart.currentNight.findSeats(total, true);

            if (foundSeats.Count > 0)
            {
                //display found seats in seating chart
                indicateSeats(foundSeats, true);

                //confirmation save
                DialogResult accept = MessageBox.Show("Total Cost: $" + String.Format("{0:0.00}", Convert.ToString(costTotal)), "Reserve Tickets?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (accept == System.Windows.Forms.DialogResult.Yes)
                {
                    //indicate that changes have been made
                    SeatingChart.changed = true;

                    //go through array list
                    for (int i = 0; i < foundSeats.Count; i++)
                    {
                        //grab the seat
                        Seat thisSeat = (Seat)foundSeats[i];

                        //reserve the seat
                        thisSeat.reserved = true;

                        //check for existing ticket types and assign to type var
                        if (adultTotal > 0)
                        {
                            type = "Adult";
                            adultTotal--;
                        }//end if

                        else if (studentTotal > 0)
                        {
                            type = "Student";
                            studentTotal--;
                        }//end else if

                        else if (seniorTotal > 0)
                        {
                            type = "Senior";
                            seniorTotal--;
                        }//end else if

                        else if (compTotal > 0)
                        {
                            type = "Comp";
                            compTotal--;
                        }//end else if

                        //this is used to add the free comp. 
                        //on the second iter, there will be no other types, so this should just add
                                //the one free ticket
                        else if (i == (foundSeats.Count - 1)) 
                        {
                            type = "comp";
                        }//end else if

                        //reserve the seat
                        if (!SeatingChart.currentNight.reserveSeat(thisSeat.seatNum, true))
                        {
                            //if there is an error saving seats, break and throw error
                            MessageBox.Show("Error reserving seats", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //deselect seats
                            indicateSeats(foundSeats, false);

                            //renable this form
                            this.Enabled = true;

                            break;
                        }//end if

                        else
                        {
                            //otherwise, assign it a ticket and move on to the next seat

                            //create a ticket for the seat
                            Ticket thisTicket = new Ticket(type);

                            //assign the ticket to the seat
                            thisSeat.ticket = thisTicket;
                        }//end else
                    }//end for

                    //confirm that reservation has been made

                    //create new reservation confirmation form
                    frmReservedSeats reserved = new frmReservedSeats(this, foundSeats, costTotal);

                    //disable this form
                    this.Enabled = true;

                    //display the form
                    reserved.Show();
                }//end if
            }//end if

            else
            {
                MessageBox.Show("Empty seats could not be found. Try searching for a smaller number.", "Seats not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //re-enable form
                this.Enabled = true;
            }//end else

            //deselect seats
            indicateSeats(foundSeats, false);

            //reset combos
            this.enableCombos();

            //clear running totals
            resetTotals();

            //re-enable the form
            this.Enabled = true;
        }//end search

        private void indicateSeats(ArrayList seats, bool selected)
        {
                        //go through array list
            for (int i = 0; i < seats.Count; i++)
            {
                //hold seat
                Seat seat = (Seat)seats[i];
                seat.selected = selected;

                //assign the modified seat to the actual seat in the main form
                SeatingChart.currentNight.htSeats2Bits[seat.seatNum] = seat;

                //update that form
                //this is inefficient to refresh the whole thing, but better than dealing with
                    //iterating through every seat searching through text
                SeatingChart.updateForm();
            }//end for
        }//end indicate seats

        private void resetTotals()
        {
            this.adultTotal = 0;
            this.studentTotal = 0;
            this.seniorTotal = 0;
            this.compTotal = 0;
        }//end reset totals

        private bool tallyCheck(ComboBox combo)
        {
            if (combo.SelectedIndex > 0)
            {
                return true;
            }

            return false;
        }//end tallyCheck

        #endregion
    }//end class
}//end namespace