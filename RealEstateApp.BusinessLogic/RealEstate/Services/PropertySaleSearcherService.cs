using RealEstateApp.Repository;
using RealEstateApp.BusinessLogic.RealEstate.Domain;
using RealEstateApp.BusinessLogic.RealEstate.Messages;
using System;

namespace RealEstateApp.BusinessLogic.RealEstate.Services
{
    public class PropertySaleSearcherService : IPropertySaleSearcherService
    {
        private readonly IRepository repository;

        public PropertySaleSearcherService(IRepository repository)
        {
            this.repository = repository;
        }

        public PropertySale FindExactByAddress(AddressMessage message)
        {
            return null;
        }
    }
}
