using System;

namespace MyApp
{
    class Car
    {
        public string model;

        /*Note that the constructor name must match the class name, 
        and it cannot have a return type (like void or int). 
        */
        public Car()
        {
            model = "Mustang";
        }
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);   

        } 
    }

}