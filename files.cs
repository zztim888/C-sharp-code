using System;
using System.IO;  // include the System.IO namespace

// this is how you create a file
namespace MyApp
{   class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello you there!";
            File.WriteAllText("filename.txt",writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
            
        } 
    }

}