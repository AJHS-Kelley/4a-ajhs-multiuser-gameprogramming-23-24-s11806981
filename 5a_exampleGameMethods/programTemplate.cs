// Ashley Wright, Program Template, v0.5
// All required examples provided. 
using System;
using System.Collections;
namespace PancakeGame
{
    class PancakeGame
    {
        //Making Pancakes Game
        //Steps(Methods) 1: Mix ingredients 2: Make Pancakes
        static int MakePancakes()
        {
            int PancakeAmount = 4;
        Console.WriteLine("Today we're making pancakes! ");
        return PancakeAmount;
        }
        static bool FluffyOrThin()
        // Player gets to decide whether they want fluffy or thin pancakes.
        { 
            bool IsFluffy = true;
            Console.WriteLine("Would you like Fluffy  or Thin Pancakes?");
            string FluffyOrThin = Convert.ToString(Console.ReadLine());
            //Get Mr.Kelly to help with the response lowercase or uppercase
            if (FluffyOrThin == "fluffy"); {
                IsFluffy = true;
                Console.WriteLine("Fluffy pancakes it is! \n");
            } else (FluffyOrThin == "thin") {
                IsFluffy = false;
                Console.WriteLine("No? Okay! Thin pancakes it is! \n");
            }
            return IsFluffy;
        }
        static string PancakeFlavor()
        {
            Console.WriteLine("Now, moving on to the pancake flavors! \n");
        var PancakeFlavors = new ArrayList()
        {
            "Plain", "Chocolate", "Strawberry", "Blueberry"
        };
        Console.WriteLine("These are the available flavors: \n");
        foreach (var item in PancakeFlavors)
            {
                Console.WriteLine(item);
            }
        Console.WriteLine("Please choose a flavor!");
        if (FlavorChoice == "Plain")
        {
            Console.WriteLine("Alright, we don't need any extra ingredients.");
        } else if (FlavorChoice == "Chocolate")
        {
            Console.WriteLine("");
        }
        return "mo";
        string FlavorChoice = Convert.ToString(Console.ReadLine);
        // Ask Mr. Kelly how to select item on the list
        }
        static float MethodFou()
        {

        }



        }
    }


// Code Review by Isaiah Reyes