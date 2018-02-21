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
    public partial class RejectedAssignments : ContentPage
    {
        public RejectedAssignments()
        {
            InitializeComponent();

            //GetIndigentDetailsAsync();


        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            assignment indigentApplicationDetails = new assignment();
            Indigents indigent = new Indigents();
            // Reset the 'resume' id, since we just want to re-start here
            ((App)App.Current).ResumeAtTodoId = -1;
            var myList = await App.Database.GetItemsNotDoneAsync("Rejected");
            ArrayList accepted1 = new ArrayList();

            for (int i = 0; i < myList.Count; i++)
            {
                //accepted1.Add(myList[i].applicantDetails);

                accepted1.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<Indigents>(myList[i].applicantDetails));
                Console.WriteLine(accepted1);
                Console.WriteLine("Hello");
            }
            Console.WriteLine(accepted1);
            listView.ItemsSource = accepted1;
        }
     

        HttpClient client = new HttpClient();

        /*
        public async Task<List<Indigents>> GetIndigentDetailsAsync()
        {

            try
            {
                var response = await client.GetStringAsync("https://munipoiapp.herokuapp.com/api/applications/New/KemptonMobileward1");
                var IndigentDetails = JsonConvert.DeserializeObject<List<Indigents>>(response);
                ListView.ItemsSource = IndigentDetails;
                ProgressLoader.IsRunning = false;
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