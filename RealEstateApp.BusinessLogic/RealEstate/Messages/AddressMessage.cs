using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.BusinessLogic.RealEstate.Messages
{
    public record AddressMessage(string StreetAddress1,
        string StreetAddress2,
        string StreetAddress3,
        string Suburb,
        string PostCode,
        string State,
        string Country);
}
