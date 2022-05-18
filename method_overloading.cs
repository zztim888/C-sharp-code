using System;

namespace HelloWorld
{
    class program
    {
        /*
        Instead of defining two methods that should do 
        the same thing, it is better to overload one.

        In the example below, we overload the PlusMethod method to work for both int and double:
        */
        static int PlusMethod(int x,int y)
        {
            return x+y;
        }
        static double PlusMethod(double x,double y)
        {
            return x+y;
        }

        static void Main(string[] args)
        {
            int num1 = PlusMethod(3,4);
            double num2 = PlusMethod(3.1,4.5);

            Console.WriteLine(num1);
            Console.WriteLine(num2); 
        } 
    }

}