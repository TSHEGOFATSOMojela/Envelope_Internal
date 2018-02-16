using System;
using Envelope_Internal.Indigent.Models;
using Xamarin.Forms;

namespace Envelope_Internal.Indigent.Assignment
{
	public partial class AcceptedDetails : ContentView
	{
		public AcceptedDetails ()
		{
			InitializeComponent ();
		}

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (Assignment1)BindingContext;
            await App.Database.SaveItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (Assignment1)BindingContext;
            await App.Database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void OnSpeakClicked(object sender, EventArgs e)
        {
            var todoItem = (Assignment1)BindingContext;
            DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.Notes);
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
