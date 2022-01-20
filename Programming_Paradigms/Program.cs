using System;

namespace Programming_Paradigms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The options for this program are: {0} 1- Sum two numbers.{0} " +
                "2- Calculate the factorial of n. {0}",
                 Environment.NewLine);
            Console.WriteLine("Insert one of the previous options: ");
            String option = Console.ReadLine();

            Algorithms alg = new Algorithms();
            switch (option)
            {
                case "1":
                    alg.sumNumbers();
                    break;
                case "2":
                    alg.calculateFactorial();
                    break;
                default:
                    Console.WriteLine("The option is not valid. Please insert another one.");
                    break;
            }
        }
    }
}
