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
		}

        private async void BalanceEnquiryClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BalanceEnquiryPage());
        }
        private async void QueryCaseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QueryCasePage());
        }
    }
}