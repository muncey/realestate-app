using System;

namespace RealEstate.Repository
{
    public interface IRepository
    {
        void Insert<T>(T record);
    }
}
