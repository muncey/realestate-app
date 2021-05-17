using RealEstateApp.Repository;
using RealEstateApp.BusinessLogic.RealEstate.Domain;
using RealEstateApp.BusinessLogic.RealEstate.Messages;

namespace RealEstateApp.BusinessLogic.RealEstate.Services
{
    public class PropertySaleCreatorService : IPropertySaleCreatorService
    {
        private readonly IRepository repository;

        public PropertySaleCreatorService(IRepository repository)
        {
            this.repository = repository;
        }

        public PropertySale Create(CreatePropertySaleMessage message)
        {
            PropertySale realProperty = new PropertySale();

            realProperty.StreetAddress1 = message.Address.StreetAddress1;
            realProperty.StreetAddress2 = message.Address.StreetAddress2;
            realProperty.StreetAddress3 = message.Address.StreetAddress3;
            realProperty.Suburb = message.Address.Suburb;
            realProperty.PostCode = message.Address.PostCode;
            realProperty.State = message.Address.State;
            realProperty.Country = message.Address.Country;
            realProperty.Headline = message.Headline;
            realProperty.Description = message.Description;
            realProperty.Price = message.Price;
            realProperty.Latitude = message.Latitude;
            realProperty.Longitude = message.Longitude;

            repository.Insert<PropertySale>(realProperty);

            return realProperty;
        }
    }
}
