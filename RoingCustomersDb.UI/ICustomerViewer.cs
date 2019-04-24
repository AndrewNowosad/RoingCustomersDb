using RoingCustomersDb.UI.ViewModels;

namespace RoingCustomersDb.UI
{
    public interface ICustomerViewer
    {
        bool ShowCustomer(CustomerVM customer);
    }
}
