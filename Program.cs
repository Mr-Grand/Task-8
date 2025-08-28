namespace Task_8;

class Program
{
    static void Main(string[] args)
    {
        Storage storage = new Storage();
        CarService carService = new CarService();
        List<Car> waitingCars = new List<Car>();
        waitingCars = GenerateCars();

        MachineMaintence(waitingCars, storage, carService);
    }

    private static void ShowStoredParts(Storage storage)
    {
        foreach (var part in storage.Parts)
        {
            Console.WriteLine($"Деталь: {part.Key}. Количество: {part.Value}");
        }
    }

    private static List<Car> GenerateCars()
    {
        List<Car> cars = new List<Car>();
        Console.WriteLine("Генерируются автомобили...");
        Thread.Sleep(1000);
        int carNumber = RandomClass.Random.Next(3, 10);
        for (int i = 0; i < carNumber; i++)
        {
            cars.Add(new Car());
        }

        Console.WriteLine($"В очереди {cars.Count} автомобилей");
        return cars;
    }

    private static void MachineMaintence(List<Car> waitingCars, Storage storage, CarService carService)
    {
        while (waitingCars.Count > 0)
        {
            Console.WriteLine($"\nВот детали на складе:");
            ShowStoredParts(storage);

            double repairPrice = 0;
            Console.WriteLine("\nПриехала машина! Вот её поломки:");
            foreach (var part in waitingCars[0].CarParts)
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

            int choice = ReadMenu();

            if (choice == 1)
            {
                foreach (var part in waitingCars[0].CarParts)
                {
                    if (!part.Value && storage.Parts[part.Key] != 0)
                    {
                        carService.PartRepaired(part.Key);
                        storage.TakePart(part.Key);
                    }
                    else if (!part.Value && storage.Parts[part.Key] == 0)
                    {
                        carService.PayFinePerPart();
                    }
                }
            }
            else
            {
                carService.PayFine();
            }

            MoneyStatus(carService);

            Console.ReadKey();
            waitingCars.RemoveAt(0);
            Console.Clear();
        }
    }

    private static int ReadMenu()
    {
        while (true)
        {
            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.D1) return 1;
            if (key == ConsoleKey.D2) return 2;
            Console.WriteLine("Введите корректное значение");
        }
    }

    private static void MoneyStatus(CarService carService)
    {
        Console.WriteLine();
        if (carService.EarnedMoney > 0)
        {
            Console.WriteLine($"Заработано {carService.EarnedMoney} денег");
        }
        else
        {
            Console.WriteLine($"В минусе на {carService.EarnedMoney}");
        }
    }
}