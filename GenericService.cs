using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AzadiSoft.ProjectTemplate.DataLayer;

namespace AzadiSoft.ProjectTemplate.ServiceLayer
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        public IUnitOfWork UnitOfWork { get; }

        public DbSet<TEntity> DbSet { get; }

        public GenericService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;

            DbSet = unitOfWork.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return DbSet.AsQueryable();
        }

        public IQueryable<TEntity> GetAllQueryable(Expression<Func<TEntity, bool>> expression = null)
        {
            if (expression != null)
            {
                return GetAll().Where(expression).AsQueryable();
            }
            else
            {
                return GetAll();
            }
        }

        public TEntity GetById(object id)
        {
            var entity = DbSet.Find(id);

            return entity;
        }

        public TEntity Insert(TEntity entity)
        {
            DbSet.Add(entity);

            SaveChanges();

            return entity;
        }

        public void Delete(TEntity entity, bool saveChanges = true)
        {
            DbSet.Remove(entity);

            if (saveChanges)
            {
                SaveChanges();
            }
        }

        public void DeleteById(object id)
        {
            var entity = GetById(id);

            Delete(entity);
        }

        public TEntity Update(TEntity entity)
        {
            var entry = UnitOfWork.Entry(entity);

            entry.State = EntityState.Modified;

            SaveChanges();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var entry = UnitOfWork.Entry(entity);

            entry.State = EntityState.Modified;

            await UnitOfWork.SaveChangesAsync();

            return entity;
        }

        private void SaveChanges()
        {
            UnitOfWork.SaveChanges();
        }
    }
}