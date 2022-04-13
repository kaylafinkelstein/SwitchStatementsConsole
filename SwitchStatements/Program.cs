using System;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var subject = Console.ReadLine();

            switch (subject)
            {
                case "math":
                    Console.WriteLine("Math is the beeknees!");
                    break;
                case "history":
                    Console.WriteLine("History will always repeat itself");
                    break;
                case "english":
                    Console.WriteLine("English is one of the hardest languages to learn");
                    break;
                case "music":
                    Console.WriteLine("Music is the universal language");
                    break;
                case "science":
                    Console.WriteLine("Science is truth");
                    break;
                default:
                    Console.WriteLine("I never liked school");
                    break;
            }
        }
    }
}
