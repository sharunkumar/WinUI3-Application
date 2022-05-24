using System;

namespace WinUI3_Application.Contracts.Services
{
    public interface IPageService
    {
        Type GetPageType(string key);
    }
}
