// 02_Collections, Ashley Wright, 10/13/23 v0.1b
using System;

namespace computer_science_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Collections are variables that can store multiple values in one variable.

            /* Arrays
            -- Number of elements in an array CANNOT change.
            -- Contents of elements in an array CAN change.
            -- Items in the array are called ELEMENTS.
            -- Arrays are ordered, meaning each item has a fixed position.
            -- The position is known as the INDEX.
            -- First element in an array is index 0.
            */

            // Declaring and Defining an Array
            string[] breakfastFoods = {"Bacon", "Waffles", "Pancakes", "Cereal", "Fruit"};
            int[] testScores = {95, 100, 25, 15, 27, 35};
            float[] GPA = {3.14f, 2.25f, 1.74f, 099f, 4.25f};

            // Print Array Contents -- All Elements on Single Line
            Console.WriteLine(" The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join(", ", breakfastFoods));
            Console.WriteLine();
             Console.WriteLine(" The elements for each array are:\n");
            Console.WriteLine("testScores: \n" + String.Join(", ", testScores));
            Console.WriteLine();
             Console.WriteLine(" The elements for each array are:\n");
            Console.WriteLine("GPA: \n" + String.Join(", ", GPA));
            Console.WriteLine();







        }
    }
}
