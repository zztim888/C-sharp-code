using System;

namespace MyApp
{   class Program
    {
        enum Months
        {
            Jan,
            Feb,
            Mar,
            Apr,
            May,
            Jun,
            Jul
        }
        static void Main(string[] args)
        {
            int myNum = (int) Months.Apr;// number of month = 3
            Console.WriteLine(myNum);
            
        } 
    }

}