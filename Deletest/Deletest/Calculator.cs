using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deletest
{
    public class Calculator
    {   
        public int Add(int Num1, int Num2)
        {
            int Sum = Num1 + Num2;
            Console.WriteLine("Sum = " + Sum);
            return Sum;
        }

        public int Sub(int Num1, int Num2)
        {
            int Sum = Num2 - Num1;
            Console.WriteLine("Sum = " + Sum);
            return Sum;
        }
    }
}
