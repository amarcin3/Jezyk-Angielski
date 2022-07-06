using System.Collections.Generic;

namespace JezykAngielski.Core.Models;

// Model for the SampleDataService. Replace with your own model.
public class SampleCompany
{
    public string CompanyID
    {
        get; set;
    }
    public ICollection<SampleOrder> Orders
    {
        get; set;
    }
}
