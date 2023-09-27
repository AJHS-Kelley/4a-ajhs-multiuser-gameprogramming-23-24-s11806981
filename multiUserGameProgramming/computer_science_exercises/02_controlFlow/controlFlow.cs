// Ashley Wright, Control Flow, v0.3
using System;

namespace controlFlow
{
    class controlFlow
    {
        static void Main(string[] args)
        {
            // DECLARATIONS
            string favColor = "Pink";
            int luckyNumber = 2;
            float myGPA = 3.9F;
            int myAge = 16;
            bool pineappleOnPizza = false;

            // if Statements -- Check for a single condition!
            if (favColor == "Green") {
                Console.WriteLine("Green with envy!");

            }
            if (myAge == 16) {
                Console.WriteLine("Your are eligible to drive");
            } else {
                Console.WriteLine("START WALKING!");
            }

            // if -- else if -- else -- Checks multipe outcomes.
            if (myGPA == 4.0F) {
                Console.WriteLine("Congrats on straight A grades!");
            } else if (myGPA >= 3.0F) {
                Console.WriteLine("Congrats on making honor roll!");
            } else if (myGPA >= 2.0F) {
                Console.WriteLine("Your graduation ready!");
            } else { 
                Console.WriteLine("You should probably study!");
            }
            
            // Nested Statements
            if (pineappleOnPizza == true) {
                Console.WriteLine("Eww, that's gross. How old are you?");
                if (myAge > 60) {
                    Console.WriteLine("Just as I suspected");
                } else {
                    Console.WriteLine("Okay, you just have bad taste in food.");
                }
            } else {
                Console.WriteLine("Glad to see you have common sense!");
            }
            
        // for loop -- Best for when you know # of interactions needed.
        /*
            for (statement1; statement 2; statement3) {
        }
        statement1 is executed ONCE BEFORE the loop starts.
        statement2 is a CONDITIONAL that is checked EVERYTIME BEFORE loop starts.
        statement3 is executed EVERYTIME after the loop executes.
        */

        for(int i = 0; i < 101; i++){
            Console.WriteLine("" + i);
        }  

        // Create your own loop that counts down from 100 to 0.
        for(int i = 100; i > 101; i--) {
            Console.WriteLine("" + i);
        }

        // Nested Loops
         for(int i = 1; i <= 2; i--) {
            Console.WriteLine("Outer: " + j);

             for(int j = 1; j <= 3; j++) {
            Console.WriteLine("Inner: " + j);
            }
         }   

        // while loop -- Best used when # of iterations needed is unknown
        int x = 0 ;
        while (x < 1000){
            Console.WriteLine("" + x);
            x++;
        } 

        // Special Keywords
        // break will immediately exit a LOOP or an IF / ELSE IF/ELSE block.
        for (int i = 0; i < 101; i++) {
            Console.WriteLine("" + i);
            if (i == 50) {
                break;
            }
        }

        // continue will SKIP the current iteration
        for (int = 0; i <101; i++) {
            Console.WriteLine("" + 1);
            if (i == 50) {
                continue;
            }
        }





        }
    }    
}    