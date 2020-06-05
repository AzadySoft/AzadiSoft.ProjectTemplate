using AzadiSoft.ProjectTemplate.DataLayer;
using AzadiSoft.ProjectTemplate.DomainClasses;

namespace AzadiSoft.ProjectTemplate.ServiceLayer
{
    public class Category_Service : GenericService<Category>, ICategory_Service
    {
        public Category_Service(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}