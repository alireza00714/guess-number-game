using System;
using System.Diagnostics;
using System.Threading;

namespace Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(0, 100);
            int counter = 0;
            int limit = 0;

            Console.WriteLine("1) Easy");
            Console.WriteLine("2) Medium");
            Console.WriteLine("3) Hard");
            Console.WriteLine("4) Exit");

            int menuInput = Convert.ToInt32(Console.ReadLine());

            switch (menuInput)
            {
                case 1:
                    limit = 10;
                    break;
                case 2:
                    limit = 5;
                    break;
                case 3:
                    limit = 3;
                    break;
                case 4:
                    return;
            }

            while (limit != counter)
            {
                Console.Clear();
                Console.Write("Please Guess The Number: ");
                int enteredNumber = Convert.ToInt32(Console.ReadLine());

                if (enteredNumber > randomNumber)
                {
                    Console.WriteLine("Entered number is higher than actual number");
                    Console.ReadKey();
                }
                else if (enteredNumber < randomNumber)
                {
                    Console.WriteLine("Entered number is lower than actual number");
                    Console.ReadKey();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("YOU WIN :)");
                    return;
                }

                counter++;
            }

            if(limit == counter)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine("YOU LOSE :(");
                return;
            }
        }
    }
}
