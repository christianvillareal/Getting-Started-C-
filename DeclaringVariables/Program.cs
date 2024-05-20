using System;

namespace declaringVariables
{
    class program
    {
        static void Main(string[] args)
        {
            // declaring variables
            // NOTE: short is a 16-bit signed integer type in C# with a range of -32,768 to 32,767, while sbyte is an 8-bit signed integer type with a range of -128 to 127.
            // NOTEL if you want to check min and max value per variable print in console "Console.WriteLine(int.MinValue);"
            sbyte s = 120; // sbyte = shortbyte whole number from -129 to 127
            short x = 3000; // short = whole number from -32767 to 32767
            int number = 0; // int = whole number from 2147483648 to 2147483647
            long y = 0;
            float x2 = 6.61f; // if float it should have f at the last just to tell ide that it is a float. because sometimes it will define as double. 
            double y2 = 9.99; // declaring double
            decimal dd = 1.5m; // if decimat it should have m at the last just to tell ide that it is decimal. 

            bool Switch = true; // boolean could be true or a false
            char singleCharacter = 'A'; // char variable could be single character only
            string username = "chanmille"; // string should use doulble quote " 


            Console.WriteLine("To Know Minimum Value " + sbyte.MinValue);
            Console.WriteLine("To Know Maximum Value " + short.MaxValue);
            Console.Read(); // porpuse to remove warning on console
        }
    }
}