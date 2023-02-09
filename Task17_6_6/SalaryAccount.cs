using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task17_6_6
{
    public class SalaryAccount : IAccount
    {
        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
