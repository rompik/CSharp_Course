//using System.Diagnostics.Contracts;

//namespace _14_Repository_Dapper_Console
//{
//    interface IPrinter {
//        void Print(string text);
//    }

//    class Book
//    {
//        public string Text { get; set; }
//        public IPrinter Printer { get; set; }

//        public Book(IPrinter printer)
//        {
//            this.Printer = printer;
//        }

//        public void Print() {
//            Printer.Print(Text);
//        }
//    }

//    class ConsolePrinter : IPrinter
//    {
//        public void Print(string text)
//        {
//            Console.WriteLine(text);
//        }
//    }


//    class HtmlPrinter : IPrinter
//    {

//        public void Print(string text)
//        {
//            Console.WriteLine("Печать в консоли");
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            Book book = new Book(new ConsolePrinter());
//            book.Print();

//            book.Printer = new HtmlPrinter();
//            book.Print();
//        }
//    }
//}

using Ninject;
using Ninject.Modules;

namespace _14_Repository_Dapper_Console
{

    internal class Program
    {
        static void Main(string[] args)
        {
            IKernel ninjectKernel = new StandardKernel(new SimpleConfigMobile());

            ItemViever1 itemViewer1 = ninjectKernel.Get<ItemViever1>();
            itemViewer1.Repository.AddItem(new Item { SomeProperty = "Item 1" });
            foreach (var item in itemViewer1.Repository.GetAllItems()) {
                Console.WriteLine(item.SomeProperty);
            }

            Console.WriteLine();

            ItemViever2 itemViewer2 = ninjectKernel.Get<ItemViever2>();
            itemViewer2.Repository.AddItem(new Item { SomeProperty = "Item 2" });
            foreach (var item in itemViewer2.Repository.GetAllItems())
            {
                Console.WriteLine(item.SomeProperty);
            }
        }
    }

    //DAL
    interface IRepository
    {
        List<Item> GetAllItems();
        void DeleteItem(Item item);
        void AddItem(Item item);
    }

    class MemoryRepository : IRepository
    {
        private List<Item> items { get; set; } = new List<Item>();
        public void AddItem(Item item) {
            items.Add(item);
        }
        public void DeleteItem(Item item) {
            items.Remove(item);
        }

        public List<Item> GetAllItems() {
            return items;
        }
    }

    //Domain 

    public class Item {
        public string SomeProperty { get; set; }
    }

    //BL

    class ItemViever1 {
        public IRepository Repository { get; set; }
        public ItemViever1(IRepository repository) {
            Repository = repository;
        }
        public List<Item> RenderItems()
        {
            return Repository.GetAllItems();
        }
    }

    class ItemViever2
    {
        public IRepository Repository { get; set; }
        public ItemViever2(IRepository repository)
        {
            Repository = repository;
        }
        public List<Item> RenderItems()
        {
            return Repository.GetAllItems();
        }
    }

    class SimpleConfigMobile : NinjectModule { 
        public override void Load()
        {
            Bind<IRepository>().To<MemoryRepository>().InSingletonScope();
        }
    }
}