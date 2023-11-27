using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Type_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object myObject = 50;
            Console.WriteLine("My obj with 50 inside is: {0}", myObject);
            Console.WriteLine("Type is {0}", myObject.GetType());

            object myObject1 = -9223000000000000000;
            Console.WriteLine("My obj with -9223000000000000000 inside is: {0}", myObject1);
            Console.WriteLine("Type is {0}", myObject1.GetType());

            object myObject2 = 3.141592653589793238D;
            Console.WriteLine("My obj with 3.141592653589793238D inside is: {0}", myObject2);
            Console.WriteLine("Type is {0}", myObject2.GetType());

            object myObject3 = true;
            Console.WriteLine("My obj with true inside is: {0}", myObject3);
            Console.WriteLine("Type is {0}", myObject3.GetType());

            object myObject4 = 'A';
            Console.WriteLine("My obj with A inside is: {0}", myObject4);
            Console.WriteLine("Type is {0}", myObject4.GetType());

            object myObject5 = "Another day in paradise.";
            Console.WriteLine("My obj with Another day in paradise. inside is: {0}", myObject5);
            Console.WriteLine("Type is {0}", myObject5.GetType());

            object myObject6 = "Just another object with a string.";
            object myObject7 = myObject6;
            Console.WriteLine("My obj with another object inside is: {0}", myObject7);
            Console.WriteLine("Type is {0}", myObject7.GetType());
        }
    }
}
