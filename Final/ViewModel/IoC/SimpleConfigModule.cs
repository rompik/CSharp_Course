using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.IoC
{
    public class SimpleConfigModule : NinjectModule
    {
        public override void Load() {

            Bind<IRepository<MyTask>>().To<EFRepository<MyTask>>().InSingletonScope();

            Bind<MainViewModel>().ToSelf.InSingletonScope();
            Bind<EditViewModel>().ToSelf.InSingletonScope();
            Bind<CreateNewViewModel>().ToSelf.InSingletonScope();


        }
    }
}
