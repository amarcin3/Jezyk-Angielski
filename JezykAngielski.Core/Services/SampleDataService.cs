using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using JezykAngielski.Core.Contracts.Services;
using JezykAngielski.Core.Models;


namespace JezykAngielski.Core.Services;

public class SampleDataService : ISampleDataService
{
    private List<SampleOrder> _allOrders;

    public SampleDataService()
    {
    }

    private static IEnumerable<SampleOrder> AllOrders()
    {
        var companies = AllCompanies();
        return companies.SelectMany(c => c.Orders);
    }
    private static IEnumerable<SampleCompany> AllCompanies()
    {
        return new List<SampleCompany>()
        {
            new SampleCompany()
            {
                Orders = new List<SampleOrder>()
                {
                    new SampleOrder()
                    {
                        OrderID = 10643,
                        Company = "A1 Elementary (YLE)",
                        Status = "Podstawowy",
                        ShipTo = "3-4 lat nauki",
                        SymbolCode = 57602,
                        Note1 = Resource._1Note1,
                        DescNote1 = Resource._1DescNote1,
                        Note2 = Resource._1Note2,
                        DescNote2 = Resource._1DescNote2,
                        Note3 = Resource._1Note3,
                        DescNote3 = Resource._1DescNote3
                    },
                    new SampleOrder()
                    {
                        OrderID = 10835,
                        Company = "A2 Key (KET)",
                        Status = "Podstawowy",
                        ShipTo = "5-6 lat nauki",
                        SymbolCode = 57634,
                        Note1 = Resource._2Note1,
                        DescNote1 = Resource._2DescNote1,
                        Note2 = Resource._2Note2,
                        DescNote2 = Resource._2DescNote2,
                        Note3 = Resource._2Note3,
                        DescNote3 = Resource._2DescNote3
                    },
                    new SampleOrder()
                    {
                        OrderID = 10952,
                        Company = "B1 Preliminary (PET)",
                        Status = "Ponadpodstawowy",
                        ShipTo = "7-8 lat nauki",
                        SymbolCode = 57625,
                        Note1 = Resource._3Note1,
                        DescNote1 = Resource._3DescNote1,
                        Note2 = Resource._3Note2,
                        DescNote2 = Resource._3DescNote2,
                        Note3 = Resource._3Note3,
                        DescNote3 = Resource._3DescNote3
                    },
                    new SampleOrder()
                    {
                        OrderID = 10135,
                        Company = "B2 First (FCE)",
                        Status = "Średnio zaawansowany",
                        ShipTo = "9-10 lat nauki",
                        SymbolCode = 57833,
                        Note1 = Resource._4Note1,
                        DescNote1 = Resource._4DescNote1,
                        Note2 = Resource._4Note2,
                        DescNote2 = Resource._4DescNote2,
                        Note3 = Resource._4Note3,
                        DescNote3 = Resource._4DescNote3
                    },
                    new SampleOrder()
                    {
                        OrderID = 10535,
                        Company = "C1 Advanced (CAE)",
                        Status = "Zaawansowany",
                        ShipTo = "11-12 lat nauki",
                        SymbolCode = 57668,
                        Note1 = Resource._5Note1,
                        DescNote1 = Resource._5DescNote1,
                        Note2 = Resource._5Note2,
                        DescNote2 = Resource._5DescNote2,
                        Note3 = Resource._5Note3,
                        DescNote3 = Resource._5DescNote3
                    },
                    new SampleOrder()
                    {
                        OrderID = 10885,
                        Company = "C2 Proficiency (CPE)",
                        Status = "Biegły",
                        ShipTo = "13-15 lat nauki",
                        SymbolCode = 57643,
                        Note1 = Resource._6Note1,
                        DescNote1 = Resource._6DescNote1,
                        Note2 = Resource._6Note2,
                        DescNote2 = Resource._6DescNote2,
                        Note3 = Resource._6Note3,
                        DescNote3 = Resource._6DescNote3
                    },
                }
            }
        };
    }

    public async Task<IEnumerable<SampleOrder>> GetContentGridDataAsync()
    {
        if (_allOrders == null)
        {
            _allOrders = new List<SampleOrder>(AllOrders());
        }

        await Task.CompletedTask;
        return _allOrders;
    }
}
