using System;

namespace basicLooping
{
    class program
    {
        static void Main(string[] args)
        {
           // WHILE LOOP
           static void firstWhileLoop()
            {
                // NOTE: <= if less than and equal to 10 it will stop the loop
                int i = 0;
                while (i <= 10)
                {
                    Console.WriteLine("WHILE LOOP: " + i);
                    i++;
                }
            }

            // DO WHILE LOOP
            static void firstDoWhile()
            {
                int i = 1;
                do
                {
                    Console.WriteLine("DO WHILE LOOP: " + i);
                    i++;
                } while (i <= 10);
            }

            //** NOTE: WHILE CONDITION FIRST BEFORE EXECUTE WHITE DO WHILE EXECUTE FIRST BEFORE MAKING CONDITION **//

            // FOR LOOP
            static void firstForLoop()
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("FOR LOOP:" + i);
                }
            }

            // FOR LOOP WITH ARRAY
            static void loopCarBrands()
            {
                string[] Cars = { "HONDA", "Yamaha" , "HYUNDAI", "TOYOTA" };
                for (int i = 0; i < Cars.Length; i++)
                {
                    //Cars.Length = count how many value under cars array
                    Console.WriteLine("Car Brands For LOOP:" + Cars[i]);
                }
            }

            firstWhileLoop();
            firstDoWhile();
            firstForLoop();
            loopCarBrands();
        }
    }
}