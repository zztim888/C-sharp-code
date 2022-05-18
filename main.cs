using System;

namespace HelloWorld
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            // write on the same line
            Console.Write("hello world");
            /*
            multiline comment
            */

            string name = "JOhn";
            Console.WriteLine(name);

            int myNum = 40;
            myNum = 20; // change value
            Console.WriteLine(myNum);

            const int ourNum = 50;// cant be changed
            Console.WriteLine(ourNum);

            //data values
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";

            string name = "John";
            Console.WriteLine("Hello " + name);

            string firstName = "John ";
            string lastName = "Doe";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); // Print the value of x + y

            int x = 5, y = 6, z = 50;
            Console.WriteLine(x + y + z);

            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);

            /*It is recommended to use descriptive names in 
            order to create understandable and maintainable code:
            */
            int minutesPerHour = 60;

            //data types
            int myNumber = 15;
            double myDoubleNum = 5.99D;
            char myLetter = 'd';
            bool myBool = true;
            string myText = "hello";

            /*The long data type can store whole numbers from -9223372036854775808 to
             9223372036854775807. This is used when int is not large enough to store 
             the value. Note that you should end the value with an "L":
             */

             long myLongNumber = 15000000000L; // ends witl 'L'
             Console.WriteLine(myLongNumber);

             float myFloatingNumber = 3.14F; // 'F'
             Console.WriteLine(myFloatingNumber);


             double myDoubleNum1 = 19.99D; //precision of 15 digits Therefore it is safer to use double for most calculations.
             Console.WriteLine(myDoubleNum1);

             /*
              The precision of a floating point value indicates how many digits the value can have after the 
             decimal point. The precision of float is only six or seven decimal digits, while double variables
              have a precision of about 15 digits.Therefore it is safer to use double for most calculations.
             */

            float f1 = 35e3F; // 35000 e= power of 10
            double d1 = 12E4D; // 120000
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty); 

            //typecasting
            //Implicit Casting
            /*Implicit casting is done automatically when passing a smaller 
            size type to a larger size type:*/

            int myIntTypeCasting = 9;
            double myDoublemyTypeCasting = myIntTypeCasting;       // Automatic casting: int to double

            Console.WriteLine(myIntTypeCasting);      // Outputs 9
            Console.WriteLine(myDoublemyTypeCasting); 

            double myDoublemyTypeCasting2 = 9.78;
            int myIntTypeCasting2 = (int) myDoublemyTypeCasting2;    // Manual casting: double to int

            Console.WriteLine(myDoublemyTypeCasting2);   // Outputs 9.78
            Console.WriteLine(myIntTypeCasting2);      // Outputs 9

             




        } 
    }

}