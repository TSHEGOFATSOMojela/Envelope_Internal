using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.Assignment;
using Envelope_Internal.Indigent.Models;
using Envelope_Internal.Indigent.Services;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
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
            listView.ItemsSource = await App.Database.GetAssignmentsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AssignmentPage
            {
                BindingContext = new Indigents()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //((App)App.Current).ResumeAtTodoId = (e.SelectedItem as Assignment1).ID;
            //Debug.WriteLine("setting ResumeAtTodoId = " + (e.SelectedItem as Assignment1).ID);
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new AssignmentPage
                {
                    BindingContext = e.SelectedItem as Indigents
                });
            }
        }
    }
}
