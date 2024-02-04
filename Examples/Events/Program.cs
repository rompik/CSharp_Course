namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Counter counter = new Counter();
            Handler_I handler1 = new Handler_I();
            Handler_II handler2 = new Handler_II();

            counter.OnCount += handler1.Message;
            counter.OnCount += handler2.Message;

            counter.Count();

        }

    }

    class Counter
    {

        public delegate void MethodCount();

        public event MethodCount OnCount;

        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i == 71)
                {
                    if (OnCount != null)
                    {
                        OnCount();
                    }
                }
            }
        }
    }

    class Handler_I
    {
        public void Message()
        {
            Console.WriteLine("Пора начинать, уже 71");
        }
    }

    class Handler_II
    {
        public void Message()
        {
            Console.WriteLine("Точно, уже 71");
        }
    }
}
