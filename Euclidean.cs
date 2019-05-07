                        /* This is the computer programming for Euclidean Algorithm 
                         in order to figure out the highest common factor for two values */
using System;
using System.Collections.Generic;

namespace Euclidean
{
    class Program
    {
        public static int Main()
        {
            Console.WriteLine("Please type in the first value: ");
            int val1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type in the second value: ");
            int val2 = int.Parse(Console.ReadLine());
            int factor = Algorithm(val1, val2);
            Console.WriteLine("The highest common factor for " 
                                + val1 + " & " + val2 + " is " + factor);
            return 0;
        }
        public static int Algorithm(int value1, int value2)
        {
            int dividend = (value1 > value2)? value1: value2;
            int divisor = (value1 == dividend)? value2: value1;
            int remainder = 1; int temp = 1;
            while(remainder != 0){
                remainder = dividend % divisor;
                temp = (remainder == 0)? temp: remainder;
                dividend = divisor;
                divisor = remainder;
            }
            return temp;
        }
    }
}