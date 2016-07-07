using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPrincipal.Contracts
{
    public interface IMainRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int Id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int Id);
    }
}
