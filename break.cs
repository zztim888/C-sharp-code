using System;

namespace HelloWorld
{
    class program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++) 
            {
            if (i == 4) 
            {
                break;
            }
            Console.WriteLine(i);
            }

            // Continue Example
            int i = 0;
            while (i < 10) 
            {
            if (i == 4) 
            {
                i++;
                continue;
            }
            Console.WriteLine(i);
            i++;
            }                       

        } 
    }

}