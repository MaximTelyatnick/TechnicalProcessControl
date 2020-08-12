using System;
using System.Collections.Generic;
using TechnicalProcessControl.DAL.EF;
using TechnicalProcessControl.DAL.Interfaces;
using TechnicalProcessControl.DAL.Repositories;

namespace TerminalMKTelegramBot.Services
{
    public class UnitOfWorkMysql : IUnitOfWorkMysql
    {
        private readonly ConnectionMysqlContext dbmysql;
        private bool disposed;
        private Dictionary<Type, object> repositoriesMysql;

        public UnitOfWorkMysql()
        {
            dbmysql = new ConnectionMysqlContext();
            repositoriesMysql = new Dictionary<Type, object>();
            disposed = false;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            if (repositoriesMysql.ContainsKey(typeof(T)))
            {
                return repositoriesMysql[typeof(T)] as IRepository<T>;
            }

            var repository = new RepositoryMySQL<T>(dbmysql);

            repositoriesMysql.Add(typeof(T), repository);

            return repository;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbmysql.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
