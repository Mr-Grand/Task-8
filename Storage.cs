namespace Task_8;

public class Storage
{
    private Dictionary<PartType, int> _parts = new()
    {
        [PartType.Brakes] = RandomClass.Random.Next(1,5),
        [PartType.Suspension] = RandomClass.Random.Next(1,5),
        [PartType.Engine] = RandomClass.Random.Next(1,5),
        [PartType.Filter] = RandomClass.Random.Next(1,5),
        [PartType.Wheel] = RandomClass.Random.Next(1,5),
        [PartType.Oil] = RandomClass.Random.Next(1,5)
    };

    public void ShowStoredParts()
    {
        foreach (var part in Parts)
        {
            Console.WriteLine($"Деталь: {part.Key}. Количество: {part.Value}");
        }
    }
    
    public IReadOnlyDictionary<PartType, int> Parts => _parts;
    
    public void TakePart(PartType part)
    {
        _parts[part] -= 1;
    }
}