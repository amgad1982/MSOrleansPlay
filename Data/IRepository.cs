using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Data.Models;

namespace Data
{
   public interface IRepository<T> where T :ModelBase
   {
       void Add(T entity);
       void Update(T entity);
       IList<T> Find(Expression<Func<Board, bool>> query=null);
       void Delete(T entity);
   }
}
