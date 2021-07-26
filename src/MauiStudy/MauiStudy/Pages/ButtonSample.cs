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

        private async void OnPressed(object sender, EventArgs e)
        {
            await DisplayAlert("Pressed!", "", "OK");
        }

        private async void OnReleased(object sender, EventArgs e)
        {
            await DisplayAlert("Released!", "", "OK");
        }
    }
}