namespace Task_8;

public class Storage
{
    private Dictionary<PartType, int> _parts = new()
    {
        [PartType.Brakes] = RandomClass.Random.Next(1, 5),
        [PartType.Suspension] = RandomClass.Random.Next(1, 5),
        [PartType.Engine] = RandomClass.Random.Next(1, 5),
        [PartType.Filter] = RandomClass.Random.Next(1, 5),
        [PartType.Wheel] = RandomClass.Random.Next(1, 5),
    };

    public IReadOnlyDictionary<PartType, int> Parts => _parts;

    public void TakePart(PartType part)
    {
        if (_parts[part] > 0 && part != null)
        {
            _parts[part] -= 1;
        }
        else
        {
            Console.WriteLine("Недостаточно частей на складе");
        }
    }
}