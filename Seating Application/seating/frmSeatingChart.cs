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
    public partial class frmSeatingChart : Form
    {
        //declare hashtables
        private Hashtable HtBits2Seats;
        private Hashtable HtSeats2Bits;
        private BitArray ArrSeatAvailability;
        private aShow CurrentShow;
        private Night CurrentNight;
        private bool Changed = false;
        private string Path;
        private bool ButtonsEnabled = true;

        //accessors
        #region
        public Hashtable htBits2Seats
        {
            set
            {
                this.HtBits2Seats = value;
            }

            get
            {
                return this.HtBits2Seats;
            }
        }

        public Hashtable htSeats2Bits
        {
            set
            {
                this.HtSeats2Bits = value;
            }

            get
            {
                return this.HtSeats2Bits;
            }
        }

        public BitArray arrSeatAvailability
        {
            set
            {
                this.ArrSeatAvailability = value;
            }

            get
            {
                return this.ArrSeatAvailability;
            }
        }

        public aShow currentShow
        {
            set
            {
                this.CurrentShow = value;
            }

            get
            {
                return this.CurrentShow;
            }
        }

        public Night currentNight
        {
            set
            {
                this.CurrentNight = value;
            }

            get
            {
                return this.CurrentNight;
            }
        }

        public bool changed
        {
            set
            {
                this.Changed = value;
            }

            get
            {
                return this.Changed;
            }
        }

        public bool buttonsEnabled
        {
            set
            {
                this.ButtonsEnabled = value;
            }

            get
            {
                return this.ButtonsEnabled;
            }
        }
        #endregion

        //initialize and form load
        #region
        //non-default constructor #1 for new show
        public frmSeatingChart(aShow show)
        {
            InitializeComponent();

            //set current show
            CurrentShow = show;

            //since this is a new show, set the default night to night 1
            CurrentNight = (Night)CurrentShow.htNights2Nights[1];

            //clear save path
            this.Path = null;
        }//end non-default constructor #1

        //non-default constructor #2 for existing show
        public frmSeatingChart(aShow show, string path)
        {
            InitializeComponent();

            //set current show
            CurrentShow = show;

            //set current night
            CurrentNight = (Night)CurrentShow.htNights2Nights[1];

            //assign path
            this.Path = path;
        }//end non-default constructor #2

        private void frmSeatingChart_Load(object sender, EventArgs e)
        {
            //set the show name in the title
            this.Text += " - " + CurrentShow.showName;

            //if there is a valid path, enable the save button
            if (this.Path != null)
            {
                saveToolStripMenuItem.Enabled = true;
            }

            //display the seats
            updateNight(1);
        }//end form load

        private void frmSeatingChart_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if there are no changes, just kill
            if (!Changed)
            {
                //actually close this form
                Application.Exit();
            }

            //otherwise, prompt to save
            else
            {
                changes();
                Application.Exit();
            }
        }//end formclosing

        #endregion

        //method for buttonclick event
        private void seatButton_Click(object sender, EventArgs e)
        {
            //call method that determines whether or not the button is clickable
            //this beats having to manually enable/disable all buttons
            //also lets buttons keep color while still being unclickable
            gateKeeper((Button)sender);

            this.buttonsEnabled = false;
        }//end seatButton_Click

        private void btnPrevNight_Click(object sender, EventArgs e)
        {
            //make sure there are still nights left to deduct from
            if ((int)btnPrevNight.Tag >= 1 && this.buttonsEnabled)
            {
                updateNight((int)btnPrevNight.Tag);
            }//end if
        }//end btnPrev

        private void btnNextNight_Click(object sender, EventArgs e)
        {
            //make sure there are still nights left to deduct from
            if ((int)btnNextNight.Tag <= currentShow.htNights2Nights.Count && this.buttonsEnabled)
            {
                //update the form
                updateNight((int)btnNextNight.Tag);
            }//end if
        }//end btnNext

        //?//////////////////////////////MENU ITEMS///////////////////
        #region
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }//end menuExit

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open dialog to save file
            saveFile();
        }//end menuSaveAs

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile(Path);
        }//end menuSave

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check for changes
            changes();

            //open the file
            openFile();
        }//end menuOpen

        private void newShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult saveChanges = MessageBox.Show("Create new show?", "Create Show?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (saveChanges == System.Windows.Forms.DialogResult.Yes)
            {
                //create new show
                newShow();
            }//end if

            else if (saveChanges == System.Windows.Forms.DialogResult.No)
            {

            }//end else if
        }//end menuNew

        private void showStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showStats();
        }//end showStatistics

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create new form object
            frmAbout about = new frmAbout();

            //display about form
            about.Show();
        }//end changes

        private void reserveSeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //create reserve tickets form
            frmReserveTickets reserveWindow = new frmReserveTickets(this);

            //disable buttons on this form
            this.ButtonsEnabled = false;

            //display that form
            reserveWindow.Show();
        }//end reserveSeats menu

        #endregion

        //?///////////////////////////////CUSTOM METHODS/////////////
        #region
        //display save prompt before saving
        private void saveFile()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != null)
                {
                    //create serialization object
                    SerializeObject writeMe = new SerializeObject(saveFileDialog.FileName, this.CurrentShow);

                    //write data and get result code
                    string result = writeMe.writeFile();

                    //handle according to result
                    if (result == "success")
                    {
                        Changed = false;

                        //set global path
                        this.Path = saveFileDialog.FileName;

                        //enable save button
                        saveToolStripMenuItem.Enabled = true;
                    }//end if

                    else if (result == "error")
                    {
                        MessageBox.Show("Unable to open file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }//end else if
                }//end inner if
            }//end main if
        }//end saveFile

        //save directly to file without prompting
        private void saveFile(string path)
        {
            //create serialization object
            SerializeObject writeMe = new SerializeObject(path, CurrentShow);

            //write data and get result code
            string result = writeMe.writeFile(true);

            //handle according to result
            if (result == "success")
            {
                Changed = false;   
            }

            else
            {
                MessageBox.Show("Unable to save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end saveFile

        private void openFile()
        {
            //show file dialog
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //make sure we're actually reading from a file
                if (openFileDialog.FileName != null)
                {
                    //create serialization object
                    SerializeObject openMe = new SerializeObject(openFileDialog.FileName);

                    //attempt to read the file
                    if (openMe.readFile())
                    {
                        try
                        {
                            //create new show from read data
                            aShow openedShow = (aShow)openMe.obj;

                            //set the current show to the opened show
                            this.CurrentShow = openedShow;

                            //update the form
                            updateNight(1);

                            //reset the changes flag
                            this.Changed = false;
                        }//end try

                        catch
                        {
                            //throw error
                            MessageBox.Show("Unable to open file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }//end catch
                    }//end if

                    else
                    {
                        //otherwise, throw error
                        MessageBox.Show("Unable to open file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }//end else
                }//end inner if
            }//end outer if
        }//end open file

        private void newShow()
        {
            //prompt for changes
            changes();

            //set to night 1
            updateNight(1);

            //create prompt for new show
            frmNumberNightsPrompt newNumNights = new frmNumberNightsPrompt(this);

            //disalbe this form
            this.Enabled = false;

            //display new prompt
            newNumNights.Show();
        }//end newShow

        public void updateForm()
        {
            for (int i = 0; i < SeatNumbers.seatNums.Length; i++ )
            {
                //get button
                Button thisButton = (Button)frmSeatingChart.Seats[SeatNumbers.seatNums[i]];

                //get seat
                Seat thisSeat = (Seat)this.currentNight.htSeats2Bits[SeatNumbers.seatNums[i]];

                //determine availability

                //no need to go through everything if it is selected
                if (!thisSeat.selected)
                {
                    switch (thisSeat.reserved)
                    {
                        case true:

                            //determine handicapped
                            switch (thisSeat.handicapped)
                            {
                                case true:
                                    //handicapped and reserved

                                    //set image
                                    thisButton.ImageKey = "reserhandi";

                                    break;

                                case false:
                                    //just reserved

                                    //set image
                                    thisButton.ImageKey = "reser";

                                    break;
                            }//end handicapped switch
                            break;

                        case false:

                            //determine handicapped
                            switch (thisSeat.handicapped)
                            {
                                case true:
                                    //handicapped and available

                                    //set image
                                    thisButton.ImageKey = "availhandi";

                                    break;

                                case false:
                                    //just available

                                    //set image
                                    thisButton.ImageKey = "avail";

                                    break;
                            }//end handicapped switch
                            break;
                    }//end availability switch
                }//end selected if

                else if (thisSeat.selected)
                {
                    //determine handicapped
                    if (!thisSeat.handicapped)
                    {
                        thisButton.ImageKey = "selectnorm";
                    }//end if

                    else if (thisSeat.handicapped)
                    {
                        thisButton.ImageKey = "selecthandi";
                    }//end else if
                }//end else if
            }//end for
        }//end end updateForm

        private void showStats()
        {
            //create stat form
            frmShowStats stats = new frmShowStats(this.CurrentShow);

            //show stat form
            stats.Show();
        }//end showStats

        private void gateKeeper(object sender)
        {
            if (this.ButtonsEnabled)
            {
                //convert sender to Button
                Button btnSeatClicked = (Button)sender;

                //grab relevant seat number from button
                string seatNum = (string)btnSeatClicked.Tag;

                //create new form
                frmSeatInfo seatInfo = new frmSeatInfo(this, seatNum);

                //display form
                seatInfo.Show();
            }//end if
        }//end gateKeeper

        public void updateNight(int night)
        {
            //change the current night
            this.CurrentNight = (Night)this.CurrentShow.htNights2Nights[night];

            //update the text box
            txtCurrentNight.Text = Convert.ToString(night);

            //make sure not to set if there is only 1 Night
            if (this.currentShow.htNights2Nights.Count == 1)
            {
                //disable buttons if there is only one show
                btnPrevNight.Enabled = false;
                btnNextNight.Enabled = false;
            }//end else if

            //if the current Night is 1, assign val to prev and disable it
            else if (this.currentNight.night == 1)
            {
                btnPrevNight.Tag = 0;
                btnPrevNight.Enabled = false;
                if (CurrentShow.htNights2Nights.Count > 1)
                {
                    btnNextNight.Enabled = true;
                    btnNextNight.Tag = (this.CurrentNight.night + 1);
                 }//end if
            }//end else if

            else if (this.CurrentNight.night > 1)
            {
                btnPrevNight.Enabled = true;
                btnPrevNight.Tag = (night - 1);

                btnNextNight.Enabled = true;
                btnNextNight.Tag = (night + 1);
            }//end else if

            if (this.CurrentNight.night < this.CurrentShow.htNights2Nights.Count)
            {
                btnPrevNight.Enabled = true;
                btnPrevNight.Tag = (night - 1);

                btnNextNight.Enabled = true;
                btnNextNight.Tag = (night + 1);
            }//end else if

            if (this.currentNight.night == this.CurrentShow.htNights2Nights.Count)
            {
                btnNextNight.Enabled = false;
                btnNextNight.Tag = (this.CurrentShow.htNights2Nights.Count + 1);

                btnPrevNight.Enabled = true;
                btnPrevNight.Tag = (this.CurrentNight.night - 1);
            }//end else if

            //reflect changes in the seating chart
            this.updateForm();
        }//end updateNight

        private void changes()
        {
            if (!Changed)
            {

            }

            else
            {
                //save prompt
                DialogResult saveChanges = MessageBox.Show("Do you wish to save your changes to this show?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (saveChanges == System.Windows.Forms.DialogResult.Yes)
                {
                    saveFile();
                }//end if

                else if (saveChanges == System.Windows.Forms.DialogResult.No)
                {
                    Changed = false;
                }//end else if

                else
                {
                    Changed = true;
                }//end else
            }//end else
        }//end changes
        #endregion
    }//end class
}//end namespace