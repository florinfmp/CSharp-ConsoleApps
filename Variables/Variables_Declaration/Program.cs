using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Declaration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            sbyte mySByte;
            byte myByte;
            short myShort;
            ushort myUShort;
            int myInt;
            uint myUint;
            long myLong;
            ulong myULong;
            float myFloat;
            double myDouble;
            decimal myDecimal;
            bool myBool;
            char myChar;
            string myString;
            object myObject;

            //Initializing variables
            // -1- By using the new keyword
            mySByte = new sbyte(); //initializes the variable with the default value for this data-type, which is 0 here
            // -2- By using a literal expression
            myString = "Welcome to paradise.";
            // -3- By referring to an already initialized variable
            myInt = 2000000000;
            int myInt2;
            myInt2 = myInt;

            Console.WriteLine("var mySByte is {0}", mySByte);
            Console.WriteLine("var myString is {0}", myString);
            Console.WriteLine("var myInt2 is {0}", myInt2);

            //Declaring and initializing at the same time
            sbyte mySByte2 = new sbyte();
            string myString2 = "Another day is here.";
            int myInt3 = myInt2;

            Console.WriteLine("var mySByte2 is {0}", mySByte2);
            Console.WriteLine("var myString2 is {0}", myString2);
            Console.WriteLine("var myInt3 is {0}", myInt3);

            //Assigning values
            // -1- assign value directly
            int height = 200;
            // -2- assign value using an already initialized variable
            int first = 5;
            int second;
            second = first;
            // -3- assign values in cascade calling, when assigning is done from right to left
            int primary;
            int secondary;
            int tertiary;
            primary = secondary = tertiary = 10;

            Console.WriteLine("var height is {0}", height);
            Console.WriteLine("var second is {0}", second);
            Console.WriteLine("var tertiary is {0}", tertiary);
            Console.WriteLine("var secondary is {0}", secondary);
            Console.WriteLine("var primary is {0}", primary);

        }
    }
}
