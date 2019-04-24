using RoingCustomersDb.DA;
using RoingCustomersDb.UI.ViewModels;
using System.Globalization;
using System.Windows;
using System.Windows.Markup;

namespace RoingCustomersDb.UI
{
    public partial class App : Application
    {
        public App()
        {
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement),
                new FrameworkPropertyMetadata(XmlLanguage.GetLanguage(
                    CultureInfo.CurrentUICulture.IetfLanguageTag)));
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var view = new MainWindow();
            var repo = EFCustomerRepository.Create();
            var vm = new MainVM(repo, view);
            view.DataContext = vm;
            view.Show();
        }
    }
}
