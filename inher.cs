using System;

namespace MyApp
{
    class Vehicle
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tutt Tutt");
        }
    }
    class Car: Vehicle
    {
        public string modelName ="Mustang";
    }
    class Program
    {    
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.honk();

            Console.WriteLine(myCar.brand + " " + myCar.modelName);

        } 
    }

}