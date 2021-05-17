using Dapper;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.Linq;

namespace RealEstateApp.Repository
{
    public class MySqliteRepository : IRepository
    {
        public void Insert<T>(T record)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> Query<T>(string sql, object parameters) where T : class
        {
            throw new System.NotImplementedException();
        }
    }
}
