﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetCarsByBrandId(int brandId);
        List<T> GetCarsByColorId(int colorId);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
