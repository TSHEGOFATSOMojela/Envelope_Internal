using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.Assignment;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IndigentPage : ContentPage
	{
		public IndigentPage ()
		{
			InitializeComponent ();
        
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainAssign());
        }
    }
}