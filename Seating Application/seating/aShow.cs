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
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace seating
{
    [Serializable()]

    public class aShow : ISerializable
    {
        public static SeatNumbers seatNums;
        private Hashtable HtNights2Night;
        private string ShowName;

        public Hashtable htNights2Nights
        {
            set
            {
                this.HtNights2Night = value;
            }

            get
            {
                return this.HtNights2Night;
            }
        }

        public string showName
        {
            get
            {
                return this.ShowName;
            }
        }

        //default constructor
        public aShow(int nights, string name)
        {
            //set the show's name
            this.ShowName = name;

            //initialize seat numbers
            seatNums = new SeatNumbers();

            //initialize hashtable
            HtNights2Night = new Hashtable(nights);

            for (int i = 1; i <= nights; i++)
            {
                //create a night object for each desired night
                Night night = new Night();
                night.night = i;

                //and add it to the hashtable
                HtNights2Night.Add(i, night);
            }//end for
        }//end default constructor

        //deserialization constructor.
        public aShow(SerializationInfo info, StreamingContext ctxt)
        {
            //grab data from the serialization and assign it to local vars
            HtNights2Night = (Hashtable)info.GetValue("NightsHashtable", typeof(Hashtable));
            ShowName = (string)info.GetValue("Name", typeof(string));

            //initialize seat numbers
            seatNums = new SeatNumbers();
        }//end deserialization constructor

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //add objects
            info.AddValue("NightsHashtable", HtNights2Night);
            info.AddValue("Name", ShowName);
        }//end GetObjectData
    }//end class
}//end namespace
