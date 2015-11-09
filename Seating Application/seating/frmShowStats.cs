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
using System.Collections;

namespace seating
{
    public partial class frmShowStats : Form
    {
        private aShow show;

        //default constructor
        public frmShowStats(aShow show)
        {
            InitializeComponent();

            this.show = show;
        }//end default constructor

        private void frmShowStats_Load(object sender, EventArgs e)
        {
            //put the show's name in the title
            this.Text += " - " + show.showName;

            populateCombo();
            updateTotalLabels();
        }//end form load

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end btnClose

        private void cmboNight_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboNight.SelectedIndex >= 0)
            {
                updateNightLabels(sumNight((Night)show.htNights2Nights[(cmboNight.SelectedIndex + 1)]));
            }//end if
        }//end index changed

        //grab enter and accept
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventArgs ee = new EventArgs();
            //if user presses enter
            if (e.KeyChar == 13)
            {
                this.Close();
            }//end if
        }//end txtInput_KeyPress

        private void populateCombo()
        {
            for (int i = 1; i <= show.htNights2Nights.Count; i++)
            {
                //populate the combo box with the number of nights
                cmboNight.Items.Add(i);
            }//end for
        }//end populateCombo

        private void updateTotalLabels()
        {
            //get the show's total
            NightlySum totalSum = showTotal();

            //create object to perform math. more for cleanliness than anything else
            TicketSums sums = new TicketSums(totalSum, Ticket.adultCost, Ticket.studentCost, Ticket.seniorCost, Ticket.parPassCost);

            //assign the values to the labels
            lblShowTixTot1.Text = totalSum.tickets.ToString();
            lblShowAdTixTot1.Text = totalSum.adults.ToString();
            lblShowStudTixTot1.Text = totalSum.students.ToString();
            lblShowSenTixTot1.Text = totalSum.seniors.ToString();
            lblShowCompTixTot1.Text = totalSum.comps.ToString();
            lblShowParPassTixTot1.Text = 
                (totalSum.parPass / show.htNights2Nights.Count).ToString();   //this is done to reflect the actual amount of passes sold, not the seats occupied by pass holders

            lblShowTakenTot1.Text = "$ " + String.Format("{0:0.00}", stripPasses(sums));
            lblShowSenTaken1.Text = "$ " + String.Format("{0:0.00}", sums.totalSenior());
            lblShowAdTaken1.Text = "$ " + String.Format("{0:0.00}", sums.totalAdult());
            lblShowStudTaken1.Text = "$ " + String.Format("{0:0.00}", sums.totalStudent());
            lblShowParPassTaken1.Text = "$ " + String.Format("{0:0.00}", 
                sums.totalParPass() / show.htNights2Nights.Count); //this is done to reflect the actual amount of passes sold, not the seats occupied by pass holders
        }//end updateTotalLabels

        private void updateNightLabels(NightlySum sum)
        {
            //create object to perform math. more for cleanliness than anything else
            TicketSums sums = new TicketSums(sum, Ticket.adultCost, Ticket.studentCost, Ticket.seniorCost, Ticket.parPassCost);

            //assign the values to the labels
            lblNightTixTot1.Text = sum.tickets.ToString();
            lblNightAdTix1.Text = sum.adults.ToString();
            lblNightStudTix1.Text = sum.students.ToString();
            lblNightSenTix1.Text = sum.seniors.ToString();
            lblNightCompTix1.Text = sum.comps.ToString();
            lblNightParPassTix1.Text = sum.parPass.ToString();

            lblNightTaken1.Text = "$ " + String.Format("{0:0.00}", sums.total());
            lblNightSenTaken1.Text = "$ " + String.Format("{0:0.00}", sums.totalSenior());
            lblNightAdTaken1.Text = "$ " + String.Format("{0:0.00}", sums.totalAdult());
            lblNightStudTaken1.Text = "$ " + String.Format("{0:0.00}", sums.totalStudent());
        }//end updateNightLabels

        private NightlySum showTotal()
        {
            //create nightly sum to hold total
            NightlySum totalSum = new NightlySum();

            //for each night
            for (int i = 1; i <= show.htNights2Nights.Count; i++)
            {
                //get the nightly sum
                NightlySum thisSum = (NightlySum)sumNight((Night)show.htNights2Nights[i]);

                //add night's sum to total sum
                totalSum.tickets += thisSum.tickets;
                totalSum.adults += thisSum.adults;
                totalSum.students += thisSum.students;
                totalSum.seniors += thisSum.seniors;
                totalSum.comps += thisSum.comps;
                totalSum.parPass += thisSum.parPass;
            }//end for

            //return the total
            return totalSum;
        }//end sum total

        private NightlySum sumNight(Night nightTable)
        {
            //declare placeholders
            int tickets = 0;
            int adults = 0;
            int students = 0;
            int seniors = 0;
            int comps = 0;
            int parPass = 0;

            foreach (string key in SeatNumbers.seatNums)
            {
                //create a local object for each seat
                Seat seat = (Seat)nightTable.htSeats2Bits[key];

                //no need to include it if it is not reserved
                if (seat.reserved == true)
                {
                    //increment total
                    tickets++;

                    //increment each type
                    if (seat.ticket.type == "Adult")
                    {
                        adults++;
                    }//end if

                    else if (seat.ticket.type == "Student")
                    {
                        students++;
                    }//end if

                    else if (seat.ticket.type == "Senior")
                    {
                        seniors++;
                    }//end if

                    else if (seat.ticket.type == "Comp")
                    {
                        comps++;
                    }//end if

                    else if (seat.ticket.type == "Parent Pass")
                    {
                        parPass++;
                    }//end if

                }//end outer if
            }//end foreach

            //create a new object to hold the sum
            NightlySum sum = new NightlySum(tickets, adults, students, seniors, comps, parPass);

            //return that object
            return sum;
        }//end sum night

        private double stripPasses(TicketSums preTotal)
        {
            if (preTotal.totalParPass() > 0)
            {
                //this effectively reduces the number of parent pass tickets to the number of 1 each for every show
                //i.e. instead of ShowNights * ParPasses * $25, it returns TotalParPasses * $25
                //this normalizes the actual amount of money received from them
                return preTotal.total() + (preTotal.totalParPass() / show.htNights2Nights.Count);
            }//end if

            else
            {
                return preTotal.total();
            }//end else
        }//end strip passe
    }//end class
}//end namespace