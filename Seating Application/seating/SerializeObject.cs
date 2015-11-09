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
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace seating
{
    public class SerializeObject
    {
        private string path;
        private object Obj;

        public object obj
        {
            get
            {
                return Obj;
            }
        }

        //constructor for writing
        public SerializeObject(string path, object obj)
        {
            this.path = path;
            this.Obj = obj;
        }//end constructor #1

        //constructor for reading
        public SerializeObject(string path)
        {
            this.path = path;
        }//end end constructor #2

        public string writeFile()
        {
            //create stream
            Stream stream = null;

            try
            {
                stream = new FileStream(path, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, obj);
                stream.Close();

                return "success";
            }//end try

            catch
            {
                    return "error";
            }//end catch

            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }//end finally
        }//end writeFile

        //to be called when using save instead of save as
        public string writeFile(bool overwrite)
        {
            //create stream
            Stream stream = null;

            try
            {
                stream = new FileStream(path, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, obj);
                stream.Close();

                return "success";
            }//end try

            catch
            {
                return "error";
            }
            // }//end catch

            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }//end finally
        }//end writeFile

        public bool readFile()
        {
            Stream stream = null;
            try
            {
                //Open the file and read values from it.
                stream = new FileStream(path, FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                bformatter = new BinaryFormatter();

                Obj = bformatter.Deserialize(stream);

                stream.Close();

                return true;
            }//end try

            catch
            {
                return false;
            }//end catch

            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }//end finally
        }//close readFile
    }//end class
}//end namespace