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
	public partial class GeneralPage : ContentPage
	{
		public GeneralPage ()
		{
			InitializeComponent ();

            GeneralListView.ItemsSource = new List<GeneralLv>
            {
                new GeneralLv
                { GeneralOptions = "Balance Enquiry",
                   ImageUrl="icon.png"},
                new GeneralLv
                { GeneralOptions =   "Query Case",
                  ImageUrl="requestIt.png"
                }


        };
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}