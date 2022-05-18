using System;

namespace HelloWorld
{
    class program
    {
        static void Main(string[] args)
        {
            int x = 100+50;
            Console.WriteLine(x);

            int sum1 = 100 + 50;        // 150 (100 + 50)
            int sum2 = sum1 + 250;      // 400 (150 + 250)
            int sum3 = sum2 + sum2;

            int y = 10;
            y += 5;
            Console.WriteLine(y);  

            /*
            = 	x = 5 	x = 5 	
            += 	x += 3 	x = x + 3 	
            -= 	x -= 3 	x = x - 3 	
            *= 	x *= 3 	x = x * 3 	
            /= 	x /= 3 	x = x / 3 	
            %= 	x %= 3 	x = x % 3 	
            &= 	x &= 3 	x = x & 3 	
            |= 	x |= 3 	x = x | 3 	
            ^= 	x ^= 3 	x = x ^ 3 	    
            >>= 	x >>= 3 	x = x >> 3 	
            <<= 	x <<= 3 	x = x << 3
            */







        } 
    }

}