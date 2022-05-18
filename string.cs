using System;

namespace HelloWorld
{
    class program
    {
        static void Main(string[] args)
        {

            string text = "sdhasdfjlasd";
            Console.WriteLine(text.Length);
            Console.WriteLine(text.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(text.ToLower()); 

            string firstName = "John ";
            string lastName = "Doe";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

            //string interpolation

            string fullName = $" My full name is: {firstName} {lastName}";
            Console.WriteLine(fullName);

            string Mystring= "Hello";
            Console.WriteLine(Mystring[1]); // prints e
            Console.WriteLine(Mystring.IndexOf("o")); 

            string hisName = "Larry Page";
            int charPosition = hisName.IndexOf("P");

            //get last name
            string getTheLastName = hisName.Substring(charPosition)
             Console.WriteLine(getTheLastName); // prints e

             // error the quote qthin a quot             
             string text = "We are the so-called "Vikings" from the north.";

             //correct
             string txt = "We are the so-called \"Vikings\" from the north.";

             string txt = "It\'s alright."; // It's alright

            // The sequence \\  inserts a single backslash in a string:
            string txt = "The character \\ is called backslash.";

            /*
            \n 	New Line 	
            \t 	Tab 	
            \b 	Backspace
            */

            int x = 10;
            int y = 20;
            int z = x + y;  // z will be 30 (an integer/number)

            string x1 = "10";
            string y2 = "20";
            string z2 = x + y;  // z will be 1020 (a string)












            




        } 
    }

}