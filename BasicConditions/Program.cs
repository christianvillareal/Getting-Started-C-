using System;

namespace basicOperators
{
    class program
    {
        static void Main(string[] args)
        {
            // IF ELSE CONDITION
            static int ifElseCondition()
            {
                // return false or 1 since 30 is lesser than 40 not greater 
                if (30 > 40)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            // SWITCH STATEMENTS
            static string firstSwitch(string firstString)
            {
                switch (firstString)
                {
                    case "Apple":
                        Console.WriteLine("The value is APPLE");
                        Console.Read();
                        break;
                    case "Orange":
                        Console.WriteLine("The value is ORANGE");
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("None of the Above" + firstString);
                        Console.Read();
                        break;
                }

                return firstString;
            }

            // IF given value for firstSwitch("value") is not in case condition it will print the default
            Console.WriteLine(firstSwitch("Orange"));
            Console.WriteLine(ifElseCondition());

        }
    }
}