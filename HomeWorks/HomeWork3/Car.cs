namespace HomeWork3
{
    public class Car
    {
        static int number;
        public int Number { get; }
        public Engine Engine { get; }
        public Car()
        {
            Engine = new Engine();
            number++;
            this.Number = number;
        }
    }
}

