using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_6_4_Open_Closed_Principle
{
   
    public class SalaryAccountCalculator : IInterestCalculator
    {
        public double Calculate(double balance)
        {
            return balance * 0.5;
        }
    }
}
