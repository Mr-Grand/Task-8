namespace Task_8;

public class Car
{
    public static Random random = new Random();
    public static int CarCount { get; private set; } = 0;
    private Dictionary<Part, bool> _carParts = new Dictionary<Part, bool>();

    public Car(IReadOnlyList<Part> parts)
    {
        foreach (var part in parts)
        {
            _carParts.Add(part, random.Next(2) == 0);
        }
        CarCount++;
    }
    
    public IReadOnlyDictionary<Part,bool> CarParts => _carParts;
    
}