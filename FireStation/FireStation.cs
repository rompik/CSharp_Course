using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireStation
{
    public class FireStation
    {
        public Area area;

        public void OnFire(Area address)
        {
            if (address == area)
            {
                Console.WriteLine("Go " + address);
            }
            else
            {
                Console.WriteLine("Sorry");
            }

        }
    }
}
