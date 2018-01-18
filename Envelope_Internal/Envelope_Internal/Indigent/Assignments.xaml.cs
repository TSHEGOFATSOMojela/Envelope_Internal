using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Assignments : ContentPage
	{
		public Assignments ()
		{
			InitializeComponent ();
		}
        private async void login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}