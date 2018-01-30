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
    public partial class MainAssign : ContentPage
    {
        public MainAssign()
        {
            InitializeComponent();
            GetIndigentDetailsAsync();
        }

        /*
           public async void GetJSON()
           {

           var client = new System.Net.Http.HttpClient();
           HttpResponseMessage response = await client.GetAsync("https://munipoiapp.herokuapp.com/api/applications/New/KemptonMobileward1");

           if (response.StatusCode == System.Net.HttpStatusCode.OK)
           {
               //Converting JSON Array Objects into generic list
               HttpContent content = response.Content;
               var IndigentJson = await content.ReadAsStringAsync();
               var ObjIndigenttList = JsonConvert.DeserializeObject<List<Indigent>>(IndigentJson);
               // Indigent.indigentApplicationDetails.indigentApplicationHeader.applicationRefNo
               //Binding listview with server response 
               ListView.ItemsSource = ObjIndigenttList[0].indigentApplicationDetails.indigentApplicationHeader.applicationRefNo;
           }




               }

     */

        HttpClient client = new HttpClient();

        public async Task<List<Indigents>> GetIndigentDetailsAsync()
        {

            try
            {
                var response = await client.GetStringAsync("https://munipoiapp.herokuapp.com/api/applications/New/KemptonMobileward1");
                var IndigentDetails = JsonConvert.DeserializeObject<List<Indigents>>(response);
                ListView.ItemsSource = IndigentDetails;

                return IndigentDetails;
            }
            catch (System.Exception exception)
            {
                throw exception;
            }
        }


        private void listviewContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var itemSelectedData = e.SelectedItem as Indigent;
            //Navigation.PushAsync(new Page1(itemSelectedData));
        }

    }
}