using System;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateApp.Repository
{
    public interface IRepository
    {
        IEnumerable<T> Query<T>(string sql, object parameters) where T : class;
        void Insert<T>(T record);

        
    }
}
