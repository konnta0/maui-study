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

        private async void OnButtonSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.ButtonSample());
        }

        private async void OnCheckBoxSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.CheckBoxSample());
        }

        private async void OnDatePickerSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.DatePickerSample());
        }

        private async void OnEditorSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.EditorSample());
        }

        private async void OnEntrySample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.EntrySample());
        }

        private async void OnImageSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.ImageSample());
        }

        private async void OnLabelSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.LabelSample());
        }

        private async void OnProgressBarSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.ProgressBarSample());
        }

        private async void OnRadioButtonSample(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Pages.RadioButtonSample());
        }

    }
}
