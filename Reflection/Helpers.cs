using Model;
namespace Helpers
{
    public class NamePrinter
    {
        public void Print(INamed p)
        {
            Console.WriteLine(p.Name);
        }
    }
}