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
    public partial class frmSeatInfo : Form
    {
        private string SeatNum;
        private int Night;
        private frmSeatingChart MainChart;

        //accessors
        #region
        public frmSeatingChart mainChart
        {
            set
            {
                this.MainChart = value;
            }

            get
            {
                return this.MainChart;
            }
        }

        public int night
        {
            set
            {
                this.Night = value;
            }

            get
            {
                return this.Night;
            }
        }

        public string seatNum
        {
            set
            {
                this.SeatNum = value;
            }

            get
            {
                return this.SeatNum;
            }
        }

        #endregion

        //constructor
        public frmSeatInfo(frmSeatingChart MainChart, string SeatNum)
        {
            InitializeComponent();
            
            //assign vars from constructor
            this.MainChart = MainChart;
            this.SeatNum = SeatNum;
            this.Night = MainChart.currentNight.night;
        }//end constructor

        //button click events
        #region

        private void frmSeatInfo_Load(object sender, EventArgs e)
        {
            //put the show's name in the title
            this.Text += " - " + MainChart.currentShow.showName;

            //assign imagelist to button
            btnSeatPic.ImageList = this.imgList1;

            //set seat number
            btnSeatPic.Text = SeatNum;
            lblSeatNumResult.Text = SeatNum;
            this.Text = "Seat Number: " + SeatNum;

            txtNightNum.Text = MainChart.currentNight.night.ToString();

            //set initial tags for arrow buttons

            //make sure not to set 0
            if (MainChart.currentNight.night > 1)
            {
                btnPrev.Tag = (MainChart.currentNight.night - 1);
            }//end if

                        //if the current Night is 1, assign val to prev and disable it
            else if (MainChart.currentNight.night == 1)
            {
                btnPrev.Tag = 0;
                btnPrev.Enabled = false;
            }//end else if

            //make sure not to set if there is only 1 Night
            if (MainChart.currentShow.htNights2Nights.Count == 1)
            {
                //disable buttons if there is only one show
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
            }//end else if

            //make sure not to set greater than total number of Nights
            if (MainChart.currentNight.night < MainChart.currentShow.htNights2Nights.Count)
            {
                btnNext.Tag = (MainChart.currentNight.night + 1);
            }//end if

            else if (MainChart.currentNight.night == MainChart.currentShow.htNights2Nights.Count)
            {
                btnNext.Enabled = false;
            }//end else if

            //update form
            updateForm();
        }//end seat load

        private void frmSeatInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainChart.buttonsEnabled = true;
        }//end form closing

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //make sure not to go less than 0
            if((int)btnPrev.Tag > 0)
            {
                 //update current Night
                this.Night = (this.Night - 1);

                //update the night on the main form
                MainChart.updateNight(this.Night);

                //update next tag
                btnNext.Tag = (this.night + 1);

                //update previous tag
                btnPrev.Tag = (this.night - 1);

                //enable next button
                btnNext.Enabled = true;

                //update form
                updateForm();

                //update main form
                MainChart.updateForm();
            }//end if

            if ((int)btnPrev.Tag == 0)
            {
                //if we reach the end, disable the button
                btnPrev.Enabled = false;

                //update the night on the main form
                MainChart.updateNight(this.Night);
            }//end else if
        }//end btnPrev

        private void btnNext_Click(object sender, EventArgs e)
        {
            //make sure not to go higher than total number of Nights
            if ((int)btnNext.Tag < MainChart.currentShow.htNights2Nights.Count)
            {
                //update the current Night
                this.night = (this.night + 1) ;

                //update the night on the main form
                MainChart.updateNight(this.Night);

                //update the next tag
                btnNext.Tag = (this.night + 1);

                //update the btnPrev button to reflect this if there is more than 1 show
                if ((int)btnPrev.Tag != MainChart.currentShow.htNights2Nights.Count)
                {
                    //update the tag
                    btnPrev.Tag = (this.night - 1);

                    //enable the button
                    btnPrev.Enabled = true;
                }//end if

                //update form
                updateForm();

                //update main form
                MainChart.updateForm();
            }//end if

            else if ((int)btnNext.Tag == MainChart.currentShow.htNights2Nights.Count)
            {
                //if we're topped out, disable this button
                btnNext.Enabled = false;

                //update current Night
                this.night = (int)btnNext.Tag;
                
                //update the night on the main form
                MainChart.updateNight(this.Night);

                //update the btnPrev button to reflect this if there is more than 1 show
                if ((int)btnPrev.Tag != MainChart.currentShow.htNights2Nights.Count)
                {
                    //update the tag
                    btnPrev.Tag = (this.night - 1);

                    //enable the button
                    btnPrev.Enabled = true;

                    //update the form
                    updateForm();
                }//end if
            }//end else if
        }//end form load

        private void btnReserve_Click(object sender, EventArgs e)
        {
            //convert sender into button
            Button thisButton = (Button)sender;

            if (thisButton.Text == "Reserve")
            {
                //create new ticket info form
                frmTicketInfo ticketForm = new frmTicketInfo(this);

                //display that form
                ticketForm.Show();
            }//end if

            else if (thisButton.Text == "Release")
            {
                //grab the relevant Night from the current show
                Night currentNight = (Night)MainChart.currentShow.htNights2Nights[Night];

                //call method to reserve seat for the correct Night
                bool status = currentNight.reserveSeat(SeatNum, false);

                if (status)
                {
                    //update form
                    updateForm();

                    //replace existing Night with the one just modified
                    MainChart.currentShow.htNights2Nights[Night] = currentNight;
                }//end if

                else
                {
                    //display error message
                    MessageBox.Show("Unable to cancel reservation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//end else
            }//end else if
        }//end btnReserve

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }//end btnOk

        #endregion

        private void updateForm()
        {
            //update Night number in text box
            txtNightNum.Text = this.night.ToString();

            //grab relevant seat object
            Night currentNight = (Night)MainChart.currentShow.htNights2Nights[this.night];
            Seat currentSeat = (Seat)currentNight.htSeats2Bits[SeatNum];

            //determine the status of the seat and update accoridngly
            switch (currentSeat.reserved)
            {
                case true:

                    //set reserved label
                    lblAvailabilityResult.Text = "Reserved";

                    //determine handicapped
                    switch (currentSeat.handicapped)
                    {
                        case true:
                            //handicapped and reserved

                            //set image
                            btnSeatPic.ImageKey = "reserhandi";

                            //set buttons
                            reservationButtons(currentSeat, true);

                            break;

                        case false:
                            //just reserved

                            //set image
                            btnSeatPic.ImageKey = "reser";

                            //set buttons
                            reservationButtons(currentSeat, true);

                            break;
                    }//end handicapped switch
                    break;

                case false:

                    //set reserved label
                    lblAvailabilityResult.Text = "Available";

                    //determine handicapped
                    switch (currentSeat.handicapped)
                    {
                        case true:
                            //handicapped and available

                            //set image
                            btnSeatPic.ImageKey = "availhandi";

                            //set buttons
                            reservationButtons(currentSeat, false);

                            break;

                        case false:
                            //just available

                            //set image
                            btnSeatPic.ImageKey = "avail";

                            //set buttons
                            reservationButtons(currentSeat, false);

                            break;
                    }//end handicapped switch
                    break;
            }//end availability switch
        }//end updateForm

        private void reservationButtons(Seat currentSeat, bool reserved)
        {
            if (currentSeat.reserved)
            {
                //toggle button to reflect status
                btnReserve.Text = "Release";

                //display ticket info if the seat has been reserved
                lblTixCostResult.Text = "$ " + String.Format("{0:0.00}", currentSeat.ticket.cost.ToString());
                lblTixTypeResult.Text = currentSeat.ticket.type;

                //flag changes
                mainChart.changed = true;
            }//end if 

            else if(!currentSeat.reserved)
            {
                //toggle button to reflect status
                btnReserve.Text = "Reserve";

                //hide ticket info if the seat is available
                lblTixCostResult.Text = "";
                lblTixTypeResult.Text = "";

                //flag changes
                mainChart.changed = true;
            }//end else if

            MainChart.updateForm();

        }//end reservation buttons

        public void reserveSeat()
        {
            //grab the relevant Night from the current show
            Night currentNight = (Night)MainChart.currentShow.htNights2Nights[Night];
            Seat thisSeat = (Seat)currentNight.htSeats2Bits[SeatNum];

            //call method to reserve seat for the correct Night
            bool status = currentNight.reserveSeat(SeatNum, true);

            if (status)
            {
                //update form
                updateForm();

                //replace existing Night with the one just modified
                MainChart.currentShow.htNights2Nights[Night] = currentNight;
            }//end if

            else
            {
                //display error message
                MessageBox.Show("Unable to reserve seat.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//end else if
        }//end reserveSeat
    }//end class
}//end namespace