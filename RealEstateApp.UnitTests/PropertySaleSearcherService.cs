using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RealEstateApp.Repository;
using RealEstateApp.BusinessLogic.RealEstate.Domain;
using RealEstateApp.BusinessLogic.RealEstate.Messages;
using RealEstateApp.BusinessLogic.RealEstate.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.UnitTests
{
    [TestClass]
    public class TestingPropertySearchByExactAddress
    {
        private readonly PropertySaleSearcherService propertyCreatorService;
        private readonly Mock<IRepository> repo;
        private readonly Mock<ISqlBuilder> sqlBuilder;

        public TestingPropertySearchByExactAddress()
        {
            repo = new Mock<IRepository>();
            sqlBuilder = new Mock<ISqlBuilder>();

            propertyCreatorService = new PropertySaleSearcherService(repo.Object);

        }

        [TestMethod]
        public void ShouldBuildQueryForAllDetails()
        {
            AddressMessage message = new AddressMessage(
                "street-address-1",
                "street-address-2",
                "street-address-3",
                "suburb", "1234",
                "state",
                "country");

            propertyCreatorService.FindExactByAddress(message);

            sqlBuilder.Verify(s => s.AddClause("StreetAddress1", "eq", message.StreetAddress1));
            sqlBuilder.Verify(s => s.AddClause("StreetAddress2", "eq", message.StreetAddress2));
            sqlBuilder.Verify(s => s.AddClause("StreetAddress3", "eq", message.StreetAddress3));
            sqlBuilder.Verify(s => s.AddClause("Suburb", "eq", message.Suburb));
            sqlBuilder.Verify(s => s.AddClause("PostCode", "eq", message.PostCode));
            sqlBuilder.Verify(s => s.AddClause("State", "eq", message.State));
            sqlBuilder.Verify(s => s.AddClause("Country", "eq", message.Country));
        }

        [TestMethod]
        public void ShouldBuildQueryForMinimalDetails()
        {
            AddressMessage message = new AddressMessage(
                "street-address-1",
                "",
                "",
                "suburb", "1234",
                "state",
                "country");

            propertyCreatorService.FindExactByAddress(message);

            sqlBuilder.Verify(s => s.AddClause("StreetAddress1", "eq", message.StreetAddress1));
            sqlBuilder.Verify(s => s.AddClause("StreetAddress2", It.IsAny<string>(), It.IsAny<object>()), Times.Never);
            sqlBuilder.Verify(s => s.AddClause("StreetAddress3", It.IsAny<string>(), It.IsAny<object>()), Times.Never);
            sqlBuilder.Verify(s => s.AddClause("Suburb", "eq", message.Suburb));
            sqlBuilder.Verify(s => s.AddClause("PostCode", "eq", message.PostCode));
            sqlBuilder.Verify(s => s.AddClause("State", "eq", message.State));
            sqlBuilder.Verify(s => s.AddClause("Country", "eq", message.Country));
        }

        [TestMethod]
        public void ShouldBuildQueryForNullDetails()
        {
            AddressMessage message = new AddressMessage(
                "street-address-1",
                null,
                null,
                "suburb", "1234",
                "state",
                "country");

            propertyCreatorService.FindExactByAddress(message);

            sqlBuilder.Verify(s => s.AddClause("StreetAddress1", "eq", message.StreetAddress1));
            sqlBuilder.Verify(s => s.AddClause("StreetAddress2", It.IsAny<string>(), It.IsAny<object>()), Times.Never);
            sqlBuilder.Verify(s => s.AddClause("StreetAddress3", It.IsAny<string>(), It.IsAny<object>()), Times.Never);
            sqlBuilder.Verify(s => s.AddClause("Suburb", "eq", message.Suburb));
            sqlBuilder.Verify(s => s.AddClause("PostCode", "eq", message.PostCode));
            sqlBuilder.Verify(s => s.AddClause("State", "eq", message.State));
            sqlBuilder.Verify(s => s.AddClause("Country", "eq", message.Country));
        }

        [TestMethod]
        public void ShouldQueryForRecord()
        {
            AddressMessage message = new AddressMessage(
                "street-address-1",
                "street-address-2",
                "street-address-3",
                "suburb", "1234",
                "state",
                "country");

            propertyCreatorService.FindExactByAddress(message);
            repo.Verify(m => m.Query<PropertySale>(It.IsAny<string>(), It.IsAny<object>()));
        }
    }
}
