using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using SignaturePad.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Accepted
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Signatures : ContentPage
	{
		public Signatures ()
		{
			InitializeComponent ();
		}

        private void Clear(Object sender, EventArgs e)
        {
            FooSignaturePad.Clear();
        }


        private async void submit(Object sender, EventArgs e)
        {
            var signedImageStream = await FooSignaturePad.GetImageStreamAsync(SignatureImageFormat.Jpeg);
            await DisplayAlert("Acme Company", "your signed agreement has been sent", "ok");
        }
    }
}