using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatApp
{
    // IWithdrawalStrategy - Strategy designmönster
    public interface IWithdrawalStrategy
    {
        void Withdraw(Bankomat bankomat, int amount);
    }

    public class NormalWithdrawal : IWithdrawalStrategy
    {
        public void Withdraw(Bankomat bankomat, int amount)
        {
            bankomat.Withdraw(amount);
        }
    }

    public class LimitedWithdrawal : IWithdrawalStrategy
    {
        private readonly int _limit;

        public LimitedWithdrawal(int limit)
        {
            _limit = limit;
        }

        public void Withdraw(Bankomat bankomat, int amount)
        {
            if (amount > _limit)
            {
                Console.WriteLine($"Uttag överstiger gränsen på {_limit} SEK");
            }
            else
            {
                bankomat.Withdraw(amount);
            }
        }
    }
}
