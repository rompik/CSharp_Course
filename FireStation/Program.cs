using System.Collections.ObjectModel;

namespace FireStation
{
    public enum Area 
    { 
        Center, Suburban
    }

    public delegate void FireHandler(Area address);

    internal class Program
    {
        static void Main(string[] args)
        {
            var city = new City();
            
            city.Add(new Building( Area.Center ));

            city.StartFire();
        }
    }
}
