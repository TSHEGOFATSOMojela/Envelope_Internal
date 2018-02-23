using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Accepted
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Documents : ContentPage
	{
		public Documents ()
		{
			InitializeComponent ();
		}

        private async void idcopybooks(object sender, EventArgs e)
        {
            //Navigate to Envelope Main Page
            //((App)App.Current).username = username.ToString();
            await Navigation.PushAsync(new IdCopyBooks());
        }

        private async void StatementAccount(object sender, EventArgs e)
        {
            //Navigate to Envelope Main Page
            //((App)App.Current).username = username.ToString();
            await Navigation.PushAsync(new StatementAccount());
        }
    }
}