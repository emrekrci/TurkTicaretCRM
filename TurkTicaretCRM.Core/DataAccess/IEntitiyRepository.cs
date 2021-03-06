﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using TurkTicaretCRM.Core.Entities;

namespace TurkTicaretCRM.Core.DataAccess
{
    public interface IEntitiyRepository<T> where T:class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}
