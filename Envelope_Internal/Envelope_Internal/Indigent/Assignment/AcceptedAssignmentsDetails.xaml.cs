    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Envelope_Internal.Indigent.ViewModels;
    using Envelope_Internal.Indigent.Models;
    using System.Net.Http;
    using Newtonsoft.Json;
    using Xamarin.Forms;
    using SQLite;
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

            //Living Condition Button
            private async void Living_Conditions(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new IndigentLoginPage());
            }

            //HouseHold memebers Button
            private async void HouseHold_Members(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new IndigentLoginPage());
            }

            //Signatures Button
            private async void Signatures(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new IndigentLoginPage());
            }

            //Documents Button
            private async void Documents(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new IndigentLoginPage());
            }
        }
    }