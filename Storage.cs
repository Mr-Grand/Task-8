namespace Task_8;

public class Storage
{
    private static readonly Random Random = new();
    private Dictionary<PartType, int> _parts = new()
    {
        [PartType.Brakes] = Random.Next(1,11),
        [PartType.Suspension] = Random.Next(1,11),
        [PartType.Engine] = Random.Next(1,11),
        [PartType.Filter] = Random.Next(1,11),
        [PartType.Wheel] = Random.Next(1,11),
        [PartType.Oil] = Random.Next(1,11)
    };

    public void ShowStoredParts()
    {
        foreach (var part in _parts)
        {
            Console.WriteLine($"Деталь: {part.Key.Name}. Количество: {part.Value}." +
                              $" Цена - {part.Key.Price}");
        }
    }
    
    public IReadOnlyDictionary<Part, int> Parts => _parts;

    public void TakePart(Part part)
    {
        _parts[part] -= 1;
    }
}