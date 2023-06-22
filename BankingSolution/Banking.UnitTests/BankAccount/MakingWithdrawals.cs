using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests.BankAccount;

public class MakingWithdrawals
{
    [Theory]
    [InlineData(100)]
    [InlineData(125.23)]
    public void MakingWithdrawalDecreasesTheBalance(decimal amountToWithdraw)
    {
        //Given
        //If I have an account and I want to deposit 100
        Account account = new Account(new DummyBonusCalculator());
        decimal openingBalance = account.GetBalance();

        //When - I do the deposit
        account.Withdraw(amountToWithdraw); // "Command"

        //Then - I can verify it worked if the new balance is 100 more than the balance was before. 
        Assert.Equal(openingBalance - amountToWithdraw, account.GetBalance());
    }

    [Fact]
    public void CanTakeFullBalance()
    {
        var account = new Account(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        account.Withdraw(openingBalance);

        Assert.Equal(0, account.GetBalance());
    }
}
