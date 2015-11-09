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
    public partial class frmNumberNightsPrompt : Form
    {
        private frmSeatingChart existingChart;
        
        //default constructor
        public frmNumberNightsPrompt()
        {
            InitializeComponent();
        }//end default constructor

        //constructor
        public frmNumberNightsPrompt(frmSeatingChart existingChart)
        {
            InitializeComponent();

            //assign local from constructor
            this.existingChart = existingChart;
        }//end non-default constructor

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            submit();
        }//end btnSubmit

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

        private void doSeatingChart(int numNights, string showName)
        {
            //create new show with selected number of nights
            aShow show = new aShow(cmboNumNights.SelectedIndex + 1, showName);

            if (existingChart != null)
            {
                //set the chart form's current show to the one just made
                existingChart.currentShow = show;

                //close this form
                this.Close();

                //re-enable the form
                existingChart.Enabled = true;

                //reset the form to night 1
                existingChart.updateNight(1);
            }//end if

            else if (existingChart == null)
            {
                //create new form and pass it the show that was just created
                frmSeatingChart seatingChartMain = new frmSeatingChart(show);

                //close this form
                this.Close();

                //show new form
                seatingChartMain.Show();
            }//end else if
        }//end doSeatingChart

        private void submit()
        {
            if (checkText())
            {
                if (checkCombo())
                {
                    //spawn form for new project
                    doSeatingChart(cmboNumNights.SelectedIndex, txtShowName.Text);
                }//end if
            }//end if
        }//end submit

        private bool checkCombo()
        {
            //make sure an index is selected
            if (cmboNumNights.SelectedIndex >= 0)
            {
                return true;
            }//end if

            else
            {
                //if no index is selected, throw an error and return to the form
                MessageBox.Show("Please select a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //focus combo box
                cmboNumNights.Focus();

                return false;
            }//end else
        }//end checkCombo

        private bool checkText()
        {
            //make sure text box is not empty
            if (txtShowName.Text != "")
            {
                return true;
            }//end if

            else
            {
                //if no index is selected, throw an error and return to the form
                MessageBox.Show("Please enter a name for this show", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //focus text box
                txtShowName.Focus();

                return false;
            }//end else
        }//end checkText
    }//end class
}//end namespace