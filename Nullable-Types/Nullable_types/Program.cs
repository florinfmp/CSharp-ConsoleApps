using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null;
            Console.WriteLine("Var age of type int with value null is: " + age);

            age = 5;
            Console.WriteLine("Var age of type int with value 5 is: " + age);

        }
    }
}
