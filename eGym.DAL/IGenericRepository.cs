﻿using System.Linq.Expressions;

namespace eGym.DAL;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(object id);
    Task Insert(T obj);
    Task Update(T obj);
    Task Delete(object id);
    Task Save();
    public Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate);
}

