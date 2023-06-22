using Banking.Domain;

namespace Banking.UnitTests.BonusCalculation;
public class CalculatingStandardBonuses
{
    [Theory]
    [InlineData(100,10)]
    [InlineData(200, 20)]
    public void AccountsThatHaveBalanceThresholdGetBonus(decimal amountToDeposit, decimal expectedBonus)
    {
        var bonusCalculator = new StandardBonusCalculator();

        decimal bonus = bonusCalculator.CalculateBonusForDepositOn(5000.01m, amountToDeposit);

        Assert.Equal(expectedBonus, bonus);
    }

    [Theory]
    [InlineData(100, 0)]
    [InlineData(200, 0)]
    public void AccountsThatHaveBalanceBelowThresholdGetBonus(decimal amountToDeposit, decimal expectedBonus)
    {
        var bonusCalculator = new StandardBonusCalculator();

        decimal bonus = bonusCalculator.CalculateBonusForDepositOn(1000.01m, amountToDeposit);

        Assert.Equal(expectedBonus, bonus);
    }

}
