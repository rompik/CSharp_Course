namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IThing> thing = new List<IThing>
            {
                new Pen(),
                new Crisps(){ },
                new BalykCheese(){ },
                new ChocolateBar(){ }
            };
            Market market = new Market(thing);

            market.Cart.Foods.Add(new BalykCheese() { });
            market.Cart.Foods.Add(new ChocolateBar() { });

            Print(market.Cart.Foods);

            market.Cart.CartBalansing();

            Console.WriteLine("+++++++++++++++++++++++++++++++");

            Print(market.Cart.Foods);

        }

        public static void Print<T>(List<T> things) where T : IThing
        {
            foreach (T thing in things)
            {
                Console.WriteLine(thing.Title);
            }
        }
    }

    public interface IThing
    {
        string Title { get; set; }
    }
    public abstract class NotFood : IThing
    {
        public string Title { get; set; }
    }
    public class Pen : NotFood
    {
    }
    public class NoteBook : NotFood
    {
    }

    public interface IFood : IThing
    {
        bool IsProteins { get; set; }
        bool IsFat { get; set; }
        bool IsCarbo { get; set; }
    }

    public abstract class Snacks : IFood
    {
        public string Title { get; set; } = string.Empty;
        public bool IsProteins { get; set; }
        public bool IsFat { get; set; }
        public bool IsCarbo { get; set; }
    }

    public class ChocolateBar : Snacks
    {
        public ChocolateBar() { IsCarbo = true; }
    }
    public class Crisps : Snacks
    {
        public Crisps() { IsFat = true; }
    }
    public class BalykCheese : Snacks
    {
        public BalykCheese() { IsProteins = true; }
    }

    public abstract class SemiFinishedFood : IFood
    {
        public string Title { get; set; } = string.Empty;
        public bool IsProteins { get; set; }
        public bool IsFat { get; set; }
        public bool IsCarbo { get; set; }
    }

    public abstract class HelthyFood : IFood
    {
        public string Title { get; set; } = string.Empty;
        public bool IsProteins { get; set; }
        public bool IsFat { get; set; }
        public bool IsCarbo { get; set; }
    }
    //+++++++++++++++++++++++++++++++++++++++++++

    public class Market
    {
        public List<IThing> Things { get; }
        public Cart<IFood> Cart { get; set; }

        public Market(List<IThing> things)
        {
            Things = things;
            Cart = new Cart<IFood>(Things);
        }
    }

    public class Cart<T> where T : IFood
    {
        private List<IThing> _things;
        public List<T> Foods { get; set; }
            = new List<T>();

        public Cart(List<IThing> things)
        {
            _things = things;
        }

        public void CartBalansing()
        {
            (bool IsPrteins, bool IsFats, bool IsCarbo) bufer;
            bufer.IsPrteins = bufer.IsFats = bufer.IsCarbo = false;

            foreach (T food in Foods)
            {
                if (food.IsFat) { bufer.IsFats = true; }
                if (food.IsCarbo) { bufer.IsCarbo = true; }
                if (food.IsProteins) { bufer.IsPrteins = true; }
            }

            if (bufer.IsFats && bufer.IsCarbo && bufer.IsPrteins) return;

            foreach (IThing thing in _things)
            {
                if (thing is T curentFood)
                {
                    if (curentFood.IsCarbo && !bufer.IsCarbo)
                    {
                        Foods.Add(curentFood);
                        bufer.IsCarbo = true;
                    }

                    else if (curentFood.IsFat && !bufer.IsFats)
                    {
                        Foods.Add(curentFood);
                        bufer.IsFats = true;
                    }

                    else if (curentFood.IsProteins && !bufer.IsPrteins)
                    {
                        Foods.Add(curentFood);
                        bufer.IsPrteins = true;
                    }

                    if (bufer.IsFats && bufer.IsCarbo && bufer.IsPrteins) return;
                }
            }
        }
    }

}