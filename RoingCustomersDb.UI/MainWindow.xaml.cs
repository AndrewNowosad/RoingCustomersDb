using System.Windows;
using RoingCustomersDb.UI.ViewModels;

namespace RoingCustomersDb.UI
{
    public partial class MainWindow : Window, ICustomerViewer
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public bool ShowCustomer(CustomerVM customer)
        {
            var customerWindow = new CustomerWindow { DataContext = customer };
            return customerWindow.ShowDialog() == true;
        }
    }
}
