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
	    public partial class EnvelopeMainPage : MasterDetailPage
	    {
            //Envelope Main Page Constructor
		    public EnvelopeMainPage()
		    {
			    InitializeComponent ();

                //Binding Items to View
                SettingListView.ItemsSource = new List<settingLv>
                {
                 //Declearing an item Name
                    new settingLv
                    { SettingOptions = "Change Password"}

                };
            }
  
            //Log out label
            private async void LogOut_Tapped(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new EnvelopeLoginPage());
            }

            //General label
            private async void GeneralClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new GeneralPage());

            }

            //Settings label 
            private async void OnSettingsClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new SettingsPage());
            }

            //Indigent image 
            private async void OnIndigentClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new IndigentLoginPage());
            }

            //M_health image 
            private async void OnMhealthClicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new IndigentLoginPage());
            }

            //log call image
            private async void called(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new TappedPageNavigation());
            }
        }
    }