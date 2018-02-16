using System;
using Envelope_Internal.Indigent.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Assignment
{
    public partial class AcceptedList : ContentPage
    {

        public AcceptedList()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;
            ListView.ItemsSource = await App.Database.GetAssignmentsAsync();
        }

        //async void OnItemAdded(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new AcceptedDetails
        //    {
        //        BindingContext = new Assignment1()
        //    });
        //}

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //((App)App.Current).ResumeAtTodoId = (e.SelectedItem as TodoItem).ID;
            //Debug.WriteLine("setting ResumeAtTodoId = " + (e.SelectedItem as TodoItem).ID);
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new AcceptedListCS
                {
                    BindingContext = e.SelectedItem as Assignment1
                });
            }
        }
    }
}
