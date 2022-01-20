using System;

namespace Code_Style
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The options for this program are: {0} 1- Example static variable Vehicle. {0} " +
                "2- Example static variable Nparks. {0} " +
                "3- Example static variable Sum. {0} " +
                 Environment.NewLine);
            Console.WriteLine("Insert one of the previous options: ");
            String option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    // Accessing the static variable
                    // using its class name
                    Console.WriteLine("Color of model is  : {0} ", Vehicle.Model_color);
                    break;
                case "2":
                    // Accessing the static method
                    // using its class name
                    Nparks.total();
                    break;
                case "3":
                    // Normal way
                    Sum sum = new Sum();
                    sum.test();
                    Sum sum2 = new Sum();
                    sum2.test();

                    // Static way
                    SumStatic sum_static = new SumStatic();
                    sum_static.test();
                    SumStatic sum_static2 = new SumStatic();
                    sum_static2.test();
                    break;
                case "4":
                    int initialized_number;
                    Out o = new Out();
                    o.OutArgExample(out initialized_number);
                    Console.WriteLine("The value of the number is: {0}", initialized_number);
                    break;
                case "5":
                    Week week = new Week();
                    week.showWorkDays();
                    break;
                default:
                    Console.WriteLine("The option is not valid. Please insert another one.");
                    break;
            }

        }
    }
}
