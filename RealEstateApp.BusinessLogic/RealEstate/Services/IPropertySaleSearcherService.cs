using RealEstateApp.BusinessLogic.RealEstate.Domain;
using RealEstateApp.BusinessLogic.RealEstate.Messages;

namespace RealEstateApp.BusinessLogic.RealEstate.Services
{
    public interface IPropertySaleSearcherService
    {
        PropertySale FindExactByAddress(AddressMessage message);
    }
}
