using AzadiSoft.ProjectTemplate.DataLayer;
using AzadiSoft.ProjectTemplate.DomainClasses;

namespace AzadiSoft.ProjectTemplate.ServiceLayer
{
    public class Product_Service : GenericService<Product>, IProduct_Service
    {
        public Product_Service(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}