using System;

namespace HelloWorld
{
    class Car
    {
        string model;
        string color;
        int year;

        static void Main(string[] args)
        {
            Car Volvo = new Car();
            Volvo.model = "xc40";
            Volvo.color = "red";
            Volvo.year = 2022;

            Car Tesla = new Car();
            Tesla.model = "Model x";
            Tesla.color = "white";
            Tesla.year = 2024;

            Console.WriteLine(Volvo.model);
            Console.WriteLine(Tesla.model);


            




        } 
    }

}