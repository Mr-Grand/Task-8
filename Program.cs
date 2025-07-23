namespace Task_8;

class Program
{
    static void Main(string[] args)
    {
        Storage storage = new Storage();
        CarService carService = new CarService();
        
        
        for (int i = 0; i < 5; i++) // i - очередь автомобилей
        {
            Console.WriteLine("Here is your storage:");
            storage.ShowStoredParts();
            
            Car car = new Car();

            double priceForRepairing = 0;

            foreach (var carParts in car.CarParts)
            {
                if (!carParts.Value)
                {
                    Console.WriteLine($"Part {carParts.Key.Name} is broken");
                    priceForRepairing += carParts.Key.Price;
                }
            }

            Console.WriteLine($"Price for repairing: {Math.Round(priceForRepairing,2)}");
            Console.WriteLine("Do you want to repain?" +
                              "\n1) Yes" +
                              "\n2) No");

            ConsoleKey input = Console.ReadKey().Key;
            
            if (input == ConsoleKey.D1)
            {
                foreach (var carPart in car.CarParts)
                
                {
                    if (!carPart.Value && storage.Parts[carPart.Key] != 0)
                    {
                        storage.TakePart(carPart.Key);
                        carService.EarnedMoney += carPart.Key.Price;
                    }
                    else if (!carPart.Value && storage.Parts[carPart.Key] == 0)
                    {
                        carService.EarnedMoney -= carService.FinePerParts;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                carService.EarnedMoney -= carService.Fine;
                
            }
            
            Console.WriteLine($"Now we have {carService.EarnedMoney} money");
            Console.ReadLine();
            Console.Clear();
        }
    }
}