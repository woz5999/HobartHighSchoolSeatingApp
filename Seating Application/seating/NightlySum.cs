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
using System.Text;

namespace seating
{
    class NightlySum
    {
        private int Tickets;
        private int Adults;
        private int Students;
        private int Seniors;
        private int Comps;
        private int ParPass;

        //accessors
        #region
        public int tickets
        {
            set
            {
                this.Tickets = value;
            }

            get
            {
                return Tickets;
            }
        }

        public int adults
        {
            set
            {
                this.Adults = value;
            }

            get
            {
                return Adults;
            }
        }

        public int students
        {
            set
            {
                this.Students = value;
            }

            get
            {
                return Students;
            }
        }

        public int seniors
        {
            set
            {
                this.Seniors = value;
            }

            get
            {
                return Seniors;
            }
        }

        public int comps
        {
            set
            {
                this.Comps = value;
            }

            get
            {
                return Comps;
            }
        }

        public int parPass
        {
            set
            {
                this.ParPass = value;
            }

            get
            {
                return ParPass;
            }
        }

        #endregion

        //default constructor
        public NightlySum()
        {
        }//end default constructor

        //non-default constructor
        public NightlySum(int tickets, int adults, int students, int seniors, int comps, int parPass)
        {
            this.Tickets = tickets;
            this.Adults = adults;
            this.Students = students;
            this.Seniors = seniors;
            this.Comps = comps;
            this.ParPass = parPass;
        }//end non-default constructor
    }//end class
}//end namespace
