namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int carsNumber = 10;
            //int clientsNumber = 7;

            FactoryAF factory = new();

            List<Customer> customers = new();
            customers.Add(new Customer("Петров А.В.") { });
            customers.Add(new Customer("Иванов А.В.") { });
            customers.Add(new Customer("Васильев А.В.") { });
            customers.Add(new Customer("Ильин А.В.") { });
            customers.Add(new Customer("Дятлов А.В.") { });
            customers.Add(new Customer("Борисов Е.В.") { });
            customers.Add(new Customer("Аксель В.П.") { });

            factory.Customers = customers;

            Console.WriteLine("Информационная система учета педальных автомобилей");
            Console.WriteLine("");
            Console.WriteLine($"На складе имеется {carsNumber} автомобилей:");
            for (int i = 0; i < carsNumber; i++)
            {
                factory.AddCar();
                Console.WriteLine($"Автомобиль {factory.Cars[i].Number}");
            }

            Console.WriteLine("");

            Console.WriteLine($"В очереди на авто {customers.Count} клиентов:");
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"Клиент {customers[i].FIO}");
            }

            factory.SaleCar();

            Console.WriteLine("");
            Console.WriteLine("Результаты распродажи:");
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"Клиент {customers[i].FIO} получил машину номер {customers[i].Car.Number}");
            }

            Console.WriteLine("");
            Console.WriteLine($"Остась машин {factory.Cars.Count}");
        }
    }
}
