using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "CSharp is the best";
            Console.WriteLine("My string is {0}\n", myString);

            string firstName = "Bruce";
            string lastName = "Willis";
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Hello, {0}!\n", firstName);
            Console.WriteLine("Full name is {0}",fullName);
        }
    }
}
