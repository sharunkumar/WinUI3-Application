﻿using System;
using System.Collections.Generic;
using System.Linq;

using CommunityToolkit.Mvvm.ComponentModel;

using Microsoft.UI.Xaml.Controls;

using WinUI3_Application.Contracts.Services;
using WinUI3_Application.ViewModels;
using WinUI3_Application.Views;

namespace WinUI3_Application.Services
{
    public class PageService : IPageService
    {
        private readonly Dictionary<string, Type> _pages = new Dictionary<string, Type>();

        public PageService()
        {
            Configure<MainViewModel, MainPage>();
            Configure<WebViewViewModel, WebViewPage>();
            Configure<ListDetailsViewModel, ListDetailsPage>();
            Configure<ContentGridViewModel, ContentGridPage>();
            Configure<ContentGridDetailViewModel, ContentGridDetailPage>();
            Configure<DataGridViewModel, DataGridPage>();
            Configure<BlankViewModel, BlankPage>();
            Configure<SettingsViewModel, SettingsPage>();
        }

        public Type GetPageType(string key)
        {
            Type pageType;
            lock (_pages)
            {
                if (!_pages.TryGetValue(key, out pageType))
                {
                    throw new ArgumentException($"Page not found: {key}. Did you forget to call PageService.Configure?");
                }
            }

            return pageType;
        }

        private void Configure<VM, V>()
            where VM : ObservableObject
            where V : Page
        {
            lock (_pages)
            {
                var key = typeof(VM).FullName;
                if (_pages.ContainsKey(key))
                {
                    throw new ArgumentException($"The key {key} is already configured in PageService");
                }

                var type = typeof(V);
                if (_pages.Any(p => p.Value == type))
                {
                    throw new ArgumentException($"This type is already configured with key {_pages.First(p => p.Value == type).Key}");
                }

                _pages.Add(key, type);
            }
        }
    }
}
