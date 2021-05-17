using System;

namespace RealEstateApp.BusinessLogic.RealEstate.Domain
{
    public class PropertySale
    {
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string StreetAddress3 { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Headline { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
