using Microsoft.Maui.Controls;

namespace MauiStudy.Pages
{
    public partial class DatePickerSample : ContentPage
    {
        public DatePickerSample()
        {
            InitializeComponent();
        }

        private async void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            await DisplayAlert("DateSelected!", $"value {dateSelected.Date.ToString()}", "OK");
        }
    }
}