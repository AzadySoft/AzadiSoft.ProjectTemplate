using AzadiSoft.ProjectTemplate.DataLayer;
using AzadiSoft.ProjectTemplate.DomainClasses;

namespace AzadiSoft.ProjectTemplate.ServiceLayer
{
    public class Order_Service : GenericService<Order>, IOrder_Service
    {
        public Order_Service(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}