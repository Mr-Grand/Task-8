namespace Task_8;

public class Part
{
    protected static Random Random = new Random();
    public virtual string Name { get; } = "Part";
    public double Price { get; } = Math.Round((Random.Next(1,50) + Random.NextDouble()),2);
    
    public override bool Equals(object obj)
    {
        if (obj is not Part other)
            return false;

        return this.Name == other.Name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name);
    }

}