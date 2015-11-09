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
    public class Night : ISerializable
    {
        private Hashtable HtBits2Seats;
        private Hashtable HtSeats2Bits;
        private BitArray SeatAvailability;
        private int thisNight;

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
                return HtBits2Seats;
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
                return HtSeats2Bits;
            }
        }

        public BitArray seatAvailability
        {
            set
            {
                this.SeatAvailability = value;
            }

            get
            {
                return SeatAvailability;
            }
        }

        public int night
        {
            set
            {
                this.thisNight = value;
            }

            get
            {
                return this.thisNight;
            }
        }

        #endregion

        //default constructor
        public Night()
        {
            //initialize elements
            htBits2Seats = new Hashtable(SeatNumbers.seatNums.Length);
            htSeats2Bits = new Hashtable(SeatNumbers.seatNums.Length);
            seatAvailability = new BitArray(SeatNumbers.seatNums.Length, false);

            //populate hash tables with blank seat info
            populateTables();
            setHandicappedSeating();
        }//end default constructor

        //deserialization constructor.
        public Night(SerializationInfo info, StreamingContext ctxt)
        {
            //grab data from the serialization and assign it to local vars
            HtBits2Seats = (Hashtable)info.GetValue("bits2Seats", typeof(Hashtable));
            HtSeats2Bits = (Hashtable)info.GetValue("seats2Bits", typeof(Hashtable));
            SeatAvailability = (BitArray)info.GetValue("avails", typeof(BitArray));
            thisNight = (int)info.GetValue("ThisNight", typeof(int));
        }//end deserialization constructor

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //add objects
            info.AddValue("bits2Seats", HtBits2Seats);
            info.AddValue("seats2Bits", HtSeats2Bits);
            info.AddValue("avails", SeatAvailability);
            info.AddValue("ThisNight", thisNight);
        }//end GetObjectData

        private void populateTables()
        {
            for (int i = (SeatNumbers.seatNums.Length - 1); i >= 0; i--)
            {
                //create new object for the seat
                Seat seat = new Seat(SeatNumbers.seatNums[i], i);
                seat.arrayIndex = i;

                //add seat to hashtables
                this.htBits2Seats.Add(i, SeatNumbers.seatNums[i]);
                this.htSeats2Bits.Add(SeatNumbers.seatNums[i], seat);
            }//end popluate for
        }//end populateTables

        private void setHandicappedSeating()
        {
            //flag handicapped seats
            for (int i = 0; i < (SeatNumbers.handicappedSeats.Count); i++)
            {
                //store seat from hashtable
                Seat seat = (Seat)HtSeats2Bits[SeatNumbers.handicappedSeats[i]];

                //modify handicaped property
                seat.handicapped = true;

                //put that seat back in hashtable
                HtSeats2Bits[SeatNumbers.handicappedSeats[i]] = seat;
            }//end popluate for
        }//end setHandicappedSeating

        public bool reserveSeat(string seatNum, bool type)
        {
            //store seat in local object
            Seat reservedSeat = (Seat)HtSeats2Bits[seatNum];

            //set that seat as reserved
            int seatIndex = reservedSeat.reserveSeat(type);

            //determine error status and the seat's index
            if (seatIndex >= 0 && type)
            {
                //set seat to reserved in array
                SeatAvailability[seatIndex] = true;

                //return stored seat to main HT
                HtSeats2Bits[seatNum] = reservedSeat;

                return true;
            }//end if

            else if (seatIndex >= 0 && !type)
            {
                //set seat to availabile in array
                SeatAvailability[seatIndex] = false;

                //return stored seat to main HT
                HtSeats2Bits[seatNum] = reservedSeat;

                return true;
            }//end else if

            else
            {
                //return error
                return false;
            }//end else
        }//end reserve seat

        public ArrayList findSeats(int numberOfSeats)
        {
            //holds number of consecutive seats
            int consec = 0;

            //declare array lists that will be used for returning results
            ArrayList foundSeats = new ArrayList(numberOfSeats);

            //search for seats. 

            //iterate through whole bit array if necessary
            for (int i = 0; i < SeatAvailability.Count; i++)
            {
                //check current index

                //if that index is free, add it to the list of indexes and increment total number found
                if (!SeatAvailability[i])
                {
                    consec++;
                    foundSeats.Add((string)this.htBits2Seats[i]);

                    //if we have found the number that we need
                    if (consec == numberOfSeats)
                    {
                        //end the loop
                        break;
                    }//end if
                }//end if

                //otherwise, if the current seat isn't available, clear placeholders and start over
                else
                {
                    //clear place holders
                    consec = 0;
                    foundSeats.Clear();
                }//end else

                //clear the array list if we reach the end of the seats without reaching goal
                if (i == (SeatAvailability.Count - 1) && consec != numberOfSeats)
                {
                    //clear place holders
                    consec = 0;
                    foundSeats.Clear();
                }//end if
            }//end for

            //return the array list containing the seats we found
            return convertToSeatObjects(foundSeats);
        }//end findSeats

        public ArrayList findSeats(int numberOfSeats, bool handi)
        {
            //this method could be heavily optimized for specifically searching handicapped seats
                //however, given the relative infrequency of such searches, i'm too lazy to do that right now

            //declare array lists that will be used for returning results
            ArrayList foundSeats = new ArrayList(numberOfSeats);

            //search for seats. 

            //iterate through whole bit array if necessary
            for (int i = 0; i < SeatAvailability.Count; i++)
            {
                //check current index

                //if that index is free and handi add it to the list of indexes and increment total number found
                if (!SeatAvailability[i] && SeatNumbers.handicappedSeats.Contains(SeatNumbers.seatNums[i]))
                {
                    //once one handicapped seat is found, make sure the next one is available also

                    //if both are available and handicapped, reserve them
                    if (SeatNumbers.handicappedSeats.Contains(SeatNumbers.seatNums[(i + 1)]))
                    {
                        //add both seats to the array list
                        foundSeats.Add((string)this.htBits2Seats[i]);
                        foundSeats.Add((string)this.htBits2Seats[(i + 1)]);
                        //break the loop
                        break;
                    }//end if
                }//end if

                //otherwise, if the current seat isn't available, clear placeholders and start over
                else
                {
                    //clear place holders
                    foundSeats.Clear();
                }//end else

                //clear the array list if we reach the end of the seats without reaching goal
                if (i == SeatAvailability.Count)
                {
                    //clear place holders
                    foundSeats.Clear();
                }//end if
            }//end for

            //if not all seats were found
            if (foundSeats.Count < numberOfSeats)
            {
                //clear the array list
                foundSeats.Clear();
            }//end if

            //return the array list containing the seats we found
            return convertToSeatObjects(foundSeats);
        }//end findSeats

        private ArrayList convertToSeatObjects(ArrayList foundSeats)
        {
            ArrayList actualSeats = new ArrayList(foundSeats.Count);

            for (int i = 0; i < foundSeats.Count; i++)
            {
                actualSeats.Add((Seat)this.HtSeats2Bits[(string)foundSeats[i]]);
            }//end for

            return actualSeats;
        }//end convert to seat objects
    }//end class
}//end namespace
