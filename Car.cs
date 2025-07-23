namespace Task_8;

public class Car
{
    
    
   private Dictionary<PartType,bool> _carParts = new()
   {
       [PartType.Brakes] = random.Next(2) == 0,
       [PartType.Suspension] = random.Next(2) == 0,
       [PartType.Engine] = random.Next(2) == 0,
       [PartType.Filter] = random.Next(2) == 0,
       [PartType.Wheel] = random.Next(2) == 0
   };
    
   
   
}