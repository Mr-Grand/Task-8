namespace Task_8;

public class Car
{
    public static Random random = new Random();
    public static int CarCount { get; private set; } = 0;
    private Dictionary<Part, bool> _carParts = new Dictionary<Part, bool>()
    {
        [new Part1()] = random.Next(2) == 0,
        [new Part2()] = random.Next(2) == 0,
        [new Part3()] = random.Next(2) == 0,
        [new Part4()] = random.Next(2) == 0,
        [new Part5()] = random.Next(2) == 0,
    }; // Честно говоря - я не понял вординг задачи, есть ли лимит на 1 поломанную деталь

    public Car()
    {
        CarCount++;
    }
    
    public IReadOnlyDictionary<Part,bool> CarParts => _carParts;
}