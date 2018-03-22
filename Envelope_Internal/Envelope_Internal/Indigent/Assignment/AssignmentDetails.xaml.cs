
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Envelope_Internal.Indigent.ViewModels;
    using Envelope_Internal.Indigent.Models;
    using Plugin.Connectivity;
    using Plugin.Connectivity.Abstractions;
    using SQLite;
    using System.Net.Http;
    using Newtonsoft.Json;
     using Envelope_Internal.Data;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    namespace Envelope_Internal.Indigent.Assignment
    {
        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class AssignmentDetails : ContentPage
        {
            private Indigents itemSelectedData;

 

            //AssignmentDetails Constructor
            public AssignmentDetails(Indigents itemSelectedData)
            {
                InitializeComponent();
                //Binding item Selected Details to View
                BindingContext = itemSelectedData;

          
            }

        //Check Network
        protected override async void OnAppearing()

        {

            base.OnAppearing();



            if (!CrossConnectivity.Current.IsConnected)

            {

                await DisplayAlert("Network Status", "Please Check Network Connectivity", "OK");

            }





        }

        //Passing Accepted(Assignment list) Status description method
        private async void AcceptedClicked(object sender, EventArgs e)
            {
                //Binding Item data
                var indigentDetails = (Indigents)BindingContext;
                //await App.Database.SaveItemAsync(indigentDetails);
          
                //Fecting application Reference Number
                var applicationRefNo = indigentDetails.indigentApplicationDetails.indigentApplicationHeader.applicationRefNo;
                //Passing application Reference Number To PassAcceptedDetails method
                var getApplicationId = await passAcceptedDetails(applicationRefNo);

           

                //DeserializeObject of Accepted status description
                var root = JsonConvert.DeserializeObject<Status>(getApplicationId);
                //check the status description
                if (root.StatusResponse.StatusDescription == "Success")
                {
                //display success message

                //await DisplayAlert("Status", "Accepted", "Okay", "Cancel");

                // await Navigation.PopAsync();
                assignment assignment1 = new assignment();
                string applicantDetails = Newtonsoft.Json.JsonConvert.SerializeObject(indigentDetails);
                assignment1.applicantDetails = applicantDetails;
                assignment1.fieldWorkerID = indigentDetails.fieldWorkerID;
                assignment1.status = "Accepted";
                assignment1._id = indigentDetails._id;
               
                await App.Database.SaveItemAsync(assignment1);
                await DisplayAlert("Status", "Accepted", "Okay", "Cancel");
                //await DisplayAlert("Status", "Accepted", "Okay", "Cancel");
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
          
                   assignment assignment1 = new assignment();
                   string applicantDetails = Newtonsoft.Json.JsonConvert.SerializeObject(indigentDetails);
                   assignment1.applicantDetails = applicantDetails;
                   assignment1.fieldWorkerID = indigentDetails.fieldWorkerID;
                   assignment1.status = "Rejected";
                   assignment1._id = indigentDetails._id;

                await App.Database.SaveItemAsync(assignment1);
                await DisplayAlert("Status", "Saved SuccessFully", "Okay", "Cancel");
                //await DisplayAlert("Status", "Accepted", "Okay", "Cancel");
                await Navigation.PopAsync();

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