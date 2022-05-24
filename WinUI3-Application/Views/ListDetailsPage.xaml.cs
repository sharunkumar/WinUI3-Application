﻿using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

using WinUI3_Application.ViewModels;

namespace WinUI3_Application.Views
{
    public sealed partial class ListDetailsPage : Page
    {
        public ListDetailsViewModel ViewModel { get; }

        public ListDetailsPage()
        {
            ViewModel = App.GetService<ListDetailsViewModel>();
            InitializeComponent();
        }

        private void OnViewStateChanged(object sender, ListDetailsViewState e)
        {
            if (e == ListDetailsViewState.Both)
            {
                ViewModel.EnsureItemSelected();
            }
        }
    }
}
