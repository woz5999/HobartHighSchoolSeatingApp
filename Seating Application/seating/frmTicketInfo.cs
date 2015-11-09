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

namespace seating
{
    public partial class frmTicketInfo : Form
    {
        frmSeatInfo seatForm;

        //default constructor
        public frmTicketInfo(frmSeatInfo seatForm)
        {
            InitializeComponent();

            //grab the seat from the 
            this.seatForm = seatForm;
        }//end non-default constructor

        private void frmTicketInfo_Load(object sender, EventArgs e)
        {
            //put the show's name in the title
            this.Text += " - " + seatForm.mainChart.currentShow.showName;

            //prevent any changes to parent form while this is active
            this.seatForm.Enabled = false;
        }//end form load

        private void frmTicketInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.seatForm.Enabled = true;
        }//end form closing

        private void btnOk_Click(object sender, EventArgs e)
        {
            submit();
        }//end btnOk

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end btnClose

        //grab enter and accept
        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            EventArgs ee = new EventArgs();
            //if user presses enter
            if (e.KeyChar == 13)
            {
                submit();
            }//end if
        }//end txtInput_KeyPress

        private void submit()
        {
            if (cmboTixType.SelectedIndex >= 0)
            {
                string type = "";

                if (cmboTixType.SelectedIndex == 0)
                {
                    type = "Adult";
                }//end if

                else if (cmboTixType.SelectedIndex == 1)
                {
                    type = "Student";
                }//end else if

                else if (cmboTixType.SelectedIndex == 2)
                {
                    type = "Senior";
                }//end else if

                else if (cmboTixType.SelectedIndex == 3)
                {
                    type = "Parent Pass";
                }//end else if

                else if (cmboTixType.SelectedIndex == 4)
                {
                    type = "Comp";
                }//end else if

                //create new ticket
                Ticket thisTicket = new Ticket(type);

                //create seat
                Night thisNight = (Night)seatForm.mainChart.currentShow.htNights2Nights[seatForm.night];
                Seat thisSeat = (Seat)thisNight.htSeats2Bits[seatForm.seatNum];

                //assign that ticket to the seat
                thisSeat.ticket = thisTicket;

                //replace the originals with the modified ones
                thisNight.htSeats2Bits[seatForm.night] = thisSeat;
                seatForm.mainChart.currentNight = thisNight;

                //reserve the seat
                this.seatForm.reserveSeat();

                //close this form
                this.Close();
            }//end outer if

            else
            {
                //if no index is selected, throw an error and return to the form
                MessageBox.Show("Please select a ticket type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //focus combo box
                cmboTixType.Focus();
            }//end else
        }//end submit
    }//end class
}//end namespace