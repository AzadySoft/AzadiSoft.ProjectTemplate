using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AzadiSoft.ProjectTemplate.DataLayer;

namespace AzadiSoft.ProjectTemplate.ServiceLayer
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        IUnitOfWork UnitOfWork { get; }

        DbSet<TEntity> DbSet { get; }

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetAllQueryable(Expression<Func<TEntity, bool>> expression = null);

        TEntity GetById(object id);

        TEntity Insert(TEntity entity);

        void Delete(TEntity entity, bool saveChanges = true);

        void DeleteById(object id);

        TEntity Update(TEntity updatedEntity);

        Task<TEntity> UpdateAsync(TEntity updatedEntity);
    }
}
