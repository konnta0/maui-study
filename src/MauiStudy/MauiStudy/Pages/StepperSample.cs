using System;
using Microsoft.Maui.Controls;

namespace MauiStudy.Pages
{
    public partial class StepperSample : ContentPage
    {
        public StepperSample()
        {
            InitializeComponent();
        }

        public async void OnValueChanged(object sender, EventArgs e)
        {
            await DisplayAlert("ValueChanged", "", "OK");
        }
    }
}