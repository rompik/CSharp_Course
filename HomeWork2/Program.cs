namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в магазин животных! Какое животное Вы хотите приобрести: кошку (1) или собаку (2)");
            int ChoosedAnimal = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Какой возраст животного?");
            int AnimalAge = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Как хотите назвать питомца?");
            string AnimalName = Console.ReadLine();

            int AnimalAction = 1;

            if (ChoosedAnimal == 1)
            {
                Dog dog = new(AnimalAge);
                dog.Name = AnimalName;


                while (dog.Health > 0)
                {
                    Console.WriteLine("Покормить (1) или наказать (2)");
                    AnimalAction = Convert.ToInt16(Console.ReadLine());
                    if (ChoosedAnimal == 1)
                    {
                        dog.Feed(5);
                    }
                    else
                    {
                        dog.Punish(10);
                    }
                    Console.WriteLine($"Текущее уровень здоровья - {dog.Health}");
                }
            }
        }
    }
}
