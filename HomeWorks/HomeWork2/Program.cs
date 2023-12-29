namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int сhoosedAnimal = 1;
            int animalAge = 0;
            string animalName = "";


            Console.WriteLine("Добро пожаловать в магазин животных! Какое животное Вы хотите приобрести:");
            Console.WriteLine("(1) - кошку");
            Console.WriteLine("(2) - собаку");

            сhoosedAnimal = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Какого возраста?");

            animalAge = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Как Вы планируете назвать питомца?");

            animalName = Console.ReadLine();

            if (сhoosedAnimal == 1)
            {
                Cat animal = new(animalAge);

                animal.Name = animalName;

                AnimalCare(animal);

                Console.WriteLine($"RIP");
                Console.WriteLine($"Кот: {animal.Name}");
                Console.WriteLine($"Возраст: {animal.Age}");
                Console.Write("Последнее слово: ");
                animal.Say();
            }

            else
            {
                Dog animal = new(animalAge);

                animal.Name = animalName;

                AnimalCare(animal);

                Console.WriteLine($"RIP");
                Console.WriteLine($"Пес: {animal.Name}");
                Console.WriteLine($"Возраст: {animal.Age}");
                Console.Write("Последнее слово: ");
                animal.Say();

            }

            Console.ForegroundColor = ConsoleColor.Gray;


            void AnimalCare(Animal animal)
            {

                while (animal.Health > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Console.WriteLine("Покормить (1) или наказать (2)");

                    if (Convert.ToInt16(Console.ReadLine()) == 1)
                    {
                        Console.WriteLine("Сколько еды дать питомцу?");

                        animal.Feed(Convert.ToInt16(Console.ReadLine()));
                    }

                    else
                    {
                        Console.WriteLine("Насколько сильно наказать питомца?");
                        animal.Punish(Convert.ToInt16(Console.ReadLine()));
                    }

                    Console.Write("Текущий уровень здоровья - ");
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), animal.Color);
                    Console.WriteLine($"{animal.Health}");

                }

                Console.WriteLine("Вы слишком сильно наказали своего питомца и он умер!");
                Console.WriteLine(" ");

                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
