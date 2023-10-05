﻿// 02_Collections, Ashley Wright, 10/13/23 v0.3a
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
            float[] GPA = {3.14f, 2.25f, 1.74f, 1.99f, 0.99f, 4.25f};

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

            /* Print Array Contents == Each Element on Seperate Line
             Console.WriteLine(" The elements for each array are:\n");
            Console.WriteLine("breakfastFoods: \n" + String.Join("\n", breakfastFoods));
            Console.WriteLine();
             Console.WriteLine(" The elements for each array are:\n");
            Console.WriteLine("testScores: \n" + String.Join("\n", testScores));
            Console.WriteLine();
             Console.WriteLine(" The elements for each array are:\n");
            Console.WriteLine("GPA: \n" + String.Join("\n", GPA));
            Console.WriteLine();
            */

            /* Determing Array Length 
            Console.WriteLine("The length of each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods.Length);
            Console.WriteLine("testScores: " + testScores.Length);
            Console.WriteLine("GPA: " + GPA.Length);

            //Accessing Array Elements -- use the index!
            Console.WriteLine("The first element in each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods[0]);
            Console.WriteLine("testScores: " + testScores[0]);
            Console.WriteLine("GPA: " + GPA[0]);

            // Access Last Element
             Console.WriteLine("The last element in each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods[breakfastFoods.Length - 1]);
            Console.WriteLine("testScores: " + testScores[testScores.Length - 1]);
            Console.WriteLine("GPA: " + GPA[GPA.Length - 1]);

            // PAUSE WRITE YOUR OWN CODE
            //v0.2b -- Access the third element in each array and print to the screen.
            Console.WriteLine("The third element in each array is:\n");
            Console.WriteLine("breakfastFoods: " + breakfastFoods[2]);
            Console.WriteLine("testScores: " + testScores[2]);
            Console.WriteLine("GPA: " + GPA[2]);
            */

            // Changing Array Elements --
            breakfastFoods[0] = "Cake";
            testScores[0] = 59;
            GPA[0] = 1.34f;
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
