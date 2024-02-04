namespace HomeWork4.Core
{
    public abstract class Animal : IInventory, IAlive
    {

        Random rnd = new Random();
        public delegate void HungryHandler(Animal sender, AnimalEventArgs e);
        public event HungryHandler? Notify;

        public int Number { get; set; }

        public abstract string Meals { get; set; }

        public int Health { get; set; }

        public Animal()
        {
            this.Number = rnd.Next(1, 100);
            this.Health = rnd.Next(0, 100);
        }

        public void IsHungry()
        {
            if (this.Health < 80)
            {
                Notify?.Invoke(this, new AnimalEventArgs($"Я хочу есть!"));
            }
        }
    }

    public class AnimalEventArgs
    {
        public int Health { get; }
        public string Message { get; }
        public AnimalEventArgs(string message)
        {
            Message = message;
        }
    }

}
