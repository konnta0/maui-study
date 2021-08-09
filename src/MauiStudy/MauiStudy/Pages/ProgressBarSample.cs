using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace MauiStudy.Pages
{
    public partial class ProgressBarSample : ContentPage
    {
        public ProgressBarSample()
        {
            InitializeComponent();
        }

        public async void OnStartProgressTo(object sender, EventArgs e)
        {
            await progressBar.ProgressTo(0.8, 250, Easing.Linear);
        }
    }
}