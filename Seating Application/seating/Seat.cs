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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace seating
{
    [Serializable()]
    public class Seat : ISerializable
    {
        string SeatNum;
        int ArrayIndex;
        bool Reserved;
        bool Handicapped;
        Ticket Ticket;
        bool Selected;

        //accessors
        #region
        public string seatNum
        {
            get
            {
                return SeatNum;
            }
        }

        public int arrayIndex
        {
            set
            {
                this.ArrayIndex = value;
            }

            get
            {
                return ArrayIndex;
            }
        }

        public bool reserved
        {
            set
            {
                this.Reserved = value;
            }

            get
            {
                return Reserved;
            }
        }

        public bool handicapped
        {
            set
            {
                Handicapped = value;
            }

            get
            {
                return Handicapped;
            }
        }

        public Ticket ticket
        {
            set
            {
                Ticket = value;
            }

            get
            {
                return Ticket;
            }
        }

        public bool selected
        {
            set
            {
                this.Selected = value;
            }

            get
            {
                return Selected;
            }
        }

        #endregion

        //default constructor
        public Seat()
        {

        }//end default constructor

        //non-default constructor
        public Seat(string seatNum, int arrayIndex)
        {
            this.SeatNum = seatNum;
            this.ArrayIndex = arrayIndex;
        }//end non-default constructor

        //deserialization constructor.
        public Seat(SerializationInfo info, StreamingContext ctxt)
        {
            //grab data from the serialization and assign it to local vars
            SeatNum = (string)info.GetValue("seatNumbers", typeof(string));
            ArrayIndex = (int)info.GetValue("arrayDex", typeof(int));
            Reserved = (bool)info.GetValue("reserved?", typeof(bool));
            Handicapped = (bool)info.GetValue("handicapped?", typeof(bool));
            this.Ticket = (Ticket)info.GetValue("theTicket", typeof(Ticket));
        }//end deserialization constructor

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //add objects
            info.AddValue("seatNumbers", SeatNum);
            info.AddValue("arrayDex", ArrayIndex);
            info.AddValue("reserved?", Reserved);
            info.AddValue("handicapped?", Handicapped);
            info.AddValue("theTicket", this.Ticket);
        }//end GetObjectData

        //toggle seat reservation
        public int reserveSeat(bool reservation)
        {
            //reserve or unreserve seat as indicated
            if (reservation)
            {
                this.Reserved = true;
                return ArrayIndex;
            }//end if

            else if (!reservation)
            {
                this.Reserved = false;
                return ArrayIndex;
            }//end else if

            else
            {
                //return nonsense of there is an error
                return -1;
            }//end else
        }//end reserve seat
    }//end class
}//end namespace
