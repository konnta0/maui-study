﻿using System;
using Microsoft.Maui.Controls;

namespace MauiStudy
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void OnContentPageSample(object sender, EventArgs e)
		{
			await this.Navigation.PushAsync(new Pages.ContentPageSample() { Title = "ContentPageSample" });
		}
	}
}
