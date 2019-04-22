using RoingCustomersDb.DA;
using RoingCustomersDb.UI.ViewModels;
using System.Windows;

namespace RoingCustomersDb.UI
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var repo = EFCustomerRepository.Create();
            var vm = new MainVM(repo);
            var view = new MainWindow { DataContext = vm };
            view.Show();
        }
    }
}
