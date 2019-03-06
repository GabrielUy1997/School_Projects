using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Time2_6
    {
        private uint time;
        public Time2_6() { time = 0; }

        public uint Hour
        {
            get
            {
                return time / 3600;
            }
            set
            {
                if (value > 23)
                {
                    throw new Exception("Invalid Hour");
                }
                time = value * 3600 + Minutes * 60 + Seconds;

            }
        }
        public uint Minutes
        {
            get
            {
                return time % 3600 / 60;
            }
            set
            {
                if (value > 59)
                {
                    throw new Exception("Invalid Minutes");
                }
                time = Hour * 3600 + value * 60 + Seconds;

            }
        }
        public uint Seconds
        {
            get
            {
                return time % 60;
            }
            set
            {
                if (value > 59)
                {
                    throw new Exception("Invalid Seconds");
                }
                time = Hour * 3600 + Minutes * 60 + value;
            }
        }

        public string ToUniversalString()
        {
            return String.Format(
               "{0:D2}:{1:D2}:{2:D2}", Hour, Minutes, Seconds);
        }
        public string ToStandardString()
        {
            return String.Format("{0}:{1:D2}:{2:D2} {3}",
               ((Hour == 12 || Hour == 0) ? 12 : Hour % 12),
               Minutes, Seconds, (Hour < 12 ? "AM" : "PM"));
        }
    }
}
