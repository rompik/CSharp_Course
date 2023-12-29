namespace HomeWork2
{
    public class Dog : Animal
    {
        public Dog(int age) : base(age) { }

        public override void Say()
        {
            Console.WriteLine("Гав");

        }
    }

}
