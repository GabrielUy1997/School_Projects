using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Time2_6 t = new Time2_6();  // calls Time1 constructor
            string output;

            // assign string representation of time to output
            output = "Initial universal time is: " +
               t.ToUniversalString() +
               "\nInitial standard time is: " +
               t.ToStandardString();

            // attempt valid time settings
            t.Hour = 13;
            t.Minutes = 27;
            t.Seconds = 6;

            // append new string representations of time to output
            output += "\n\nUniversal time after SetTime is: " +
               t.ToUniversalString() +
               "\nStandard time after SetTime is: " +
               t.ToStandardString();

            // attempt invalid time settings
            t.Hour = 99;
            t.Minutes = 99;
            t.Seconds = 99;

            output += "\n\nAfter attempting invalid settings: " +
               "\nUniversal time: " + t.ToUniversalString() +
               "\nStandard time: " + t.ToStandardString();

            // MessageBox.Show(output, "Testing Class Time1");
        }
    }
}
