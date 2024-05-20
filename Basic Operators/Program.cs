using System;

namespace basicOperators
{
    class program
    {
        static void Main(string[] args)
        {
            // MULTIPLY
            static int MyMultiply()
            {
                int num1 = 50;
                int num2 = 60;

                int total = num1 * num2;

                return total;
            }

            // ADDITION
            static int MyAddition()
            {
                int num1 = 50;
                int num2 = 60;

                int total = num1 + num2;

                return total;
            }


            // DIVISION
            static int MyDivision()
            {
                int num1 = 50;
                int num2 = 60;

                int total = num1 / num2;

                return total;
            }

            // SUBTRACT
            static int MySubtract()
            {
                int num1 = 50;
                int num2 = 60;

                int total = num1 - num2;

                return total;
            }

            Console.WriteLine("Multiply:" + MyMultiply());
            Console.WriteLine("Addition:" + MyAddition());
            Console.WriteLine("Division:" + MyDivision());
            Console.WriteLine("Subtraction:" + MySubtract());

            /*
            static int CustomMethod()
            {
               // this is Method 
            }
            */

            // CustomMethod(); call method

        }
    }
}