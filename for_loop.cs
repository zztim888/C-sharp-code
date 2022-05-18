using System;

namespace HelloWorld
{
    class program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) 
            {
            Console.WriteLine(i);
            }

            for (int i = 0; i <= 10; i = i + 2) 
            {
            Console.WriteLine(i);
            }

            //cars
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars) 
            {
                Console.WriteLine(i);
            }

            string [] nature = {"wind", "fire", "water", "earth"};
            foreach (string i in nature)
            {
                Console.WriteLine(i);
            }

        } 
    }

}