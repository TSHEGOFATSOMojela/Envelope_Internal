﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Envelope_Internal
{
	public partial class MainPage : ContentPage
	{

		public MainPage()
		{
			InitializeComponent();
		}

        private async void login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new navPage());
        }
}
}
