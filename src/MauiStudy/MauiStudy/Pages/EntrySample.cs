using System;
using System.ComponentModel;
using Microsoft.Maui.Controls;

namespace MauiStudy.Pages
{
    public partial class EntrySample : ContentPage
    {
        public EntrySample()
        {
            InitializeComponent();
        }

        public async void OnCompleted(object sender, EventArgs e)
        {
            var text = ((Entry)sender).Text;
            await DisplayAlert("Completed!", text, "OK");
        }
    }
}