﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace CCSS.CORE.REPOSITORY
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
