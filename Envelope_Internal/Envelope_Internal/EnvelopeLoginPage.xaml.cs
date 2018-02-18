    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Xamarin.Forms;

    namespace Envelope_Internal
    {
	    public partial class EnvelopeLoginPage : ContentPage
        {
            //Envelope Login Constructor
		    public EnvelopeLoginPage()
		    {
			    InitializeComponent();
            
            }

           //login button clicked 
            private async void login_Clicked(object sender, EventArgs e)
            {
                //Navigate to Envelope Main Page
                await Navigation.PushAsync(new EnvelopeMainPage());
            }
    }
    }
