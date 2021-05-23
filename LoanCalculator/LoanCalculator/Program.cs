using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your capital: ");
            double capital = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Please input the number of installments: ");
            double installments = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.Write("Please input the interest rate: ");
            double interest_rate =Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            interest_rate = interest_rate / 100;

            double installment = capital * interest_rate / (1 - Math.Pow((1 + interest_rate), (-1 * installments)));
            Math.Round(installment, 2);

            Console.WriteLine("1.Capital is: " + capital);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("2.Number of installments is: " + installments);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("3.Interest rate is: " + interest_rate);
            Console.WriteLine("===================================");
            Console.WriteLine("4.Your installment is: " + Math.Round(installment, 2) + " euros");

            Console.ReadKey();
        }
    }
}
