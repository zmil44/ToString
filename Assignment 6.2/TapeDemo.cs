/*Zachary Miller
 * 12/11/2017
 * assignment 6.2
 * The purpose of this program is to create instances of the tape class and the subclasses VideoTape and AdhesiveTape
 * GirlScout.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._2
{
    class TapeDemo
    {
        static void Main(string[] args)
        {
            Tape tape = new Tape(50, 10);
            VideoTape videoTape = new VideoTape(60, 6, 150);
            AdhesiveTape adhesiveTape = new AdhesiveTape(20, 9, 5);

            Console.WriteLine(tape);
            Console.WriteLine(videoTape);
            Console.WriteLine(adhesiveTape);

            Console.ReadLine();
        }
    }
}
