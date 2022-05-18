    using System;

    namespace HelloWorld
    {
        class program
        {
            // instead of viod we have int to return a value
            static int MyMethod(int x) 
            {
            return 5 + x;
            }

            static int MyMethod2(int x, int y) 
                {              
                return x + y;
                }
            static int MyMethod3(int x, int y) 
                {              
                return x + y;
                }

            static void Main(string[] args)
            {            
                Console.WriteLine(MyMethod(3));
                Console.WriteLine("Mymethod2:"+MyMethod2(3,15));

                // this is eaisier to read
                int z = MyMethod3(22,33);
                Console.WriteLine("Mymethod3: "+z);

            } 
        }

    }