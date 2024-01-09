using HomeWork4.Animals;
using HomeWork4.Office;

namespace HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            Tiger item1 = new Tiger();
            Table item2 = new Table();
            Rabbit item3 = new Rabbit();
            Monkey item4 = new Monkey();
            Wolf item5 = new Wolf();
            Table item6 = new Table();
            Rabbit item7 = new Rabbit();
            Table item8 = new Table();
            Monkey item9 = new Monkey();
            Table item10 = new Table();
            Computer item11 = new Computer();

            Zoo zoo = new Zoo();
            zoo.Register(item1);
            zoo.Register(item2);
            zoo.Register(item3);
            zoo.Register(item4);
            zoo.Register(item5);
            zoo.Register(item6);
            zoo.Register(item7);
            zoo.Register(item8);
            zoo.Register(item9);
            zoo.Register(item10);
            zoo.Register(item11);

            Console.WriteLine("Система управления зоопарком");

            zoo.PrintInventoryList();

        }
    }
}
