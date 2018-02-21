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
using Xamarin.Forms.Xaml;

namespace Envelope_Internal.Indigent.Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AssignmentList : ContentPage
    {
         //Assignment List Constructor
        public AssignmentList()
        {
            InitializeComponent();
            //Binding Assignment List details to the View
            GetIndigentDetailsAsync();


        }

        string username = ((App)App.Current).username.ToString();

        //Item Selected Method
        private void listviewContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Declare Item Selected Details
            var itemSelectedData = e.SelectedItem as Indigents;
            //Passing item selected details to Assignment Detail page
            Navigation.PushAsync(new AssignmentDetails(itemSelectedData));
            
        }
        
        //Get Assignment list details Method
        public async Task<List<Indigents>> GetIndigentDetailsAsync()
        {

            try
            {

                HttpClient client = new HttpClient();
                //Get Assignment list details
                var response = await client.GetStringAsync("https://munipoiapp.herokuapp.com/api/applications/New/ + username");
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




    }
}