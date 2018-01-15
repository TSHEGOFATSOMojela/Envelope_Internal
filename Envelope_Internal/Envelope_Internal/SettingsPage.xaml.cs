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
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}
        private async void ProfileClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProfilePage());
        }
        private async void PreferencesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PreferencesPages());
        }
        private async void PasswordClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PasswordPage());
        }
    }
}