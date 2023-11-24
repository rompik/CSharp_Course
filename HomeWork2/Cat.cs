namespace HomeWork2
{
    public class Cat : Animal
    {
        public Cat(int age) : base(age) { }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
