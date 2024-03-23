using HomeWork4.Core;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace HomeWork4
{
    public class Zoo
    {
        private ObservableCollection<Animal> Animals = new ObservableCollection<Animal>();

        public void Animals_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    if (e.NewItems?[0] is Animal newAnimal)
                    {
                        Console.WriteLine($"Новое животное принято.");
                    }
                    break;

                case NotifyCollectionChangedAction.Remove:
                    if (e.NewItems?[0] is Animal oldAnimal)
                    {
                        Console.WriteLine($"Животное передали в другой зоопарк - {oldAnimal.GetType().Name}.");
                    }
                    break;
            }
        }

        public void Add(Animal animal)
        {

            if (animal.Health <= 50)
            {
                Console.WriteLine($"Привезли новое животное - {animal.GetType().Name}. Ветклиника: животное не принято, оно больное.");
            }

            else
            {
                Console.WriteLine($"Привезли новое животное - {animal.GetType().Name}. Ветклиника: животное принято, оно здоровое.");
                Animals.Add(animal);
            }
        }

        public void Remove(Animal animal)
        {
            Animals.Remove(animal);
            Console.WriteLine("Животное переведено в другой зоопарк.");
        }
    }
}