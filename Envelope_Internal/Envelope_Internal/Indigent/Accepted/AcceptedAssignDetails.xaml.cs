using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.ViewModels;
using Envelope_Internal.Indigent.Models;

using System.Net.Http;
using Newtonsoft.Json;
using Envelope_Internal.Indigent.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Accepted
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AcceptedAssignDetails : ContentPage
	{
        private Indigents itemSelectedData;
        public AcceptedAssignDetails (Indigents itemSelectedData)
		{
            InitializeComponent();
            BindingContext = itemSelectedData;
        }

        //button Living condition clicked
        private async void Living_Conditions(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new navPage());
        }
        //button HouseHold Members clicked
        private async void HouseHold_Members(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new navPage());
        }
        //button Signatures clicked
        private async void Signatures(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new navPage());
        }
        //button Documents clicked
        private async void Documents(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new navPage());
        }

    }
}