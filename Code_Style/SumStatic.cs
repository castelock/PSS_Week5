using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Style
{
    class SumStatic
    {
        public static int i = 5;
        public void test()
        {
            i = i + 5;
            Console.WriteLine("Variable static: {0}",i);
        }
    }
}
