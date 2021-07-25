using System;
using Microsoft.Maui.Controls;

namespace MauiStudy.Pages
{
    public partial class ButtonSample : ContentPage
    {
        public ButtonSample()
        {
            InitializeComponent();
        }

        private async void OnClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Clicked!", "", "OK");
        }
    }
}