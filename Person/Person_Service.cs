using AzadiSoft.ProjectTemplate.DataLayer;
using AzadiSoft.ProjectTemplate.DomainClasses;

namespace AzadiSoft.ProjectTemplate.ServiceLayer
{
    public class Person_Service : GenericService<Person> , IPerson_Service
    {
        public Person_Service(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}