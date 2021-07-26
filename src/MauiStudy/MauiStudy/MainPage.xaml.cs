using System;
using Microsoft.Maui.Controls;

namespace MauiStudy
{
    public partial class MainPage : ContentPage
    {
        public MainPage() => InitializeComponent();

        private async void OnContentPageSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.ContentPageSample());
        }

        private async void OnTabbedPageSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.TabbedPageSample());
        }

        private async void OnActivityIndicatorSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.ActivityIndicatorSample());
        }

        private async void OnButtonSample(object sender, EventArgs eventArgs)
        {
            await this.Navigation.PushAsync(new Pages.ButtonSample());
        }
        private async void OnCheckBoxSample(object sender, EventArgs eventArgs)
        {
            await this.Navigation.PushAsync(new Pages.CheckBoxSample());
        }
    }
}
