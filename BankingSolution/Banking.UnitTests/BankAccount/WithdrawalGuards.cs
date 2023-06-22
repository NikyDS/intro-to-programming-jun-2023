﻿using Banking.Domain;
using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests.BankAccount;

public  class WithdrawalGuards
{
    [Fact]
    public void OverdraftnotAllowed()
    {
        var account = new Account(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        try
        {
            account.Withdraw(openingBalance + .01M);
        }
        catch (OverdraftException)
        {

            //ignore any exception
        }

        Assert.Equal(openingBalance, account.GetBalance());
    }
    [Fact]
    public void OverdraftThrowsException()
    {
        var account = new Account(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();

        Assert.Throws<OverdraftException>(() => account.Withdraw(openingBalance + .01M));
    }
}
