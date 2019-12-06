using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerminalMK.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T Create(T item);
        void CreateRange(IEnumerable<T> entity);
        void Update(T item);
        void Delete(T item);
        void DeleteAll(IEnumerable<T> item);
        //IEnumerable<T> SQLExecuteProc(string executeProcString, params FbParameter[] paramArr);


    }
}
