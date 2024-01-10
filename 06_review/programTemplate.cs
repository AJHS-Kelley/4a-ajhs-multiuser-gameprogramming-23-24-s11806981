// Ashley Wright, Program Template, v0.01
using System;

namespace ReviewProject
{
    class ReviewProject
    {
        static void Main(string[] args)
        {
       
            // Declaring and Assigning Variables
            // Integer -- -2,147,483,648 to -2,147,483,647
            int numberPeople = 8;

            //Long -- -9,223,372,036,
            // Long = 8 bytes
            long myLong = 168326826378;

            //Float -- Stores up to 6-7 decimal digits.
            //Float = 4 bytes
            float soupMade = 1.25f;

            // Double -- Stores up to 15 decimal digits.
            //Double -- 8 bytes
            double myDouble = 9.346832748738D;

            // Boolean -- true / false
            // Boolean = 1 bit
            bool isTired = true;
            // String
            // 2-bytes PER CHARACTER
            // Must be in DOUBLE QUOTES " "
            string happyBirthday = "Happy birthday to you!";
            
            // Character (char)
            //  Single character, in SINGLE QUOTES ' '
            // 2-bytes
            char myChar = 'C';

            // Type Casting -- changing oone data type to another
            // IMPLICIT -- happens automatically when going smaller -> larger
            // char -> int -> long -> float -> double
            //int myInt = 9;
            //double myDouble = myInt;
            //Console.WriteLine(myDouble);
            // EXPLICIT -- Must be done maunally when going larger -> smaller.
            // double -> float -> long -> int -> char
            //double exampleDouble = 9.9504904959D;
            //int myInt = (int) myDouble;

            // Conversion Methods
            //Convert.ToString(); // String
            //Convert.ToDouble(); // Double
            //Convert.ToInt32(); // Integer
            //Convert.ToInt64(); // Long


            // Switch Statement
            int dayOfWeek = 5;
            switch (dayOfWeek)
            {
                case 1:
                Console.WriteLine("The day is Sunday.\n");
                break;
                case 2:
                Console.WriteLine("The day is Monday.\n");
                break;
                case 3:
                Console.WriteLine("The day is Tuesday.\n");
                break;
                case 4:
                Console.WriteLine("The day is Wednesday.\n");
                break;
                case 5:
                Console.WriteLine("The day is Thursday.\n");
                break;
                case 6:
                Console.WriteLine("The day is Friday.\n");
                break;
                case 7:
                Console.WriteLine("The day is Saturday.\n");
                break;
            default:
                Console.WriteLine("No match found.\n"); 
                break; 
            }
        }
    }
}