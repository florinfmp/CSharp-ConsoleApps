using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte myPosSByte = 126;
            Console.WriteLine("Positive sbyte is {0}", myPosSByte);

            sbyte myNegSByte = -126;
            Console.WriteLine("Negative sbyte is {0}", myNegSByte);

            byte myByte = 250;
            Console.WriteLine("My byte is {0}", myByte);

            short myPosShort = 32700;
            Console.WriteLine("Positive short is {0}", myPosShort);

            short myNegShort = -32700;
            Console.WriteLine("Negative short is {0}", myNegShort);

            ushort myUShort = 65500;
            Console.WriteLine("My ushort is {0}", myUShort);

            int myPosInt = 2147000000;
            Console.WriteLine("Positive int is {0}", myPosInt);

            int myNegInt = -2147000000;
            Console.WriteLine("Negative int is {0}", myNegInt);

            uint myUInt = 4294000000;
            Console.WriteLine("My uint is {0}", myUInt);

            long myPosLong = 9223000000000000000;
            Console.WriteLine("Positive long is {0}", myPosLong);

            long myNegLong = -9223000000000000000;
            Console.WriteLine("Negative long is {0}", myNegLong);

            ulong myULong = 18446000000000000000;
            Console.WriteLine("My ulong is {0}", myULong);
        }
    }
}
