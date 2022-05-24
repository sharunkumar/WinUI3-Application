using Microsoft.UI.Xaml.Controls;

using WinUI3_Application.ViewModels;

namespace WinUI3_Application.Views
{
    public sealed partial class ContentGridPage : Page
    {
        public ContentGridViewModel ViewModel { get; }

        public ContentGridPage()
        {
            ViewModel = App.GetService<ContentGridViewModel>();
            InitializeComponent();
        }
    }
}
