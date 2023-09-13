using System;
namespace Todo
{
public class Program
{
    public static void Main(string[] args)
    {
            var a=new Random();
            var favNumber = 8;
            bool guessedCorrectly;
            do
            {
                Console.WriteLine("Guess The Random Number");
                var userInput = int.Parse(Console.ReadLine());
                if (favNumber > userInput)
                {
                    Console.WriteLine("Too low");
                    guessedCorrectly = false;
                }
                else if (favNumber < userInput)
                {
                    Console.WriteLine("too High");
                    guessedCorrectly = false;
                }
                else
                {
                    Console.WriteLine("Wow!You guessed it correctly");
                    guessedCorrectly = true;
                }


            } while (!guessedCorrectly);
    }
}
}
