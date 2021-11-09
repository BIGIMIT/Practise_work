using System;

namespace AP_2_Lib
{
    public class Bank
    {
        string name;
        public string Name { get { return name; } set { name = value; } }

        double number_deposits;
        public double Number_deposits { set { number_deposits = value; } }

        double contribution;
        public double Contribution { set { contribution = value; } }

        double percent;
        public double Percent { set { percent = value; } }

        public double Sum
        {
            get { return number_deposits * contribution * (percent / 100); }
        }

        public void GenInfo()
        {
            Console.WriteLine($"Название банка : {name}\n" +
                              $"Число кадров   : {number_deposits} \n" +
                              $"Размер вкладов : {contribution} \n" +
                              $"Процент        : {percent} % \n" + $"");
            Console.WriteLine($"Общие выплаты по процентам = {Sum}");
        }


    }
    c
    }
}
