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

     


        public async void Save(object sender, EventArgs eventArgs)
        {

            Stream stream = await Pad.GetImageStreamAsync(SignatureImageFormat.Jpeg);
        }
    }
}