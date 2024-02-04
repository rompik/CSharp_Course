using Model.BL;
using Model.DAL;
using Model.Model;
using Ninject;
using Ninject.Modules;
using Presenter;

namespace View1
{
    internal static class Program
    {
        public static IKernel? NinlectKernel { set; get; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {           
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            NinlectKernel = new StandardKernel(new SimpleConfigModule());


            //IMainView form1 = NinlectKernel.Get<IMainView>();
            //IMainModel model = NinlectKernel.Get<IMainModel>();
            MainPresenter presenter = NinlectKernel.Get<MainPresenter>();
        }
    }

    class SimpleConfigModule : NinjectModule
    {
        public override void Load()
        {

            Bind<IMainView>().To<Form1>().InSingletonScope();
            Bind<IMainModel>().To<MainModel>().InSingletonScope();
            //Bind<IRepository<Employee>>().To<FakeRepository<Employee>>().InSingletonScope();
            //Bind<IRepository<Employee>>().To<EFRepository<Employee>>().InSingletonScope();
            Bind<IRepository<Employee>>().To<DapperRepositiry<Employee>>().InSingletonScope();

        }


    }
}