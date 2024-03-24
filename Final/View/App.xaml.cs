using System.Configuration;
using System.Data;
using System.Windows;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ViewModelManager.Instance.ViewModelShow += ViewManager.ViewShow;
            ViewModelManager.Instance.ViewModelClose += ViewManager.ViewClose;
            ViewModelManager.Instance.ShowMessage += ViewManager.ShowMessageUI();

            var ninjectKernel = new StandardKernel(new SimpleConfigModule());

            var mainViewModel = ninjectKernel.Get<MainViewModel>();

            ViewModelManager.Instance.OnViewModelShow(mainViewModel);

        }
    }
}
