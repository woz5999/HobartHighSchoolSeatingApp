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
    class TicketSums
    {
        private int Adults;
        private int Students;
        private int Seniors;
        private int ParPass;

        private double adultPrice;
        private double studentPrice;
        private double seniorPrice;
        private double parPassPrice;

        //default constructor
        public TicketSums()
        {

        }//end default constructor

        //non-default constructor
        public TicketSums(NightlySum totals, double adultPrice, double studentPrice, double seniorPrice, double parPassPrice)
        {
            //assign values
            this.Adults = totals.adults;
            this.Students = totals.students;
            this.Seniors = totals.seniors;
            this.ParPass = totals.parPass;

            this.adultPrice = adultPrice;
            this.studentPrice = studentPrice;
            this.seniorPrice = seniorPrice;
            this.parPassPrice = parPassPrice;
        }//end non-default constructor

        public double total()
        {
            return (totalAdult() + totalSenior() + totalStudent());
        }//end total

        public double totalAdult()
        {
            return (adultPrice * Adults); 
        }//end total adult

        public double totalStudent()
        {
            return (studentPrice * Students);
        }//end total student

        public double totalSenior()
        {
            return (seniorPrice * Seniors);
        }//end total senior

        public double totalParPass()
        {
            return (parPassPrice * ParPass);
        }//end total parPass

    }//end class
}//end namespace
