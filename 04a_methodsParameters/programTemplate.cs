// Ashley Wright, Program Template, v0.02
using System;

namespace MethodsParameters
{
    class MethodsParameters
    {
        // METHOD -- name block of code, can be used over and over.
        // All methods have a SIGNATURE that defines their name, parameters, and output.
        // Example Signature
        static void MyMethod()
        {
            Console.WriteLine("cookies for breakfast.\n");
        }
        // static -- This method belongs to the current class, it is NOT an object.
        //void -- This method has no return value.

        static int DoubleUp()
        {
            int sum = 0;
            Console.WriteLine("This method will double a number and return it.\n");
            Console.WriteLine("Please enter a number on the next line.\n");
            sum = System.Convert.ToInt32(Console.ReadLine());
            sum *= 2;
            Console.WriteLine(sum);
            return sum; 
        }

        // Methods with Parameters
        static void MakePancakes(int num)
        {
            for (int i = 0; i < num; i++) 
            {
                Console.WriteLine("One fluffy pancake coming up!\n");
            }
        }
        static void Main(string[] args)
        {
            //MyMethod();
            //DoubleUp();
            MakePancakes(2);
        }
    }
}