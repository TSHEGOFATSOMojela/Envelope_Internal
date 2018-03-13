
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Envelope_Internal.Indigent.Accepted;
    using Envelope_Internal.Indigent.ViewModels;
    using Envelope_Internal.Indigent.Models;
    using System.Net.Http;
    using Newtonsoft.Json;
    using Xamarin.Forms;
    using System.Timers;
    using SQLite;
    using Plugin.Geolocator;
    using Plugin.Geolocator.Abstractions;
    using Plugin.Permissions.Abstractions;
    using Envelope_Internal.Droid;
    using Xamarin.Forms.Xaml;

    namespace Envelope_Internal.Indigent.Assignment
    {
	    [XamlCompilation(XamlCompilationOptions.Compile)]
	    public partial class AcceptedAssignmentsDetails : ContentPage
	    {
            private Indigents itemSelectedData;

            //Accepted Assignments Details Constructor
            public AcceptedAssignmentsDetails(Indigents itemSelectedData)
            {
                InitializeComponent();
                //Binding item Selected Details to View
           
                BindingContext = itemSelectedData;

            }
        //location button
        private async void Saves_Location(object sender, EventArgs e)
        {

            try
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 100;


                var position = await locator.GetPositionAsync(TimeSpan.FromSeconds(1000), null, true);


               // var Longitude = position.Longitude.ToString();
              // var Latitude = position.Latitude.ToString();

                var output = string.Format("Time: {0} \nLat: {1} \nLong: {2} \nAltitude: {3} \nAltitude Accuracy: {4} \nAccuracy: {5} \nHeading: {6} \nSpeed: {7}",
                    position.Timestamp, position.Latitude, position.Longitude,
                    position.Altitude, position.AltitudeAccuracy, position.Accuracy, position.Heading, position.Speed);




                await DisplayAlert("Location",  output, "Save", "Cancel");
               
            }

            catch (Exception ex)
            {
                await DisplayAlert("Location", "Unable to get location, may need to increase timeout " + ex, "Save", "Cancel");
            }
           


    }

        //Living Condition Button
        private async void Living_Conditions(object sender, EventArgs e)
            {
            //Binding Item data
            var indigentDetails = (Indigents)BindingContext;
            await Navigation.PushAsync(new LivingConditions(indigentDetails));
            }

            //HouseHold memebers Button
            private async void HouseHold_Members(object sender, EventArgs e)
            {
            var indigentDetails = (Indigents)BindingContext;
           
            await Navigation.PushAsync(new HouseHoldDetails(indigentDetails));
            }

            //Signatures Button
            private async void Signature(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new Signatures());
            }

            //Documents Button
            private async void Document(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new Documents());
            }
        }
    }