namespace HomeWork4.Core
{
    public abstract class Thing : IInventory
    {
        Random rnd = new Random();
        public int Number { get; set; }
        public int Health { get; set; }
        public Thing()
        {
            this.Number = rnd.Next(1, 100);
            this.Health = rnd.Next(0, 100);
        }

    }
}
