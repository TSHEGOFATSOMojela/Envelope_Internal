    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Envelope_Internal.Indigent.Assignment;
    using Envelope_Internal.Indigent.Models;
    using Envelope_Internal.Indigent.Services;
    using Xamarin.Forms;
    using System.Net.Http;
    using Newtonsoft.Json;
    using Xamarin.Forms.Xaml;

    namespace Envelope_Internal.Indigent
    {
        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class IndigentLoginPage : ContentPage
        {
           //Indigent Login Constructor
            public IndigentLoginPage()
            {
                InitializeComponent();
            }

            //Login Button
            private async void Login_Tapped(object sender, EventArgs e)
            {
                //Start Activity Indicator 
                ProgressLoader.IsRunning = true; 
                //Passing Users Credentials
                var getLoginDetails = await checkLogin(username.Text, password.Text);
                //DeserializeObject UserLogin
                var root = JsonConvert.DeserializeObject<UserLogin>(getLoginDetails);
                if (root.IsCorrect == "Yes")
                {

                    await DisplayAlert("Login success", "You are login", "Okay", "Cancel");
                    //Navigate to Tapped page Navigation
                    await Navigation.PushAsync(new TappedPageNavigation());
                }
                else
                {

                    await DisplayAlert("Login failed", "Username or Password is incorrect or not exists", "Okay", "Cancel");
                }
                // //Stop Activity Indicator 
                ProgressLoader.IsRunning = false;

            }

            //Pass/Check User credentials Method
            public async Task<string> checkLogin(string username, string password)
            {
                try
                {
                    //Pass User credentials
                    string LoginWebServiceUrl = "http://wmdev.ekurhuleni.gov.za:5555/rest/EMMDirectoryServices/resources/AdAuthentication/?userId=" + username + "&pwd=" + password;
                   HttpClient client = new HttpClient();
                    //Check User credentials
                    var response = await client.GetStringAsync(LoginWebServiceUrl);

                    //Return results
                     return response;
                }
                catch (System.Exception exception)
                {
                    throw exception;
                }
            }

        }
    }