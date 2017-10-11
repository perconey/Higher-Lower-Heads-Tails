using LIST___2___HigherLower_HeadsTails.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIST___2___HigherLower_HeadsTails
{

    /// <summary>
    /// Second program from my challenge list - it very simply gives you a chance to play
    /// two console games:
    /// 1.Higher or lower number guess
    /// 2.Heads and tails
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            do
            {
                Console.WriteLine("Which game do you want to play\n" +
                    "1. Higher/Lower\n" +
                    "2. Heads/Tails");

                option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        bool success;
                        int guess;
                        HiLow game = new HiLow();
                        do
                        {
                            Console.WriteLine("You chose Higher/Lower!\n" +
                                "Guess a number(0 - 9999):");
                            guess = Convert.ToInt16(Console.ReadLine());
                            success = game.CheckGuess(guess);
                        } while (!success);

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        HeadsOrTails game1 = new HeadsOrTails();
                        do
                        {
                            Console.WriteLine("You chose Heads/Tails!\n" +
                                    "Heads(0) or tails(1):");

                            guess = Convert.ToInt16(Console.ReadLine());
                            success = game1.CheckIfGuessed(guess);
                        } while (!success);

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();

                        break;


                }
            } while (true);

        }
    }
}
