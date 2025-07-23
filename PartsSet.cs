namespace Task_8;

public class PartsSet
{
    private List<Part> _parts = new List<Part>()
    {
        new Part1(),
        new Part2(),
        new Part3(),
        new Part4(),
        new Part5()
    };
    
    public IReadOnlyList<Part> Parts => _parts;
}