using System;

namespace HelloWorld
{
    class program
    {
        static void Main(string[] args)
        {
            if (20 > 18) 
                {
                Console.WriteLine("20 is greater than 18");
                }
            
            int x =20;
            int y=100;
            if(x<y)
            {
               Console.WriteLine("x is smaller");
            }

            int time = 13;
            if(time >12)
            {
              Console.WriteLine("it\'s afternoon");

            }
            else
            {
              Console.WriteLine("it\'s noon");

            }

            // else if
            int time2 = 22;
            if (time2 < 10) 
            {
            Console.WriteLine("Good morning.");
            } 
            else if (time2 < 20) 
            {
            Console.WriteLine("Good day.");
            } 
            else 
            {
            Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

            //short hand
            int theTime = 20;
            string result = (theTime<18) ? "Good day" : "Good evening";
            Console.WriteLine(result);
           




        } 
    }

}