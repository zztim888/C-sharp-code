using System;

namespace HelloWorld
{
    class program
    {
        static void Main(string[] args)
        {
            using System;

namespace HelloWorld
{
    class program
    {
           static void MyMethod(string fname, int age) 
            {
            Console.WriteLine(fname + " is " + age);
            }

            static void CountryAndPopulation(string country, int population) 
            {
            Console.WriteLine("the population of " + country+" is " + population+ " millions");
            }

            static void Main(string[] args)
            {
                 MyMethod("Tom", 28);
                MyMethod("Hanna", 34);
                MyMethod("Tim",38);
                MyMethod("Morry",46);

                // country and population
                CountryAndPopulation("Sweden",10);
                CountryAndPopulation("USA", 325);
                CountryAndPopulation("Germany",83);
                CountryAndPopulation("Finland", 4);
            }
            
    }

}  
        
}

}