using HomeWork4.Core;

namespace HomeWork4
{
    public class Zoo
    {

        //Инвентарный список животных
        private List<Predator> list_of_predators = new List<Predator>();
        private List<Herbo> list_of_herbos = new List<Herbo>();

        //Инвентарный список офисных вещей
        private List<Thing> list_of_things = new List<Thing>();

        //Метод регистрации нового элемента
        public void Register(IInventory element)
        {
            //   Console.WriteLine($"tests {element.GetType().FullName}");
            //Проверяем тип элемента и решаем в какой список его закинуть
            switch (element.GetType().BaseType.Name)
            {
                case "Herbo":
                    list_of_herbos.Add((Herbo)element);
                    break;
                case "Predator":
                    list_of_predators.Add((Predator)element);
                    break;
                case "Thing":
                    list_of_things.Add((Thing)element);
                    break;
            }
        }

        public void Unregister(IInventory element)
        {
            switch (element.GetType().BaseType.Name)
            {
                case "Herbo":
                    list_of_herbos.Remove((Herbo)element);
                    break;
                case "Predator":
                    list_of_predators.Remove((Predator)element);
                    break;
                case "Thing":
                    list_of_things.Remove((Thing)element);
                    break;
            }
        }

        public void PrintInventoryList()
        {
            int index = 1;
            Console.WriteLine("Инвентарный список зоопарка");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("| Травоядные животные              |");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("№ - Тип - Здоровье - Доброта");

            foreach (Herbo item in list_of_herbos)
            {
                Console.WriteLine($"{index} - {item.GetType().Name} - {item.Health} - {item.Kindness}");
                index = index + 1;
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Хищные животные                    |");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("№ - Тип - Здоровье - Еда");

            foreach (Predator item in list_of_predators)
            {
                Console.WriteLine($"{index} - {item.GetType().Name} - {item.Health} - {item.Meals}");
                index = index + 1;
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Оборудование                       |");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("№ - Тип");

            foreach (Thing item in list_of_things)
            {
                Console.WriteLine($"{index} - {item.GetType().Name}");
                index = index + 1;
            }


        }
    }
}
