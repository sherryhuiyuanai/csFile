using System;
using System.Linq;
using System.Collections.Generic;

/* Given an array as the items of a checkbox = [A, B, C, D, E, F, G], write a function that passes in this array and return a result,
    which stands for each possibility of the user choice. The choice is just not allowed to contain repeated item. The choice items can be multiple */

namespace Checkbox
{
    class Program
    {
        public static int Main()
        {
            string[] checkbox = {"A", "B", "C", "D", "E", "F", "G"};
            string[] result = new string[checkbox.Length];
            Random ran = new Random();
            for (int n = 0; n < checkbox.Length; n++)
            {
                int temp = ran.Next(0, 2);
                result[n] = temp == 0? "": checkbox[n];
                Console.WriteLine(result[n]);
            }
            result = result.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            for ( int n = 0; n < result.Length; n++) {
                Console.WriteLine(result[n]);
            }
            return 0;
        }
    }
}