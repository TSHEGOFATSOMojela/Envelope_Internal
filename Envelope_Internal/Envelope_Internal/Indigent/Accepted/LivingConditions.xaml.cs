using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media.Abstractions;
using Envelope_Internal.Indigent.Accepted;
using Envelope_Internal.Indigent.ViewModels;
using Envelope_Internal.Indigent.Models;
using Envelope_Internal.Droid;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using Plugin.Media;
using SQLite;
using Envelope_Internal.Indigent.Assignment;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Accepted
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LivingConditions : ContentPage
	{
         Indigents indigentDetails;
        public LivingConditions(Indigents indigentDetails)
		{
			InitializeComponent ();
            BindingContext = indigentDetails;
        }

        private async void TakePhoto(object sender, EventArgs e)
        {
            //  await Navigation.PushAsync(new BottomNavigationBar());
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
            {
                SaveToAlbum = true,
                Name = "test.jpg"
            });

            if (file == null)
                return;


            image.Source = ImageSource.FromStream(() => file.GetStream());
                
            }
        
    

        private async void uploadAphoto(object sender, EventArgs e)
        {

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("No upload", "Picking a photo is not supported.", "ok");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null)
                return;

            image.Source = ImageSource.FromStream(() => file.GetStream());
        }
    }
}