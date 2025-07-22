namespace Task_8;

public class Storage
{
    private static readonly Random random = new Random();
    private Dictionary<Part, int> _parts = new Dictionary<Part, int>
    {
        [new Part1()] = random.Next(1, 5),
        [new Part2()] = random.Next(1, 5),
        [new Part3()] = random.Next(1, 5),
        [new Part4()] = random.Next(1, 5),
        [new Part5()] = random.Next(1, 5),
    };

    public void ShowStoredParts()
    {
        foreach (var part in _parts)
        {
            Console.WriteLine($"Деталь: {part.Key.Name}. Количество: {part.Value}." +
                              $" Цена - {part.Key.Price}");
        }
    }
}