using System;
using Microsoft.Maui.Controls;

namespace MauiStudy.Pages
{
    public partial class EditorSample : ContentPage
    {
        public EditorSample()
        {
            InitializeComponent();
        }

        private async void OnCompleted(object sender, EventArgs e)
        {
            await DisplayAlert("Completed!", $"value {((Editor)sender)?.Text}", "OK");
        }
    }
}