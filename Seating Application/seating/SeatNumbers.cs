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
using System.Collections;

namespace seating
{
    [Serializable()]

    public class SeatNumbers : ISerializable
    {
        private static string[] SeatNums;
        private static ArrayList HandicappedSeats;

        public static string[] seatNums
        {
            get
            {
                return SeatNums;
            }
        }

        public static ArrayList handicappedSeats
        {
            get
            {
                return HandicappedSeats;
            }
        }

        public SeatNumbers()
        {
            SeatNums = new string[] { "A201", "A202", "A203", "A204", "A205", "A206", "A207", "A208", "A209", "B201", "B202", "B203", "B204", "B205", "B206", "B207", "B208", "B209", "C201", "C202", "C203", "C204", "C205", "C206", "C207", "C208", "C209", "C210", "D201", "D202", "D203", "D204", "D205", "D206", "D207", "D208", "D209", "D210", "D211", "E201", "E202", "E203", "E204", "E205", "E206", "E207", "E208", "E209", "E210", "E211", "A301", "A302", "A303", "A304", "A305", "A306", "A307", "A308", "B301", "B302", "B303", "B304", "B305", "B306", "B307", "B308", "B309", "C301", "C302", "C303", "C304", "C305", "C306", "C307", "C308", "C309", "D301", "D302", "D303", "D304", "D305", "D306", "D307", "D308", "D309", "A101", "A102", "A103", "A104", "A105", "A106", "A107", "A108", "B101", "B102", "B103", "B104", "B105", "B106", "B107", "B108", "B109", "C101", "C102", "C103", "C104", "C105", "C106", "C107", "C108", "C109", "D101", "D102", "D103", "D104", "D105", "D106", "D107", "D108", "D109", "F201", "F202", "F203", "F204", "F205", "F206", "F207", "F208", "F209", "F210", "F211", "G201", "G202", "G203", "G204", "G205", "G206", "G207", "G208", "G209", "G210", "G211", "H201", "H202", "H203", "H204", "H205", "H206", "H207", "H208", "H209", "H210", "H211", "H212", "J201", "J202", "J203", "J204", "J205", "J206", "J207", "J208", "J209", "J210", "J211", "J212", "E301", "E302", "E303", "E304", "E305", "E306", "E307", "E308", "E309", "F301", "F302", "F303", "F304", "F305", "F306", "F307", "F308", "F309", "F310", "G301", "G302", "G303", "G304", "G305", "G306", "G307", "G308", "G309", "G310", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109", "F101", "F102", "F103", "F104", "F105", "F106", "F107", "F108", "F109", "F110", "G101", "G102", "G103", "G104", "G105", "G106", "G107", "G108", "G109", "G110", "K201", "K202", "K203", "K204", "K205", "K206", "K207", "K208", "K209", "K210", "K211", "K212", "K213", "L201", "L202", "L203", "L204", "L205", "L206", "L207", "L208", "L209", "L210", "L211", "L212", "L213", "M201", "M202", "M203", "M204", "M205", "M206", "M207", "M208", "M209", "M210", "M211", "M212", "M213", "M214", "H301", "H302", "H303", "H304", "H305", "H306", "H307", "H308", "H309", "H310", "J301", "J302", "J303", "J304", "J305", "J306", "J307", "J308", "J309", "J310", "J311", "K301", "K302", "K303", "K304", "K305", "K306", "K307", "K308", "K309", "K310", "K311", "H101", "H102", "H103", "H104", "H105", "H106", "H107", "H108", "H109", "H110", "J101", "J102", "J103", "J104", "J105", "J106", "J107", "J108", "J109", "J110", "J111", "K101", "K102", "K103", "K104", "K105", "K106", "K107", "K108", "K109", "K110", "K111", "L301", "L302", "L303", "L304", "L305", "L306", "L307", "L308", "L309", "L310", "L311", "M301", "M302", "M303", "M304", "M305", "M306", "M307", "M308", "M309", "M310", "M311", "L101", "L102", "L103", "L104", "L105", "L106", "L107", "L108", "L109", "L110", "L111", "M101", "M102", "M103", "M104", "M105", "M106", "M107", "M108", "M109", "M110", "M111", "N201", "N202", "N203", "N204", "N205", "N206", "N207", "N208", "N209", "N210", "N211", "N212", "N213", "N214", "P201", "P202", "P203", "P204", "P205", "P206", "P207", "P208", "P209", "P210", "P211", "P212", "P213", "P214", "Q201", "Q202", "Q203", "Q204", "Q205", "Q206", "Q207", "Q208", "Q209", "Q210", "Q211", "Q212", "Q213", "Q214", "R201", "R202", "R203", "R204", "R205", "R206", "R207", "R208", "R209", "R210", "R211", "R212", "R213", "R214", "S201", "S202", "S203", "S204", "S205", "S206", "S207", "S208", "S209", "S210", "S211", "S212", "S213", "S214", "T201", "T202", "T203", "T204", "T210", "T211", "T212", "T213", "N301", "N302", "N303", "N304", "N305", "N306", "N307", "N308", "N309", "N310", "N311", "P301", "P302", "P303", "P304", "P305", "P306", "P307", "P308", "P309", "P310", "P311", "Q301", "Q302", "Q303", "Q304", "Q305", "Q306", "Q307", "Q308", "Q309", "Q310", "Q311", "R301", "R302", "R303", "R304", "R305", "R306", "R307", "R308", "R309", "R310", "R311", "N101", "N102", "N103", "N104", "N105", "N106", "N107", "N108", "N109", "N110", "N111", "P101", "P102", "P103", "P104", "P105", "P106", "P107", "P108", "P109", "P110", "P111", "Q101", "Q102", "Q103", "Q104", "Q105", "Q106", "Q107", "Q108", "Q109", "Q110", "Q111", "R101", "R102", "R103", "R104", "R105", "R106", "R107", "R108", "R109", "R110", "R111", "S301", "S302", "S303", "S304", "S305", "S306", "S307", "S308", "S309", "S310", "S311", "T301", "T302", "T303", "T304", "T305", "T306", "T307", "T308", "T309", "T310", "T311", "U301", "U302", "U303", "U304", "U305", "U306", "U307", "U308", "U309", "U310", "U311", "V301", "V302", "V303", "V304", "V305", "V306", "V307", "V308", "V309", "V310", "V311", "S101", "S102", "S103", "S104", "S105", "S106", "S107", "S108", "S109", "S110", "S111", "T101", "T102", "T103", "T104", "T105", "T106", "T107", "T108", "T109", "T110", "T111", "U101", "U102", "U103", "U104", "U105", "U106", "U107", "U108", "U109", "U110", "U111", "V101", "V102", "V103", "V104", "V105", "V106", "V107", "V108", "V109", "V110", "V111", "W301", "W302", "W303", "W304", "W305", "W306", "W103", "W104", "W105", "W106", "W107", "W108", "W307", "W308", "W101", "W102" };
            HandicappedSeats = new ArrayList();

            //create array with seat numbers
            string[] handiSeats = {"A201", "A202", "A208", "A209", "V110", "V111", "W101", "W102", "V301", "V302", "W307", "W308" };

            for (int i = 0; i < handiSeats.Length; i++)
            {
                HandicappedSeats.Add(handiSeats[i]);
            }//end for
            

        }//end default constructor

        //deserialization constructor.
        public SeatNumbers(SerializationInfo info, StreamingContext ctxt)
        {
            //grab data from the serialization and assign it to local vars
            SeatNums = (string[])info.GetValue("seatsArray", typeof(string[]));
            HandicappedSeats = (ArrayList)info.GetValue("handicappedArray", typeof(ArrayList));
        }//end deserialization constructor

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            //add objects
            info.AddValue("seatsArray", SeatNums);
            info.AddValue("handicappedArray", HandicappedSeats);
        }//end GetObjectData
    }//end class
}//end "namespace
