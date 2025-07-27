namespace Task_8;

public static class PartsCatalog
{
    public static readonly Dictionary<PartType, double> Prices = new()
    {
        [PartType.Brakes] = 50,
        [PartType.Suspension] = 101.7,
        [PartType.Engine] = 99.9,
        [PartType.Filter] = 20,
        [PartType.Wheel] = 16.5
    };
}