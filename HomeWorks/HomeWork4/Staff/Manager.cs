using HomeWork4.Core;

namespace HomeWork4.Staff
{
    public class Manager
    {
        public string Name { get; set; }

        public void Feed(Animal animal)
        {
            if (animal.Health < 100)
            {
                Console.WriteLine($"Текущий уровень {animal.Health} Животное голодное, надо покормить");
                animal.Health = 100;
                Console.WriteLine("Животное накормлено!");
            }
        }
    }
}
