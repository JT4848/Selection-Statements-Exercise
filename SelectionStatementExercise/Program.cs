using System.Security.Cryptography;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my favorite number?");
            var r = new Random();
            var favNumber = r.Next(48);
            var userInput = int.Parse(Console.ReadLine());

            

            if(userInput < 48)
            {
                Console.WriteLine("To Low");
            }
            else if(userInput > 48)
            {
                Console.WriteLine("To High");
            }
            else
            {
                Console.WriteLine("You Got It");
            }
        }
    }
}
