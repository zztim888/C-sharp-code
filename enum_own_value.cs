using System;

namespace MyApp
{   class Program
    {
        enum Months
        {
            Jan,
            Feb,
            Mar = 7,
            Apr,// 8
            May,// 9
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