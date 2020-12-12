using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TechnicalProcessControl.DAL.EF;
using TechnicalProcessControl.DAL.Interfaces;

namespace TechnicalProcessControl.DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ConnectionContext db;



        public Repository(ConnectionContext context)
        {
            this.db = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            var hhh = db.Set<T>();
            return hhh;
        }

        public T Create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
            return db.Set<T>().Local.Last();
        }

        public void CreateRange(IEnumerable<T> entity)
        {
            db.Set<T>().AddRange(entity);
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(T entity)
        {
            db.Set<T>().Remove(entity);
            db.SaveChanges();
        }

        public void DeleteAll(IEnumerable<T> entity)
        {
            db.Set<T>().RemoveRange(entity);
            db.SaveChanges();
        }



        public IEnumerable<T> SQLExecuteProc(string executeProcString, params FbParameter[] paramArr)
        {
            return db.Set<T>().SqlQuery(executeProcString, paramArr);
        }


    }
}
