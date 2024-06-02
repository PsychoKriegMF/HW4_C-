using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_C_
{
    public class Money
    {
        public int Whole { get; set; }
        public int Fraction { get; set; }
        public double Total() { return Whole + (double)(Fraction) / 100; }
        public void Print()
        {
            Console.WriteLine("\nВаш баланс: " + Total());
        }
    }
}
