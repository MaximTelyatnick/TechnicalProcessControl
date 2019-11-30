using TerminalMKTelegramBot.Infrastructure;
using TerminalMKTelegramBot.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMKTelegramBot.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ConnectionContext db;
        private bool disposed;
        private Dictionary<Type, object> repositories;

        public UnitOfWork()
        {
            db = new ConnectionContext();
            repositories = new Dictionary<Type, object>();
            disposed = false;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            if (repositories.ContainsKey(typeof(T)))
            {
                return repositories[typeof(T)] as IRepository<T>;
            }

            var repository = new Repository<T>(db);

            repositories.Add(typeof(T), repository);

            return repository;
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
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
