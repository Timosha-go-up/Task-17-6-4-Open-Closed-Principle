using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_6_4_Open_Closed_Principle
{
    public class RegularAccountCalculator : IInterestCalculator
    {
        public double Calculate(double balance)
        {
           
            if (balance < 1000)
                balance *= 0.2;

            else if (balance >= 1000)
                 balance *= 0.4;

            return balance;
        }
    }
}
