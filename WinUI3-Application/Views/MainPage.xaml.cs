using Microsoft.UI.Xaml.Controls;

using WinUI3_Application.ViewModels;

namespace WinUI3_Application.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; }

        public MainPage()
        {
            ViewModel = App.GetService<MainViewModel>();
            InitializeComponent();
        }
    }
}
