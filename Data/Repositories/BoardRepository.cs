using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class BoardRepository : IRepository<Board>
    {
        private DbContext _ctx;
        public BoardRepository(DbContext dbContext)
        {
            _ctx = dbContext;
        }

        public void Add(Board entity)
        {
            _ctx.Set<Board>().Add(entity);
            _ctx.SaveChanges();
        }

        public void Delete(Board entity)
        {
            _ctx.Set<Board>().Remove(entity);
            _ctx.SaveChanges();
        }

        public IList<Board> Find(Expression<Func<Board,bool>> query=null)
        {
            if (query != null)
                return _ctx.Set<Board>().Where(query).Include(b=>b.BoarCollections).ToList();
            else return _ctx.Set<Board>().Include(b => b.BoarCollections).ToList();

        }

        public void Update(Board entity)
        {
            _ctx.Set<Board>().Update(entity);
            _ctx.SaveChanges();
        }
    }
}
