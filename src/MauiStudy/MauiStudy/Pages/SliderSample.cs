using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MauiStudy.Pages
{
    public partial class SliderSample : ContentPage
    {
        public SliderSample()
        {
            InitializeComponent();
        }

        public async OnDragCompleted(object sender, EventArgs e)
        {
            await DisplayAlert("DragCompleted", "", "OK");
        }
    }
}