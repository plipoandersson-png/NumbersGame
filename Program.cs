using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace NumbersGame
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int secretNumber = random.Next(0, 41);
            int guessCount = 0;
            bool run = true;
            while (run)
            {
                
                Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 0 och 40. Kan du gissa vilket? Du får fem försök.");
                Console.Write("Din gissning:");
                int userGuess;
                if (int.TryParse(Console.ReadLine(), out userGuess))
                {
                    guessCount++;
                    

                    CheckGuess(userGuess, secretNumber);

                    if (guessCount > 5)
                    {
                        Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                        run = false;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Du skrev en bokstav :(");
                }
                
              
            }
            
        }
       
        public static void CheckGuess(int guess, int correctNumber)
        {
            if(guess == correctNumber)
            {
                Console.WriteLine("Wohoo! Du klarade det!\n");
            }
            else if (guess > correctNumber)
            {
                Console.WriteLine("Tyvärr, du gissade för högt!\n");
            }
            else
            {
                Console.WriteLine("Tyvärr, du gissade för lågt!\n");
            }
        }
        
    }
}
