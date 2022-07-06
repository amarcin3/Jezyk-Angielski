using System;

namespace JezykAngielski.Contracts.Services;

public interface IPageService
{
    Type GetPageType(string key);
}
