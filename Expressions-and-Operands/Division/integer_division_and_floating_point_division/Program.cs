using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integer_division_and_floating_point_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A.Integer division
            // 1) when both operands are sbyte/byte/short/ushort/int/uint/long/ulong
            int a = 16;
            int b = 4;
            int c = a / b;
            Console.WriteLine("Integer division 16/4 is quotient: {0}, here the remainder is 0", c);
            Console.WriteLine("Variable type is: {0}", c.GetType());

            int d = 17;
            int e = 4;
            int f = d / e;
            Console.WriteLine("Integer division 17/4 is quotient: {0}, even if the remainder is 1", f);
            Console.WriteLine("Variable type is: {0}", f.GetType());

            // 2) when an int (32-bit) is divided by a short (16-bit)
            int p = 16;
            short q = 4;
            Console.WriteLine("Integer division: int (32-bit) as 16/short (16-bit) as 4 is quotient: {0}, here the remainder is 0", p / q);
            Console.WriteLine("Variable type is: {0}", (p/q).GetType()); //int

            // 3) when a short (16-bit) is divided by an int (32-bit)
            short r = 16;
            int s = 4;
            Console.WriteLine("Integer division: short (32-bit) as 16/int (16-bit) as 4 is quotient: {0}, here the remainder is 0", r / s);
            Console.WriteLine("Variable type is: {0}", (r / s).GetType()); //int

            //B.Floating-Point division
            // 1) when both operands are float/double/decimal
            float g = 16.8F;
            float h = 4.1F;
            float i = g / h;
            Console.WriteLine("F-P division 16.8F/4.1F is: {0}", i);
            Console.WriteLine("Variable type is: {0}", i.GetType());

            double j = 16.8D;
            double k = 4.1D;
            double l = j / k;
            Console.WriteLine("F-P division 16.8D/4.1D is: {0}", l);
            Console.WriteLine("Variable type is: {0}", l.GetType());

            decimal m = 16.8M;
            decimal n = 4.1M;
            decimal o = m / n;
            Console.WriteLine("F-P division 16.8M/4.1M is: {0}", o);
            Console.WriteLine("Variable type is: {0}", o.GetType());

            // 2) when a double (64-bit) is divided by a float (32-bit)
            double t = 16.8D;
            float u = 4.1F;
            Console.WriteLine("F-P division: double (64-bit) as 16.8D/float (32-bit) as 4.1F is quotient: {0}", t / u);
            Console.WriteLine("Variable type is: {0}", (t / u).GetType()); //double

            // 3) when a float (32-bit) is divided by a double (32-bit)
            float v = 16.8F;
            double w = 4.1D;
            Console.WriteLine("F-P division: float (32-bit) as 16.8F/double (64-bit) as 4.1D is quotient: {0}", v / w);
            Console.WriteLine("Variable type is: {0}", (v / w).GetType()); //double

            //C. Mixed division
            // 1) when a float (32-bit) is divided by a short (16-bit)
            float x = 16.8F;
            short y = 4;
            Console.WriteLine("F-P division: float (32-bit) as 16.8F/short (16-bit) as 4 is quotient: {0}", x / y);
            Console.WriteLine("Variable type is: {0}", (x / y).GetType()); //float

            // 2) when a short (16-bit) is divided by a float (32-bit)
            short z1 = 16;
            float z2 = 4.1F;
            Console.WriteLine("F-P division: short (16-bit) as 16/float (32-bit) as 4.1F is quotient: {0}", z1 / z2);
            Console.WriteLine("Variable type is: {0}", (z1 / z2).GetType()); //float

            Console.WriteLine(16%4);
            Console.WriteLine((16%4).GetType());

            Console.WriteLine(5.2F % 2.0F);
            Console.WriteLine((5.2F % 2.0F).GetType());
        }
    }
}
