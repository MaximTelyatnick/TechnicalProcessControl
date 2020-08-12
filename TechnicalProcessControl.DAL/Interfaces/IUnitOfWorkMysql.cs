using System;

namespace TechnicalProcessControl.DAL.Interfaces
{
    public interface IUnitOfWorkMysql:IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
