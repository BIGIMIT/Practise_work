using System;
using AP_2_Lib;

namespace AP_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            bank.Name = (Console.ReadLine());
            bank.Number_deposits = Convert.ToDouble(Console.ReadLine());
            bank.Contribution = Convert.ToDouble(Console.ReadLine());
            bank.Percent = Convert.ToDouble(Console.ReadLine());

            bank.GenInfo();
            Bank bank_2 = new Bank();

            bank_2.Name = (Console.ReadLine());
            bank_2.Number_deposits = Convert.ToDouble(Console.ReadLine());
            bank_2.Contribution = Convert.ToDouble(Console.ReadLine());
            bank_2.Percent = Convert.ToDouble(Console.ReadLine());

            bank_2.GenInfo();


        }
    }
}
