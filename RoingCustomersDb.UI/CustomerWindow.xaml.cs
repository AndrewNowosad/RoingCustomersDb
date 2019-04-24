using System.Windows;

namespace RoingCustomersDb.UI
{
    public partial class CustomerWindow : Window
    {
        public CustomerWindow()
        {
            InitializeComponent();
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
