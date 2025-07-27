namespace Task_8;

public class CarService
{
    private double _earnedMoney;
    public int PaymentForWork { get; } = 10;
    public int Fine { get; } = 100;
    public int FinePerParts { get; } = 25;


    public double EarnedMoney
    {
        get { return Math.Round(_earnedMoney, 2); }
        set { _earnedMoney = Math.Round(value, 2); }
    }

    public void PartRepaired(PartType part)
    {
        EarnedMoney += PaymentForWork + PartsCatalog.Prices[part];
    }

    public void PayFine()
    {
        EarnedMoney -= Fine;
    }

    public void PayFinePerPart()
    {
        EarnedMoney -= FinePerParts;
    }
}