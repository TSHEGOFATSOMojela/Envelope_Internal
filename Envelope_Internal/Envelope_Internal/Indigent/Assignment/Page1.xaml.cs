
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
    public partial class Page1 : ContentPage
    {
        private Indigents itemSelectedData;


        public Page1(Indigents itemSelectedData)
        {
            InitializeComponent();
            BindingContext = itemSelectedData;

          
        }

        //accept assignment
        private async void AcceptedClicked(object sender, EventArgs e)
        {
            var indigentDetails = (Indigents)BindingContext;

            var id = indigentDetails.indigentApplicationDetails.indigentApplicationHeader.applicationRefNo;

            var getLoginDetails = await passAcceptedDetails(id);

           

            var root = JsonConvert.DeserializeObject<acceptedResponse>(getLoginDetails);
            if (root.StatusResponse.StatusDescription == "Success")
            {

                await DisplayAlert("Accepted", "Successfull", "Okay", "Cancel");
               // await Navigation.PushAsync(new Page2());
            }
            else
            {

                await DisplayAlert("Accepted failed", "Username or Password is incorrect or not exists", "Okay", "Cancel");
            }


        }



        public async Task<string> passAcceptedDetails(string id)
        {
            try
            {

         

                string AcceptAssignWebServiceUrl = "http://wmdev.ekurhuleni.gov.za:5555/rest/EMMShared/resources/updateFieldWorkerTaskStatus/{'taskStatus':'Accepted','applicationId':'" + id + "','reasonForRejection':''}";
                HttpClient client = new HttpClient();

                var response = await client.GetStringAsync(AcceptAssignWebServiceUrl);
               
                return response;
            }
            catch (System.Exception exception)
            {
                throw exception;
            }
        }
  

        private async void UnavailableClicked(object sender, EventArgs e)
        {


        }


    }
}