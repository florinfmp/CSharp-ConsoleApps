using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type_Floating_Point_all_variations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myPosFloat = 330000000000000000009F;
            Console.WriteLine("Positive float is {0}", myPosFloat);

            float myNegFloat = -0.000000000000000000014F;
            Console.WriteLine("Negative float is {0}", myNegFloat);

            double myPosDouble = 49000000000000000000000000000000000000000D;
            Console.WriteLine("Positive double is {0}", myPosDouble);

            double myNegDouble = -0.00000000000000000000000000000000000000016D;
            Console.WriteLine("Negative double is {0}", myNegDouble);

            decimal myPosDecimal = 78000000000000000000000000M;
            Console.WriteLine("Positive decimal is {0}", myPosDecimal);

            decimal myNegDecimal = -0.000000000000000000000000001M;
            Console.WriteLine("Negative decimal is {0}", myNegDecimal);
        }
    }
}
