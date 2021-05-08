using RealEstate.Repository;
using RealEstateApp.BusinessLogic.RealEstate.Domain;
using RealEstateApp.BusinessLogic.RealEstate.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.BusinessLogic.RealEstate.Services
{
    public class PropertyCreatorService : IPropertyCreatorService
    {
        private readonly IRepository repository;

        public PropertyCreatorService(IRepository repository)
        {
            this.repository = repository;
        }

        public RealProperty Create(CreateRealPropertyMessage message)
        {
            RealProperty realProperty = new RealProperty();

            realProperty.StreetAddress1 = message.StreetAddress1;
            realProperty.StreetAddress2 = message.StreetAddress2;
            realProperty.StreetAddress3 = message.StreetAddress3;
            realProperty.Suburb = message.Suburb;
            realProperty.PostCode = message.PostCode;
            realProperty.State = message.State;
            realProperty.Country = message.Country;
            realProperty.Headline = message.Headline;
            realProperty.Description = message.Description;
            realProperty.Price = message.Price;
            realProperty.Latitude = message.Latitude;
            realProperty.Longitude = message.Longitude;

            repository.Insert<RealProperty>(realProperty);

            return realProperty;
        }
    }
}
