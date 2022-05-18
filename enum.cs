using System;

namespace MyApp
{   class Program
    {
        enum Level
        {
            Low,
            Midium,
            High
        }
        static void Main(string[] args)
        {
            Level myVar = Level.Midium;
            Console.WriteLine(myVar);
            
        } 
    }

}