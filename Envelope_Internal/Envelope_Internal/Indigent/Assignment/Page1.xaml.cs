
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

        //page 1 Constructor
        public Page1(Indigents itemSelectedData)
        {
            InitializeComponent();
            //Binding item Selected Data assignments list details to the view Page1.xaml
            BindingContext = itemSelectedData;
          
        }



        //Passing Accepted(Assignment list) Status description method
        private async void AcceptedClicked(object sender, EventArgs e)
        {
            //Binding Item data
            var indigentDetails = (Indigents)BindingContext;
            //Fecting application Reference Number
            var applicationRefNo = indigentDetails.indigentApplicationDetails.indigentApplicationHeader.applicationRefNo;
            //Passing application Reference Number To PassAcceptedDetails method
            var getApplicationId = await passAcceptedDetails(applicationRefNo);


            //DeserializeObject of Accepted status description
            var root = JsonConvert.DeserializeObject<Status>(getApplicationId);
            //check the status description
            if (root.StatusResponse.StatusDescription == "Success")
            {
                Assignment1 assignment = new Assignment1();

                //display success message

                string applicantDetails = Newtonsoft.Json.JsonConvert.SerializeObject(indigentDetails);
                assignment.applicantDetails = applicantDetails;
                assignment.FieldWorkrId = indigentDetails.fieldWorkerID;
                assignment.Status = "Accepted";
                await App.Database.SaveItemAsync(assignment);

                await DisplayAlert("Status", "Accepted", "Okay", "Cancel");
                await Navigation.PopAsync();

            }
            else
            {
                //display unsuccessfull message
                await DisplayAlert("Status", "Unsuccessfull", "Okay", "Cancel");
            }


        }




        //Passing Accepted status description to the server
        public async Task<string> passAcceptedDetails(string applicationRefNo)
        {
            try
            {
               
                string AcceptAssignWebServiceUrl = "http://wmdev.ekurhuleni.gov.za:5555/rest/EMMShared/resources/updateFieldWorkerTaskStatus/{'taskStatus':'Accepted','applicationId':'" + applicationRefNo + "','reasonForRejection':''}";
                HttpClient client = new HttpClient();
                //Passing application Reference Number to the server
                var response = await client.GetStringAsync(AcceptAssignWebServiceUrl);
               //return status description response
                return response;
            }
            catch (System.Exception exception)
            {
                throw exception;
            }
        }




        //Passing Rejected(Assignment list) Status description method
        private async void UnavailableClicked(object sender, EventArgs e)
        {
            //Binding Item data
            var indigentDetails = (Indigents)BindingContext;
            //Fecting application Reference Number
            var applicationRefNo = indigentDetails.indigentApplicationDetails.indigentApplicationHeader.applicationRefNo;
            //Passing application Reference Number To PassAcceptedDetails method
            var getApplicationId = await passRejectedDetails(applicationRefNo);


            //DeserializeObject of Rejected status description
            var root = JsonConvert.DeserializeObject<Status>(getApplicationId);
            //check the status description
            if (root.StatusResponse.StatusDescription == "Success")
            {
                //display success message
                await DisplayAlert("Status", "Rejected", "Okay", "Cancel");

            }
            else
            {
                //display unsuccessfull message
                await DisplayAlert("Status", "Unsuccessfull", "Okay", "Cancel");
            }

        }




        //Passing Rejected status description to the server
        public async Task<string> passRejectedDetails(string applicationRefNo)
        {
            try
            {

                string RejectedAssignWebServiceUrl ="http://wmdev.ekurhuleni.gov.za:5555/rest/EMMShared/resources/updateFieldWorkerTaskStatus/{'taskStatus':'Rejected','applicationId':'" + applicationRefNo + "','reasonForRejection':''}";
                HttpClient client = new HttpClient();
                //Passing application Refrence Number to the server
                var response = await client.GetStringAsync(RejectedAssignWebServiceUrl);
                //return status description response
                return response;
            }
            catch (System.Exception exception)
            {
                throw exception;
            }
        }
    }
}