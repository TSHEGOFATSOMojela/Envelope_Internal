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
    public partial class IndigentPage : ContentPage
    {
        public IndigentPage()
        {
            InitializeComponent();


        }



        private async void Login_Tapped(object sender, EventArgs e)
        {
            // LoginService services = new LoginService();
            ProgressLoader.IsRunning = true; 
            var getLoginDetails = await checkLogin(username.Text, password.Text);
            var root = JsonConvert.DeserializeObject<UserLogin>(getLoginDetails);
            if (root.IsCorrect == "Yes")
            {

                await DisplayAlert("Login success", "You are login", "Okay", "Cancel");
                await Navigation.PushAsync(new Page2());
            }
            else
            {

                await DisplayAlert("Login failed", "Username or Password is incorrect or not exists", "Okay", "Cancel");
            }

            ProgressLoader.IsRunning = false;

        }




        public async Task<string> checkLogin(string username, string password)
        {
            try
            {
                string LoginWebServiceUrl = "http://wmdev.ekurhuleni.gov.za:5555/rest/EMMDirectoryServices/resources/AdAuthentication/?userId=" + username + "&pwd=" + password;
                HttpClient client = new HttpClient();

                var response = await client.GetStringAsync(LoginWebServiceUrl);

                return response;
            }
            catch (System.Exception exception)
            {
                throw exception;
            }
        }




    }
}