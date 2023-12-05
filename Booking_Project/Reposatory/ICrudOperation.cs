﻿using System.Linq.Expressions;

namespace Booking_Project.Reposatory
{
    public interface ICrudOperation<T>where T : class
    {
        List<T> GetAll(params Expression<Func<T, object>>[] includeProperties);
        T GetById(int id);
        void insert(T Entity);
        void update(T Entity);
        void Delete(int id);
        int save();
        object? SelectMany(Func<object, object> value);
    }
}
