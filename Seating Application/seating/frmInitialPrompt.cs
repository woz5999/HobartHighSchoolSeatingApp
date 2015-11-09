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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace seating
{
    public partial class frmInitialPrompt : Form
    {
        public frmInitialPrompt()
        {
            InitializeComponent();
        }//end constructor

        private void btnOpen_Click(object sender, EventArgs e)
        {
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
                            frmSeatingChart chart = new frmSeatingChart(openedShow, openFileDialog.FileName);

                            //display that form
                            chart.Show();

                            //hide this form
                            this.Visible = false;
                        }//end try

                        catch
                        {
                            MessageBox.Show("Error while opening file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }//end catch
                    }//end if

                    else
                    {
                        //otherwise, throw error
                        MessageBox.Show("Unable to open file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }//end else
                }//end inner if
            }//end outer if
        }//end btnOpen

        private void btnNew_Click(object sender, EventArgs e)
        {
            //create new number of nights form
            frmNumberNightsPrompt prompt = new frmNumberNightsPrompt();

            //hide this form
            this.Visible = false;

            //display that form
            prompt.Show();
        }//end btnNew
    }//end class
}//end namespace