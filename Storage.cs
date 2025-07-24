namespace Task_8;

public class Storage
{
    
    private Dictionary<PartType, int> _parts = new()
    {
        [PartType.Brakes] = RandomClass.Random.Next(1,11),
        [PartType.Suspension] = RandomClass.Random.Next(1,11),
        [PartType.Engine] = RandomClass.Random.Next(1,11),
        [PartType.Filter] = RandomClass.Random.Next(1,11),
        [PartType.Wheel] = RandomClass.Random.Next(1,11),
        [PartType.Oil] = RandomClass.Random.Next(1,11)
    };

    public void ShowStoredParts()
    {
        foreach (var part in _parts)
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