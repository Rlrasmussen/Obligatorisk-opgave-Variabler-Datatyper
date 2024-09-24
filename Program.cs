using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorisk_opgave___Variabler___Datatyper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basisprogrammering – Variabler & Datatyper");

            //Random number between 0-100
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            //Console.WriteLine(randomNumber);

            //Hello and players name
            Console.WriteLine("Hello, what is your name");
            
            //Telling the player to guess a number
            Console.WriteLine("Hello " + Console.ReadLine());
            Console.WriteLine("Your task is to guess a random number inbetween 0-100. What do you guess?");
            int guessNumber = Convert.ToInt32(Console.ReadLine());

            while (guessNumber <0 || guessNumber > 100)
            {
                Console.WriteLine("Your guess need to be in between 0-100. Guess again");
                guessNumber = Convert.ToInt32(Console.ReadLine());
            }

            //The differents between the numbers 
            int difNumber = Math.Abs(randomNumber - guessNumber);

            //Ens text with the result 4
            Console.WriteLine($"Your guess is {guessNumber} is {difNumber} from the number");
            Console.WriteLine("Your guess is " + guessNumber);
            Console.WriteLine("The number is " + randomNumber);
            Console.WriteLine(" ");
            Console.WriteLine("Have a nice day");
            Console.WriteLine("Press a key to close the program");

            //Close the program
            Console.ReadKey();
        }
    }
}
