using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MeVaBeShop.Data.Infrastructure
{
    public interface IRepository <T> where T :class
    {
        //Mask an entity as New
        void Add(T entity);
        // Mask an entity as to be remove
        void Delete(T entity);
        //Delete multi records
        void DeleteMulti(Expression<Func<T, bool>> where);

        //get an entity by int ID
        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        IQueryable<T> GetAll(string[] includes = null);
        IQueryable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
        IQueryable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);
        int Count(Expression<Func<T, bool>> where);
        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}
