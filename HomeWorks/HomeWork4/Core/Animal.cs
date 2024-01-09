namespace HomeWork4.Core
{
    public abstract class Animal : IInventory, IAlive
    {

        Random rmd = new Random();

        public int Health { get; set; }
        public int Number { get; set; }

        public Animal()
        {
            this.Health = rmd.Next(-1, 100);

        }

    }
}
