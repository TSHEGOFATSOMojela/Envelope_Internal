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

            SettingListView.ItemsSource = new List<settingLv>
            {
                new settingLv
                { SettingOptions = "Edit Profile",
                  ImageUrl="icon.png"},
                new settingLv
                { SettingOptions =   "Preferences",
                   ImageUrl="reportIt.png"},
                new settingLv
                { SettingOptions = "Change Password",
                   ImageUrl="tourisim.png"}

            };
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}