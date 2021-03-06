using System;
using System.Linq;

using CommunityToolkit.Mvvm.ComponentModel;

using WinUI3_Application.Contracts.ViewModels;
using WinUI3_Application.Core.Contracts.Services;
using WinUI3_Application.Core.Models;

namespace WinUI3_Application.ViewModels
{
    public class ContentGridDetailViewModel : ObservableRecipient, INavigationAware
    {
        private readonly ISampleDataService _sampleDataService;
        private SampleOrder _item;

        public SampleOrder Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }

        public ContentGridDetailViewModel(ISampleDataService sampleDataService)
        {
            _sampleDataService = sampleDataService;
        }

        public async void OnNavigatedTo(object parameter)
        {
            if (parameter is long orderID)
            {
                var data = await _sampleDataService.GetContentGridDataAsync();
                Item = data.First(i => i.OrderID == orderID);
            }
        }

        public void OnNavigatedFrom()
        {
        }
    }
}
