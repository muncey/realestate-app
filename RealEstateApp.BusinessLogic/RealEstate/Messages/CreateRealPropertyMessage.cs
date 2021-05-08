namespace RealEstateApp.BusinessLogic.RealEstate.Messages
{
    public record CreateRealPropertyMessage(
        string StreetAddress1, 
        string StreetAddress2,
        string StreetAddress3,
        string Suburb, 
        string PostCode, 
        string State, 
        string Country, 
        string Headline, 
        string Description, 
        decimal Price, 
        double Latitude, 
        double Longitude);
}
