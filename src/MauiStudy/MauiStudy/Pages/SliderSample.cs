using System;
using Microsoft.Maui.Controls;

namespace MauiStudy.Pages
{
    public partial class SliderSample : ContentPage
    {
        public SliderSample()
        {
            InitializeComponent();
        }

        public async void OnDragCompleted(object sender, EventArgs e)
        {
            await DisplayAlert("DragCompleted", "", "OK");
        }

        public async void OnDragStarted(object sender, EventArgs e)
        {
            await DisplayAlert("DragStarted", "", "OK");
        }

        public async void OnValueChanged(object sender, EventArgs e)
        {
            await DisplayAlert("ValueChanged", "", "OK");
        }
    }
}