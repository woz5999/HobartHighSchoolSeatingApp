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
    public partial class frmReservedSeats : Form
    {
        frmReserveTickets ReservedTickets;
        ArrayList Seats;
        double Cost;

        public frmReservedSeats(frmReserveTickets reservedTickets, ArrayList seats, double cost)
        {
            InitializeComponent();

            //grab the values
            ReservedTickets = reservedTickets;
            Seats = seats;
            Cost = cost;
        }//end constructor

        private void frmReservedSeats_Load(object sender, EventArgs e)
        {
            //go through the list of seats
            for (int i = 0; i < Seats.Count; i++)
            {
                //create placeholder seat
                Seat thisSeat = (Seat)Seats[i];

                //add seat number to list box
                lstSeatsReserved.Items.Add(thisSeat.seatNum);
            }//end for

            //show total cost
            lblCostResult.Text = "$" + String.Format("{0:0.00}", Convert.ToString(Cost));

            //disable parent form
            ReservedTickets.Enabled = false;
        }//end form load

        private void frmReservedSeats_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReservedTickets.Enabled = true;
        }//end form closing

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end btnok

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
    }//end class
}//end namespace