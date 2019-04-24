using RoingCustomersDb.BL;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace RoingCustomersDb.UI.ViewModels
{
    public class MainVM : VM
    {
        private readonly ICustomerRepository customerRepository;
        private readonly ICustomerViewer customerViewer;

        private bool isLoading;
        public bool IsLoading
        {
            get => isLoading;
            set => Set(ref isLoading, value);
        }

        private CustomerVM selectedCustomer;
        public CustomerVM SelectedCustomer
        {
            get => selectedCustomer;
            set
            {
                if (Set(ref selectedCustomer, value))
                {
                    UpdateCustomerCommand.RaiseCanExecuteChanged();
                    RemoveCustomerCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private ObservableCollection<CustomerVM> customers;
        public ObservableCollection<CustomerVM> Customers
        {
            get => customers;
            set => Set(ref customers, value);
        }

        public SimpleCommand AddCustomerCommand { get; }
        public SimpleCommand UpdateCustomerCommand { get; }
        public SimpleCommand RemoveCustomerCommand { get; }

        public MainVM(ICustomerRepository customerRepository, ICustomerViewer customerViewer)
        {
            if (customerRepository is null)
                throw new ArgumentNullException(nameof(customerRepository));
            if (customerViewer is null)
                throw new ArgumentNullException(nameof(customerViewer));

            this.customerRepository = customerRepository;
            this.customerViewer = customerViewer;

            AddCustomerCommand = new SimpleCommand(AddCustomerAsync);
            UpdateCustomerCommand = new SimpleCommand(UpdateCustomerAsync, () => SelectedCustomer != null);
            RemoveCustomerCommand = new SimpleCommand(RemoveCustomerAsync, () => SelectedCustomer != null);

            // TODO: вынести инициализацию отдельным шагом
            LoadCustomersAsync();
        }

        private async void LoadCustomersAsync()
        {
            IsLoading = true;
            var customersFromRepo = await customerRepository.GetCustomersAsync();
            var customers = new ObservableCollection<CustomerVM>(
                customersFromRepo.Select(c => new CustomerVM(c)));
            Customers = customers;
            IsLoading = false;
        }

        private async void AddCustomerAsync()
        {
            IsLoading = true;

            IsLoading = false;
        }

        private async void UpdateCustomerAsync()
        {
            IsLoading = true;

            IsLoading = false;
        }

        private async void RemoveCustomerAsync()
        {
            IsLoading = true;

            IsLoading = false;
        }
    }
}
