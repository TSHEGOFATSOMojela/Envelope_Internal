using System;
using System.Diagnostics;
using Xamarin.Forms;
using Envelope_Internal.Indigent.Models;

namespace Envelope_Internal.Indigent.Views
{
	public partial class IndigentListPage : ContentPage
	{
		public IndigentListPage ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;
            listView.ItemsSource = await App.Database.GetItemsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Assignment1Page
            {
                BindingContext = new Assignment1()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //((App)App.Current).ResumeAtTodoId = (e.SelectedItem as Assignment1).ID;
            //Debug.WriteLine("setting ResumeAtTodoId = " + (e.SelectedItem as Assignment1).ID);
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new Assignment1Page
                {
                    BindingContext = e.SelectedItem as Assignment1
                });
            }
        }
    }
}
