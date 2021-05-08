namespace RealEstateApp.BusinessLogic.RealEstate.Messages
{
    public record SearchPropertiesMessage(string Select, string Filter, int Page, int PageSize);
}
