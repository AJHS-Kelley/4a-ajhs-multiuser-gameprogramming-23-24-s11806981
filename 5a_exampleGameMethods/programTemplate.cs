// Ashley Wright, Program Template, v0.2
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
        { 
            bool IsFluffy = true;
            Console.WriteLine("Would you like Fluffy Pancakes?");
            string FluffyOrThin = Convert.ToString(Console.ReadLine);
            if (FluffyOrThin == "yes");
        }
        static string PancakeFlavor()
        {
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
        string FlavorChoice = Convert.ToString(Console.ReadLine);
        // Ask Mr. Kelly how to select item on the list
        }
        static float MethodFou()
        {

        }



        }
    }


// Code Review by Isaiah Reyes