﻿using System.Collections.Generic;
using System.Threading.Tasks;

using JezykAngielski.Core.Models;

namespace JezykAngielski.Core.Contracts.Services;

// Remove this class once your pages/features are using your data.
public interface ISampleDataService
{
    Task<IEnumerable<SampleOrder>> GetContentGridDataAsync();
}
