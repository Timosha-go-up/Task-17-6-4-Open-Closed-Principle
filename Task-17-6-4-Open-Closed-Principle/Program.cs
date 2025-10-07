namespace Task_17_6_4_Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем калькулятор для обычного счета
            var regularCalculator = new RegularAccountCalculator();
            var regularAccount = new Account(regularCalculator)
            {
                Type = "Обычный",
                Balance = 3000
            };

            regularAccount.CalculateInterest();
            Console.WriteLine($"Расчет процента:{regularAccount.Type}  {regularAccount.Interest}");

            // Создаем калькулятор для зарплатного счета
            var salaryCalculator = new SalaryAccountCalculator();
            var salaryAccount = new Account(salaryCalculator)
            {
                Type = "Зарплатный",
                Balance = 3000
            };

            salaryAccount.CalculateInterest();
            Console.WriteLine($"Расчет процента:{salaryAccount.Type}  {salaryAccount.Interest}");
        }
    }
    
}
