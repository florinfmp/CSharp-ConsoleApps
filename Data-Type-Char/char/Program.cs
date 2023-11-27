using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @char
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            char myChar = 'A';
            Console.WriteLine("Character {0} as literal", myChar); //Character A as literal   
        }*/

        /*static void Main(string[] args)
        {
            char myChar1 = '\x0041';
            Console.WriteLine("Character {0} as hexadecimal", myChar1); //Character A as hexadecimal
        }*/

        /*static void Main(string[] args)
        {
            char myChar2 = (char)65;
            Console.WriteLine("Character {0} as integer type", myChar2); //Character A as integer type
        }*/

        static void Main(string[] args)
        {
            char myChar3 = '\u0041';
            Console.WriteLine("Character {0} as unicode", myChar3); //Character A as unicode
        }
    }
}
