namespace Task_8;

public class CarService
{
    public int PaymentForWork = 10;
    public int Fine { get; }= 100;
    public int FinePerParts { get; }= 25;

    private double _earnedMoney;

    public double EarnedMoney
    {
        get
        {
            return Math.Round(_earnedMoney, 2);
        }
        set
        {
            _earnedMoney = value;
        }
    }

}