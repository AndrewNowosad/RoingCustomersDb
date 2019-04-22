using RoingCustomersDb.BL;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace RoingCustomersDb.UI.ViewModels
{
    class MainVM : VM
    {
        private readonly ICustomerRepository customerRepository;

        public MainVM(ICustomerRepository customerRepository)
        {
            if (customerRepository is null)
                throw new ArgumentNullException(nameof(ICustomerRepository));

            this.customerRepository = customerRepository;

            // TODO: вынести инициализацию отдельным шагом
            LoadCustomersAsync();
        }

        private bool isLoading;
        public bool IsLoading
        {
            get => isLoading;
            set => Set(ref isLoading, value);
        }

        private ObservableCollection<CustomerVM> customers;
        public ObservableCollection<CustomerVM> Customers
        {
            get => customers;
            set => Set(ref customers, value);
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
    }
}
