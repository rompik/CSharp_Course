using HomeWork4;
using HomeWork4.Animals;
using HomeWork4.Core;
using HomeWork4.Staff;


Monkey animal1 = new Monkey { };
Rabbit animal2 = new Rabbit { };
Tiger animal3 = new Tiger { };
Wolf animal4 = new Wolf { };
Wolf animal5 = new Wolf { };

Zoo zoo = new Zoo();
Manager manager = new Manager();

zoo.Animals.CollectionChanged += zoo.Animals_CollectionChanged;

void DisplayMessage(Animal sender, AnimalEventArgs e)
{
    Console.WriteLine($"{sender.Number} - {sender.GetType().Name} - {sender.Health}% - {e.Message}");
}

zoo.Add(animal1);
animal1.Notify += new Animal.HungryHandler(DisplayMessage);
animal1.Notify += DisplayMessage;

zoo.Add(animal2);
animal2.Notify += new Animal.HungryHandler(DisplayMessage);
animal2.Notify += DisplayMessage;

zoo.Add(animal3);
animal3.Notify += new Animal.HungryHandler(DisplayMessage);
animal3.Notify += DisplayMessage;

zoo.Add(animal4);
animal4.Notify += new Animal.HungryHandler(DisplayMessage);
animal4.Notify += DisplayMessage;

zoo.Add(animal5);
animal5.Notify += new Animal.HungryHandler(DisplayMessage);
animal5.Notify += DisplayMessage;

Console.WriteLine($"---------------------------");
Console.WriteLine($"Number - Animal - Health, %");
foreach (Animal animal in zoo.Animals)
{
    animal.IsHungry();
}
