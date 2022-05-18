using System;

namespace MyApp
{   class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myArray = {2,4,7,9};
                Console.WriteLine(myArray[8]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            try
            {
                int[] myArray = {2,4,7,9,"hello"};
                Console.WriteLine(myArray[5]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }              
        } 
    }
}