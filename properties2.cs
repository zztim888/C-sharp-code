using System;

namespace MyApp
{
    class Person
    {
        public string Name
        {get; set;}
    }
    class program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);          
    
        } 
    }

}