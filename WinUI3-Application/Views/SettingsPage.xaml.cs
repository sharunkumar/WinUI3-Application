using Microsoft.UI.Xaml.Controls;

using WinUI3_Application.ViewModels;

namespace WinUI3_Application.Views
{
    // TODO: Set the URL for your privacy policy by updating SettingsPage_PrivacyTermsLink.NavigateUri in Resources.resw.
    public sealed partial class SettingsPage : Page
    {
        public SettingsViewModel ViewModel { get; }

        public SettingsPage()
        {
            ViewModel = App.GetService<SettingsViewModel>();
            InitializeComponent();
        }
    }
}
