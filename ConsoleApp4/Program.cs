using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money();

            money.SetCountMoney(7);
            money.SetParMoney(500);
            Console.WriteLine("Количество купюр: " + money.GetCountMoney());
            Console.WriteLine("Номинал купюр: " + money.GetParMoney() + "тг.");
            Console.WriteLine("Денег у вас: " + money.valueMoney() + "тг.");
            money.CostProduct(5000);
            money.CountProduct(500);

            Console.ReadKey();
        }
    }
}
