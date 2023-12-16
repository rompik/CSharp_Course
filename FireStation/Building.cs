using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireStation
{
    public class Building
    {
        private readonly Area _address;

        public Building(Area area)
        {
            _address = area;
        }

        public event FireHandler Fire;

        public void OnFire()
        {
            Console.WriteLine( "Fire" + _address );

            Fire?.Invoke( _address );
        }
    }
}
