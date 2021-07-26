using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.Maui.Controls;

namespace MauiStudy.Pages
{
    public partial class CheckBoxSample : ContentPage
    {
        public CheckBoxSample()
        {
            InitializeComponent();
        }

        private async void OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            await DisplayAlert("CheckBoxCheckedChanged", $"value {e.Value}", "OK");
        }
    }
}