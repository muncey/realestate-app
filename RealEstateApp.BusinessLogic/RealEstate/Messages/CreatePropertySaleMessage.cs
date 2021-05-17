namespace RealEstateApp.BusinessLogic.RealEstate.Messages
{
    public record CreatePropertySaleMessage(
        AddressMessage Address,
        string Headline, 
        string Description, 
        decimal Price, 
        double Latitude, 
        double Longitude);
}
