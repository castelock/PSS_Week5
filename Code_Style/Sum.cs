using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Style
{
    class Sum
    {
        public int i = 5;
        public void test()
        {
            i = i + 5;
            Console.WriteLine("Variable non-static: {0}", i);
        }
    }
}
