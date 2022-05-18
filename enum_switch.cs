using System;

namespace MyApp
{   class Program
    {
        enum Level 
        {
        Low,
        Medium,
        High,
        Higher,
        Highest
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            switch(myVar) 
            {
                case Level.Low:
                Console.WriteLine("Low level");
                break;
                case Level.Medium:
                Console.WriteLine("Medium level");
                break;
                case Level.High:
                Console.WriteLine("High level");
                break;
            }
            Level myVar2 = Level.Highest;
            switch(myVar2) 
            {
                case Level.Low:
                Console.WriteLine("Low level");
                break;
                case Level.Medium:
                Console.WriteLine("Medium level");
                break;
                case Level.High:
                Console.WriteLine("High level");
                break;
                case Level.Higher:
                Console.WriteLine("Higher level");
                break;
                case Level.Highest:
                Console.WriteLine("...Highest level...");
                break;
            }
            
        } 
    }

}