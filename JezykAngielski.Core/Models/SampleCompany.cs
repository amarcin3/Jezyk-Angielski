using System.Collections.Generic;

namespace JezykAngielski.Core.Models;

public class SampleCompany
{
    public ICollection<SampleOrder> Orders
    {
        get; set;
    }
}
