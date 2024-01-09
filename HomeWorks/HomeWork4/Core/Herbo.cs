namespace HomeWork4.Core
{
    public class Herbo : Animal
    {
        Random rmd = new Random();

        public int Kindness { get; }

        public Herbo()
        {
            this.Kindness = rmd.Next(0, 100);

        }
    }
}
