using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using Envelope_Internal.Indigent;
using  Envelope_Internal.Indigent.Models;
using Envelope_Internal.Indigent.Assignment;
using Xamarin.Forms;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Envelope_Internal
{
	public partial class App : Application
	{
    

        public App ()
		{
			InitializeComponent();
  
            MainPage = new NavigationPage (new EnvelopeLoginPage());

      
        }
    

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
