using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using Envelope_Internal.Indigent.ViewModels;
using Envelope_Internal.Indigent.Models;
using Envelope_Internal;
using SQLite;
using System.Net.Http;
using Newtonsoft.Json;
using Envelope_Internal.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Assignment
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccptedAssignmentsList : ContentPage
	{
        //Accpted Assignments List Constructor
        public AccptedAssignmentsList()
        {
            InitializeComponent();
            //Binding  Accepted Assignment List Details to view
            // GetIndigentDetailsAsync();

            OnAppearing();
        }



        protected override async void OnAppearing()
        {
            base.OnAppearing();
            assignment indigentApplicationDetails = new assignment();
            Indigents indigent = new Indigents();
            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;
            var myList = await App.Database.GetItemsAsync();
            ArrayList accepted1 = new ArrayList();

            for (int i = 0; i < 1; i++)
            {
                //accepted1.Add(myList[i].applicantDetails);

                accepted1.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<Indigents>(myList[i].applicantDetails));
                Console.WriteLine(accepted1);
                Console.WriteLine("Hello");
            }
            Console.WriteLine(accepted1);
            listView.ItemsSource = accepted1;
        }

        //accepted Assignment list ,Item Selected method
        private  void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           
            //Declare Item Selected Details
            var itemSelectedData = e.SelectedItem as Indigents;
            //Passing item selected details to Accepted Assignment Detail page
            Navigation.PushAsync(new AcceptedAssignmentsDetails(itemSelectedData));

        }

        /*
        //Get Assignment list details Method
        public async Task<List<Indigents>> GetIndigentDetailsAsync()
        {

            try
            {

                HttpClient client = new HttpClient();
                //Get Assignment list details
                var response = await client.GetStringAsync("https://munipoiapp.herokuapp.com/api/applications/New/KemptonMobileward1");
                //DeserializeObject Indigents
                var IndigentDetails = JsonConvert.DeserializeObject<List<Indigents>>(response);
                //Binding Assignment list details to View
                ListView.ItemsSource = IndigentDetails;
                //Stop Activity Indicator
                ProgressLoader.IsRunning = false;
                //Return Results
                return IndigentDetails;
            }
            catch (System.Exception exception)
            {
                throw exception;
            }
        }
        */
    }
}