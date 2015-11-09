
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
    public class Ticket : ISerializable
    {
        //these are defined here so that can be easily changed without searching through code
        private static double StudentCost = 6;
        private static double AdultCost = 8;
        private static double SeniorCost = 7;
        private static double ParPassCost = 25;
        
        private string Type;
        private double Cost;

        //accessors
        #region

        public string type
        {
            set
            {
                this.Type = value;
            }

            get
            {
                return this.Type;
            }
        }//end Type

        public double cost
        {
            get
            {
                return Cost;
            }
        }//end Cost

        public static double studentCost
        {
            get
            {
                return StudentCost;
            }
        }

        public static double adultCost
        {
            get
            {
                return AdultCost;
            }
        }

        public static double seniorCost
        {
            get
            {
                return SeniorCost;
            }
        }

        public static double parPassCost
        {
            get
            {
                return ParPassCost;
            }
        }

        #endregion

        // default constructor
        public Ticket()
        {

        }//end default constructor

        //non-default constructor
        public Ticket(string type)
        {
            //set the type
            this.Type = type;

            //set the cost based on type
                if (type == "Adult")
                {
                    this.Cost = AdultCost;
                }//end if

                else if (type == "Student")
                {
                    this.Cost = StudentCost;
                }//end else if

                else if (type == "Senior")
                {
                    this.Cost = SeniorCost;
                }//end else if

                else if (type == "Parent Pass")
                {
                    this.Cost = ParPassCost;
                }//end else if

                else if (type == "Comp")
                {
                    this.Cost = 0;
                }//end else if
        }//end non-default constructpr

        //deserialization constructor.
        public Ticket(SerializationInfo info, StreamingContext ctxt)
        {
            //grab data from the serialization and assign it to local vars
            this.Type = (string)info.GetValue("tickType", typeof(string));
            Cost = (double)info.GetValue("price", typeof(double));
        }//end deserialization constructor

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //add objects
            info.AddValue("tickType", this.Type);
            info.AddValue("price", Cost);
        }//end GetObjectData
    }//end class
}//end namespace
