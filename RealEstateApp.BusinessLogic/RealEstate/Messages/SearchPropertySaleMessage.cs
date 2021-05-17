namespace RealEstateApp.BusinessLogic.RealEstate.Messages
{
    public record SearchPropertySaleMessage(string Select, string Filter, int Page, int PageSize);
}
