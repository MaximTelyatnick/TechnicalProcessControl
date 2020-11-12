using System;
using System.Collections.Generic;
using TechnicalProcessControl.DAL.Interfaces;
using TechnicalProcessControl.DAL.EF;
using TechnicalProcessControl.DAL.Repositories;
using System.Data.Entity.Core;

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

        public bool GetExecuteSqlCommand(string str)
        {
            try
            {
                db.Database.BeginTransaction();
                db.Database.ExecuteSqlCommand(str);
                db.SaveChanges();

                //db.Database.
            }
            catch (Exception ex)
            {
                return false;
            }





            //try
            //{
            //    db.Database.BeginTransaction();
            //    db.Database.ExecuteSqlCommand(str);
            //    db.SaveChanges();

            //    //db.Database.
            //}
            //catch (Exception ex)
            //{
            //    return false;
            //}

            return true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
