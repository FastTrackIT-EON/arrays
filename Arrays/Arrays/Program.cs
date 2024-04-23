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
            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 2, 3},
                new int[] { 4, 5 },
                new int[] { 4, 5 }
            };

            object[] arrayOfObjects = new object[] { 1, "test", DateTime.Now };
            if (arrayOfObjects[0] is int convertedInt)
            {
                //int intObj = (int)arrayOfObjects[0];
                Console.WriteLine(convertedInt);
            }

            string strObj = arrayOfObjects[1] as string;


            // A = [1, 2, 3]
            // B = [4, 5]
            // A x B = [ (1, 4), (1, 5), (2, 4) .... ]

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }

        static bool ShouldContinue(int[] array)
        {
            return true;
        }

        public void PrintIsPrime(int n)
        {
            bool isPrime = false;

            for (int i = 2; i < n; i++)
            {
                if ((i != n) && (n % i == 0))
                {
                    // i is a divisor of N => N is not prime
                    isPrime = false;
                    break;
                }
            }

            bool stopAll = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    stopAll = true;
                    break;
                }

                if (stopAll)
                {
                    break;
                }
            }
        }

        public void PrintAllEvenNumbers(int n)
        {
            for (int i = 0; i < n; i++)
            {
                bool isEven = i % 2 == 0;
                if (!isEven)
                {
                    continue;
                }

                Console.WriteLine(i + " is even.");
            }
        }

        static void Examples_with_matrix()
        {
            int noOfRows = ReadNumber("Number of rows", 0);
            int noOfCols = ReadNumber("Number of cols", 0);

            int[,] matrix = new int[noOfRows, noOfCols];
            for (int i = 0; i < noOfRows; i++)
            {
                for (int j = 0; j < noOfCols; j++)
                {
                    int elem = ReadNumber("Element at [" + i + "," + j + "]", 0);
                    matrix[i, j] = elem;
                }
            }


            // 1   2   3
            // 4   5   6
            Console.WriteLine("------");
            for (int i = 0; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); i++)
            {
                Console.WriteLine(matrix[i, i]);
            }
        }

        static void Examples_with_unidimensional_arrays()
        {
            int nrOfElements = ReadNumber("Array size", 0);

            int[] arrayOfInt = new int[nrOfElements];

            for (int i = 0; i < arrayOfInt.Length; i++)
            {
                int element = ReadNumber("Element at index " + i, 0);

                arrayOfInt[i] = element;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array">DO NOT PASS NULLs!</param>
        static void PrintArrayProperties(int[] array)
        {
            if (array == null)
            {
                Console.WriteLine("Cannot display properties for null array");
                return;
            }

            if (array.Length == 0)
            {
                Console.WriteLine("Cannot display properties for empty array");
                return;
            }

            Console.WriteLine("First element=" + array[0]);
            Console.WriteLine("Last element=" + array[array.Length - 1]);

            int medianIndex = (0 + array.Length - 1) / 2;
            Console.WriteLine("Median element=" + array[medianIndex]);
        }

        static void PrintElementAtIndex(int[] array, int index)
        {
            int arrayLength = array?.Length ?? 0;
            if (arrayLength == 0)
            {
                // do stuff
            }

            if (array == null)
            {
                Console.WriteLine("Cannot print element at index from a null array");
                return;
            }

            if (array.Length == 0)
            {
                Console.WriteLine("Cannot print element at index from an empty array");
                return;
            }

            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Index must be between 0 and " + (array.Length - 1));
                return;
            }

            Console.WriteLine("Element at index " + index + "=" + array[index]);
        }

        static int ReadNumber(string label, int defaultValue)
        {
            string safeLabel = label ?? "Value";

            Console.Write(safeLabel + "=");
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
