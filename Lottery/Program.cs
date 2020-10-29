using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            int match = 0;
            bool exactmatch = false;
            int award = 0;

            //random number generation
            var rn = new Random();
            var value = Enumerable.Range(1, 4).OrderBy(x => rn.Next()).ToArray();
            int firstrandom = value[1];
            int secondrandom = value[2];
            int thirdrandom = value[3];

            //introduction to game, user explanation 
            Console.WriteLine("!Welcome to Dad's Lottery!");
            Console.WriteLine();
            Console.WriteLine("Here's how to play:");
            Console.WriteLine("You guess 3 random numbers & our program generates 3 random numbers.");
            Console.WriteLine("The more of your numbers that match ours you win more money!!!");
            Console.WriteLine();
            Console.WriteLine("Here's what you could win: ");
            Console.WriteLine("Any one matching = $10.00");
            Console.WriteLine("Two matching = $100");
            Console.WriteLine("Three mathcing(not in order) = $1000");
            Console.WriteLine("Three mathcing(in exact order) = $10,000");
            Console.WriteLine("no matches = $0");
            Console.WriteLine();
            Console.WriteLine("OKAY! LETS PLAY!");
            Console.WriteLine();

            
            //user inputing their three numbers
            Console.Write("Please guess your first number: ");
            int firstguess = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please guess your second number: ");
            int secondguess = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please guess your third number: ");
            int thirdguess = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            /*decisions - included multiple guesses of the same number to be counted as different guess each time and 
              will be counted as a guess; example, user guesses=111; generated guesses=312; user wins $1000 */
             if (firstguess == firstrandom && secondguess == secondrandom && thirdguess == thirdrandom)
                exactmatch = true;
            else
                if (firstguess == firstrandom || firstguess == secondrandom || firstguess == thirdrandom)
                    match = match + 1;
                if (secondguess == firstrandom || secondguess == secondrandom || secondguess == thirdrandom)
                    match = match + 1;
                if (thirdguess == firstrandom || thirdguess == secondrandom || thirdguess == thirdrandom)
                    match = match + 1;
            
                //winnnings
            if (exactmatch)
                award = 10000;
            else if (match == 1)
                award = 10;
            else if (match == 2)
                award = 100;
            else if (match == 3)
                award = 1000;

            
            //award
            Console.WriteLine("Your guesses were: First guess> " + firstguess + ", Second guess> " + secondguess + ", Third guess> " + thirdguess);
            Console.WriteLine();
            Console.WriteLine("The random numbers generated were " + firstrandom + secondrandom + thirdrandom);
            Console.WriteLine();
            Console.WriteLine("You have won $" + award);

            Console.ReadLine();
        }
    }
    
}
