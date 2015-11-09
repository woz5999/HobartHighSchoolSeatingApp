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
using System.Diagnostics;

namespace seating
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }//end constructor

        private void lblGNUGPL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //start the default browser with the link
            System.Diagnostics.Process.Start("http://www.gnu.org/licenses/");
        }//end link
    }//end class
}//end namespace