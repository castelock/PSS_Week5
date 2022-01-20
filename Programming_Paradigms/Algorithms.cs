using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Paradigms
{
    class Algorithms
    {
        public void sumNumbers()
        {
            // Declare the variables.
            int num1 = 0;
            int num2 = 0;
            int sum = 0;

            // Read values num1 and num2.
            Console.Write("Insert number1: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Insert number2: ");
            num2 = Int32.Parse(Console.ReadLine());

            // Add num1 and num2 and assign the result to sum.
            sum = num1 + num2;

            //Display sum.
            Console.WriteLine("The sum of 2 numbers is: " + sum);

        }

        public void calculateFactorial()
        {
            // Declare the variables.
            int n = 0;
            int factorial = 1;

            // Read value of n.
            Console.Write("Insert the number n: ");
            n = Int32.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of " + n + " es: " + factorial);

        }
    }
}
