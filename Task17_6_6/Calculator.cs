﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task17_6_6
{
    public static class Calculator
    {
        public static void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}
