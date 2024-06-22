namespace BankomatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankomat bankomat = Bankomat.Instance;

            // Factory Method används för att skapa en normal uttagsstrategi
            IWithdrawalStrategy normalStrategy = WithdrawalFactory.GetWithdrawalStrategy("normal");

            // Sätter in pengar
            bankomat.Deposit(1000);

            // Använder normal strategi för uttag
            normalStrategy.Withdraw(bankomat, 500);

            // Factory Method används för att skapa en begränsad uttagsstrategi
            IWithdrawalStrategy limitedStrategy = WithdrawalFactory.GetWithdrawalStrategy("limited", 200);

            // Försöker ta ut mer än gränsen
            limitedStrategy.Withdraw(bankomat, 300);

            // Tar ut inom gränsen
            limitedStrategy.Withdraw(bankomat, 150);
        }
    }
}
