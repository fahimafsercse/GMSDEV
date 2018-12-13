using GMS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using GMS.Interface.IRepository;
using System.Data.Entity;

namespace GMS.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private GMSEntities context;
        //private DbSet<T> entities;
        string errorMessage = string.Empty;

        public virtual IQueryable<T> Table
        {
            get
            {
                return context.Set<T>();
            }
        }

        public Repository(GMSEntities context)
        {
            this.context = context;
        }
        public async Task<List<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }
        public async Task<T> Get(object id)
        {
            return await context.Set<T>().FindAsync(id);
        }
        public async Task<int> Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Set<T>().Add(entity);
            return await context.SaveChangesAsync();
        }

        public async Task<int> Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            return await context.SaveChangesAsync();
        }

        public async Task<int> Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.Set<T>().Remove(entity);
            return await context.SaveChangesAsync();
        }
        public async Task<int> Delete(object id)
        {
            var entity = context.Set<T>().Find(id);
            context.Set<T>().Remove(entity);
            return await context.SaveChangesAsync();
        }
        public IEnumerable<T> ExecWithStoreProcedure(string query, params object[] parameters)
        {
            return context.Database.SqlQuery<T>(query, parameters);
        }
        public IEnumerable<T> ExecWithStoreProcedure(string querys)
        {
            return context.Database.SqlQuery<T>(querys);
        }

        //public void BeginTransaction()
        //{
        //    dbContextTransaction = context.Database.BeginTransaction();
        //}
        //public void CommitTransaction()
        //{
        //    if (dbContextTransaction != null)
        //    {
        //        dbContextTransaction.Commit();
        //    }
        //}
        //public void RollbackTransaction()
        //{
        //    if (dbContextTransaction != null)
        //    {
        //        dbContextTransaction.Rollback();
        //    }
        //}
        //public void DisposeTransaction()
        //{
        //    if (dbContextTransaction != null)
        //    {
        //        dbContextTransaction.Dispose();
        //    }
        //}
    }
}