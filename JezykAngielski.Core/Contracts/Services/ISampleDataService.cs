using System.Collections.Generic;
using System.Threading.Tasks;

using JezykAngielski.Core.Models;

namespace JezykAngielski.Core.Contracts.Services;

public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetContentGridDataAsync();
}
