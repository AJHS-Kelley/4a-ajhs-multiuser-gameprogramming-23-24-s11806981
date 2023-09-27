// Ashley Wright, Program Template, v0.04
using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt1 = 43;
            int myInt2 = 20;

            string myString1 = "Ashley";
            string myString2 = "October";

            float myFloat1 = 4.0F;
            float myFloat2 = 96.8F;


            // Arithmetic Operators
            Console.WriteLine(myInt1 + myInt2);
            //Console.WriteLine(myString1 + myString2);
            Console.WriteLine(myFloat1 + myFloat2);
            Console.WriteLine(myInt1 + myFloat2);

              Console.WriteLine(myInt1 - myInt2);
            //Console.WriteLine(myString1 - myString2);
            Console.WriteLine(myFloat1 - myFloat2);
            Console.WriteLine(myInt1 - myFloat2);

              Console.WriteLine(myInt1 / myInt2);
            //Console.WriteLine(myString1 / myString2);
            Console.WriteLine(myFloat1 / myFloat2);
            Console.WriteLine(myInt1 / myFloat2);

              Console.WriteLine(myInt1 * myInt2);
            //Console.WriteLine(myString1 * myString2);
            Console.WriteLine(myFloat1 * myFloat2);
            Console.WriteLine(myInt1 * myFloat2);

            // Modulus
            Console.WriteLine("Modulus");
            Console.WriteLine(10 % 2);
            Console.WriteLine(9 % 4);

            // Increment
            int myInt3 = 1;
            //myInt4++;
            Console.WriteLine(myInt3);

            // Decrement
            int Int4 = 2;
            myInt3--;
            //Console.WriteLine(myInt4);

            //Assignment Operaters
            // = THE ASSIGNMENT OPERATERS THROWS OUT OLD VALUES
            myInt3 = 5;

            // These assignment operaters keep old values !!
            // +=
            myInt3 += -1;
            // -=
            myInt3 -= 2;
            // *=
            myInt3 *= 3;
            // /=
            myInt3 /= 2;
            Console.WriteLine(myInt3);

            // Comparison Operators 
            // Is Equal To
            Console.WriteLine(5 == 4);
            // Not Equal To 
            Console.WriteLine(3 != 2);
            // Greater Than
            Console.WriteLine( 5 > 3);
            // Greater Than or Equal To
            Console.WriteLine(55 >= 75);
            // Less Than
            Console.WriteLine(-1 < -2);
            // Less Than or Equal To
            Console.WriteLine(1 <= 5);


            // Logical Operators
            // And -- ALL CONDITIONS MUST BE TRUE FOR WHOLE STATEMENT TRUE
            Console.WriteLine(3 > 2 && 2 == 2); // True and True = True
            Console.WriteLine(3 > 2 && 5 > 6); // True and False = False
            // Or -- ONE condition must be true for the whole statement to be true.
            Console.WriteLine(5 < 9 || 5 != 4); // True or True == True
            Console.WriteLine(9 < 10 || 3 > 5); // True or False ==  True
            // Not -- Find the 'opposite' value.
            Console.WriteLine(!(5 > 4)); //


        }
    }
}