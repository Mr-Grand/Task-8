namespace Task_8;

public class Car
{
   private Dictionary<PartType,bool> _carParts = new()
   {
       [PartType.Brakes] = RandomClass.Random.Next(2) == 0,
       [PartType.Suspension] = RandomClass.Random.Next(2) == 0,
       [PartType.Engine] = RandomClass.Random.Next(2) == 0,
       [PartType.Filter] = RandomClass.Random.Next(2) == 0,
       [PartType.Wheel] = RandomClass.Random.Next(2) == 0
   };
    
   public IReadOnlyDictionary<PartType,bool> CarParts => _carParts;
   
}