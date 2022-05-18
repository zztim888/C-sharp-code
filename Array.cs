using System;

namespace HelloWorld
{
    class program
    {
        static void Main(string[] args)
        {
            // Sort a string
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            Array.Sort(cars);
            foreach (string i in cars)
            {
            Console.WriteLine(i);
            } 

            int [] numbers = {88,55,99,22,70,15};
            Array.Sort(numbers);
            foreach(int i in numbers)
            {
             Console.WriteLine(i);
             
            }  
            Console.WriteLine(numbers.Max());  // returns the largest value
            Console.WriteLine(numbers.Min());  // returns the smallest value
            Console.WriteLine(numbers.Sum());    

        } 
    }

}