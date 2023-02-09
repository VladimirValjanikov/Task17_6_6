using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17_6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.CalculateInterest(new OrdinaryAccount());
            Calculator.CalculateInterest(new SalaryAccount());
        }
    }
}
