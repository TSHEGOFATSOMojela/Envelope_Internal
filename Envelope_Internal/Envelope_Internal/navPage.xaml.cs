using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class navPage : ContentPage
	{
		public navPage ()
		{
			InitializeComponent ();
		}
       
       
        

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void GeneralClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeneralPage());

        }
        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
        private async void OnIndigentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IndigentPage());
        }
    }
}