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
            int nrOfElements = ReadNumber("Array size", 0);

            int[] arrayOfInt = new int[nrOfElements];

            for (int i = 0; i  < nrOfElements; i++)
            {
                int element = ReadNumber("Element at index " + i, 0);

                arrayOfInt[i] = element;
            }

            Console.WriteLine("First element=" + arrayOfInt[0]);
            Console.WriteLine("Last element=" + arrayOfInt[arrayOfInt.Length - 1]);
           
            int medianIndex = (0 + arrayOfInt.Length - 1) / 2;
            if (medianIndex >= 0 && medianIndex < arrayOfInt.Length)
            {
                Console.WriteLine("Median element=" + arrayOfInt[medianIndex]);
            }
            else
            {
                Console.WriteLine("Cannot calculate median element");
            }

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
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
