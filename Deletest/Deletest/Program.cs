using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deletest
{
    class Program
    {
        public delegate int Calc(int i, int j);

        static void Main(string[] args)
        {
            Calculator calc1 = new Calculator();
            Calc ccalc1 = new Calc(calc1.Add);
            Calc ccalc2 = new Calc(calc1.Sub);
            ccalc1(1,2);
            ccalc2(2,3);
            Calc ccalc3 = ccalc1 + ccalc2 - ccalc1;
            ccalc3(2, 3);




        }
    }
}
