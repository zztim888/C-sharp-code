using System;

namespace MyApp
{
    class Person
    {
        private string name;
        public string Name
         {
            get { return name; }
            set { name = value; }
        }
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