using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankomatApp
{
    // Bankomat - Singleton designmönster
    public class Bankomat
    {
        private static Bankomat _instance;
        public int Balance { get; private set; }

        private Bankomat()
        {

        }
        public static Bankomat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Bankomat();
                }
                return _instance;

            }
        }

        public void Deposit(int amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount} SEK insatt. Nytt saldo: {Balance} SEK");
        }

        public void Withdraw(int amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Otillräckliga medel!");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"{amount} SEK uttaget. Nytt saldo: {Balance} SEK");
            }
        }
    }
}
