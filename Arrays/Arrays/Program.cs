using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arrayOfInt = { 1, 2, 3, 4, 5 };


            string[] arrayOfString = new string[10];
        }

        static int ReadNumber(string label, int defaultValue)
        {
            Console.Write(label + "=");
            string value = Console.ReadLine();
            
            int result;
            if (int.TryParse(value, out result))
            {
                // parsing succeeded => return parsed result
                return result;
            }

            // parsing failed => return defaultValue
            return defaultValue;
        }
    }
}
