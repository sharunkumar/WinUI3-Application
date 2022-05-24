using Microsoft.UI.Xaml.Controls;

using WinUI3_Application.ViewModels;

namespace WinUI3_Application.Views
{
    public sealed partial class BlankPage : Page
    {
        public BlankViewModel ViewModel { get; }

        public BlankPage()
        {
            ViewModel = App.GetService<BlankViewModel>();
            InitializeComponent();
        }
    }
}
