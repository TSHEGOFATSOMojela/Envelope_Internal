using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.Assignment;
using Envelope_Internal.Indigent;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class navPage : MasterDetailPage
	{
		public navPage ()
		{
			InitializeComponent ();

            SettingListView.ItemsSource = new List<settingLv>
            {
                

                new settingLv
                { SettingOptions = "Change Password",
                   ImageUrl="iconslock.png"}

            };

            
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
        private async void OnMhealthClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AssignmentPage());
        }

        private async void called(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}