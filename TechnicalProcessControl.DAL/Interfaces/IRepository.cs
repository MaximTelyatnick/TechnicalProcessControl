﻿using System.Collections.Generic;
using System.Linq;

namespace TechnicalProcessControl.DAL.Interfaces
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
