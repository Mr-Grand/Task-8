namespace Task_8;

class Program
{
    static void Main(string[] args)
    {
        Storage storage = new Storage();
        CarService carService = new CarService();

        Console.WriteLine("Генерируются автомобили...");
        Thread.Sleep(1000);
        int carNumber = RandomClass.Random.Next(3, 10);

        List<Car> cars = new List<Car>();
        for (int i = 0; i < carNumber; i++)
        {
            cars.Add(new Car());
        }

        Console.WriteLine($"В очереди {cars.Count} автомобилей");

        while (cars.Count > 0)
        {
            Console.WriteLine($"\nВот детали на складе:");
            storage.ShowStoredParts();

            double repairPrice = 0;
            Console.WriteLine("\nПриехала машина! Вот её поломки:");
            foreach (var part in cars[0].CarParts)
            {
                if (!part.Value)
                {
                    Console.WriteLine($"Сломаная деталь - {part.Key}");

                    repairPrice += PartsCatalog.Prices[part.Key] + carService.PaymentForWork;
                }
            }

            Console.WriteLine($"Цена за починку - {Math.Round(repairPrice, 2)}");
            Console.WriteLine("\nОбслуживаем машину?" +
                              "\n1) Да" +
                              "\n2) Нет");

            ConsoleKey input = Console.ReadKey().Key;

            switch (input)
            {
                case ConsoleKey.D1:
                    foreach (var part in cars[0].CarParts)
                    {
                        if (!part.Value && storage.Parts[part.Key] != 0)
                        {
                            carService.PartRepaired(part.Key);
                            storage.TakePart(part.Key);
                            // Можно добавить метод изменения состояния
                            // детали у машины. Но нужно ли?
                        }
                        else if (!part.Value && storage.Parts[part.Key] == 0)
                        {
                            carService.PayFinePerPart();
                        }
                    }

                    break;
                default:
                    carService.PayFine();
                    break;
            }


            Console.WriteLine();
            if (carService.EarnedMoney > 0)
            {
                Console.WriteLine($"Заработано {carService.EarnedMoney} денег");
            }
            else
            {
                Console.WriteLine($"В минусе на {carService.EarnedMoney}");
            }

            Console.ReadKey();
            cars.RemoveAt(0);
            Console.Clear();
        }
    }
}