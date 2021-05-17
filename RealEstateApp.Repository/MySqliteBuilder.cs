using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Repository
{
    public class MySqliteBuilder : ISqlBuilder
    {
        public void SetTable(string table)
        {
            throw new NotImplementedException();
        }

        public void AddSelect(string selectField)
        {
            throw new NotImplementedException();
        }

        public void AddClause(string name, string clause, object value)
        {
            throw new NotImplementedException();
        }

        public object GetParams()
        {
            throw new NotImplementedException();
        }

        public string GetQuery()
        {
            throw new NotImplementedException();
        }
    }
}
