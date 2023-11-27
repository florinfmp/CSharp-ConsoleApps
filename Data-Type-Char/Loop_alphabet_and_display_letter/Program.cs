using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_alphabet_and_display_letter
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            for (char myChar = 'a'; myChar <= 'z'; myChar++)
            {
                Console.WriteLine(myChar);
            }
        }*/

        /*static void Main(string[] args)
        {
            for (char myChar = 'A'; myChar <= 'Z'; myChar++)
            {
                Console.WriteLine(myChar);
            }
        }*/

        //Loop through integers and convert them to letters - letters start at A=65 decimal ...Z=90 decimal; a=97 decimal ... z=122 decimal
        /*static void Main(string[] args)
        {
            for (int myChar = 65; myChar <= 90; myChar++)
            {
                Console.WriteLine((char)myChar);
            }
        }*/

        static void Main(string[] args)
        {
            for (int myChar = 65; myChar <= 90; myChar++)
            {
                Console.WriteLine((char)myChar);
            }
        }
    }
}
