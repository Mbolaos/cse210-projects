using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        int magicnumber = int.Parse(Console.ReadLine());

        int guess = -1;
          while (guess != magicnumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicnumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicnumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            //I tried to create a loop to let the user the chance to answer yes to continue playing but dont had succes can we get some tips on how to do that?

        }
    }
}