using Should;
using Xunit;

namespace WriteGoodTests.Test.Antipatterns.Chain_Gang
{
    public class When_Performing_Banking_Transactions
    {
        private readonly BankAccount _bankAccount;

        public When_Performing_Banking_Transactions()
        {
            _bankAccount = new BankAccount(100);
        }

        [Fact]
        public void Deposit_Should_Increase_Balance()
        {
            _bankAccount.Deposit(20);
            _bankAccount.Balance.ShouldEqual(120);
        }

        [Fact]
        public void Withdrawal_Should_Decrease_Balance()
        {
            _bankAccount.Withdraw(20);
            _bankAccount.Balance.ShouldEqual(100);
        }
    }

    public class BankAccount
    {
        public int Balance { get; set; }

        public BankAccount(int initialDeposit)
        {
            Balance = initialDeposit;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public void Withdraw(int amount)
        {
            Balance -= amount;
        }
    }
}