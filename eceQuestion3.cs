using System;
using System.Collections.Generic;
using System.Linq;

namespace SortMachine
{
    class Program
    {
        public static void Main()
        {
            List<char> dictionary = new List<char>(){
                ' ','-',
                'a','A','b','B','c','C','d','D','e','E','f','F','g','G',
                'h','H','i','I','j','J','k','K','l','L','m','M','n','N',
                'o','O','p','P','q','Q','r','R','s','S','t','T','u','U',
                'v','V','w','W','x','X','y','Y','z','Z'
            };
            Console.WriteLine(dictionary[2]);
            Console.ReadLine();
            // public int compare(const char str1[], const char str2[])
            // {
            //     int 
            //     if ()
            //     {
            //         //str1-->str2
            //         return -1;
            //     }
            //     else if ()
            //     {
            //         //same
            //         return 0;
            //     }
            //     else
            //     {
            //         //str2-->str1
            //         return 1;
            //     }
            // }


            // public int isSorted(const char* const names[])
            // {

            // }

            // private enum SortType { START, ASCENDING, DESCENDING, UNKNOWN, UNSORTED, DONE };


            return 0;
        }
}
}