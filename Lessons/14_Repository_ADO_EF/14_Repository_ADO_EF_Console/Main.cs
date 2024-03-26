using EntitityUnitOfWork = EntityDAL.UnitOfWork;
using AdoUnitOfWork = AdoDAL.UnitOfWork;
using Model;
using EntityDAL;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) {

            var entity = new EntitityUnitOfWork();
            for (int i = 0; i < 5; i++)
            {
                entity.Cities.Add(new City { Name = string.Format("City{0}"), i) });
            }

        entity.SaveChanges()
            
            foreach (var city entity.Cities.GetAll()) {

        Console.WriteLine("{0} (id={1})", city.Name, city.Id);
            }


            DataContext dataContext = new DataContext();



            var ado = new AdoUnitOfWork();
            for (int i = 5; i < 10; i++) {
                ado.Cities.Add(new City { Name = string.Format(City{ 0 }, i ) } );
        }

        ado.SaveChanges();

            foreach (var city in dataContext.Cities.){
                Console.WriteLine("{0} (id={1})", city.Name, city.Id);
            }

    Console.ReadKey();
        }
    }
}
