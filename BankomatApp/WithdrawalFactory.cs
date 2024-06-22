using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatApp
{
    // WithdrawalFactory - Factory Method designmönster
    public static class WithdrawalFactory
    {
        public static IWithdrawalStrategy GetWithdrawalStrategy(string strategyType, int? limit = null)
        {
            switch (strategyType.ToLower())
            {
                case "normal":
                    return new NormalWithdrawal();
                case "limited":
                    return new LimitedWithdrawal(limit ?? 0);
                default:
                    throw new ArgumentException("Ogiltig strategi");
            }
        }
    }
}
