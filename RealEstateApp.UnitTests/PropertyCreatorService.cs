using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using RealEstateApp.BusinessLogic.RealEstate.Domain;
using RealEstateApp.BusinessLogic.RealEstate.Messages;
using RealEstateApp.BusinessLogic.RealEstate.Services;
using RealEstate.Repository;
using Moq;

namespace RealEstateApp.UnitTests
{
    [TestClass]
    public class PropertyCreatorServiceTest
    {
        private RealProperty realProperty;
        private readonly CreateRealPropertyMessage message;
        private readonly PropertyCreatorService propertyCreatorService;
        private readonly Mock<IRepository> repo;
        
        public PropertyCreatorServiceTest()
        {
            repo = new Mock<IRepository>();

            propertyCreatorService = new PropertyCreatorService(repo.Object);
            message = new CreateRealPropertyMessage(
                "street-address-1",
                "street-address-2",
                "street-address-3",
                "suburb", "1234",
                "state",
                "country",
                "headline",
                "description", new decimal(1.1), 1, 1);
        }

        [TestInitialize]
        public void RunCreate()
        {
            realProperty = propertyCreatorService.Create(message);
        }

        [TestMethod]
        public void ShouldInsertRecord()
        {
            repo.Verify(m => m.Insert<RealProperty>(realProperty));
        }

        [TestMethod]
        public void ShouldSetFields()
        {
            realProperty.StreetAddress1.Should().Be("street-address-1");
            realProperty.StreetAddress2.Should().Be("street-address-2");
            realProperty.StreetAddress3.Should().Be("street-address-3");
            realProperty.Suburb.Should().Be("suburb");
            realProperty.PostCode.Should().Be("1234");
            realProperty.State.Should().Be("state");
            realProperty.Country.Should().Be("country");
            realProperty.Headline.Should().Be("headline");
            realProperty.Description.Should().Be("description");
            realProperty.Price.Should().Be(new decimal(1.1));
            realProperty.Latitude.Should().Be(1);
            realProperty.Longitude.Should().Be(1);
        }
    }
}
