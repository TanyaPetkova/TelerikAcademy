﻿//Declare two string variables and assign them with “Hello” and “World”.  
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class HelloWorld
{
        static void Main()
        {
            string greeting1 = "Hello";
            string greeting2 = "World";
            object greeting = greeting1 + " " + greeting2;
            Console.WriteLine(greeting);
            string cast = (string)greeting;
            Console.WriteLine(cast);
        }
}
