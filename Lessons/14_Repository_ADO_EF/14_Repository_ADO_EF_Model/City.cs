using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class City : IDomainObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Person> Persons { get; set; }
    }
}
