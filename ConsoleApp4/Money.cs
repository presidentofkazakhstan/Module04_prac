using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Money
    {
        private int _countMoney;
        private int _parMoney;
        public Money()
        {
            _countMoney = 0;
            _parMoney = 0;
        }
        public Money(int countMoney, int parMoney)
        {
            _countMoney = countMoney;
            _parMoney = parMoney;
        }
        public void Output()
        {
            Console.WriteLine(_countMoney);
            Console.WriteLine(_parMoney);
        }
        public void CostProduct(int price)
        {
            if (_parMoney * _countMoney > price)
            {
                Console.WriteLine("Вам хватит денежных средств на покупку товара стоимостью " + price + "тг.");
            }
            else if (_parMoney * _countMoney < price)
            {
                Console.WriteLine("Вам не хватит денежных средств на покупку товара стоимостью " + price + "тг.");
            }

        }
        public void CountProduct(int price)
        {
            int count = (_parMoney * _countMoney) / price;
            Console.WriteLine(count + " штук товара стоимостью " + price + "тг можно купить на имеющиеся денежные средства");
        }



        public int GetCountMoney()
        {
            return _countMoney;
        }
        public int GetParMoney()
        {
            return _parMoney;
        }
        public void SetCountMoney(int countMoney)
        {
            _countMoney = countMoney;
        }
        public void SetParMoney(int parMoney)
        {
            _parMoney = parMoney;
        }
        public int valueMoney()
        {
            return _parMoney * _countMoney;
        }

    }
}
