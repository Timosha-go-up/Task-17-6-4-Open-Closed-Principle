using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17_6_4_Open_Closed_Principle
{
    public class Account
    {
        public string? Type { get; set; }
        public double Balance { get; set; }
        public double Interest { get; set; }

        private IInterestCalculator _calculator;

        public Account(IInterestCalculator calculator)
        {
            _calculator = calculator;
        }

        public void CalculateInterest()
        {
            Interest = _calculator.Calculate(Balance);
        }
    }
}
