using System;

namespace Loops
{
    class Loop{
        public static void IterativeStatement(){
            int counter = 0;
            while (counter < 10)
            {
              Console.WriteLine($"Hello World! The counter is {counter}");
              counter++;
            }

            //do .. while
            Console.WriteLine("do... while()\n");
            counter = 0;
            do
            {
              Console.WriteLine($"Hello World! The counter is {counter}");
              counter++;
            } while (counter < 10);


            //for loops
            Console.WriteLine("\nfor loop: ");
            for(int c = 0; c < 10; c++)
            {
              Console.WriteLine($"Hello World! The counter is {c}");
            }

            //nested for loop
            Console.WriteLine("\nnested for loop:\n");
            for (int row = 1; row < 11; row++)
            {
              for (char column = 'a'; column < 'k'; column++)
               {
                 Console.WriteLine($"The cell is ({row}, {column})\n");
                }
            }

            //combining branches and loops
            Console.WriteLine("\nCombining branches with loops:\n");
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
             if (number % 3 == 0)
              {
                sum = sum + number;
              }
              }
               Console.WriteLine($"The sum is {sum}");
        }
    }
}