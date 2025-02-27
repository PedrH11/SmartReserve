﻿using Microsoft.EntityFrameworkCore;
using SmartReserve.Domain.Base;
using SmartReserve.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SmartReserve.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity<int>
    {
        protected readonly MySqlContext _mySqlcontext;
        public BaseRepository(MySqlContext mySqlcontext)
        {
            _mySqlcontext = mySqlcontext;
        }

        public void AttachObject(object obj)
        {
            _mySqlcontext.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _mySqlcontext.ChangeTracker.Clear();
        }

        public void Delete(object id)
        {
            _mySqlcontext.Set<TEntity>().Remove(Select(id));
            _mySqlcontext.SaveChanges();
        }

        public void Insert(TEntity entity)
        {
            _mySqlcontext.Set<TEntity>().Add(entity);
            _mySqlcontext.SaveChanges();
        }

        public IList<TEntity> Select(IList<string>? includes = null)
        {
            var dbCContext = _mySqlcontext.Set<TEntity>().AsQueryable();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbCContext = dbCContext.Include(include);
                }
            }
            return dbCContext.ToList();
        }

        public TEntity Select(object id, IList<string>? includes = null)
        {
            var dbContext = _mySqlcontext.Set<TEntity>().AsQueryable();
            if(includes != null)
            {
                foreach(var include in includes)
                {
                    dbContext = dbContext.Include(include);
                }
            }
            return dbContext.ToList().Find(x => x.Id == (int)(id));
        }

        public void Update(TEntity entity)
        {
            _mySqlcontext.Entry(entity).State = EntityState.Modified;
            _mySqlcontext.SaveChanges();
        }
    }
}
