/*Zachary Miller
 * 12/11/2017
 * assignment 6.2
 * The purpose of this program is to create the class and sub classes for tape. It also has a ToString modifier in each class and subclass.
 * Tape.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._2
{
    class Tape
    {

        public Tape(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int Length { get; set; }
        public int Width { get; set; }

        public override string ToString()
        {
            return String.Format("{0}\nLength: {1}\nWdith: {2}",GetType(),Length,Width);
        }
    }

    class AdhesiveTape : Tape
    {
        int StickyRating;
        public AdhesiveTape(int length, int width, int stickiness)
            :base(length, width)
        {
            StickyRating = stickiness;
        }

        public int Stickiness
        {
            get
            {
                return StickyRating;
            }
            set
            {
                if (value >= 1 && value <= 10)
                    StickyRating = value;
                else
                    StickyRating = 0;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}\nStickiness Rating: {1}",base.ToString(),(StickyRating == 0)?"Invalid":Stickiness.ToString());
        }
    }

    class VideoTape:Tape
    {
        public int Time { get; set; }
        public VideoTape(int length, int width, int time)
            :base(length,width)
        {
            if (time >= 1 && time <= 180)
                Time = time;
            else
                Time = 0;
        }

        public override string ToString()
        {
            return String.Format("{0}\nTime: {1}",base.ToString(),(Time==0)?"Invalid":Time.ToString());
        }
    }


}
