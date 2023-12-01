using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printing_Reading_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //WriteLine
            /*Console.WriteLine("my first text");
            Console.WriteLine("my second text");*/

            //Write
            /*Console.Write("this ");
            Console.Write("is ");
            Console.Write("another ");
            Console.Write("text ");*/

            //ReadLine
            /*Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("User name is: " + name);*/

            /*Console.WriteLine("Enter your age:");
            short age = short.Parse(Console.ReadLine());
            Console.WriteLine("User age is: " + age);*/

            /*Console.WriteLine("Enter your age:");
            short age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("User age is: " + age);*/

            //Read
            int x;
            Console.WriteLine("Enter a Character from keyboard to get its char Decimal number");
            x = Console.Read();
            Console.WriteLine("The char Decimal number is: " + x);

        }
    }
}
