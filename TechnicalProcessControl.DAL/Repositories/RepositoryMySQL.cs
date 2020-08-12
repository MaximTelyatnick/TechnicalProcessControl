using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TechnicalProcessControl.DAL.EF;
using TechnicalProcessControl.DAL.Interfaces;

namespace TechnicalProcessControl.DAL.Repositories
{
    public class RepositoryMySQL<T> : IRepository<T> where T : class
    {
        private ConnectionMysqlContext dbmysql;



        public RepositoryMySQL(ConnectionMysqlContext context)
        {
            this.dbmysql = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            return dbmysql.Set<T>();
        }

        public T Create(T entity)
        {
            dbmysql.Set<T>().Add(entity);
            dbmysql.SaveChanges();
            return dbmysql.Set<T>().Local.Last();
        }

        public void CreateRange(IEnumerable<T> entity)
        {
            dbmysql.Set<T>().AddRange(entity);
            dbmysql.SaveChanges();
        }

        public void Update(T entity)
        {
            dbmysql.Entry(entity).State = EntityState.Modified;
            dbmysql.SaveChanges();
        }

        public void Delete(T entity)
        {
            dbmysql.Set<T>().Remove(entity);
            dbmysql.SaveChanges();
        }

        public void DeleteAll(IEnumerable<T> entity)
        {
            dbmysql.Set<T>().RemoveRange(entity);
            dbmysql.SaveChanges();
        }

        //public IEnumerable<T> SQLExecuteProc(string executeProcString, params MysqlParameter[] paramArr)
        //{
        //    return dbmysql.Set<T>().SqlQuery(executeProcString, paramArr);
        //}


    }
}
