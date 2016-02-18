using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebApis.Models;

namespace WebApis
{
    public class Repository<T> where T : class
    {
        private BDKRContext _context;
        public Repository(BDKRContext context)
        {
            this._context = context;
        }
        public List<T> GetList(Func<T, bool> predicate = null)
        {
            if (predicate == null)
                return _context.Set<T>().ToList();
            return _context.Set<T>().Where(predicate).ToList();
        }

        public List<U> GetList<U>(Func<T, U> selector, Func<T, bool> predicate = null)
        {
            var list = GetList(predicate);
            return list.Select(selector).ToList();
        }

        public IQueryable<T> GetQueryable(Expression<Func<T, bool>> predicate = null)
        {
            if (null == predicate)
                return _context.Set<T>().AsQueryable();
            return _context.Set<T>().Where(predicate);
        }

        public IQueryable<U> GetQueryable<U>(Expression<Func<T, U>> selector, Expression<Func<T, bool>> predicate = null)
        {
            var query = GetQueryable(predicate);
            return query.Select(selector);
        }

        public T GetSingle(Expression<Func<T, bool>> predicate = null)
        {
            return GetQueryable(predicate).FirstOrDefault();
        }

        public int AddNew(T t, Expression<Func<T, bool>> predicate = null)
        {
            var _t = GetSingle(predicate);
            if (null != _t)
                throw new Exception("该数据在当前数据库中已存在,无法新增");
            _context.Set<T>().Add(t);
            return _context.SaveChanges();
        }
        public int Edit(T t, Expression<Func<T, bool>> predicate = null)
        {
            var _t = GetSingle(predicate);
            if (null == _t)
                throw new Exception("该数据在当前数据库中并不存在,无法修改");
            _context.Entry(_t).State = System.Data.Entity.EntityState.Detached;
            _context.Set<T>().Add(t);
            _context.Entry(t).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges();
        }

        public int Remove(T t, Expression<Func<T, bool>> predicate = null)
        {
            var _t = GetSingle(predicate);
            if (null == _t)
                throw new Exception("该数据在当前数据库中并不存在,无法删除");
            _context.Set<T>().Remove(t);
            return _context.SaveChanges();
        }

        public int RemoveAll(Expression<Func<T, bool>> predicate = null)
        {
            var query = GetQueryable(predicate);
            _context.Set<T>().RemoveRange(query);
            return _context.SaveChanges();
        }

        public U Max<U>(Expression<Func<T, U>> selector, Expression<Func<T, bool>> predicate = null)
        {
            return GetQueryable(predicate).Select(selector).Max<U>();
        }
    }
}