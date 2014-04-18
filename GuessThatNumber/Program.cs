using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greet player and ask for his/her name.
            Console.WriteLine("Hello. What is your name?");
            //Begin Program!
            GuessProgram(Console.ReadLine());
        }
        //Create GuessProgram function
        static void GuessProgram(string user)
        {
            //Formally greet player using name
            Console.WriteLine("Welcome, " + user + ". Give me a moment to pick a number. It'll be between 1 and 100.");
            Console.WriteLine("'Jeopardy theme plays'");
            //Assign addon variable to boolean true
            var addon = true;
            //Begin macro 'while' loop
            while (addon == true)
            {
                //Set up randomizer variable pair
                var random = new Random();
                var number = random.Next(1, 101);
                //Inform player when number is chosen
                Console.WriteLine("I have picked a number. Good luck trying to guess it!");
                //Attach response to a variable
                var input = Console.ReadLine();
                int guess = Convert.ToInt32(input);
                int track = 0;
                //start secondary 'while' loop
                while (guess != number)
                {
                    if (guess < number)
                    {
                        Console.WriteLine("You were under, but keep trying!");
                        input = Console.ReadLine();
                        guess = Convert.ToInt32(input);
                        track += 1;
                    }
                    if (guess > number)
                    {
                        Console.WriteLine("You were over, but you'll get it soon, I know it!");
                        input = Console.ReadLine();
                        guess = Convert.ToInt32(input);
                        track += 1;
                    }
                }
                Console.WriteLine("Congratulations! You got the number! Your reward is satifaction!");
                Console.WriteLine("You required " + track + " guesses. Try to do it in less next time!");
                Console.WriteLine("Would you like to play again?");
                Console.WriteLine("    ENTER YES OR NO     ");
                string reply = Console.ReadLine();
                reply = reply.ToLower();
                if (reply == "no")
                {
                    addon = false;
                    Console.WriteLine("Goodbye. Hope you play again sometime, " + user + "!");
                    Console.WriteLine("PRESS ANY KEY TO LEAVE");
                    Console.ReadKey();
                }
            }
        }
    }
}
